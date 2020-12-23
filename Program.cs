using System;
using System.Collections.Generic;

namespace LikesList
{
    class Program
    {
        static List<string> GetNames(List<string> likes)
        {
            Console.WriteLine("Enter a name: ");
            var name = Console.ReadLine();
            if(name.Replace(" ","") == "") //If the entry does not contain anything other than white space return.
            {
                return(likes);
            }
            else
            {
                likes.Add(name);
                return(GetNames(likes)); //Else prompt user for another name.
            }

        }

        static string GetLikes()
        {
            var names = GetNames(new List<String>());
            if(names.Count == 0)
            {
                return("Zero Likes");
            }
            else if(names.Count == 1)
            {
                return(names[0] + " liked your post.");
            }
            else if(names.Count == 2)
            {
                return(names[0] + " and " + names[1] + " liked your post.");
            }
            else if(names.Count == 3)
            {
                return(names[0] + ", " + names[1] + " and " + (names.Count-2) + " other liked your post.");
            }
            else
            {
                return(names[0] + ", " + names[1] + " and " + (names.Count-2) + " others liked your post.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetLikes());
        }
    }
}
