using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            { 
                new Car {CarId=1,BrandId=1,Description="Kia Sportage", ModelYear=2024 , DailyPrice=4000 },
                new Car {CarId=2,BrandId=1,Description="Ford Ecosport", ModelYear=2024 , DailyPrice=5000 },
                new Car {CarId=3,BrandId=2,Description="Peugeot 307", ModelYear=2024 , DailyPrice=6000 },
                new Car {CarId=4,BrandId=2,Description="Citroen  C4", ModelYear=2024 , DailyPrice=3000 },
                new Car {CarId=5,BrandId=3,Description="Seat Leon", ModelYear=2024 , DailyPrice=8000 },
            };
            
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c=>c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
