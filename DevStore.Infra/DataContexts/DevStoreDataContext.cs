using DevStore.Domain;
using System.Data.Entity;

namespace DevStore.Infra.DataContexts
{
    public class DevStoreDataContext : DbContext
    {
        public DevStoreDataContext() : base("devStoreConnectionString")
        {
            Database.SetInitializer(new DevStoreDataContextInitializer());
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }


    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContext>
    {
        protected override void Seed(DevStoreDataContext context)
        {
            context.Categories.Add(new Category { Id = 1 , Title = "Informática" });
            context.Categories.Add(new Category { Id = 2, Title = "Games" });
            context.Categories.Add(new Category { Id = 3, Title = "Papelaria" });
            context.SaveChanges();

            context.Products.Add(new Product { Id = 1 , CategoryId = 1 , IsActive = true , Title = "Macbook Pro 13" , Price = 5999 });
            context.Products.Add(new Product { Id = 2, CategoryId = 1, IsActive = true, Title = "Computador Intel Core I5 5ª Geracao ", Price = 1250 });
            context.Products.Add(new Product { Id = 3, CategoryId = 1, IsActive = true, Title = "Kit mouse e teclado dell ", Price = 159 });

            context.Products.Add(new Product { Id = 4, CategoryId = 2, IsActive = true, Title = "PS4 + 2 Controles + 1 Jogo", Price = 1699 });
            context.Products.Add(new Product { Id = 5, CategoryId = 2, IsActive = true, Title = "Xbox One 500 Giga" , Price = 1500 });
            context.Products.Add(new Product { Id = 6, CategoryId = 2, IsActive = true, Title = "Jogo PS4 Metal Slug", Price = 99 });

            context.Products.Add(new Product { Id = 7, CategoryId = 3, IsActive = true, Title = "Caderno Tilibra", Price = 9 });

            base.Seed(context);
        }
    }
}
