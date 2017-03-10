﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSaleX.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void Insertorder()
        {

        }
        /// <summary>
        /// 刪除訂單by id
        /// </summary>
        public void DeleteorderById()
        {

        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void Updateorder()
        {

        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.order GetorderById(string id)
        {
            Models.order result = new order();
            result.CustID = "GSS";
            result.CustName = "瑞陽資訊";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.order> Getorders()
        {
            return new List<order>();
        }
    }
}