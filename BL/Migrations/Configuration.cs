namespace DAL.Migrations
{
    using DAL.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MyContext context)
        {
            //context.Categories.Add(new Category() { Name = "Chemical" });
            //context.Categories.Add(new Category() { Name = "Water" });

            //context.SaveChanges();

            //context.Products.Add(new Product
            //{
            //    Category = context.Categories.FirstOrDefault(c => c.Name == "Water"),
            //    Name = "Morshynska",
            //    Number = 012056
            //});

            //context.Products.Add(new Product
            //{
            //    Category = context.Categories.FirstOrDefault(c => c.Name == "Water"),
            //    Name = "Mirhorodska",
            //    Number = 325406
            //});

            //context.Products.Add(new Product
            //{
            //    Category = context.Categories.FirstOrDefault(c => c.Name == "Water"),
            //    Name = "Bon_Aqua",
            //    Number = 012056
            //});

            //context.Products.Add(new Product
            //{
            //    Category = context.Categories.FirstOrDefault(c => c.Name == "Chemical"),
            //    Name = "Pirana",
            //    Number = 5897416
            //});

            //context.Products.Add(new Product
            //{
            //    Category = context.Categories.FirstOrDefault(c => c.Name == "Chemical"),
            //    Name = "Henkel",
            //    Number = 012056
            //});

            //context.Products.Add(new Product
            //{
            //    Category = context.Categories.FirstOrDefault(c => c.Name == "Chemical"),
            //    Name = "Mirabella",
            //    Number = 012056
            //});
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
