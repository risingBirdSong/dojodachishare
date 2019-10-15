using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWeekCSharp.Models
{
    public class dojoDachi_Instance
    {
        public Random rando = new Random();
        public int Happiness { get; set; } = 20;
        public int Fullness { get; set; } = 20;
        public int Meals { get; set; } = 3;
        public int Energy { get; set; } = 50;

        public string Message { get; set; }


        public dojoDachi_Instance() {
            this.Happiness = DojoDachi.Happiness;
            this.Fullness = DojoDachi.Fullness;
            this.Energy = DojoDachi.Energy;
            this.Meals  = DojoDachi.Meals;
            this.Message = DojoDachi.Message;
        }

    }
}
