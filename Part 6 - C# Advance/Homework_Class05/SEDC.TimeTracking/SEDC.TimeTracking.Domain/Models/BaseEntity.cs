using SEDC.TimeTracking.Domain.Interfaces;

namespace SEDC.TimeTracking.Domain.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
