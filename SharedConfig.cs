using NServiceBus;

static class SharedConfig
{
    internal static BusConfiguration ConfigureBus(BusConfiguration configuration)
    {
        configuration.UseTransport<SqlServerTransport>()
            .ConnectionStringName("SqlServer");
        configuration.UsePersistence<InMemoryPersistence>();
        configuration.Conventions()
            .DefiningEventsAs(t => t.Name.EndsWith("Event"))
            .DefiningCommandsAs(t => t.Name.EndsWith("Command"));

        return configuration;
    }
}