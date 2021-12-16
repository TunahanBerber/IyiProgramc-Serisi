using System;

namespace ReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayı1 : " + sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };       //int[] ile inti karıştırma array,class interface reference types'tır 
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayilar1 [0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Tunahan";

            person2 = person1;
            person1.FirstName = "Büşra";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Deniz";
            customer.CreditCartNumber = "1235456";
            Employee employee = new Employee();
            employee.FirstName = "Aybüke";

            Person person3 = customer;              //BASEClass olduğu için kızmaz

            //Console.WriteLine(((Customer)person3).CreditCartNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
        }

        class Person
        {
            public int id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditCartNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
