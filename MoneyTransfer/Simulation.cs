using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person cody = new Person("cody", 1000);
            Person jenny = new Person("Jenny", 850);
            Person jordy = new Person("jordy", 500);
            Person jack = new Person("jack", 450);
            Person jon = new Person("jon", 800);

            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            cody.DisplayInfo();
            jenny.DisplayInfo();
            jordy.DisplayInfo();
            jack.DisplayInfo();
            jon.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            //Bonus
            string choice =cody.ChooseFriend();  //Choice is holding a string value of ChooseFriend.
            
            if (choice == jordy.name)
            {
                cody.TransferMoney(jordy, 500);
            }
            else if (choice == jack.name)
            {
                cody.TransferMoney(jack, 1001);
            }
            else if (choice == jenny.name)
            {
                cody.TransferMoney(jenny, 1001);
            }
            else if (choice == jon.name)
            {
                cody.TransferMoney(jon, 500);
            }
            else
            {
                Console.WriteLine("Choose a name from the list.");
                cody.ChooseFriend();
            }


            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            cody.DisplayInfo();
            jenny.DisplayInfo();
            jordy.DisplayInfo();
            jack.DisplayInfo();
            jon.DisplayInfo();

            Console.WriteLine("Simulation complete.");
        }


    }
}
