using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SVCBookStore.BookServiceClient client = new SVCBookStore.BookServiceClient();

            // Use the 'client' variable to call operations on the service.
            SVCBookStore.Book[] books = client.GetAllBooks();

            foreach (var item in books)
            {
                var props = GetProperties(item);
                foreach (var prop in props)
                {
                    Console.WriteLine(prop.Key);
                    Console.WriteLine(": ");
                    Console.WriteLine(prop.Value);
                }
            }

            // Always close the client.
            client.Close();
            Console.ReadKey();
        }

        private static Dictionary<string, string> GetProperties(object obj)
        {
            var props = new Dictionary<string, string>();
            if (obj == null)
                return props;

            var type = obj.GetType();
            foreach (var prop in type.GetProperties())
            {
                var val = prop.GetValue(obj, new object[] { });
                var valStr = val == null ? "" : val.ToString();
                props.Add(prop.Name, valStr);
            }

            return props;
        }
    }
}
