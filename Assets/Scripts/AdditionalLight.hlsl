void AdditionalLight_float(float3 WorldPos, int Index, out float3 Direction, out float3 Color, out float DistanceAtten, out float ShadowAtten)
{
   Direction = normalize(float3(0.5f,0.5f,0.25f));
   Color = float3(0,0,0);
   DistanceAtten = 0;
   ShadowAtten = 0;

#ifndef SHADERGRAPH_PREVIEW
   int pixelLightCount = GetAdditionalLightsCount();
   if(Index < pixelLightCount)
   {
      Light light = GetAdditionalLight(Index, WorldPos);

      Direction = light.direction;
      Color = light.color;
      DistanceAtten = light.distanceAttenuation;
      ShadowAtten = light.shadowAttenuation;
   }   
#endif
}
