using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = "This is supposed to be a very long blog post blah blah...";

            var shortenPost = post.Shorten(4);

            Console.WriteLine(shortenPost);
        }
    }
}
