using System;
using WinFormsClient.WWIServiceReference;

namespace WindowsFormsClient
{
    public static class ContextHelper
    {
        public static WideWorldImportersEntities context { get; } = new WideWorldImportersEntities(new Uri("http://localhost:60630/WWIDataService.svc"));
    }
}
