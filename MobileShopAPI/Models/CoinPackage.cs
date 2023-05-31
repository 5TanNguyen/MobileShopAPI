﻿using System;
using System.Collections.Generic;

namespace MobileShopAPI.Models
{
    public partial class CoinPackage
    {
        public CoinPackage()
        {
            Transactions = new HashSet<Transaction>();
        }

        public string Id { get; set; } = null!;
        public string PackageName { get; set; } = null!;
        public long PackageValue { get; set; }
        /// <summary>
        /// vnđ,...v.v
        /// </summary>
        public string ValueUnit { get; set; } = null!;
        public long? CoinAmount { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
