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
        #region Overrides
        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);

            /*
             * Null checking is very important in RimWorld.
             * 99% of errors reported are from NullReferenceExceptions (NREs).
             * Make sure your code checks if things actually exist, before they
             * try to use the code that belongs to said things.
             */
            if (Def != null && hitThing != null && hitThing is Pawn hitPawn) //Fancy way to declare a variable inside an if statement. - Thanks Erdelf.
            {
                var rand = Rand.Value; // This is a random percentage between 0% and 100%

                //This checks to see if the character has a heal differential, or hediff on them already.



                   

          
                List<BodyPartRecord> bpList = hitPawn.RaceProps.body.AllParts;
                for (int i = 0; i < bpList.Count; i++)
                {
                    BodyPartRecord record = bpList[i];
                    if (record.def == DefDatabase<BodyPartDef>.GetNamed("Heart"))
                    {
                        
                        Hediff hediff1 = HediffMaker.MakeHediff(Def.hediffToAdd1, hitPawn, record);
                        hediff1.Severity = 1.0f;
                        hitPawn.health.AddHediff(hediff1, null, null);
                        Hediff hediff2 = HediffMaker.MakeHediff(Def.hediffToAdd2, hitPawn, record);
                        hediff2.Severity = 0.1f;
                        hitPawn.health.AddHediff(hediff2, null, null);
                    }
                }

            }
             
            }
        }
        #endregion Overrides

    }



