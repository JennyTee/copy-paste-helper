using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CopyPasteHelper
{
    class CopyPasteHelper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCopyPasteHelper");

            while (true) {
                Console.WriteLine("\nPaste your copied code (with line numbers) below. When finished, press ENTER and type \"go\"\n");

                string line;
                StringBuilder result = new StringBuilder();
                result.Append("\n-----------------------------------------\nRESULT\n-----------------------------------------\n\n");
                while ((line = Console.ReadLine()) != null && (!line.ToLower().Equals("go")))
                {
                    var newLine = Regex.Replace(line, @"^\s*\d+\.?", String.Empty);
                    result.AppendLine(newLine);
                }

                result.Append("\n");
                Console.WriteLine(result);

                Console.Write("Would you like to try again? (y/n)");
                var tryAgain = Console.ReadLine();

                if (!tryAgain.ToLower().Equals("y"))
                {
                    break;
                }
            }
        }
    }
}
