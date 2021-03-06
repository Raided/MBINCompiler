﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcEntitlementRewardData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string EntitlementId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string RewardId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Name;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Error;
    }
}
