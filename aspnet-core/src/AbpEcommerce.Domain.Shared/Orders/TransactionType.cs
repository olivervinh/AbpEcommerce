﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbpEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder = 1,
        StartProcessing = 2,
        FinishOrder = 3,
        CancelOrder = 4
    }
}
