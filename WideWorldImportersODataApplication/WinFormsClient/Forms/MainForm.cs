using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsClient;
using WinFormsClient.Interfaces;
using WinFormsClient.Managers;
using WinFormsClient.WWIServiceReference;
using WindowsFormsClient.Helper;

namespace WinFormsClient.Forms
{
    public partial class MainForm : Form
    {
        private ucShowAllElements _showAllCustomers;
        private ucShowAllElements _showAllOrders;
        public MainForm()
        {
            InitializeComponent();
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var customersManager = new CustomersManager();
            _showAllCustomers = new ucShowAllElements(customersManager, LoadCustomers);
            tabCustomers.Controls.Add(_showAllCustomers);

            var ordersManagers = new OrdersManager();
            _showAllOrders = new ucShowAllElements(ordersManagers, LoadOrders);
            tabOrders.Controls.Add(_showAllOrders);
        }
        private void LoadCustomers(IFillable currentControl)
        {
            var context = ContextHelper.context;
            context.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(OnSendingRequest);
            var customers = context.Customers.ToArray();
            Dictionary<string, int> columns = new Dictionary<string, int>
            {
                {"ID", 50},
                {"Name", 190},
                {"Phone", 100},
                {"Opened", 100},
                {"WebSite", 100},
                {"Payment Days", 30},
                {"PostalAddress1", 100},
                {"PostalAddress2", 100},
                {"DeliveryAddress1", 80},
                {"DeliveryAddress2", 140},
                {"Fax", 100},
                {"Valid to", 150}
            };

            var items = customers?.Select(x => new[]
            {
                x.CustomerID.ToString(),
                x.CustomerName,
                x.PhoneNumber.ToString(),
                x.AccountOpenedDate.ToString(),
                x.WebsiteURL.ToString(),
                x.PaymentDays.ToString(),
                x.PostalAddressLine1.ToString(),
                x.PostalAddressLine2.ToString(),
                x.DeliveryAddressLine1.ToString(),
                x.DeliveryAddressLine2.ToString(),
                x.FaxNumber.ToString(),
                x.ValidTo.ToString(),

            }).ToArray();
            currentControl.FillControl(columns, items);
        }

        private void LoadOrders(IFillable currentControl)
        {

            var context = ContextHelper.context;
            context.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(OnSendingRequest);
            IQueryable<Order> orders1 = from o in context.Orders
                                        where o.OrderID < 35000
                                        select o;


            IQueryable<Order> orders2 = from o in context.Orders
                                        where o.OrderID > 35000
                                        select o;
            currentControl.FillOrdersControl(orders1, orders2);
        }

        private void ExportToCSVItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create)))
                {
                    StringBuilder sb = new StringBuilder();
                    if (tabMain.SelectedTab.Name == tabCustomers.Name)
                    {
                        var customersContext = ContextHelper.context;
                        customersContext.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(OnSendingRequest);

                        sb.AppendLine(
                            "CustomerId, CustomerName, BillToCustomerId, CustomerCategoryId, PrimaryContactPersonID, AlternateContactPersonID, DeliveryMethodID, DeliveryCityID, PostalCityID, CreditLimit, " +
                            "AccountOpenedDate, StandardDiscountPercentage, IsStatementSent, IsOnCreditHold, PaymentDays, Phone, Fax, DeliveryRun, Position, Website, DeliveryAddressLine1, DeliveryAddressLine2, " +
                            "DeliveryPostalCode, PostalAddressLine1, PostalAddressLine2, PostalPostalCode, LasEditedBy, ValidFrom, ValidTo");

                        foreach (var item in customersContext.Customers)
                        {
                            sb.AppendLine(
                                $"{item.CustomerID},{item.CustomerName},{item.BillToCustomerID},{item.CustomerCategoryID},{item.BuyingGroupID}, {item.PrimaryContactPersonID}, {item.AlternateContactPersonID}" +
                                $"{item.DeliveryMethodID}, {item.DeliveryCityID}, {item.PostalCityID}, {item.CreditLimit}, {item.AccountOpenedDate}, {item.StandardDiscountPercentage},{item.IsStatementSent}" +
                                $"{item.IsOnCreditHold}, {item.PaymentDays}, {item.PhoneNumber}, {item.FaxNumber}, {item.DeliveryRun}, {item.RunPosition}, {item.WebsiteURL}, {item.DeliveryAddressLine1}" +
                                $"{item.DeliveryAddressLine2}, {item.DeliveryPostalCode}, {item.PostalAddressLine1}, {item.PostalAddressLine2}, {item.PostalPostalCode}, {item.LastEditedBy}, {item.ValidFrom}" +
                                $"{item.ValidTo}");
                        }
                        sw.WriteLine(sb.ToString());
                        sw.Close();
                    }
                    if (tabMain.SelectedTab.Name == tabOrders.Name)
                    {
                        var ordersContext = ContextHelper.context;
                        ordersContext.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(OnSendingRequest);
                        IQueryable<Order> orders1 = from o in ordersContext.Orders
                                                    where o.OrderID < 35000
                                                    select o;

                        sb.AppendLine("OrderID, CustomerID, SalesPersonID, PickedByPersonID, ContactPersonID, BackorderedOrderID, Date, ExpectedDeliveryDate, CustomerPurchaseOrderNumber, IsUndersupplyBackordered, " +
                                      "Comments, DeliveryInstructions, InternalComments, PickingcompletedWhen, LastEditedBy, LastEditedWhen");

                        foreach (var item in orders1)
                        {
                            sb.AppendLine(
                                $"{item.OrderID},{item.CustomerID}, {item.SalespersonPersonID}, {item.PickedByPersonID}, {item.ContactPersonID}, {item.BackorderOrderID}, {item.OrderDate}, {item.ExpectedDeliveryDate}" +
                                $"{item.CustomerPurchaseOrderNumber}, {item.IsUndersupplyBackordered}, {item.Comments}, {item.DeliveryInstructions}, {item.InternalComments}, {item.PickingCompletedWhen}, {item.LastEditedBy}" +
                                $"{item.LastEditedWhen}");
                        }
                        sw.WriteLine(sb.ToString());

                        IQueryable<Order> orders2 = from o in ordersContext.Orders
                            where o.OrderID > 35000
                            select o;
       
                        foreach (var item in orders2)
                        {
                            sb.AppendLine(
                                $"{item.OrderID},{item.CustomerID}, {item.SalespersonPersonID}, {item.PickedByPersonID}, {item.ContactPersonID}, {item.BackorderOrderID}, {item.OrderDate}, {item.ExpectedDeliveryDate}" +
                                $"{item.CustomerPurchaseOrderNumber}, {item.IsUndersupplyBackordered}, {item.Comments}, {item.DeliveryInstructions}, {item.InternalComments}, {item.PickingCompletedWhen}, {item.LastEditedBy}" +
                                $"{item.LastEditedWhen}");
                        }
                        sw.WriteLine(sb.ToString());
                        sw.Close();
                    }

                }
                MessageBox.Show("Saved");
            }

        }

        static void OnSendingRequest(object sender, SendingRequest2EventArgs e)
        {
            e.RequestMessage.SetHeader("Authorization", CurrentUserHelper.currentUserName + " " + CurrentUserHelper.currentUserPassword);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
