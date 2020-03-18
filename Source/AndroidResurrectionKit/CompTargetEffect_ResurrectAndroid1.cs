using System;
using System.Collections.Generic;
using RimWorld;
using Verse;
using Verse.AI;

namespace AndroidResurrectionKit
{
    // Token: 0x02000786 RID: 1926
    public class CompTargetEffect_ResurrectAndroid1 : CompTargetEffect
    {
        // Token: 0x06002A9F RID: 10911 RVA: 0x00141F6C File Offset: 0x0014036C
        public override void DoEffectOn(Pawn user, Thing target)
        {
            if (!user.IsColonistPlayerControlled)
            {
                return;
            }
            if (!user.CanReserveAndReach(target, PathEndMode.Touch, Danger.Deadly, 1, -1, null, false))
            {
                return;
            }
            Job job = new Job(JobDefOf.ResurrectAndroid1, target, this.parent);
            job.count = 1;
            user.jobs.TryTakeOrderedJob(job, JobTag.Misc);
        }
    }
}