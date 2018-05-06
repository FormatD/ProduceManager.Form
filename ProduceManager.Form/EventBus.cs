using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraTab;
using ProduceManager.Forms.UserControls;
using DevExpress.XtraPrinting.Preview;
using ProduceManager.Forms.Utils;
using System.IO;
using DevExpress.XtraReports.UI;
using ProduceManager.Forms.Messages;

namespace ProduceManager.Forms
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