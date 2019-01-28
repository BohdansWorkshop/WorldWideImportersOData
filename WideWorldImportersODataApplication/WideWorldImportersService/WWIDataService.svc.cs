using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Web;
using NLog;
using WideWorldImportersService.Authentication;

namespace WideWorldImportersService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class WWIDataService : EntityFrameworkDataService<WideWorldImportersEntities>
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.UseVerboseErrors = true;
            config.SetEntitySetAccessRule("Customers", EntitySetRights.All);
            config.SetEntitySetAccessRule("Orders", EntitySetRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        [QueryInterceptor("Customers")]
        public Expression<Func<Customer, bool>> CustomersFilter()
        {
            if (HttpContext.Current.Request.IsAuthenticated)
            {
                logger.Info($"Request to dbo.Customers from Application:{HttpContext.Current.User}, User:{CurrentUser.currentUser}");
                return (Customer b) => true;
            }
            throw new DataServiceException(401, "not authorized");
        }

        [QueryInterceptor("Orders")]
        public Expression<Func<Order, bool>> OrdersFilter()
        {
            if (HttpContext.Current.Request.IsAuthenticated)
            {
                logger.Info($"Request to dbo.Orders from Application:{HttpContext.Current.User}, User:{CurrentUser.currentUser}");
                return (Order o) => true;
            }
            else
            {
                throw new DataServiceException(401, "not authorized");
            }
        }
    }
}
