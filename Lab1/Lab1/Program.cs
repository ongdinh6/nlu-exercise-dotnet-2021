using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
        class Ticket
        {
        public String flightName { set; get; }
        public DateTime startDate { set; get; }
        public double price { set; get; }


            public Ticket() { }
            
        public Ticket(String flightName, DateTime startDate, double price)
        {
            this.flightName = flightName;
            this.startDate = startDate;
            this.price = price;
        }
        }
    class Person
    {
        public  String fullName { set; get; }
        public String gender { get; set; }
        public int age { set; get; }

        public Person(String fullName, String gender, int age)
        {
            this.fullName = fullName;
            this.gender = gender;
            this.age = age;
        }
        public Person()
        {

        }
    }

    class Cosumer : Person, IComparable<Cosumer>
    {
        public Ticket ticket { set; get; }
        public int amount { set; get; }

        public Cosumer()
        {

        }
        public Cosumer(Ticket ticket, int amount)
        {
            this.ticket = ticket;
            this.amount = amount;
        }

        public double totalPrice()
        {
            double total = this.ticket.price * this.amount;

            if (this.amount >= 3)
            {
                total = total - (total*0.15);
            }
            if (age < 5)
            {
                total = 0.0;
            }
            else
            if (age >= 6 && age <= 10)
            {
                total *= 0.5;
            }
            return total;
        }

        public int CompareTo(Cosumer other)
        {
            return totalPrice().CompareTo(other.totalPrice());
        }
    }
    class MainTest
    {
       

        public static void printList(ArrayList listCosumer)
        {
            foreach (Cosumer c in listCosumer)
            {
                Console.WriteLine("FullName :" + c.fullName + ", gender = " + c.gender + ", age = " + c.age + ", totalPrice = " + c.totalPrice());
            }
        }
        static void Main(String[] args)
        {
            ArrayList listCosumer = new ArrayList();
            Console.Write("Enter amount of list cosumer: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while(n > 0)
            {
                Console.WriteLine("Input cosumer info {0}?", i);
                Cosumer cosumer = new Cosumer();
                Console.Write("Full name: ");
                String fullName = Console.ReadLine();
                cosumer.fullName = fullName;
                Console.Write("Gender: ");
                String gender = Console.ReadLine();
                cosumer.gender = gender;
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                cosumer.age = age;
                Console.Write("==========\nTicket info ");
                Console.Write("Flight name: ");
                Ticket ticket = new Ticket();
                String flightName = Console.ReadLine();
                ticket.flightName = flightName;
                DateTime startDate = new DateTime();
                ticket.startDate = startDate;
                Console.Write("Price of ticket: ");
                double price = double.Parse(Console.ReadLine());
                ticket.price = price;
                cosumer.ticket = ticket;
                Console.Write("Amount: ");
                int amount = int.Parse(Console.ReadLine());
                cosumer.amount = amount;
                Console.WriteLine("=============================\n");
                

                listCosumer.Add(cosumer);
                i++;
                n--;
            }

            Console.WriteLine("List initial:");
            printList(listCosumer);

            Console.WriteLine("List after sort:");
            for (int j = 0; j < listCosumer.Count; j++)
            {
                for (int k = 0; k < listCosumer.Count - j - 1; k++)
                {
                    Cosumer c = (Cosumer)listCosumer[k]; //k co price nho hon
                    if (c.CompareTo((Cosumer)listCosumer[k + 1]) == -1)
                    {
                        listCosumer[k] = listCosumer[k + 1]; //gan k = k+1
                        listCosumer[k+1] = c; 
                    }
                }
            }
            printList(listCosumer);
        }
    }
}
