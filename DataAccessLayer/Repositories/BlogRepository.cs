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
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void EkleBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void GuncelleBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }

        public Blog IdDenGetirBlog(int id)
        {
            return c.BlogVT.Find(id);
        }

        public List<Blog> ListeTumBlog()
        {
            return c.BlogVT.ToList();
        }

        public void SilBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }
    }
}
