using System;

namespace Ecliptic.Entities.Sale
{
    public class SaleItem : OrderItem<Guid>
    {
        //
    }

    public class SalePayment
    {
        //
    }

    public class Sale : Order<Guid, SaleItem>
    {
        //
    }
}