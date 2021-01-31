using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class Mediator : IMediator
    {
        private List<Colleague> Colleagues;

        public Mediator()
        {
            this.Colleagues = new List<Colleague>();
        }
        public void AddColleague(Colleague colleague)
        {
            this.Colleagues.Add(colleague);
        }

        public void Send(string eventMessage, Colleague originator)
        {
            this.Colleagues
                .ForEach(c =>
                {
                    if (c != originator)
                    {
                        c.HandleEvent(eventMessage);
                    }
                });
        }
    }
}
