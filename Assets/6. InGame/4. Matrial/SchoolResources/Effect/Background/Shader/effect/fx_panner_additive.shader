// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:33237,y:32572,varname:node_4795,prsc:2|emission-2393-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32425,y:32916,ptovrint:False,ptlb:[MainTex],ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False|UVIN-143-OUT;n:type:ShaderForge.SFN_Multiply,id:2393,x:33052,y:32664,varname:node_2393,prsc:2|A-6448-OUT,B-2053-RGB,C-2053-A;n:type:ShaderForge.SFN_VertexColor,id:2053,x:32846,y:32740,varname:node_2053,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:3457,x:31688,y:33067,ptovrint:False,ptlb:Main_X_speed,ptin:_Main_X_speed,varname:node_3457,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:4816,x:31688,y:33150,ptovrint:False,ptlb:Main_Y_speed,ptin:_Main_Y_speed,varname:node_4816,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:4372,x:31870,y:33094,varname:node_4372,prsc:2|A-3457-OUT,B-4816-OUT;n:type:ShaderForge.SFN_Multiply,id:2353,x:32055,y:33012,varname:node_2353,prsc:2|A-2757-T,B-4372-OUT;n:type:ShaderForge.SFN_Add,id:143,x:32247,y:32916,varname:node_143,prsc:2|A-3538-UVOUT,B-2353-OUT;n:type:ShaderForge.SFN_Tex2d,id:8199,x:32425,y:32459,ptovrint:False,ptlb:[SubTex],ptin:_SubTex,varname:node_8199,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9382-OUT;n:type:ShaderForge.SFN_Time,id:2757,x:31682,y:32340,varname:node_2757,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:5696,x:31682,y:32528,ptovrint:False,ptlb:Sub_X_speed,ptin:_Sub_X_speed,varname:_X_speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:8716,x:31682,y:32612,ptovrint:False,ptlb:Sub_Y_speed,ptin:_Sub_Y_speed,varname:_Y_speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:2249,x:31864,y:32556,varname:node_2249,prsc:2|A-5696-OUT,B-8716-OUT;n:type:ShaderForge.SFN_Multiply,id:9786,x:32049,y:32474,varname:node_9786,prsc:2|A-2757-T,B-2249-OUT;n:type:ShaderForge.SFN_TexCoord,id:3538,x:31856,y:32185,varname:node_3538,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:9382,x:32237,y:32459,varname:node_9382,prsc:2|A-3538-UVOUT,B-9786-OUT;n:type:ShaderForge.SFN_Multiply,id:6448,x:32846,y:32608,varname:node_6448,prsc:2|A-9997-OUT,B-1010-OUT,C-7371-OUT;n:type:ShaderForge.SFN_Tex2d,id:101,x:32425,y:32163,ptovrint:False,ptlb:[Mask_frame],ptin:_Mask_frame,varname:node_101,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3938-UVOUT;n:type:ShaderForge.SFN_Multiply,id:7371,x:32655,y:33090,cmnt:Main_Tex,varname:node_7371,prsc:2|A-6074-RGB,B-8592-OUT,C-3150-RGB;n:type:ShaderForge.SFN_Slider,id:8592,x:32268,y:33110,ptovrint:False,ptlb:MainTex_power,ptin:_MainTex_power,varname:node_8592,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_Multiply,id:9997,x:32650,y:32270,varname:node_9997,prsc:2|A-101-R,B-2229-OUT;n:type:ShaderForge.SFN_Slider,id:2229,x:32268,y:32354,ptovrint:False,ptlb:Mask_frame_power,ptin:_Mask_frame_power,varname:node_2229,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_Rotator,id:3938,x:32226,y:32068,varname:node_3938,prsc:2|UVIN-3538-UVOUT,ANG-2538-OUT;n:type:ShaderForge.SFN_Slider,id:2538,x:32069,y:32223,ptovrint:False,ptlb:Mask_rotaion,ptin:_Mask_rotaion,varname:node_2538,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:6;n:type:ShaderForge.SFN_Slider,id:6255,x:32268,y:32641,ptovrint:False,ptlb:SubTex_power,ptin:_SubTex_power,varname:_Mask_frame_power_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_Multiply,id:1010,x:32643,y:32624,cmnt:Sub_Tex,varname:node_1010,prsc:2|A-8199-RGB,B-6255-OUT,C-9037-RGB;n:type:ShaderForge.SFN_Color,id:9037,x:32425,y:32739,ptovrint:False,ptlb:Sub_Tex_Color,ptin:_Sub_Tex_Color,varname:node_9037,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:3150,x:32425,y:33222,ptovrint:False,ptlb:Main_Tex_Color,ptin:_Main_Tex_Color,varname:_Sub_Tex_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;proporder:6074-3150-8592-3457-4816-8199-9037-6255-5696-8716-101-2229-2538;pass:END;sub:END;*/

