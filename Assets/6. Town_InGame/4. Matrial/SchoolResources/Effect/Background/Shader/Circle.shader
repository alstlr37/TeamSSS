Shader "eTOYLab/Unlit Flat Circle v2" {
	Properties{
		_MainTex("Main Texture", 2D) = "white" {}
		_Color("Color", Color) = (1,1,1,1)
		_Distort("Distort", vector) = (0.5, 0.5, 1.0, 1.0)
		_OuterRadius("Outer Radius", float) = 0.5
		_InnerRadius("Inner Radius", float) = -0.5
		_Hardness("Hardness", float) = 1.0
	}

		SubShader{
			Tags { "RenderType" = "Transparent" "Queue" = "Transparent" "AllowProjectors" = "False" }

			blend SrcAlpha OneMinusSrcAlpha

			CGPROGRAM
			#pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
			#pragma target 3.0
			#pragma surface surf NoLighting keepalpha

			fixed4 LightingNoLighting(SurfaceOutput s, fixed3 lightDir, fixed atten)
			{
				return fixed4(s.Albedo, s.Alpha);
			}

			sampler2D _MainTex;

			struct Input
			{
				float2 uv_MainTex;
			};

			float4 _Color, _Distort;
			float _OuterRadius, _InnerRadius, _Hardness;
			void surf(Input IN, inout SurfaceOutput o)
			{
				half4 c = tex2D(_MainTex, IN.uv_MainTex);

				fixed x = length((_Distort.xy - IN.uv_MainTex.xy) * _Distort.zw);

				fixed rc = (_OuterRadius + _InnerRadius) * 0.5f; // "central" radius
				fixed rd = _OuterRadius - rc; // distance from "central" radius to edge radii

				fixed circleTest = saturate(abs(x - rc) / rd);

				o.Albedo = _Color.rgb * c.rgb;
				o.Alpha = (1.0f - (1.0f - pow(circleTest, _Hardness)) * c.a) * _Color.a;
			}
			ENDCG
		}
			FallBack "Diffuse"
}