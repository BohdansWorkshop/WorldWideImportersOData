using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormsClient.Interfaces;

namespace WinFormsClient.Forms
{
    public partial class ucShowAllElements : UserControl, IFillable
    {
        private readonly IEditable _manager;
        private readonly CallbackRefresh _refreshCallback;

        public ucShowAllElements()
        {
            InitializeComponent();
        }

        public ucShowAllElements(IEditable manager, CallbackRefresh refreshCallBack)
        {
            InitializeComponent();
            _manager = manager;
            _refreshCallback = refreshCallBack;
            _refreshCallback.Invoke(this);
            this.Dock = DockStyle.Fill;
        }
        public void FillControl(Dictionary<string, int> columns, string[][] elements)
        {
            lvContent.Columns.Clear();
            foreach (var columnHeader in columns)
            {
                lvContent.Columns.Add(columnHeader.Key, columnHeader.Value);
            }
            lvContent.Items.Clear();
            foreach (var element in elements)
            {
                lvContent.Items.Add(new ListViewItem(element));
            }
        }
        public void FillOrdersControl(IQueryable<WinFormsClient.WWIServiceReference.Order> elements1, IQueryable<WinFormsClient.WWIServiceReference.Order> elements2)
        {
            lvContent.Columns.Clear();
            lvContent.Items.Clear();
            lvContent.Columns.Add("ID", 50);
            lvContent.Columns.Add("Date", 110);
            lvContent.Columns.Add("Customer", 80);
            lvContent.Columns.Add("ExpectedDate", 150);
            lvContent.Columns.Add("DeliveryInstructions", 80);
            lvContent.Columns.Add("CustomerPurchaseOrderNumber", 100);
            lvContent.Columns.Add("Comments", 50);
            lvContent.Columns.Add("InternalComments", 80);
            lvContent.Columns.Add("ContactPersonID", 90);
            lvContent.Columns.Add("PickingCompletedDate", 150);
            lvContent.Columns.Add("PickedByPersonID", 70);
            lvContent.Columns.Add("LastEdited", 150);
            lvContent.Columns.Add("LastEditedBy", 80);


            foreach (var element in elements1)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = element.OrderID.ToString();
                item.SubItems.Add(element.OrderDate.ToString());
                item.SubItems.Add(element.CustomerID.ToString());
                item.SubItems.Add(element.ExpectedDeliveryDate.ToString());
                item.SubItems.Add(element.DeliveryInstructions);
                item.SubItems.Add(element.CustomerPurchaseOrderNumber);
                item.SubItems.Add(element.Comments);
                item.SubItems.Add(element.InternalComments);
                item.SubItems.Add(element.ContactPersonID.ToString());
                item.SubItems.Add(element.PickingCompletedWhen.ToString());
                item.SubItems.Add(element.PickedByPersonID.ToString());
                item.SubItems.Add(element.LastEditedWhen.ToString());
                item.SubItems.Add(element.LastEditedBy.ToString());
                lvContent.Items.Add(item);
            }

            foreach (var element in elements2)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = element.OrderID.ToString();
                item.SubItems.Add(element.OrderDate.ToString());
                item.SubItems.Add(element.CustomerID.ToString());
                item.SubItems.Add(element.ExpectedDeliveryDate.ToString());
                item.SubItems.Add(element.DeliveryInstructions);
                item.SubItems.Add(element.CustomerPurchaseOrderNumber);
                item.SubItems.Add(element.Comments);
                item.SubItems.Add(element.InternalComments);
                item.SubItems.Add(element.ContactPersonID.ToString());
                item.SubItems.Add(element.PickingCompletedWhen.ToString());
                item.SubItems.Add(element.PickedByPersonID.ToString());
                item.SubItems.Add(element.LastEditedWhen.ToString());
                item.SubItems.Add(element.LastEditedBy.ToString());
                lvContent.Items.Add(item);
            }

        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                //case nameof(tsbAdd):
                //    _manager.Add(_refreshCallback, this);
                //    break;
                //case nameof(tsbEdit):
                //    if (lvContent.SelectedItems.Count == 0)
                //        break;
                //    _manager.Edit(_refreshCallback, Guid.Parse(lvContent.SelectedItems[0].SubItems[0].Text), this);
                //    break;
                //case nameof(tsbRemove):
                //    Delete();
                //    break;
                //case nameof(tsbRefresh):
                //    _refreshCallback.Invoke(this);
                //    break;
            }
        }
    }
}
