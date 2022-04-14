using DataAccessLayer.Abstract;
using DataAccessLayer.concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class blogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }
        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }
        public Blog GetByIdBlog(int id)
        {
            return c.Blogs.Find(id);
        }
        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public List<Blog> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
