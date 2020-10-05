using Appccelerate.EventBroker;
using System;

namespace AfvCompanion
{
    public abstract class EventBus : IDisposable, IEventBus
    {
        protected IEventBroker eventBroker;
        protected EventBus(IEventBroker broker)
        {
            eventBroker = broker;
        }
        public virtual void Register()
        {
            eventBroker.Register(this);
        }
        public virtual void Dispose()
        {
            eventBroker?.Unregister(this);
        }
    }
}
