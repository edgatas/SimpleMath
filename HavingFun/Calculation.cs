using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavingFun
{
    public class Calculations
    {
        private int number1;
        private int number2;



        public Calculations()
        {
            this.number1 = 0;
            this.number2 = 0;
        }

        public int getNumber1()
        {
            return this.number1;
        }

        public int getNumber2()
        {
            return this.number2;
        }

        public void generateNumbers()
        {
            Random random = new Random();
            this.number1 = random.Next(100);
            this.number2 = random.Next(100);
        }
    }
}
