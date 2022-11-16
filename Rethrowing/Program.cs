using System;

namespace Rethrowing
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var s = new Sentence(null);
            Console.WriteLine($"The first character is {s.GetFirstCharacter()}");
        }
    }

    // The example displays the following output:
    //    Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
    //       at Sentence.GetFirstCharacter()
    //       at Program.Main()
}