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
    public class HakkindaRepository : IHakkindaDal
    {
        Context c = new Context();
        public void EkleHakkinda(Hakkinda hakkinda)
        {
            c.Add(hakkinda);
            c.SaveChanges();
        }

        public void GuncelleHakkinda(Hakkinda hakkinda)
        {
            c.Update(hakkinda);
            c.SaveChanges();
        }

        public Hakkinda IdDenGetirHakkinda(int id)
        {
            return c.HakkindaVT.Find(id);
        }

        public List<Hakkinda> ListeTumHakkinda()
        {
            return c.HakkindaVT.ToList();
        }

        public void SilHakkinda(Hakkinda hakkinda)
        {
            c.Remove(hakkinda);
            c.SaveChanges();
        }
    }
}
