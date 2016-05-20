using System;

namespace Case18221.Messages
{
    public class ChartProductMasterPublishedEvent : IProductCatalogueEvent
    {
        public Guid TeamId { get; set; }
        public Uri ItemData { get; set; }
    }
}