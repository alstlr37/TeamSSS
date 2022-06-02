
Shader "eTOYLab/ColorDodge"
{
	Properties
	{
		_MainTex("Base (RGB) Trans (A)", 2D) = "white" {}
		_Color("Main Color", Color) = (1,1,1,1)

		[Enum(UnityEngine.Rendering.BlendMode)] 
		_SrcBlend("SrcBlend mode", float) = 5
		
		[Enum(UnityEngine.Rendering.BlendMode)] 
		_DstBlend("DstBlend mode", float) = 10

		[Enum(UnityEngine.Rendering.CullMode)] 
		_Cull("Cull mode", float) = 2

		[Enum(UnityEngine.Rendering.CompareFunction)]
		_ZTest("ZTest", float) = 0

		[Toggle] 
		_Zwrite("Zwrite On", float) = 0
	}

	SubShader
	{
		Tags
		{ 
			"Queue" = "Transparent" 
			"IgnoreProjector" = "True" 
			"RenderType" = "Transparent" 
		}
		
		Fog{ Mode Off }
		Lighting Off
		//Cull[_Cull]
		//Blend [_SrcBlend][_DstBlend]
		ZWrite [_Zwrite]
		ZTest [_ZTest]
		LOD 110

		Pass
		{
			CGPROGRAM
			
			#pragma vertex vert_vct
			#pragma fragment frag_mult 
			#pragma fragmentoption ARB_precision_hint_fastest
			#pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
			#pragma target 3.0
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			fixed4 _Color;

			struct vin_vct
			{
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f_vct
			{
				float4 vertex : SV_POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			v2f_vct vert_vct(vin_vct v)
			{
				v2f_vct o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.texcoord = v.texcoord;
				return o;
			}

			fixed4 frag_mult(v2f_vct i) : SV_Target
			{
				fixed4 c = tex2D(_MainTex, i.texcoord);
				return (c / (1.0f - c)) * i.color;
			}

			ENDCG
		}
	}
}
