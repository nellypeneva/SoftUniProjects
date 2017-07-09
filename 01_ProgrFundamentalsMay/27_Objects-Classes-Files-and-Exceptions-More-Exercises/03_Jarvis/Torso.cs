using System;

namespace _03_Jarvis
{
    class Torso 
    {
        public Torso(int consumption, double processorSize, string housingMaterial)
        {
            this.Consumption = consumption;
            this.ProcessorSize = processorSize;
            this.CorpusMaterial = housingMaterial;
        }

        public int Consumption { get; set; }
        public double ProcessorSize { get; set; } //in centimeters 
        public string CorpusMaterial { get; set; }

        public override string ToString()
        {
            string info = String.Format("#{0}:" + Environment.NewLine +
                                       "###Energy consumption: {1}" + Environment.NewLine +
                                       "###Processor size: {2:f1}" + Environment.NewLine +
                                       "###Corpus material: {3}",
                                        GetType().Name, this.Consumption, this.ProcessorSize, this.CorpusMaterial);

            return info;
        }

    }
}
