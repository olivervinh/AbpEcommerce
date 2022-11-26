﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpEcommerce.Inventories
{
    public class Inventory : AuditedAggregateRoot<Guid>
    {
        public Guid ProductId { get; set; }
        public string SKU { get; set; }
        public int StockQuantity { get; set; }
    }
}
