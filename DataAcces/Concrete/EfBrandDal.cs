using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCarContext>, IBrandDal
    {
    }
}
