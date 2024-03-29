﻿using System;

namespace lab6
{

    public abstract class Sport
    {
        public Sport()
        {
            Console.WriteLine("Constructor abstract class Sport" );
        }
       public abstract void exersise();
       public void improve_health()
        {
            Console.WriteLine("Your health has improved(HEALTH++) (Sport)");
        }

        public abstract string kindSport();
    }

    public class WaterSport : Sport
    {
        public WaterSport()
        {
            Console.WriteLine("Constructor class WaterSport");
        }

        public override void exersise()
        {
            Console.WriteLine("Swim (WaterSport)");
        }

        public virtual void swim()
        {
            Console.WriteLine("SWIM (WaterSport)");
        }

        public override string kindSport()
        {
            return "WaterSport";
        }
    }

   public class Swiming: WaterSport
    {
        public Swiming()
        {
            Console.WriteLine("Constructor class Swiming");
        }

        public override void swim()
        {
            Console.WriteLine("Swim fast (Swiming)");
        }

        public override string kindSport()
        {
            return "Swimming";
        }
    }
    
    public class WaterPolo : WaterSport
    {
        public WaterPolo()
        {
            Console.WriteLine("Constructor class WaterPolo");
        }
        public override void swim()
        {
            base.swim();
        }

        public override string kindSport()
        {
            return "WaterPolo";
        }
    }

   public class GroundSport : Sport
    {
        public GroundSport()
        {
            Console.WriteLine("Constructor class GroundSport");
        }
        public override void exersise()
        {
            Console.WriteLine("Run (GroundSport)");
        }
        public void run()
        {
            Console.WriteLine("RUN (GroundSport)");
        }

        public override string kindSport()
        {
            return "GroundSport";
        }
    }

    public class Football : GroundSport
    {
        public Football()
        {
            Console.WriteLine("Constructor class Football");
        }
        public new void run()
        {
            Console.WriteLine("Run football (Football)");
        }

        public override string kindSport()
        {
            return "Football";
        }

    }

    public class Volleyball : GroundSport
    {
        public Volleyball()
        {
            Console.WriteLine("Constructor class Volleyball");
        }
        public new void run()
        {
            Console.WriteLine("Run volleyball (Volleyball)");
        }

        public override string kindSport()
        {
            return "Volleyball";
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            WaterPolo watarPolo = new WaterPolo();
            Swiming swiming = new Swiming();
            Football football = new Football();
            Volleyball volleyball = new Volleyball();

            Console.WriteLine(" ");
            swiming.improve_health();
            swiming.exersise();
            swiming.swim();


            Console.WriteLine(" ");
            watarPolo.improve_health();
            watarPolo.exersise();
            watarPolo.swim();

            Console.WriteLine(" ");
            football.improve_health();
            football.exersise();
            football.run();

            Console.WriteLine(" ");
            volleyball.improve_health();
            volleyball.exersise();
            volleyball.run();
        }
    }
}
