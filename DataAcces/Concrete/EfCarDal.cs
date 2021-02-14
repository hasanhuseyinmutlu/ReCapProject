using System.Linq;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces.EntityFramework;

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
                             select new CarDetailDto
                             {
                                 BrandName = c.Name,
                                 CarName = c.Name,
                                 CarId = c.Id,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description



                             };
                return result.ToList();
            }
        }
    }
}
