﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingSimulator.Classes
{
    public class Order
    {
        public int id { get; set; }
        public int ownerID { get; set; }

        public int itemID { get; set; }
        public virtual Item Item { get; set; }
        public float price { get; set; }
        public int count { get; set; }

        public long expireTime { get; set; }
    }
}
