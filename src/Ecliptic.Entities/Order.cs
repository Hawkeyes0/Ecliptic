using System;
using System.Collections.Generic;

namespace Ecliptic.Entities
{
    public abstract class Order<TKey, TItem> : EntityBelonged<TKey>
    {
        public string OrderNum { get; set; }

        public DateTime OrderDate { get; set; }

        public int Status { get; set; }
        
        public List<TItem> Items { get; set; }
    }

    public abstract class OrderItem<TKey> : EntityBelonged<TKey>
    {
        public TKey HeadId { get; set; }

        public string OrderNum { get; set; }

        public TKey MatId { get; set; }

        public string MatName { get; set; }

        public decimal Amount { get; set; }

        public decimal Price { get; set; }

        public decimal Taxrate { get; set; }

        public decimal NotaxPrice { get; set; }

        public decimal TaxValue { get; set; } 
    }

    public abstract class BasedOrder<TKey, TItem> : Order<TKey, TItem>
    {
        public int SourceOrderType { get; set; }

        public TKey SourceOrderId { get; set; }

        public string SourceOrderNum { get; set; }

        public int BaseOrderType { get; set; }

        public TKey BaseOrderId { get; set; }

        public string BaseOrderNum { get; set; }
    }

    public abstract class BasedOrderItem<TKey> : OrderItem<TKey>
    {
        public int SourceOrderType { get; set; }

        public TKey SourceOrderId { get; set; }

        public string SourceOrderNum { get; set; }

        public int SourceOrderLine { get; set; }

        public int BaseOrderType { get; set; }

        public TKey BaseOrderId { get; set; }

        public string BaseOrderNum { get; set; }
        
        public int BaseOrderLine { get; set; }
    }
}