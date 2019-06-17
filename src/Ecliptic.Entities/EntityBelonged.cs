namespace Ecliptic.Entities
{
    public abstract class EntityBelonged<TKey> : Entity<TKey>
    {
        public TKey PharmacyId { get; set; }
    }
}