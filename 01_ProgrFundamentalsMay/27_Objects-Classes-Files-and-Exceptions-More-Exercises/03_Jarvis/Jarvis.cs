using System;
using System.Collections.Generic;
using System.Linq; 

namespace _03_Jarvis
{
    class Jarvis
    {
        private long MaxEnergy;
        private Head Head;
        private Torso Torso;
        private List<Arm> Arms;
        private List<Leg> Legs;

        public Jarvis(long maxEnergy)   
        {
           this.MaxEnergy = maxEnergy;
           this.Arms =   new List<Arm>();
           this.Legs =  new List<Leg>();
        } 
        public long GetEnergyConsumption()
        {
            long energy = 0;

            if (Head != null)
            {
                energy += (long)Head.Consumption;
            }

            if (Torso != null)
            {
                energy += (long)Torso.Consumption;
            }

            energy +=  Arms.Sum(item => (long)item.Consumption);
            energy +=  Legs.Sum(item => (long)item.Consumption);

            return energy;
        }


        public void applyHead(Head head)
        {
            if (Head == null || Head.Consumption > head.Consumption)
            {
                Head = head;
            } 
        }

        public void applyTorso(Torso torso)
        {
            if (Torso == null || Torso.Consumption > torso.Consumption)
            {
                Torso = torso;
            }            
        }

        public void applyArm(Arm arm)
        {
            if (Arms.Count >= 2)
            {
                //int index = Arms.OrderByDescending(x => x.Consumption).ToList().FindIndex(x => x.Consumption > arm.Consumption); 
                int index = Arms.FindIndex(x => x.Consumption > arm.Consumption); 
                if (index >=0)
	            {
                    Arms[index] = arm;
	            }                
            }
            else
            {
                Arms.Add(arm);
            }
        }

        public void applyLeg(Leg leg)
        {
            if (Legs.Count >= 2)
            {
                //int index = Legs.OrderByDescending(x => x.Consumption).ToList().FindIndex(x => x.Consumption > leg.Consumption);
                int index = Legs.FindIndex(x => x.Consumption > leg.Consumption);
                if (index >= 0)
                {
                    Legs[index] = leg;
                }      
            }
            else
            {
                Legs.Add(leg);
            }
        }

        public override string ToString()
        {

            if (Head == null || Torso == null || Legs.Count < 2 || Arms.Count < 2)
            {
                return "We need more parts!"; 
            }

            if (this.MaxEnergy < GetEnergyConsumption())
            {
                return "We need more power!";  
            }
 
            string info = String.Format("{0}:" + Environment.NewLine +
                                        "{1}" + Environment.NewLine +
                                        "{2}" + Environment.NewLine +
                                        "{3}" + Environment.NewLine +
                                        "{4}",
                                         GetType().Name, Head, Torso, 
                                         string.Join(Environment.NewLine, Arms.OrderBy(x => x.Consumption)) ,
                                         string.Join(Environment.NewLine, Legs.OrderBy(x => x.Consumption)) 
                                        );

            return info;
        }
         
    }
}
