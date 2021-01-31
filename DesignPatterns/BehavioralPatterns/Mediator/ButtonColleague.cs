using System;

namespace Mediator
{
    public class ButtonColleague : Colleague
    {
        public ButtonColleague(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleEvent(string message)
        {
            Console.WriteLine("Button handle event: " + message);
        }
    }
}
