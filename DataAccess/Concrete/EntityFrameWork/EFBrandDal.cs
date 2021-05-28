using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Core.DataAcces.EntityFramework;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EFBrandDal : EfEntityRepositoryBase<Brand, ReCapContext>,IBrandDal
    {
       
    }
}

