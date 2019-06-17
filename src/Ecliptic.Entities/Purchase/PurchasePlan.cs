using System;

namespace Ecliptic.Entities.Purchase
{
    public class PurchasePlanItem : OrderItem<Guid>
    {
        //
    }

    public class PurchasePlan : Order<Guid, PurchasePlanItem>
    {
        //
    }
}