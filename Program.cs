using System;
using Bogus;

namespace FakerData
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = new Faker<Peoples>("pt_BR")
               .RuleFor(c => c.Id, f => f.Random.Guid())
               .RuleFor(c => c.Name, f => f.Name.FullName())
               .RuleFor(c => c.Email, f => f.Internet.Email())
               .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
               .RuleFor(c => c.Password, f => f.Internet.Password())
               .Generate(3);

            foreach (var peopleFake in peoples)
            {
                Console.WriteLine(@"People's Data");
                Console.WriteLine($"ID: {peopleFake.Id}");
                Console.WriteLine($"Nome: {peopleFake.Name}");
                Console.WriteLine($"Email: {peopleFake.Email}");
                Console.WriteLine($"PhoneNumber: {peopleFake.PhoneNumber}");
                Console.WriteLine($"Password: {peopleFake.Password}");
                Console.WriteLine("------------------");
            }
        }
    }
}