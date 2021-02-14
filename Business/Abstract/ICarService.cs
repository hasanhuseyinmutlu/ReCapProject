using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {

        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<Car>> GetCarsById(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();
   
        IResult Add(Car car);
        

    }
}
