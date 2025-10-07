using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale()
        {
            
        }
        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman, Customer customer) : base (id)
        {
            Id = id;
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Salesman = salesman;
            Customer = customer;
            SaleItems = new List<SaleItem>();
        }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public User Salesman { get; set; }
        public int UserId { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }

    public class SaleItem : BaseEntity<int>
    {
        public SaleItem()
        {
            
        }
        public SaleItem (int id, Sale sale, Product product, decimal quantity, decimal unitPrice, decimal totalPrice) : base (id)
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
