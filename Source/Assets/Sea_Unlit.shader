Shader "SF/BG/Sea_Unlit" 
{
	Properties 
	{
		_Blend ("Blend", Range (0, 1) ) = 0.5 
		_MainTex  ( "Sequence", 2D ) = "" 
		_Texture2 ( "SeaBottom", 2D ) = ""
	}

	Category 
	{
		Lighting Off
		Tags {"RenderType"="Queue"}

	SubShader 
	{
        Pass {
            SetTexture[_MainTex]
            SetTexture[_Texture2] 
			{
                ConstantColor (0,0,0, [_Blend])
                Combine texture Lerp(constant) previous
            }
        }
    }
}
}