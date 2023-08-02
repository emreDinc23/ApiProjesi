using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.BusinessLayer.Concreate
{
   public class PortföyManager:IPortföyService
   {
       private readonly IPortföyDal _portföyDal;

       public PortföyManager(IPortföyDal portföyDal)
       {
           _portföyDal = portföyDal;
       }
        public void TInsert(Portföy t)
        {
            _portföyDal.Insert(t);
        }

        public void TDelete(Portföy t)
        {
           _portföyDal.Delete(t);
        }

        public void TUpdate(Portföy t)
        {
            _portföyDal.Update(t);
        }

        public List<Portföy> TGetList()
        {
            return _portföyDal.GetList();
        }

        public Portföy TGetByID(int id)
        {
            return _portföyDal.GetByID(id);
        }
    }
}
