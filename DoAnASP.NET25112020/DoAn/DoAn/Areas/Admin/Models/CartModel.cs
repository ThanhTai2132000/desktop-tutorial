﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class CartModel
    {
        public DienThoaiModel DienThoai { get; set; }
        public int Quantity { get; set; }

    }
}
