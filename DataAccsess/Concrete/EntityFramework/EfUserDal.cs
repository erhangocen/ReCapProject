﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfUserDal : IEntityRepositoryBase<User,CarsDBContext>, IUserDal
    {
    }
}
