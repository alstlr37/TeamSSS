// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Hidden/radial_blur" {

	Properties{

		_MainTex("Base (RGB)", 2D) = "white" {}

		fSampleDist("fSampleDist", float) = 1

		fSampleStrength("fSampleStrength", float) = 1

	}



		SubShader

		{

			Pass

			{

				ZTest Always Cull Off ZWrite Off

				Fog { Mode off }



		CGPROGRAM

			// Upgrade NOTE: excluded shader from Xbox360 and OpenGL ES 2.0 because it uses unsized arrays 

			#pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
			#pragma target 3.0

			#pragma vertex vert 

			#pragma fragment frag 

			#pragma fragmentoption ARB_precision_hint_fastest



			#include "UnityCG.cginc"



			uniform sampler2D _MainTex;

			uniform fixed fSampleDist;

			uniform fixed fSampleStrength;

			uniform fixed4 _MainTex_ST;

			uniform fixed4 _MainTex_TexelSize;

			//static const float sam[11] = { -0.08,-0.05,-0.03,-0.02,-0.01,0,0.01,0.02,0.03,0.05,0.08 };



			struct v2f {

				float4 pos : POSITION;

				float2 uv : TEXCOORD0;

			};



			v2f vert(appdata_img v)

			{

				v2f o;

				o.pos = UnityObjectToClipPos(v.vertex);

				o.uv = v.texcoord.xy;

				return o;

			}



			fixed4 frag(v2f i) : COLOR

			{

				float2 texCo = i.uv;

				fixed2 dir = 0.5 - texCo;

				fixed dist = length(dir);



				dir /= dist;

				fixed4 color = tex2D(_MainTex, texCo);

				fixed4 sum = color;



				fixed samples[11] = { -0.08,-0.05,-0.03,-0.02,-0.01,0,0.01,0.02,0.03,0.05,0.08 };





				//    float samples[10] = float[](-0.08,-0.05,-0.03,-0.02,-0.01,0.01,0.02,0.03,0.05,0.08); 



					for (int i = 0; i < 10; ++i)

					{

						sum += tex2D(_MainTex, texCo + dir * samples[i] * fSampleDist);

						//         sum += tex2D(_MainTex, texCo + dir*samples[i]*0.5);  

							}



							sum /= 11.0;

							fixed t = saturate(dist * fSampleStrength);

							//     float t = saturate(dist * 1);

								return lerp(color, sum,t);

								//return float4 (1,0,0,1);

								}

								ENDCG



									}

		}



			Fallback off



}
