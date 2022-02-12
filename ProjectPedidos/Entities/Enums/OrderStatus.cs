﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPedidos.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, 
        Processing =1,
        Shipped =2,
        Delivered = 3
    }
}
