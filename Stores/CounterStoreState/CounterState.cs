using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Stores.CounterStoreState
{
    public interface ICounterState
    {
        int Counter { get; }
        string Message { get; }
        void UpdateCounter(ComponentBase source, int counter);
        event Action<ComponentBase, string> StateChanged;
    }
    public class CounterState: ICounterState
    {
        public int Counter { get; private set; } = 1;
        public string Message { get; private set; } = "First Message";

        public void UpdateCounter(ComponentBase Source, int counter)
        {
            Counter = counter;
            NotifyStateChanged(Source, "Counter");
        }
        public void UpdateMessage(ComponentBase Source, string message)
        {
            Message = message;
            NotifyStateChanged(Source, "Message");
        }
        public event Action<ComponentBase, string> StateChanged;
        private void NotifyStateChanged(ComponentBase Source, string Property) 
            => StateChanged?.Invoke(Source, Property);
    }
}
