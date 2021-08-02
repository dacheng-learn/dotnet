using System;
using System.Linq;

namespace HelloEFCore
{
    class Program
    {
        private static void Main(string[] args)
        {
            using var db = new ApplicationDbContext();
            var comments = db.Comments.OrderByDescending(c => c.Id).ToList();
            foreach (var comment in comments)
            {
                Console.WriteLine($"id={comment.Id}, content={comment.Content}");
            }
        }
    }
}
