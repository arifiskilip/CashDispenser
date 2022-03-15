using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ILogDal
    {
        void Add(Log log);
        List<Log> GetAll();

    }
}
