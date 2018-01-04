using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;
using UnityEngine;

namespace NonLethalGuns
{
    public class Projectile_Dart : Bullet
    {
        
        //
        public ThingDef_Dart Def
        {
            get
            {
                return this.def as ThingDef_Dart;
            }
        }
        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            Pawn pawn = hitThing as Pawn;
            bool flag = this.Def != null && hitThing != null;
            if (flag)
            {
                Hediff hediff2 = HediffMaker.MakeHediff(this.Def.hediffToAdd, pawn, null);
                pawn.health.AddHediff(hediff2, null, null);
            }
        }
        
    }

}

