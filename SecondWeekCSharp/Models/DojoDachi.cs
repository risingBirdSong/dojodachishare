using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWeekCSharp.Models
{
    public static class DojoDachi
    {
        public static Random rando = new Random();
        public static int Happiness { get; set; } = 20;
        public static int Fullness { get; set; } = 20;
        public static int Meals { get; set; } = 3;
        public static int Energy { get; set; } = 50;

        public static bool initial = true;

        public static void reset()
        {
            Happiness = 20;
            Fullness = 20;
            Meals = 3;
            Energy = 50;
        }


        public static string Message { get; set; }
        public static void Feed()
        {
            if (Meals < 1)
            {
                Message = "insufficient meals!";

            }
            else if (determine_liking() == true)
            {
                Meals -= 1;
                var eatamount = rando.Next(5, 10);
                Fullness += eatamount;
                Message = $"Your Dojodachi loved eating {eatamount} food units";
                return ;
            }

            else
            {
                Meals -= 1;
                Message = $"the Dojodachi eats the meal, but doesn't enjoy it";
                return ;
            }

        }

        public static bool determine_liking()
        {
            var roll = rando.Next(0, 4);
            if (1 < roll)
            {
                return false;
            }
            else return true;
        }

        public static void Play()
        {
            if (determine_liking() == true)
            {
                Energy -= 5;
                var funAMount = rando.Next(0, 5);
                Happiness += funAMount;
                Message = $"your Dachi enjoyed playing and it's happiness has incremented by {funAMount}";
            }
            else
            {
                Energy -= 5;
                Message = $"The Dachi is not amused even slightly";
            }
        }

        public static void Work()
        {
            //Working costs 5 energy and earns between 1 and 3 meals
            Energy -= 5;
            var earnings = rando.Next(1, 3);
            Meals += earnings;
            Message = $"my dilligent work has earned me {earnings} meals.";
        }

        public static void Sleep()
        {
            Energy += 15;
            Fullness -= 5;
            Happiness -= 5;
            Message = $"yawn. im less happy, im less full, but my energy has been boosted by 15 points, this sleeps tradeoffs way in my favor";
        }

        public static void EndGameConditions()
        {
            if (Energy + Fullness + Happiness > 100) {
                Message = $"Victory attained has been attained! The conditions for such are that my happiness, energy and fullness sum to the heights of winning";
            }

            else if (Fullness <= 0 || Happiness <= 0 || Energy <= 0)
            {
                Message = $"you've allowed me to die! Damn you and may my death ever haunt your mind!";   
            }
        }


    }

}
