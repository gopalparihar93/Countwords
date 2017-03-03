using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gopal_countWords_of_sentence
{
    class Program
    {
        static void Main()
        {
            string sentece = "i am Gopal.The DEMO Brand website provides information about launch, pitch, attend and sponsorship opportunities for DEMO events around the world.";
            string[] Words = sentece.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
           Console.WriteLine("Words of sentence are {0}", Words.Count());
           string[] sentence = sentece.Split(new char[] {  '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
           foreach (var iten in sentence)
           {
               Console.Write(iten);
               Console.WriteLine();
           }
          
        }
    }
}
