string stringMessage = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = stringMessage.ToCharArray();

Array.Reverse(charMessage);
string newMessage = new String(charMessage);

// Count all the o's
int o = 0;

foreach (char c in charMessage)
{
    if (c == 'o')
    {
        o++;
    }
}

// Prints the Messages about o number and the Reversed Message
Console.WriteLine(newMessage);
Console.WriteLine($"The 'o' character appears {o} times in this message.");