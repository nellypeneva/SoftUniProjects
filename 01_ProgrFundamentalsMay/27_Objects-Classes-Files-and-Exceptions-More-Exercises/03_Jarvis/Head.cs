using System;
namespace _03_Jarvis
{
    class Head 
    {
        public Head(int consumption, int iq, string skinMaterial)
        {
            this.Consumption = consumption;
            this.Iq = iq;
            this.SkinMaterial = skinMaterial;
        }

        public int Consumption { get; set; }
        public int Iq { get; set; }
        public string SkinMaterial { get; set; }

        public override string ToString()
        {  
            string info = String.Format("#{0}:" + Environment.NewLine +
                                       "###Energy consumption: {1}" + Environment.NewLine +
                                       "###IQ: {2}" + Environment.NewLine +
                                       "###Skin material: {3}",
                                        GetType().Name, this.Consumption,  this.Iq, this.SkinMaterial );

            return info; 
        }
    }
}
