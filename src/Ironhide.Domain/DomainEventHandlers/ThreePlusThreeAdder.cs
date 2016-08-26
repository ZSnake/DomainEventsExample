using Ironhide.Domain.DomainEvents;

namespace Ironhide.Domain.DomainEventHandlers
{
    public class ThreePlusThreeAdder 
    {
        private readonly TwoPlusTwoAdded _domainEvent;

        public ThreePlusThreeAdder(TwoPlusTwoAdded domainEvent)
        {
            _domainEvent = domainEvent;
        }

        public int Handle(TwoPlusTwoAdded @event)
        {
            return 3+3;
        }
    }
}