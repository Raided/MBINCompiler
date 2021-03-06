﻿using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;

        public GcAlienRace AlienRace;
        public GcInteractionType InteractionType;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        public string Text;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        public string TextAlien;

        public bool TranslateAlienText;
        public List<GcAlienPuzzleOption> Options;
    }
}
