using System;

namespace Ecliptic.Entities.Warehouse
{
    /// <summary>库存信息</summary>
    public class Storage : EntityBelongedBase
    {
        #region 商品信息
        public Guid MatId { get; set; }

        public string MatName { get; set; }
        #endregion

        #region 位置信息
        public Guid ShelfId { get; set; }

        public string ShelfName { get; set; }
        #endregion

        #region 批次信息
        public Guid SupplierId { get; set; }

        public string BatchNum { get; set; }

        public decimal Amount { get; set; }

        public decimal MaxAmount { get; set; }

        public decimal Cost { get; set; }

        public DateTime ProdDate { get; set; }

        public DateTime ExpireDate { get; set; }
        #endregion

        #region 单据信息
        public int OrderType { get; set; }

        public string OrderNum { get; set; }

        public int OrderLine { get; set; }

        public Guid OrderId { get; set; }

        public Guid OrderItemId { get; set; }
        #endregion
    }
}
