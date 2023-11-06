using System;

namespace pass.crack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Enter your password: ");
            string user_password = Convert.ToString(Console.ReadLine());
            string[] password =
            {
                "a","b","c","d","e","f","g","h","j","k","l","z","x","v","n","m","q","w","e","r","s",
                "t","y","u","i","o","p","1","2","3","4","5","6","7","8","9",".",",","/","?","*","[","]",
                "'",";",":",">","<","-","+","#"
            };
            string pw = "";
            Random rnd = new Random();
            while (pw!=user_password)
            {

                pw = "";
                foreach (char element in user_password)
                {

                    string guess_pswd = password[rnd.Next(0,51)];
                        pw = guess_pswd + pw;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(pw + "\n");
                    Console.Write("by. @daniil_adams  " +
                        "Cracking Password... Please wait: ");
                    Console.ResetColor();


                }

            }
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("Your password is: " + pw);
        }

    }
}