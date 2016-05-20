using System;
using Case18221.Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Case18221.Handlers
{
    public class ProductCatalogueEventHandler : IHandleMessages<IProductCatalogueEvent>
    {
        private static readonly ILog Log = LogManager.GetLogger<ProductCatalogueEventHandler>();

        public void Handle(IProductCatalogueEvent message)
        {
            Log.Info($"Product Catalog Event Published: {message.ItemData}");
        }
    }
}
