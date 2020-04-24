using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContentInitializer : DropCreateDatabaseAlways<MyContext>
    {
        string errorTxt = "";

        protected override void Seed(MyContext context)
        {
            try
            {
                context.Categories.Add(new Category() { Name = "Chemical", Number = 0002 });
                context.Categories.Add(new Category() { Name = "Water", Number = 0003 });

                context.SaveChanges();

                context.Products.Add(new Product
                {
                    CategoryId = context.Categories.Single(c => c.Name == "Chemical").Id,
                    Name = "Morshynska",
                    Number = 012056
                });
                context.SaveChanges();

                context.Products.Add(new Product
                {
                    CategoryId = context.Categories.Single(c => c.Name == "Chemical").Id,
                    Name = "Mirhorodska",
                    Number = 325406
                });
                context.SaveChanges();

                context.Products.Add(new Product
                {
                    CategoryId = context.Categories.Single(c => c.Name == "Chemical").Id,
                    Name = "Bon_Aqua",
                    Number = 012056
                });
                context.SaveChanges();

                context.Products.Add(new Product
                {
                    CategoryId = context.Categories.Single(c => c.Name == "Water").Id,
                    Name = "Pirana",
                    Number = 5897416
                });
                context.SaveChanges();

                context.Products.Add(new Product
                {
                    CategoryId = context.Categories.Single(c => c.Name == "Water").Id,
                    Name = "Henkel",
                    Number = 012056
                });
                context.SaveChanges();

                context.Products.Add(new Product
                {
                    CategoryId = context.Categories.Single(c => c.Name == "Water").Id,
                    Name = "Mirabella",
                    Number = 012056
                });
                context.SaveChanges();

                base.Seed(context);
            }

            catch (Exception ex)
            {
                //errorTxt = DateTime.Now.Date.ToString() + " " + ex.Message + "\n";
            }
        }

    }
}
