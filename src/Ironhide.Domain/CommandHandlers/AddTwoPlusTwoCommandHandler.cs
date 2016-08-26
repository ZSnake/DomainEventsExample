using System;
using AcklenAvenue.Commands;
using Ironhide.Domain.Commands;
using Ironhide.Domain.DomainEvents;

namespace Ironhide.Domain.CommandHandlers
{
    public class AddTwoPlusTwoCommandHandler
    {
        public readonly AddTwoPlusTwo AddTwoPlusTwoCommand;
        public event DomainEvent NotifyObservers;


        public AddTwoPlusTwoCommandHandler(AddTwoPlusTwo addTwoPlusTwoCommand)
        {
            AddTwoPlusTwoCommand = addTwoPlusTwoCommand;
        }


        public void Handle()
        {
            int result = 2 + 2;
            Console.WriteLine("2 + 2 has been added: " + result);
            NotifyObservers(new TwoPlusTwoAdded());
        }
    }
}