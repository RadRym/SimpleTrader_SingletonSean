using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System;

namespace SimpleTrader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            Console.WriteLine(userService.Delete(4));
            //Console.WriteLine(userService.Update(4, new User() { Username = "Pawel", Email = "Abc", Password = "xyz" }).Result.Username);
            //Console.WriteLine(userService.GetById(4).Result);
            //Console.WriteLine(userService.GetAll().Result.Count());
            //userService.Create(new User { Username = "Adrian", Email = "Abc", Password = "xyz"}).Wait();
            Console.ReadLine();
        }
    }
}