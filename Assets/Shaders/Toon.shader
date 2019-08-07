Shader "Custom/Toon"
{
    Properties
    {
        _RampTex("Ramp" , 2D) = "white"{}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Toon
		#pragma target 3.0

        sampler2D _RampTex;

       fixed4 LightingToon(SurfaceOutput s, fixed3 lightDir, fixed atten)
	   {
		
	   }
        ENDCG
    }
    FallBack "Diffuse"
}
