using System;
using System.Collections.Generic;

namespace ProduceManager.Core
{

    public class EventBus
    {
        public static EventBus Instanse { get; } = new EventBus();

        private EventBus()
        {
        }

        public void SendMessage<TMessage>(TMessage message)
        {
            InnerEventBus<TMessage>.Instanse.SendMessage(message);
        }

        public IDisposable Subscrible<TMessage>(Action<TMessage> callback)
        {
            return InnerEventBus<TMessage>.Instanse.Subscrible(callback);
        }

        private class InnerEventBus<TMessage>
        {
            private List<Subscriber> _subscribers = new List<Subscriber>();

            public static InnerEventBus<TMessage> Instanse { get; } = new InnerEventBus<TMessage>();

            public void SendMessage(TMessage message)
            {
                foreach (var item in _subscribers)
                {
                    item.Action(message);
                }
            }

            public IDisposable Subscrible(Action<TMessage> callback)
            {
                var subscriber = new Subscriber(callback, _subscribers);
                _subscribers.Add(subscriber);
                return subscriber;
            }

            public class Subscriber : IDisposable
            {
                public List<Subscriber> _allSubscribers;

                public Action<TMessage> Action { get; set; }

                public Subscriber(Action<TMessage> action, List<Subscriber> allSubscribers)
                {
                    Action = action;
                    _allSubscribers = allSubscribers;
                }

                public void Dispose()
                {
                    _allSubscribers.Remove(this);
                }
            }
        }
    }
}