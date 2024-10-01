Main();
static void Main()
{


    Console.WriteLine("Enter string");
    string str = Console.ReadLine();
    int numberOfWords = 0;
    for (int i = 0; i < str.Length; i++)
    {
        char c = str[i];
        if (Char.IsUpper(c))
        {
            // Add 1 to the total word count
            numberOfWords++;
        }

    }
    Console.WriteLine($"The sentence you inputted is: {str}");
    Console.WriteLine($"Number of words = {numberOfWords}");
    //this works because i added a comment

}