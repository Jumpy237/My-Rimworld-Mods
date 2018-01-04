using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;
using UnityEngine;

namespace NonLethalGuns
{
    public class ThingDef_Dart : ThingDef
    {
        public HediffDef hediffToAdd = HediffDefOf_DartBleed.DartBleed;
    }
}
