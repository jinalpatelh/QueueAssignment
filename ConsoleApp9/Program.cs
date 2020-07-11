using System;
using System.Collections.Generic;

namespace QueueAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            myQueue<Customer> myCustomerQ = new myQueue<Customer>();
            myCustomerQ.myq = new Queue<Customer>(10);
            myCustomerQ.Add(new Customer { firstname="Joe", lastname="Smith" } );
            myCustomerQ.Add(new Customer { firstname = "Sally", lastname = "James" });
            myCustomerQ.Add(new Customer { firstname = "Mumbo", lastname = "Alex" });
            myCustomerQ.Add(new Customer { firstname = "Jumbo", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "Jack", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "Jill", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "Went", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "Up", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "To", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "Hill", lastname = "Smith" });
            myCustomerQ.Add(new Customer { firstname = "Final", lastname = "Smith" });

            Console.WriteLine("We can add only 10 item. When we add 11the automatically ger removed from first place.");
            foreach(var item in myCustomerQ.myq)
            {
                Console.WriteLine($"{item.firstname} {item.lastname}");
            }

            Console.WriteLine("After Removing few items to check---------- ");

            myCustomerQ.Remove();
            myCustomerQ.Remove();
            myCustomerQ.Remove();

            foreach (var item in myCustomerQ.myq)
            {
                Console.WriteLine($"{item.firstname} {item.lastname}");
            }

        }

        public class myQueue<T> where T : class
        {
            public Queue<T> myq;
            public void Add(T item)
            {
                if(myq.Count == 10)
                {
                    myq.Dequeue();
                }
                myq.Enqueue(item);
            }
            public void Remove()
            {
                myq.Dequeue();
            }
        }

        public class Customer
        {
            public string firstname { get; set; }
            public string lastname { get; set; }

        }
    }
}
