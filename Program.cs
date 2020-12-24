using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1202_Assignment_1_GUI
{
    static class Program
    {
        static EventCoordinator eCoord;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            eCoord = new EventCoordinator(200, 1000, 101, 5000);

            eCoord.addCustomer("Simon", "Bermudez", "123456789");
            eCoord.addCustomer("Fatih", "Camgoz", "123456789");
            eCoord.addCustomer("Oliver", "Kmiec", "123456789");
            eCoord.addCustomer("Rahul", "Singla", "123456789");

            eCoord.addEvent("Test", "1", new Date(1, 1, 1, 1, 1), 10);

            Console.WriteLine(eCoord.addRSVP(101, 200));
            Console.WriteLine(eCoord.addRSVP(101, 201));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenu mainMenu = new MainMenu(eCoord);
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(mainMenu);
        }
    }
}
