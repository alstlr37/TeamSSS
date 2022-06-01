// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32859,y:32585,varname:node_3138,prsc:2|emission-1384-OUT;n:type:ShaderForge.SFN_Tex2d,id:2367,x:31927,y:32767,ptovrint:False,ptlb:MaskTex,ptin:_MaskTex,varname:_MaskTex_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9224,x:31927,y:32576,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_VertexColor,id:6244,x:31927,y:32938,varname:node_6244,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8243,x:32493,y:32746,varname:node_8243,prsc:2|A-9224-R,B-1512-OUT;n:type:ShaderForge.SFN_Clamp01,id:1512,x:32649,y:32891,varname:node_1512,prsc:2|IN-4578-OUT;n:type:ShaderForge.SFN_Add,id:7432,x:32325,y:32891,varname:node_7432,prsc:2|A-1935-OUT,B-610-OUT;n:type:ShaderForge.SFN_RemapRange,id:4578,x:32493,y:32891,varname:node_4578,prsc:2,frmn:0,frmx:1,tomn:-10,tomx:1|IN-7432-OUT;n:type:ShaderForge.SFN_Multiply,id:1384,x:32649,y:32686,varname:node_1384,prsc:2|A-4858-OUT,B-8243-OUT;n:type:ShaderForge.SFN_Relay,id:4858,x:32493,y:32686,varname:node_4858,prsc:2|IN-6244-RGB;n:type:ShaderForge.SFN_OneMinus,id:1935,x:32121,y:32838,varname:node_1935,prsc:2|IN-2367-R;n:type:ShaderForge.SFN_RemapRange,id:610,x:32121,y:32968,varname:node_610,prsc:2,frmn:0,frmx:1,tomn:-0.1,tomx:1|IN-6244-A;proporder:9224-2367;pass:END;sub:END;*/

Shader "etoylab_effect/fx_particle_dissolve_add" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _MaskTex ("MaskTex", 2D) = "black" {}
		_Value ("Value", float) = 1
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _MaskTex; uniform float4 _MaskTex_ST;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
			fixed _Value;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                fixed4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
				fixed4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
			fixed4 frag(VertexOutput i, float facing : VFACE) : COLOR {
				fixed isFrontFace = ( facing >= 0 ? 1 : 0 );
				fixed faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
				fixed4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
				fixed4 _MaskTex_var = tex2D(_MaskTex,TRANSFORM_TEX(i.uv0, _MaskTex));
				fixed node_7469 = (_MainTex_var.r*saturate((((1.0 - _MaskTex_var.r) + (i.vertexColor.a*1.1 + -0.1))*11.0 + -10.0)));
				fixed3 emissive = (i.vertexColor.rgb*node_7469);
				fixed3 finalColor = emissive;
                return fixed4(finalColor, (node_7469*_MainTex_var.a * _Value));
            }
            ENDCG
        }
        /*Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }*/
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
