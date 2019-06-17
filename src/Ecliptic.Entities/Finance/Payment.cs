using System;

namespace Ecliptic.Entities.Finance
{
    public class PaymentItem : BasedOrderItem<Guid>
    {
        public decimal Unsettled { get; set; }

        public decimal Setteled { get; set; }
    }

    /// <summary>
    /// 应收应付账款，与采购、采购退货、配送、配送退回业务相关
    /// </summary>
    public class Payment : BasedOrder<Guid, PaymentItem>
    {
        /// <summary>
        /// 支付对象类型。1：供应商。2：连锁门店
        /// </summary>
        public int PayForType { get; set; }

        /// <summary>
        /// 支付对象ID
        /// </summary>
        public Guid PayForId { get; set; }

        /// <summary>
        /// 支付对象编码
        /// </summary>
        public string PayForCode { get; set; }

        /// <summary>
        /// 支付对象名称
        /// </summary>
        public string PayForName { get; set; }

        /// <summary>
        /// 未结款金额
        /// </summary>
        public decimal Unsettled { get; set; }

        /// <summary>
        /// 已结款金额
        /// </summary>
        public decimal Setteled { get; set; }
    }
}