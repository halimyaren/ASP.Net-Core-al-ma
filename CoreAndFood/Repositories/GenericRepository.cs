using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T: class,new()   //T'ye class olma şartı konuldu, new barındırabilmeli
    {
        Context c = new Context();
        public List<T> TList()  //Listeleme metodumuz
        {
            return c.Set<T>().ToList();
        }

        public void TAdd(T p)  //Ekleme metodu
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public void TDelete(T p)  //Silme metodu
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }
        public void TUpdate(T p)  //Güncelleme metodu
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
        public T TGet(int id)  //Bir kategori getirme metodu
        {
            return c.Set<T>().Find(id);

        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();  //İlişkili alandan id yerine id ye ait ad bilgisini getirmek için
        }
        public List<T> List(Expression<Func<T,bool>>filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
