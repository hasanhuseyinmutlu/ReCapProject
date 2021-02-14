using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Deleted(User user);
        IResult Updete(User user);

        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int Id);
    }
}
