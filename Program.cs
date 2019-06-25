using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting the process");
            using (var context = new TestDatabaseEntities() )
            {
                var blog = new Blog()
                {
                    PostId = 4,
                    Title = "My 4th Post",
                    Description = "My 4th Post",
                    CreatedDate = DateTime.Today

                };
                context.Blogs.Add(blog);
                context.SaveChanges();
            }

            Console.WriteLine("Successfully added a post");
            Console.ReadKey();
        }
    }
}
