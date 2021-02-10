using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailsDto
                             {

                             };
            }
        }
    }
}
