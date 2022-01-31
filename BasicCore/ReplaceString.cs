using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class ReplaceString
    {
        public void ReplaceStr()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            string text = "Hello <<UserName>>, How are you?";
            string replacedText = text.Replace("<<UserName>>", name);
            Console.WriteLine(replacedText);
        }
    }
}
