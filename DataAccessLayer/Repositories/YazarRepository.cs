using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class YazarRepository : IYazarDal
    {
        Context c = new Context();
        public void EkleYazar(Yazar yazar)
        {
            c.Add(yazar);
            c.SaveChanges();
        }

        public void GuncelleYazar(Yazar yazar)
        {
            c.Update(yazar);
            c.SaveChanges();
        }

        public Yazar IdDenGetirYazar(int id)
        {
            return c.YazarVT.Find(id);
        }

        public List<Yazar> ListeTumYazar()
        {
            return c.YazarVT.ToList();
        }

        public void SilYazar(Yazar yazar)
        {
            c.Remove(yazar);
            c.SaveChanges();
        }
    }
}
