// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.25 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.25;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32948,y:32703,varname:node_3138,prsc:2|emission-8255-OUT,custl-2059-OUT,clip-6084-A;n:type:ShaderForge.SFN_Tex2d,id:6084,x:32534,y:32267,ptovrint:False,ptlb:main_Tex,ptin:_main_Tex,varname:node_6084,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8e4ef0c52a68cb44db913481b3685d77,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2668,x:32255,y:32312,varname:node_2668,prsc:2|A-5510-OUT,B-8102-RGB;n:type:ShaderForge.SFN_Power,id:5510,x:32102,y:32313,varname:node_5510,prsc:2|VAL-3583-OUT,EXP-1292-OUT;n:type:ShaderForge.SFN_OneMinus,id:3583,x:32257,y:32455,varname:node_3583,prsc:2|IN-3953-OUT;n:type:ShaderForge.SFN_Clamp01,id:3953,x:32092,y:32454,varname:node_3953,prsc:2|IN-3763-OUT;n:type:ShaderForge.SFN_Dot,id:3763,x:32259,y:32618,varname:node_3763,prsc:2,dt:0|A-9684-OUT,B-3897-OUT;n:type:ShaderForge.SFN_Normalize,id:9684,x:32084,y:32626,varname:node_9684,prsc:2|IN-3985-OUT;n:type:ShaderForge.SFN_NormalVector,id:3897,x:32099,y:32763,prsc:2,pt:False;n:type:ShaderForge.SFN_ViewVector,id:3985,x:31906,y:32619,varname:node_3985,prsc:2;n:type:ShaderForge.SFN_Slider,id:1292,x:31767,y:32422,ptovrint:False,ptlb:RimPower,ptin:_RimPower,varname:node_1292,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:20,max:20;n:type:ShaderForge.SFN_Color,id:8102,x:32042,y:32167,ptovrint:False,ptlb:rimColor,ptin:_rimColor,varname:node_8102,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Add,id:8255,x:32539,y:32446,varname:node_8255,prsc:2|A-6084-RGB,B-2668-OUT;n:type:ShaderForge.SFN_Tex2d,id:7175,x:32379,y:32940,ptovrint:False,ptlb:BlendTex,ptin:_BlendTex,varname:node_7175,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d61cb2fad3d72e145889484bf0babb8c,ntxv:2,isnm:False|UVIN-6509-OUT;n:type:ShaderForge.SFN_Power,id:2059,x:32597,y:32941,varname:node_2059,prsc:2|VAL-7175-RGB,EXP-1986-OUT;n:type:ShaderForge.SFN_RemapRange,id:6509,x:32569,y:33102,varname:node_6509,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-3983-OUT;n:type:ShaderForge.SFN_ComponentMask,id:3983,x:32380,y:33103,varname:node_3983,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-2467-XYZ;n:type:ShaderForge.SFN_Transform,id:2467,x:32576,y:33264,varname:node_2467,prsc:2,tffrom:0,tfto:3|IN-8438-OUT;n:type:ShaderForge.SFN_NormalVector,id:8438,x:32416,y:33264,prsc:2,pt:False;n:type:ShaderForge.SFN_Slider,id:1986,x:32379,y:32849,ptovrint:False,ptlb:BlendPower,ptin:_BlendPower,varname:node_1986,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:10,max:10;proporder:6084-1292-8102-7175-1986;pass:END;sub:END;*/

Shader "Shader Forge/Non_Char" {
    Properties {
        _main_Tex ("main_Tex", 2D) = "white" {}
        _RimPower ("RimPower", Range(0, 20)) = 20
        _rimColor ("rimColor", Color) = (0.5,0.5,0.5,1)
        _BlendTex ("BlendTex", 2D) = "black" {}
        _BlendPower ("BlendPower", Range(0, 10)) = 10
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _main_Tex; uniform float4 _main_Tex_ST;
            uniform float _RimPower;
            uniform float4 _rimColor;
            uniform sampler2D _BlendTex; uniform float4 _BlendTex_ST;
            uniform float _BlendPower;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 _main_Tex_var = tex2D(_main_Tex,TRANSFORM_TEX(i.uv0, _main_Tex));
                clip(_main_Tex_var.a - 0.5);
////// Lighting:
////// Emissive:
                float3 emissive = (_main_Tex_var.rgb+(pow((1.0 - saturate(dot(normalize(viewDirection),i.normalDir))),_RimPower)*_rimColor.rgb));
                float2 node_6509 = (mul( UNITY_MATRIX_V, float4(i.normalDir,0) ).xyz.rgb.rg*0.5+0.5);
                float4 _BlendTex_var = tex2D(_BlendTex,TRANSFORM_TEX(node_6509, _BlendTex));
                float3 finalColor = emissive + pow(_BlendTex_var.rgb,_BlendPower);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _main_Tex; uniform float4 _main_Tex_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 _main_Tex_var = tex2D(_main_Tex,TRANSFORM_TEX(i.uv0, _main_Tex));
                clip(_main_Tex_var.a - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
