using System;
using System.Collections.Generic;
using RimWorld;
using Verse;
using Verse.AI;

namespace AndroidResurrectionKit
{
    // Token: 0x02000950 RID: 2384
    [DefOf]
    public static class JobDefOf
    {
        // Token: 0x06003779 RID: 14201 RVA: 0x001A8399 File Offset: 0x001A6799
        static JobDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(RimWorld.JobDefOf));
        }

        // Token: 0x04001FF3 RID: 8179
        public static JobDef ResurrectAndroid1;
        public static JobDef ResurrectAndroid2;
        public static JobDef ResurrectAndroid3;
    }
}