namespace Ecliptic.Entities
{
    public static class OrderStatus
    {
        public const int
            Drift = 11,
            Commited = 12,
            Canceled = 19,
            CheckPass = 21,
            CheckRefuse = 29,
            Incomplete = 31,
            Completed = 41,
            Closed = 49;
    }
}