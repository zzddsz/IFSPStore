using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {

        public Sale() : base(0)
        {
            SaleItems = new List<SaleItem>();
        }
        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman, Costumer customer) : base(id)
        {
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Salesman = salesman;
            Costomer = customer;
            SaleItems = new List<SaleItem>();
        }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public User Salesman { get; set; }
        public Costumer Costomer { get; set; }
        public List<SaleItem> SaleItems { get; set; }

    }

    public class SaleItem : BaseEntity<int>
    {

        public SaleItem() : base(0)
        {
        }
        public SaleItem(int id, Sale sale, Product product, int quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}