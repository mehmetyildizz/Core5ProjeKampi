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
    public class YorumRepository : IYorumDal
    {
        Context c = new Context();
        public void EkleYorum(Yorum yorum)
        {
            c.Add(yorum);
            c.SaveChanges();
        }

        public void GuncelleYorum(Yorum yorum)
        {
            c.Update(yorum);
            c.SaveChanges();
        }

        public Yorum IdDenGetirYazar(int id)
        {
            return c.YorumVT.Find(id);
        }

        public List<Yorum> ListeTumYorum()
        {
            return c.YorumVT.ToList();
        }

        public void SilYorum(Yorum yorum)
        {
            c.Remove(yorum);
            c.SaveChanges();
        }
    }
}
