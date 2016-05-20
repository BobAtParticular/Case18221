
namespace Case18221.Host
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            SharedConfig.ConfigureBus(configuration);
        }
    }
}
