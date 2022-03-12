using CoreAndFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    public class FoodRepository:GenericRepository<Food>  //DİKKAT: Generic sınıfı kalıtımla al T ye Food gönder
    {                                                    //Böylece metotları bir daha yazmana gerek yok
                                                        //Generic sınıfta metotların bir sunumu var!
        //Context c = new Context();
        //public void FoodAdd(Food f)  //Ekleme metodu
        //{
        //    c.Foods.Add(f);
        //    c.SaveChanges();
        //}
        //public void FoodRemove(Food f) 
        //{
        //    c.Foods.Remove(f);
        //    c.SaveChanges();
        //}
        //public void FoodUpdate(Food f)
        //{
        //    c.Foods.Update(f);
        //    c.SaveChanges();
        //}
        //public List<Food> FoodList()
        //{
        //    return c.Foods.ToList();
        //}
        //public void GetFood(int id)  //getirme metodu
        //{
        //    c.Foods.Find(id);

        //}
    }
}
