using Business.Concrete;
using DataAccess.Concrete;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());
        foreach (var cars in carManager.GetAll())
        {
            Console.WriteLine("Araclar  :  " + cars.Description);
        }

        
    }
}