Shader "Custom/test" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		    // properties for water shader
	    _WaveScale ("Wave scale", Range (0.02,0.15)) = 0.07 // sliders
	    _ReflDistort ("Reflection distort", Range (0,1.5)) = 0.5
	    _RefrDistort ("Refraction distort", Range (0,1.5)) = 0.4
	    _RefrColor ("Refraction color", Color)  = (.34, .85, .92, 1) // color
	    _ReflectionTex ("Environment Reflection", 2D) = "" {} // textures
	    _RefractionTex ("Environment Refraction", 2D) = "" {}
	    _Fresnel ("Fresnel (A) ", 2D) = "" {}
	    _BumpMap ("Bumpmap (RGB) ", 2D) = "" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