Shader "etoylab_effect/fx_panner_additive" {
    Properties {
        _MainTex ("[MainTex]", 2D) = "black" {}
        _Main_Tex_Color ("Main_Tex_Color", Color) = (1,1,1,1)
        _MainTex_power ("MainTex_power", Range(0, 3)) = 1
        _Main_X_speed ("Main_X_speed", Float ) = 0
        _Main_Y_speed ("Main_Y_speed", Float ) = 0
        _SubTex ("[SubTex]", 2D) = "white" {}
        _Sub_Tex_Color ("Sub_Tex_Color", Color) = (1,1,1,1)
        _SubTex_power ("SubTex_power", Range(0, 3)) = 1
        _Sub_X_speed ("Sub_X_speed", Float ) = 0
        _Sub_Y_speed ("Sub_Y_speed", Float ) = 0
        _Mask_frame ("[Mask_frame]", 2D) = "white" {}
        _Mask_frame_power ("Mask_frame_power", Range(0, 3)) = 1
        _Mask_rotaion ("Mask_rotaion", Range(0, 6)) = 0
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
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform fixed _Main_X_speed;
            uniform fixed _Main_Y_speed;
            uniform sampler2D _SubTex; uniform float4 _SubTex_ST;
            uniform fixed _Sub_X_speed;
            uniform fixed _Sub_Y_speed;
            uniform sampler2D _Mask_frame; uniform float4 _Mask_frame_ST;
            uniform fixed _MainTex_power;
            uniform fixed _Mask_frame_power;
            uniform fixed _Mask_rotaion;
            uniform fixed _SubTex_power;
            uniform fixed4 _Sub_Tex_Color;
            uniform fixed4 _Main_Tex_Color;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
				fixed4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
				fixed4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
			fixed4 frag(VertexOutput i, float facing : VFACE) : COLOR {
				fixed isFrontFace = ( facing >= 0 ? 1 : 0 );
				fixed faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
				fixed node_3938_ang = _Mask_rotaion;
				fixed node_3938_spd = 1.0;
				fixed node_3938_cos = cos(node_3938_spd*node_3938_ang);
				fixed node_3938_sin = sin(node_3938_spd*node_3938_ang);
				float2 node_3938_piv = float2(0.5,0.5);
				float2 node_3938 = (mul(i.uv0-node_3938_piv, float2x2( node_3938_cos, -node_3938_sin, node_3938_sin, node_3938_cos))+node_3938_piv);
				fixed4 _Mask_frame_var = tex2D(_Mask_frame,TRANSFORM_TEX(node_3938, _Mask_frame));
				float4 node_2757 = _Time;
				float2 node_9382 = (i.uv0+(node_2757.g*float2(_Sub_X_speed,_Sub_Y_speed)));
				fixed4 _SubTex_var = tex2D(_SubTex,TRANSFORM_TEX(node_9382, _SubTex));
				float2 node_143 = (i.uv0+(node_2757.g*float2(_Main_X_speed,_Main_Y_speed)));
				fixed4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_143, _MainTex));
				fixed3 node_2393 = (((_Mask_frame_var.r*_Mask_frame_power)*(_SubTex_var.rgb*_SubTex_power*_Sub_Tex_Color.rgb)*(_MainTex_var.rgb*_MainTex_power*_Main_Tex_Color.rgb))*i.vertexColor.rgb*i.vertexColor.a);
				fixed3 emissive = node_2393;
				fixed3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor, (_Mask_frame_var.r*_SubTex_var.r*_MainTex_var.r*i.vertexColor.a));
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0,0,0,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
