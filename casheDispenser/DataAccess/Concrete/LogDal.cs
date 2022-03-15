using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class LogDal : ILogDal
    {
        List<Log> _logs;
        public LogDal()
        {
            _logs = new List<Log>();
        }
        public void Add(Log log)
        {
            _logs.Add(log);
        }

        public List<Log> GetAll()
        {
            return _logs;
        }
    }
}
