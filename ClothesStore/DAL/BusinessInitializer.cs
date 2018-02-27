using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClothesStore.Models;

namespace ClothesStore.DAL
{
   public class BusinessInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BusinessContext>
   {
      protected override void Seed(BusinessContext context)
      {

         var Category = new List<Category>
            {
            new Category{CategoryID= 1,CategoryName="Jeans"},
            new Category{CategoryID= 2,CategoryName="Shorts"},
            new Category{CategoryID= 3,CategoryName="Pants"},
            new Category{CategoryID= 4,CategoryName="Polos"},
      
            };

         Category.ForEach(s => context.Categories.Add(s));
         context.SaveChanges();

         var Items = new List<Item>
            {
            new Item {ItemID=1,ItemName="xxx",Description="All weather Jeans",ImagePath="~/Content/Images/jeans4.jpg",ItemPrice=35,CategoryID =1 },
            new Item {ItemID=2,ItemName="Levis1",Description="Best since 1906",ImagePath="~/Content/Images/jeans.jpg",ItemPrice=50,CategoryID =1 },
            new Item {ItemID=3,ItemName="True Religion",Description="We Simply Believe In IT!",ImagePath="True.png",ItemPrice=40,CategoryID =1 },
            new Item {ItemID=4,ItemName="Brand",Description="Best brand",ImagePath="Brand.png",ItemPrice=25,CategoryID =1 },
            new Item {ItemID=5,ItemName="Nike",Description="Best product ever",ImagePath="Nike.png",ItemPrice=60,CategoryID =1 },

            new Item {ItemID=6,ItemName="Puma",Description="Your sports needs is here",ImagePath="Puma.png",ItemPrice=30,CategoryID =2 },
            new Item {ItemID=7,ItemName="Reebok",Description="Best since 1906",ImagePath="Reebok.png",ItemPrice=32,CategoryID =2 },
            new Item {ItemID=8,ItemName="Adidas1",Description="Best product in the market!",ImagePath="Adidas1.png",ItemPrice=40,CategoryID =2 },
            new Item {ItemID=9,ItemName="Theory",Description="Long Life shorts!",ImagePath="Theory.png",ItemPrice=32,CategoryID =2 },
            new Item {ItemID=10,ItemName="Swiss",Description="Best products!",ImagePath="Swiss.png",ItemPrice=40,CategoryID =2 },

            new Item {ItemID=11,ItemName="Levis",Description="Best since 1906",ImagePath="Levis.png",ItemPrice=25,CategoryID =3 },
            new Item {ItemID=12,ItemName="Adidas",Description="Best product in the market!",ImagePath="Adidas.png",ItemPrice=25,CategoryID =3 },
            new Item {ItemID=13,ItemName="Nike",Description="Best product ever",ImagePath="Nike.png",ItemPrice=25,CategoryID =3 },
            new Item {ItemID=14,ItemName="Fila1",Description="latest in the market",ImagePath="Fila1.png",ItemPrice=25,CategoryID =3 },
            new Item {ItemID=15,ItemName="Burnside",Description="Lasts long",ImagePath="Burnside.png",ItemPrice=25,CategoryID =3 },

            new Item {ItemID=16,ItemName="Lacoste",Description="Hand made polo",ImagePath="Lacoste.png",ItemPrice=22,CategoryID =4 },
            new Item {ItemID=17,ItemName="Fila",Description="latest in the market",ImagePath="Filal.png",ItemPrice=30,CategoryID =4 },
            new Item {ItemID=18,ItemName="Hugo",Description="Best of the best",ImagePath="Hugo.png",ItemPrice=35,CategoryID =4 },
            new Item {ItemID=19,ItemName="Volcom",Description="Made for your comfort",ImagePath="Volcom.png",ItemPrice=28,CategoryID =4 },
            new Item {ItemID=20,ItemName="Under",Description="Sports wear",ImagePath="Under.png",ItemPrice=25,CategoryID =4 },



            };
         Items.ForEach(s => context.Items.Add(s));
         context.SaveChanges();
      }
   }
}



