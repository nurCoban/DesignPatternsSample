using System;

namespace Mediator
{
    public class ComboBoxColleague : Colleague
    {
        public ComboBoxColleague(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleEvent(string message)
        {
            Console.WriteLine("Combobox handle event: " + message);
        }
    }
}
