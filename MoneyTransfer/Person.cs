using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Person
    {
        public string name;
        private Wallet wallet;

        public Person(string name, int cash)
        {
            //TODO 2: Assign the value of the 'name' parameter to the 'name' member variable. One line.
            this.name = name;
            //TODO 3: Instantiate a new 'Wallet' object, passing the 'cash' parameter into its constructor. Assign this new Wallet to the 'wallet' member variable. One line.
            Wallet wallet = new Wallet(cash); this.wallet = wallet;
        }

        public void DisplayInfo()
        {
            //TODO 4: Use string interpolation in a ConsoleWriteLine to display the user's name and also the amount of money in their wallet (using dot notation). One line.
            Console.WriteLine($"{name} has ${wallet.money}.");
        }

        public void AcceptMoney(int amount)
        {
            //TODO 7: Use an assignment operator to increase the amount of money in the person's wallet by the value of the 'amount' parameter. One line.
            this.wallet.money += amount;
        }

        public bool TransferMoney(Person receiver, int amountToTransfer)
        {
            //TODO 8: Use a conditional to check if the 'amountToTransfer' parameter of this method is less than or equal to the amount of money in the wallet of the giver.
            //If the parameter is less than the amount in the wallet, subtract that amount from the wallet, then call the receiver's AcceptMoney() method and pass 'amountToTransfer' into it. Also use a Console.WriteLine to describe the transaction that occurred.
            //If the parameter is greater than the amount in the giver's wallet, do not transfer any money and instead print a message describing why the transfer failed.
            Console.WriteLine($"{name} wants to send {receiver.name} money!");

            if (amountToTransfer <= this.wallet.money) //Check if the transfer is less than the wallet
            {
                this.wallet.money -= amountToTransfer; //Subtract from my wallet.
                receiver.AcceptMoney(amountToTransfer); //Pass in the amount to transfer as a param.
                Console.WriteLine("Transaction Successful!");
                Console.WriteLine($"{name} has sent {receiver.name} {amountToTransfer} dollars.");
                return true;
            }
            else if (amountToTransfer > this.wallet.money) //Check if the transfer is more than the wallet
            {
                Console.WriteLine("Insufficient Funds!");
                return false;
            }
            else
            {
                Console.WriteLine("Error 404 Not Found");
                return false;
            }

        }
        public string ChooseFriend()
        {
            Console.WriteLine("Choose a friend you want to help! cody, jenny, jordy, jack or jon");
            string choice = Console.ReadLine();
            return choice;
        }


    }
}
