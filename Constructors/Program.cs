using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };           // Direkt değerleri veren hali---      customer1.Id=1;  gibi alternatifi

            Customer customer3 = new Customer();
            customer3.Id = 3;


            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");          // Parametreli hali

            Console.WriteLine(customer2.FirstName);






        }
    }


    class Customer 
    {
        //default constructor. Yazsan da yazmasan da arka planda çalışır default constructor
        public Customer() 
        {

        }

        public Customer(int id, string firstName, string lastName, string city)         // Class ı new lediğimizde çalışmasını istediğimiz kodlar varsa constructor kullanırız
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;                     //  parametrelerle, customer class ının prop
            City = city;
        }




        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }


}
