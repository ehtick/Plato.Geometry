﻿using System.Diagnostics;

namespace Plato.Geometry.Graphics
{
    public class Material
    {
        public string Name;
        public Color Color;
        public double Transmission;
        public double Metallic;
        public double Roughness;
        public double Sheen;
        public double SheenTint;
        public bool UseSpecularReflectance = false;
        public double SpecularReflectance = 0.4;
        public double IndexOfRefraction;
        public double SpecularTint;
        public double SubsurfaceScattering;
        public Color SubsurfaceColor;

        public Material(Color color)
            => Color = color;

        public Material(
            int red, 
            int green, 
            int blue, 
            int alpha,            
            double transmission, 
            double metallic, 
            double roughness, 
            double sheen, 
            double sheenTint, 
            bool useSpecularReflectance, 
            double specularReflectance, 
            double indexOfRefraction, 
            double specularTint, 
            double subsurfaceScattering, 
            int subsurfaceRed,
            int subsurfaceGreen,
            int subsurfaceBlue,
            [System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            Debug.Assert(alpha == 255, "Alpha channel is not currently supported");
            Color = new Color(red / 255.0f, green / 255.0f, blue / 255.0f, (float)(1.0 - transmission));
            Metallic = metallic;
            Roughness = roughness;
            Sheen = sheen;
            SheenTint = sheenTint;
            UseSpecularReflectance = useSpecularReflectance;
            SpecularReflectance = specularReflectance;
            SpecularTint = specularTint;
            IndexOfRefraction = indexOfRefraction;
            SubsurfaceColor = new Color(subsurfaceRed / 255, subsurfaceGreen / 255, subsurfaceBlue / 255, 1);
            SubsurfaceScattering = subsurfaceScattering;
            Name = name;
        }

        public SpecularSettings GetSpecularSettings()
            => SpecularSettings.FromPBR(Color, Metallic, Roughness);

        public bool UseSpecular 
            => Metallic != 0 || Roughness != 0;

        public static implicit operator Material(Color color) => new Material(color);
    }

    public struct SpecularSettings
    {
        public readonly Color Color;
        public readonly double Power;
        public SpecularSettings(Color color, double power)
        {
            Color = color;
            Power = power;
        }

        public static Color DielectricSpecular = new Color(0.04f, 0.04f, 0.04f, 1.0f);

        public static SpecularSettings FromPBR(Color color, double metallic, double roughness)
            => throw new System.NotImplementedException();
        //=> new SpecularSettings(DielectricSpecular.Lerp(color, metallic), ((Number)1).Lerp(100, 1 - roughness));
    }
}
