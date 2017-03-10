﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSaleX.Models
{
    public class order
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// 客戶代碼
        /// </summary>
        public string CustID { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustName { get; set; }

        /// <summary>
        /// 訂單日期
        /// </summary>
        public DateTime? OrderDate { get; set; }
    }
}