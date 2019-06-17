using System;

namespace Ecliptic.Entities.Finance
{
    /// <summary>
    /// 毛利记录
    /// </summary>
    public class ProfitLog : EntityBelongedBase
    {
        #region 单据信息

        public int InOrderType { get; set; }

        public string InOrderNum { get; set; }

        public int InOrderLine { get; set; }

        public Guid InOrderId { get; set; }

        public Guid InOrderItemId { get; set; }

        public int OutOrderType { get; set; }

        public string OutOrderNum { get; set; }

        public int OutOrderLine { get; set; }

        public Guid OutOrderId { get; set; }

        public Guid OutOrderItemId { get; set; }

        #endregion

        #region 商品信息
        
        public Guid MatId { get; set; }

        public string MatName { get; set; }
        
        #endregion

        #region 批次信息
        
        public string BatchNum { get; set; }

        public decimal Amount { get; set; }

        #endregion

        #region 价格信息
            
        public decimal Cost { get; set; }

        public decimal Price { get; set; }

        /// <summary>
        /// Value Range: [0, )
        /// </summary>
        public decimal InTax { get; set; }

        /// <summary>
        /// Value Range: [0, )
        /// </summary>
        public decimal OutTax { get; set; }

        /// <summary>
        /// <code>NotaxCost</code> = <code>Cost</code> / (1 + <code>InTax</code>)
        /// </summary>
        public decimal NotaxCost { get; set; }

        /// <summary>
        /// <code>NotaxPrice</code> = <code>Price</code> / (1 + <code>OutTax</code>)
        /// </summary>
        public decimal NotaxPrice { get; set; }

        public decimal TotalCost { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal TotalNotaxCost { get; set; }

        public decimal TotalNotaxPrice { get; set; }

        /// <summary>
        /// Profit = TotalPrice - TotalCost
        /// </summary>
        public decimal Profit { get; set; }

        public decimal NotaxProfit { get; set; }

        /// <summary>
        /// ProfitRate = Profit / TotalPrice
        /// </summary>
        public decimal ProfitRate { get; set; }

        public decimal NotaxProfitRate { get; set; }

        #endregion
    }
}