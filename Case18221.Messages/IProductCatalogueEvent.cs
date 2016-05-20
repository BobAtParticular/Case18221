using System;

namespace Case18221.Messages
{
    public interface IProductCatalogueEvent
    {
        Uri ItemData { get; }
    }
}
