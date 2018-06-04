using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavingFun
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Math window = new Math();
            Application.Run(window);

            Calculations equation = new Calculations();

            bool done = false;

            while (!done)
            {
                equation.generateNumbers();
                window.setLabel1(equation.getNumber1().ToString() + equation.getNumber2().ToString());
            }
        }
    }
}
