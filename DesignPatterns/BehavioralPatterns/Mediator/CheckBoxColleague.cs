using System;

namespace Mediator
{
    public class CheckBoxColleague : Colleague
    {
        public CheckBoxColleague(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleEvent(string message)
        {
            Console.WriteLine("Checkbox handle event: " + message);
        }
    }
}
