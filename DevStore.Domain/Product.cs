using System;

namespace DevStore.Domain
{
    public class Product
    {

        public Product()
        {
            this.AcquiredDate = DateTime.Now; 
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public DateTime AcquiredDate { get; set; }

        public bool IsActive { get; set; }

        public int CategoryId { get; set; }

        public virtual Category category{ get; set; }

        public override string ToString()
        {
            return this.Title;
        }

    }
}
