//Will convert String to Binary data

namespace CharacterEncoding.Model
{
    internal class StringToBinaryConverter
    {
        public void StringToBinary(string inputStr)
        {
            string binaryvirsion = "";
            foreach (char c in inputStr)
            {
                string binary = "";
                int asciiValue = (int)c;
                while (asciiValue > 1)
                {
                    int remainder = asciiValue % 2;
                    binary = Convert.ToString(remainder) + binary;
                    asciiValue /= 2;
                }
                binary = Convert.ToString(asciiValue) + binary;
                binaryvirsion = binaryvirsion + binary.PadLeft(8, '0');
                Console.WriteLine("8 bit Ascii for {0} = {1} Binary {2} ", c, (int)c, binary.PadLeft(8,'0'));
                Console.WriteLine("7 bit Ascii for {0} = {1} Binary {2} ", c, (int)c, binary.PadLeft(7, '0'));
            }
            Console.WriteLine($"Length of Binary String = { binaryvirsion.ToString().Length}");
            Console.WriteLine($"Brinary String = {binaryvirsion}");
        }
    }
}
