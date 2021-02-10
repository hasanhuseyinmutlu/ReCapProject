using Business.Abstract;
using Business.Concrete;
using DataAcces.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    public class Program
    {
       static ICarService _carService = new CarManager(new EfCarDal());

        static void Add()
        {
            _carService.Add(new Car {BrandId =1,ColorId =1,Id =1,DailyPrice =2000,ModelYear =1998,Description ="20KM"});
        }
        
    }
}
