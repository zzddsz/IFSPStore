using IFSPStore.Domain.Base;
using System.Collections.Generic;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale()
        {
            Salesman = null!;
            Customer = null!;
            SaleItens = new List<SaleItem>();
        }

        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman, Costumer customer) : base(id)
        {
            Id = id;
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Salesman = salesman;
            Customer = customer;
            SaleItens = new List<SaleItem>();
        }

        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public User Salesman { get; set; }
        public int UserId { get; set; }
        public Costumer Customer { get; set; }
        public List<SaleItem> SaleItens { get; set; }
    }

    public class SaleItem : BaseEntity<int>
    {
        public SaleItem()
        {
            Sale = null!;
            Product = null!;
        }
        public SaleItem(int id, Sale sale, Product product, decimal quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }

        public int SaleId { get; set; }

        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}