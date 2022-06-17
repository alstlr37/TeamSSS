Shader "eTOYLab/bg_default"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        
		//Emission
		_Emission("Emission", 2D) = "white" {}
		_Emission_color("Emission_color", Color) = (1,1,1,1)
		_Emission_power("Emission_power", Range(0, 10)) = 0.0

		[Space(10)]

		//Cull
		_Cull("Cull", Range(0, 2)) = 2
    }

	SubShader
    {
        Tags { "RenderType"="Opaque" }

		Cull[_Cull]

        CGPROGRAM
		#pragma surface surf NoLighting noambient noforwardadd novertexlights

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

		uniform sampler2D _Emission;
		uniform fixed4 _Emission_ST;
		uniform fixed _Emission_power;
		uniform fixed4 _Emission_color;
        fixed4 _Color;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutput o)
        {
            half4 main = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = main.rgb * _Color.rgb;
			o.Alpha = main.a * _Color.a;

			fixed4 _Emission_var = tex2D(_Emission, TRANSFORM_TEX(IN.uv_MainTex, _Emission));
			fixed3 emissive = (_Emission_var.rgb * _Emission_color.rgb) * _Emission_power;
			o.Emission = emissive;
        }

		fixed4 LightingNoLighting(SurfaceOutput s, fixed3 lightDir, fixed atten)
     {
         fixed4 c;
         c.rgb = s.Albedo; 
         c.a = s.Alpha;
         return c;
     }
        ENDCG
    }

    FallBack "Diffuse"
}
