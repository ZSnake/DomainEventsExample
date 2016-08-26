using Ironhide.Domain.DomainEventHandlers;
using Ironhide.Domain.DomainEvents;
using Machine.Specifications;

namespace Ironhide.Domain.Specs
{
    public class after_adding_two_plus_two_add_three_plus_three
    {
        private Establish context =
            () =>
            {
                _domainEvent = new TwoPlusTwoAdded();
                _domainEventHandler = new ThreePlusThreeAdder(_domainEvent);
            };

        private Because of =
            () => _result = _domainEventHandler.Handle(_domainEvent);

        private It should_add_three_plus_three =
            () => { _result.ShouldEqual(6); };

        private static TwoPlusTwoAdded _domainEvent;
        private static ThreePlusThreeAdder _domainEventHandler;
        private static int _result;
    }
}