﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkProceduralTexture : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Name;

        public TkPaletteTexture Palette;
        public float Probability;
        public int TextureGameplayUse;

        public string[] TextureGameplayUseValues()
        {
            return new[] { "IgnoreName", "MatchName", "DoNotMatchName" };
        }

        public bool OverrideAverageColour;
        public Colour AverageColour;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Diffuse;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Normal;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Mask;
    }
}
