namespace WinFormsClient.Interfaces
{
    public interface IEditable
    {
        void Delete(CallbackRefresh refresh, int id, IFillable control);
        void Edit(CallbackRefresh refresh, int id, IFillable control);
        void Add(CallbackRefresh refresh, IFillable control);
    }
}