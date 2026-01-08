using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class BankAccount
    {
        private double blance = 10000;
        public void Withdraw(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be greather than zero");
            }
            if(amount > blance)
            {
                throw new ArgumentException("Insfficient Blance");
            }
            blance -= amount;
            Console.WriteLine("Withdraw Successfully");
            Console.WriteLine("Remaining Blance is : " + blance);
        }
    }
    internal class Exception_handiling_ex3
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            try
            {
                Console.WriteLine("Enter amount to be withdraw :");
                double amt = Convert.ToDouble(Console.ReadLine());
                account.Withdraw(amt);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Enput error :" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaction Failed " + ex.Message);
            }
            finally
            { 
                Console.WriteLine("Transaction completed "); 
            }


            Console.ReadLine();
        }
    }
}
