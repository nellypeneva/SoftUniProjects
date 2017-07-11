using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Jarvis
{
    class JarvisRobot
    {
        static void Main()
        {
            long maxEnergy = long.Parse(Console.ReadLine());
            Jarvis robot = new Jarvis(maxEnergy); 
             
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Assemble!")
                {
                    break;
                } 
 
                switch (input[0])
                {
                    case "Head":
                    {
                        var part = new Head(int.Parse(input[1]), int.Parse(input[2]), input[3]);
                        robot.applyHead(part);
                        break;
                    }
                    case "Torso":
                    {
                        var part = new Torso(int.Parse(input[1]), double.Parse(input[2]), input[3]);
                        robot.applyTorso(part);
                        break;
                    }
                    case "Arm":
                    {
                        var part = new Arm(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));
                        robot.applyArm(part);
                        break;
                    }
                    case "Leg":
                    {
                        var part = new Leg(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));
                        robot.applyLeg(part);
                        break;
                    } 
                } 
            }

            Console.WriteLine(robot);
        } 
    }
}
