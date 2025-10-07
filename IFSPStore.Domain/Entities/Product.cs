﻿using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
            
        }
        public Product(int id, string name, decimal price, int quantity, DateTime purchaseDate, string salesUnit, Category category) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            PurchaseDate = purchaseDate;
            SalesUnit = salesUnit;
            Category = category;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SalesUnit{ get; set; }
        public Category Category { get; set; }
    }
}

