using System;
using WinFormsClient.Interfaces;

namespace WinFormsClient.Managers
{
    public class CustomersManager : IEditable
    {
        //TODO Add\Delete\Edit operations for Customers.

        public void Add(CallbackRefresh refresh, IFillable control)
        {
            throw new NotImplementedException();
        }

        public void Delete(CallbackRefresh refresh, int id, IFillable control)
        {
            throw new NotImplementedException();
        }

        public void Edit(CallbackRefresh refresh, int id, IFillable control)
        {
            throw new NotImplementedException();
        }
    }

}
