using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProject
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Player greenPlayer = new PlayerProject.Player("green");
            greenPlayer.MoveForward();


            
            WaitForAnyKey();
        }
        /// <summary>
        /// Utility methof for a console key press from the user
        ///     
        /// </summary>
        public static void WaitForAnyKey()
        {
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
