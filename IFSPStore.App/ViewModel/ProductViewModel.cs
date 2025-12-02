using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string? SalesUnit { get; set; }
        public string? PurchaseDate { get; set; }
        public int IdCategory { get; set; }
        public string? Category { get; set; }
    }
}