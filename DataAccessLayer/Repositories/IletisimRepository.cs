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
    public class IletisimRepository : IIletisimDal
    {
        Context c = new Context();
        public void EkleIletisim(Iletisim iletisim)
        {
            c.Add(iletisim);
            c.SaveChanges();
        }

        public void GuncelleIletisim(Iletisim iletisim)
        {
            c.Update(iletisim);
            c.SaveChanges();
        }

        public Iletisim IdDenGetirIletisim(int id)
        {
            return c.IletisimVT.Find(id);
        }

        public List<Iletisim> ListeTumIletisim()
        {
            return c.IletisimVT.ToList();
        }

        public void SilIletisim(Iletisim iletisim)
        {
            c.Remove(iletisim);
            c.SaveChanges();
        }
    }
}
