using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWeekCSharp.Models
{
    public class Pseudo
    {
        public int count = 0;
        public string pseudopassword;
        public Pseudo() {
            this.count = 0;
            this.pseudopassword = makeRandoms.RandomString(13);
        }
        public void generatenew() {
            this.pseudopassword = makeRandoms.RandomString(13);
        }
    }
}
