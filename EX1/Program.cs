// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//========================================  EX1 =============================================
int i = 0;
while (i < 3)
{
    String pass = Console.ReadLine();

    if (pass.Equals("12345"))
    {
        Console.WriteLine("Login successful!");
    }
    else
    {
        Console.WriteLine("error login!");
        i++;
    }
}
Console.WriteLine("accout disable!");
//===============================================  EX2  ==========================================
long passs = 11;
Random rand = new Random();
long int_random = rand.NextInt64(passs);
Console.WriteLine(int_random);
//=================================================  EX3  =========================================
string password = "";


long char_random1 = rand.Next(0, 26);
char ch = (char)('a' + char_random1);
Console.WriteLine(ch);

