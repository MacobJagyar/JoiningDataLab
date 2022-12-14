using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningDataLab
{


    public class CustomerOrder
    {
        public CustomerOrder(string aCustomerName, string aItem, decimal aPrice, int aQuantity, decimal aTotal)
        {
            CustomerName = aCustomerName;
            Item = aItem;
            Price = aPrice;
            Quantity = aQuantity;
            Total = aTotal;

        }

        public CustomerOrder() { }

        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public static List<CustomerOrder> CustomerDb { get; set; } = new List<CustomerOrder>()
        {
            new CustomerOrder(
               "Acme Hardware",
               "Mouse",
               25,
               3 ,
               75) ,

            new CustomerOrder(
                "Acme Hardware",
                "Keyboard",
                45,
                2,
                90),

            new CustomerOrder(
                "Falls Realty",
                "Macbook",
                800,
                2,
                1600),

            new CustomerOrder(
                "Julie's Morning Diner",
                "iPad",
                525,
                1,
                525),

            new CustomerOrder(
                "Julie's Morning Diner",
                "Credit Card Reader",
                45,
                1,
                45)
        };

        public static void ForExercise1()
        {
            Console.WriteLine();

            Console.WriteLine("EXERCISE 1");
            Console.WriteLine("\nAcme Hardware");

            Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Acme Hardware")
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }

            Console.WriteLine("\nFalls Realty");

            Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Falls Realty")
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }

            Console.WriteLine("\nJulie's Morning Diner");

            Console.WriteLine(String.Format("{0, 20} {1, 20} {2, 20} {3, 20}", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Julie's Morning Diner")
                {
                    Console.WriteLine(String.Format("{0, 20} {1, 20} {2, 20} {3, 20}", CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }
        }

        public static void ForExercise2()
        {
            Console.WriteLine();

            Console.WriteLine("EXERCISE 2");
            Console.WriteLine("\nAcme Hardware");

            decimal acmeGrand = 0;

            Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Acme Hardware")
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}",
                        CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }

            foreach (CustomerOrder c in CustomerDb.FindAll(x => x.CustomerName == "Acme Hardware"))
            {
                acmeGrand += c.Total;
            }

            Console.WriteLine(String.Format("{0, -47} {1, -47}", "Total ", acmeGrand));


            Console.WriteLine("\nFalls Realty");

            decimal fallsGrand = 0;

            Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Falls Realty")
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}",
                        CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }

            foreach (CustomerOrder c in CustomerDb.FindAll(x => x.CustomerName == "Falls Realty"))
            {
                fallsGrand += c.Total;
            }

            Console.WriteLine(String.Format("{0, -47} {1, -47}", "Total ", fallsGrand));

            Console.WriteLine("\nJulie's Morning Diner");

            decimal juliesGrand = 0;

            Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Julie's Morning Diner")
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}",
                        CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }

            foreach (CustomerOrder c in CustomerDb.FindAll(x => x.CustomerName == "Julie's Morning Diner"))
            {
                juliesGrand += c.Total;
            }
        }

        public static void ForExercise3()
        {
            Console.WriteLine();

            Console.WriteLine("EXERCISE 3");
            Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}", "Customer", "Item", "Price", "Quantity", "Total"));

            for (int count = 0; count < CustomerDb.Count; count++)
            {
                if (CustomerDb[count].CustomerName == "Acme Hardware")
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}",
                        CustomerDb[count].CustomerName, CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
                }
            }

            //Console.WriteLine("\nFalls Realty");

            //Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", "Item", "Price", "Quantity", "Total"));

            //for (int count = 0; count < CustomerDb.Count; count++)
            //{
            //    if (CustomerDb[count].CustomerName == "Falls Realty")
            //    {
            //        Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15}", CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
            //    }
            //}

            //Console.WriteLine("\nJulie's Morning Diner");

            //Console.WriteLine(String.Format("{0, 20} {1, 20} {2, 20} {3, 20}", "Item", "Price", "Quantity", "Total"));

            //for (int count = 0; count < CustomerDb.Count; count++)
            //{
            //    if (CustomerDb[count].CustomerName == "Julie's Morning Diner")
            //    {
            //        Console.WriteLine(String.Format("{0, 20} {1, 20} {2, 20} {3, 20}", CustomerDb[count].Item, CustomerDb[count].Price, CustomerDb[count].Quantity, CustomerDb[count].Total));
            //    }
            //}
        }
    }
}
