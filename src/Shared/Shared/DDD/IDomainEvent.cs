
using MediatR;

namespace Shared.DDD
{
    public interface IDomainEvent : INotification
    {
        Guid Event => Guid.NewGuid();
        public DateTime OccurredOn => DateTime.UtcNow;
        public string EventType => GetType().AssemblyQualifiedName ?? GetType().FullName ?? GetType().Name;
    }
}
