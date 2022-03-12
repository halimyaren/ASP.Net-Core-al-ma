using CoreAndFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    
    public class CategoryRepository:GenericRepository<Category>
    {
        //Generic bir sınıf tanımladık ve bunları kaldırdık.

        //Context c = new Context();
        //public List<Category> CategorList()  //Listeleme metodumuz
        //{
        //    return c.Categories.ToList();
        //}

        //public void CategorAdd(Category ct)  //Ekleme metodu
        //{
        //   c.Categories.Add(ct);
        //    c.SaveChanges();
        //}
        //public void CategorDelete(Category ct)  //Silme metodu
        //{
        //    c.Categories.Remove(ct);
        //    c.SaveChanges();
        //}
        //public void CategorUpdate(Category ct)  //Güncelleme metodu
        //{
        //    c.Categories.Update(ct);
        //    c.SaveChanges();
        //}
        //public void GetCategory(int id)  //Bir kategori getirme metodu
        //{
        //    c.Categories.Find(id);
            
        //}
    }
}
