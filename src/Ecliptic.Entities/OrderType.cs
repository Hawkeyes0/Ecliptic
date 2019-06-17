namespace Ecliptic.Entities
{
    public static class OrderType
    {
        #region 采购
        public const int PurchasePlan = 1,
        PurchaseOrder = 2,
        PurchaseArrival = 3,
        PurchaseCheck = 4,
        PurchaseIn = 5,
        PurchaseReturn = 6,
        PurchaseOut = 7,
        #endregion

        #region 销售
        SaleOut = 11,
        SaleIn = 12,
        #endregion

        #region 配送
        DistrRequest = 21,
        DistrPicks = 22,
        DistrOut = 23,
        DistrNotice = 24,
        DistrArrival = 25,
        DistrCheck = 26,
        DistrIn = 27,
        #endregion

        #region 配送退回
        DistrReturn = 31,
        DistrReturnOut = 32,
        DistrReturnNotice = 33,
        DistrReturnArrival = 34,
        DistrReturnCheck = 35,
        DistrReturnIn = 36,
        #endregion
        
        #region 其他单据
        OtherIn = 41,
        OtherOut = 42,
        Split = 43,
        Move = 44,
        Inventory = 45,
        Fill = 46,
        Empty = 47,
        #endregion

        #region 特殊单据
        DistrSwitch = 101,
        StoreInRequest = 102
        #endregion
        ;
    }
}