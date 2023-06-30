using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Services.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateCreate { get; set; }
        [Browsable(false)]
        public int CategoryId { get; set; }

        [Browsable(false)]
        public virtual Category Category { get; set; }
    }
}
