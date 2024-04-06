//Character Encoding
using CharacterEncoding.Model;

//take input 
Console.Write("Enter String:-");
string inputStr = Console.ReadLine();

//print Ascii va;ue
PrintAscii ascii = new PrintAscii();
ascii.printAsciiValue(inputStr);

//Call StringToBinary
StringToBinaryConverter base2 = new StringToBinaryConverter();
base2.StringToBinary(inputStr);