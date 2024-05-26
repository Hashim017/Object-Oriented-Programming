using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSystem
{
    class CredentialsUI
    {
        public static CredentialsBL takeInput()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            CredentialsBL user = new CredentialsBL(username, password);
            return user;
        }

        public static void signedIn()
        {
            Console.WriteLine();
            Console.WriteLine("Signed In Successfully ... !");
        }

        public static void signedUp()
        {
            Console.WriteLine();
            Console.WriteLine("Signed Up Successfully ... !");
        }

        public static void inValidUser()
        {
            Console.WriteLine();
            Console.WriteLine("User Not Found, Kindly Sign Up First ... !");
        }

        public static void wrongCredentials()
        {
            Console.WriteLine();
            Console.WriteLine("Wrong Credentials ... !");
        }

        public static void alreadyExists()
        {
            Console.WriteLine();
            Console.WriteLine("Credentials Already Exists, Try Different Username Or Password ... !");
        }

        public static void addedAdmin()
        {
            Console.WriteLine();
            Console.WriteLine("Admin Added Successfully ... !");
        }
    }
}
