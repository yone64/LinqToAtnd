using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AtndLibrary;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = AtndWebClient.QueryEvent("owner_twitter_id=ufcpp");
            t.Wait();

            foreach (var item in t.Result)
            {
                Console.WriteLine(item.title);
            }


            Console.WriteLine("--");

            var context = new AtndDataContext();
            var source = context.hashEvent;
            foreach (var item in source.Where(e => e.owner_twitter_id == "ufcpp"))
            {
                Console.WriteLine
                    (item.title);
            }
        }


        private static void Queryable()
        {
            IQueryable<int> aaa = null;

            
            var q = aaa.Where(a => a > 10);


            var param = Expression.Parameter(typeof(int), "a");
            var lambda = Expression.Lambda<Func<int, bool>>(
                Expression.GreaterThan(param, Expression.Constant(10, typeof(int))),
                param);
            var q2 = aaa.Where(lambda);
        }

        private static void Enumerable()
        {
            IEnumerable<int> aaa = null;
            var q = aaa.Where(a => a > 10);
        }

    }



}
