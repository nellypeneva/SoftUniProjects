using System;
namespace _03_Jarvis
{
    class Arm 
    {
        public Arm(int consumption, int reachDistance, int fingerCount)
        {
            this.Consumption = consumption;
            this.FingerCount = fingerCount;
            this.ReachDistance = reachDistance;
        }

        public int Consumption { get; set; }
        public int FingerCount { get; set; }
        public int ReachDistance { get; set; }

        public override string ToString()
        {
            string info = String.Format("#{0}:" + Environment.NewLine + 
                                        "###Energy consumption: {1}"+ Environment.NewLine +
                                        "###Reach: {2}"+ Environment.NewLine +
                                        "###Fingers: {3}",
                                         GetType().Name, this.Consumption, this.ReachDistance, this.FingerCount);

            return info;
        }
    }
}
