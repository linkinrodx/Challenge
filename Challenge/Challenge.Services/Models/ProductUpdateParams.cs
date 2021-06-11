﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Services.Models
{
    public class ProductUpdateParams
    {
        public int ProductId { get; set; }
        public string Code { get; set; }
        public int State { get; set; }
        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Observations { get; set; }
    }
}
