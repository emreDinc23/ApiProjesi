﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.DataAccessLayer.EntityFramework
{
   public class EfSubscribeDal : GenericRepository<Subscribe>,ISubscribeDal
    {
        public EfSubscribeDal(Context context):base(context)
        {

            
        }
    }
}
