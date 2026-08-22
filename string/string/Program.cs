using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string namee = "Diksha";

             Console.WriteLine(namee.Length);


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your City: ");
            string city = Console.ReadLine();
            Console.WriteLine("My Name is " + name);
            Console.WriteLine("ILive in " + city);
            Console.WriteLine("Name Length = " + name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());



            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.WriteLine($"My name is {name}, I am {age} years old and I live in {city}.");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("First Character = " + name[0]);
            Console.WriteLine("Last Character = " + name[name.Length - 1]);





            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                count++;
            }
            Console.WriteLine("Total Characters = " + count);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();
            int vowel = 0;
            int consonant = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }
                
            }
                Console.WriteLine("Total Vowels = " + vowel);
            Console.WriteLine("Total Consonants = " + consonant);



            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();


            
            
                if (name.Contains("a"))
                {
                    Console.WriteLine("Name contains a");
                }
                else
                {
                    Console.WriteLine("not found");
                }
            


            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();
            if(name.StartsWith("a"))
            {
                Console.WriteLine("Name start with a");
            }
             if(name.EndsWith("a"))
            {
                Console.WriteLine("NAme ends with a");
            }




            Console.Write("Enter your name: ");
            string message = Console.ReadLine().ToLower();

            message = message.Replace("bad", "good");

            Console.WriteLine(message);


            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();


            name = name.Trim();

            Console.WriteLine("Name = " + name);

            Console.WriteLine(name.Substring(0, 3));


            Console.Write("Enter your Full Name: ");
            string name = Console.ReadLine().ToLower();


            int spaceIndex = name.IndexOf(" ");
            name.Substring(0, spaceIndex);
            
            string firstName = name.Substring(0, spaceIndex);

            Console.WriteLine("First Name- " + firstName);
            



            Console.Write("Enter your Full Name: ");
            string name = Console.ReadLine().ToLower();
            int spaceIndex = name.IndexOf(" ");
           
            
            string lastName = name.Substring(spaceIndex+1);
            Console.WriteLine("Last Name = " + lastName);

            

            Console.Write("Enter your Full Name: ");
            string name = Console.ReadLine().ToLower();

            int spaceIndex = name.IndexOf(" ");
            

            string firstName = name.Substring(0, spaceIndex);
          
           


            string lastName = name.Substring(spaceIndex + 1);

           

            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                count++;
            }
            Console.WriteLine("First Name- " + firstName);
            Console.WriteLine("Last Name = " + lastName);
            Console.WriteLine("Total Characters = " + count);
            Console.WriteLine("First Character = " + name[0]);
            Console.WriteLine("Last Character = " + name[name.Length - 1]);



            Console.Write("Enter your Full Name: ");
            string name = Console.ReadLine().ToLower();
            string[] parts = name.Split(' ');

            Console.WriteLine(parts[0]);
            Console.WriteLine(parts[1]);





            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();


            string[] words = sentence.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                count++;
            }
            Console.WriteLine("total words= " + count);


            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(' ');
            Console.Write("Enter a word to search: ");
            string search = Console.ReadLine().ToLower();
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == search)
                {
                    count++;
                }
            }
            Console.WriteLine(search + " appears " + count + " times");


            Console.Write("Enter a Phone number:");
            string phone = Console.ReadLine();
            string result = phone.Remove(0, 5);

            Console.WriteLine("Remaining Number=" + result);


            Console.Write("Enter a Phone number:");
            string phone = Console.ReadLine();
            string result=phone.Replace("-", "");
            Console.WriteLine("Clean phone number=" + result); 

            Console.Write("Enter your full name:");
            string name = Console.ReadLine().ToLower();
            name = name.Trim();


            Console.WriteLine(name);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());*/
            Console.Write("Enter password:");
            string pwd = Console.ReadLine();
            string correctPassword = "admin123";
            if (pwd.Equals(correctPassword))
            {
                Console.WriteLine("Correct password - Access Granted");
            }
            else
            {
                Console.WriteLine("Wrong password - Access Denied");
            }














        }
    }
}
