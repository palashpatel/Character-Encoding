//Will print Ascii value of string
namespace CharacterEncoding.Model
{
    internal class PrintAscii
    {
        public void printAsciiValue(string inputStr)
        {
            Console.WriteLine("\n==================Read Each Character of string==================");
            foreach (char ch in inputStr)
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine("\n==================Print Ascii Value of  Each Character now==================");
            foreach(char ch in inputStr)
            {
                int asciivalue = (int)ch;
                Console.WriteLine($"char = {ch} Ascii Value = {asciivalue}");
            }
        }
    }
}
