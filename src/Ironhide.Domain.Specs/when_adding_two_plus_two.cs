using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BlingBag;
using Ironhide.Domain;
using Ironhide.Domain.CommandHandlers;
using Ironhide.Domain.Commands;
using Ironhide.Domain.DomainEvents;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;


namespace Ironhide.Domain.Specs
{
    public class when_adding_two_plus_two
    {
        private Establish context =
            () =>
            {
                _addTwoPlusTwoCommand = new AddTwoPlusTwo();
                _handler = new AddTwoPlusTwoCommandHandler(_addTwoPlusTwoCommand);

                _expectedEvent = new TwoPlusTwoAdded();
                _handler.NotifyObservers += x => _eventRaised = x;
            };

        private Because of =
            () => _handler.Handle();

        private It should_raise_the_two_plus_two_added_domain_event=
            () => { _eventRaised.ShouldBeLike(_expectedEvent); };

        private static AddTwoPlusTwo _addTwoPlusTwoCommand;
        private static AddTwoPlusTwoCommandHandler _handler;
        private static TwoPlusTwoAdded _expectedEvent;
        private static object _eventRaised;
    }
}
