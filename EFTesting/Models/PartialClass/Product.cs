using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTesting.Models
{
    public partial class Product
    {
        [NotMapped]
        public int Id { get => ProductId; set => ProductId = value; }
    }
}
