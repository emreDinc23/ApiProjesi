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
   public class TestimonialManager : ITestimonialService
   {
       private readonly ITestimonialDaL _testimonialDaL;

       public TestimonialManager(ITestimonialDaL testimonialDaL)
       {
           _testimonialDaL = testimonialDaL;
       }
       public void TInsert(Testimonial t)
       {
          _testimonialDaL.Insert(t);
       }

       public void TDelete(Testimonial t)
       {
          _testimonialDaL.Delete(t);
       }

       public void TUpdate(Testimonial t)
       {
           _testimonialDaL.Update(t);
       }

       public List<Testimonial> TGetList()
       {
          return _testimonialDaL.GetList();
       }

       public Testimonial TGetByID(int id)
       {
           return _testimonialDaL.GetByID(id);
       }
   }
}
