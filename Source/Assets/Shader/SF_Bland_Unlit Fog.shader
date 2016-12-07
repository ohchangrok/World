//SHADER FORGE//
Shader "SF/BG/Bland_Lightmap Unlit Fog" {
    Properties {
        _MaskBGB ("Mask(BGB)", 2D) = "white" {}
        _RChannel ("R(Channel)", 2D) = "white" {}
        _GChannel ("G(Channel)", 2D) = "white" {}
        _BChannel ("B(Channel)", 2D) = "white" {}
        _Light ("Light", 2D) = "white" {}
        _SetColor ("SetColor", Color) = (0.5,0.5,0.5,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 2.0
            uniform sampler2D _MaskBGB; uniform float4 _MaskBGB_ST;
            uniform sampler2D _RChannel; uniform float4 _RChannel_ST;
            uniform sampler2D _GChannel; uniform float4 _GChannel_ST;
            uniform sampler2D _BChannel; uniform float4 _BChannel_ST;
            uniform sampler2D _Light; uniform float4 _Light_ST;
            uniform float4 _SetColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                UNITY_FOG_COORDS(2)
                #ifndef LIGHTMAP_OFF
                    float4 uvLM : TEXCOORD3;
                #else
                    float3 shLight : TEXCOORD3;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
/////// Vectors:
////// Lighting:
                float4 _MaskBGB_var = tex2D(_MaskBGB,TRANSFORM_TEX(i.uv0, _MaskBGB));
                float4 node_4 = float4(_MaskBGB_var.rgb,_MaskBGB_var.a);
                float4 _RChannel_var = tex2D(_RChannel,TRANSFORM_TEX(i.uv0, _RChannel));
                float4 _GChannel_var = tex2D(_GChannel,TRANSFORM_TEX(i.uv0, _GChannel));
                float4 _BChannel_var = tex2D(_BChannel,TRANSFORM_TEX(i.uv0, _BChannel));
                float4 _Light_var = tex2D(_Light,TRANSFORM_TEX(i.uv1, _Light));
                float3 finalColor = ((node_4.r*_RChannel_var.rgb + node_4.g*_GChannel_var.rgb + node_4.b*_BChannel_var.rgb + node_4.a*_MaskBGB_var.a)*_SetColor.rgb*_Light_var.rgb);
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
