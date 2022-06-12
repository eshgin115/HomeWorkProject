// See https://aka.ms/new-console-template for more information
char[] alphabetLower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[] alphabitsUpper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
string text = Console.ReadLine();
string TargetName = Console.ReadLine();
string TargetLetter = Console.ReadLine();
string result = MyMetod(text, alphabetLower, alphabitsUpper);
string secondResult = MyMetod2(text, alphabitsUpper, alphabetLower);
static string MyMetod(string text, char[] Lower, char[] Upper)
{
    for (int i = 0; i < Lower.Length; i++)
    {
        text = text.Replace(Lower[i], Upper[i]);
    }
    return text;
}
static string MyMetod2(string text, char[] Upper2, char[] Lower2)
{
    for (int i = 0; i < Lower2.Length; i++)
    {
        text = text.Replace(Upper2[i], Lower2[i]);
    }
    return text;
}

static bool IsLetterExist(string TargedName, string TargedLetter)
{
    for (int i = 0; i < TargedName.Length; i++)
    {
        if (TargedName[i] == TargedLetter[0])
        {
            Console.WriteLine("Compatible: ");
            return true;
        }
    }
    Console.WriteLine("Not Compatible: ");
    return false;
}