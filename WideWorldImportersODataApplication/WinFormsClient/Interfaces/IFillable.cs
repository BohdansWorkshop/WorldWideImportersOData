using System.Collections.Generic;
using System.Linq;
using WinFormsClient.WWIServiceReference;

namespace WinFormsClient.Interfaces
{
    public interface IFillable
    {
        void FillControl(Dictionary<string, int> columns, string[][] elements);
        void FillOrdersControl(IQueryable<Order> elements1, IQueryable<Order> elements2);
    }

    public delegate void CallbackRefresh(IFillable control);
}