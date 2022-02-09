using System;
using System.Threading.Tasks;

namespace WindowsSerivces.Waiter
{
    public interface IWaiterUi : IDisposable
    {
        event Func<object, EventArgs, Task> OnAutoClose;
        Task HideAsync();
        void Show();
    }
}
