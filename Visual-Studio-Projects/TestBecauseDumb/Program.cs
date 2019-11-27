using System;

class Program
{

    // YOUR CODE HERE: Define a Quote method!
    static string Quote(string phrase)
    {
        return (" \" " + phrase + " \"");
        //return(" \" \"");
    }
    static void Main(string[] args)
    {
        // Quote by Maya Angelou.
        Console.WriteLine(Quote("When you learn, teach. When you get, give."));
        // Quote by Benjamin Franklin.
        Console.WriteLine(Quote("No gains without pains."));
    }

}
