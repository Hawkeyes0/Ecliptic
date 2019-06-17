using System;

namespace Ecliptic.Entities.Warehouse
{
    /// <summary>移动记录</summary>
    public class MoveLog : EntityBelongedBase
    {
        #region 单据信息
        public int OrderType { get; set; }

        public string OrderNum { get; set; }

        public int OrderLine { get; set; }

        public Guid OrderId { get; set; }

        public Guid OrderItemId { get; set; }
        #endregion

        #region 商品信息
        public Guid MatId { get; set; }

        public string MatName { get; set; }
        #endregion

        #region 移动信息
        public int Direction { get; set; }

        public string BatchNum { get; set; }

        public decimal Amount { get; set; }

        public Guid ShelfId { get; set; }
        #endregion
    }
}