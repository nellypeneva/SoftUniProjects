using System;
namespace _03_Jarvis
{
    class Leg 
    {
        public Leg(int consumption, int strength, int speed)
        {
            this.Consumption = consumption;
            this.Strength = strength;
            this.Speed = speed;
        }

        public int Consumption { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }   

        public override string ToString()
        {
            string info = String.Format("#{0}:" + Environment.NewLine +
                                        "###Energy consumption: {1}" + Environment.NewLine +
                                        "###Strength: {2}" + Environment.NewLine +
                                        "###Speed: {3}",
                                         GetType().Name, this.Consumption, this.Strength, this.Speed);

            return info;
        }
    }
}
