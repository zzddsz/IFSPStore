using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.ViewModel
{
    public class SaleViewModel
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public int IdSalesman { get; set; }
        public string? Salesman { get; set; }
        public int IdCustomer { get; set; }
        public string? Customer { get; set; }
    }

    public class SaleItemViewModel
    {
        public int Id { get; set; }
        public string? Sale { get; set; }
        public int IdProduct { get; set; }
        public string? Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}