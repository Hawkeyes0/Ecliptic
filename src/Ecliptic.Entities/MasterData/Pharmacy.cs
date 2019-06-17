using System;

namespace Ecliptic.Entities.MasterData
{
    public class Pharmacy : EntityBase
    {
        public int PharmacyType { get; set; }

        public Guid ParentId { get; set; }

        public string PharmacyCode { get; set; }

        public bool IsLock { get; set; }

        public string CreditNum { get; set; }

        public string RegistAddress { get; set; }
    }
}