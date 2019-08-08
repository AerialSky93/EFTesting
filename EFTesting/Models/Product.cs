using System;
using System.Collections.Generic;

namespace EFTesting.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Amount { get; set; }
    }
}
