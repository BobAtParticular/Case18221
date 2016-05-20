using System;
using Case18221.Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Case18221.Handlers
{
    public class PublishChartProductMasterCommandHandler : IHandleMessages<PublishChartProductMasterCommand>
    {
        private static readonly ILog Log = LogManager.GetLogger<PublishChartProductMasterCommandHandler>();

        public IBus Bus { get; set; }

        public void Handle(PublishChartProductMasterCommand message)
        {
            Bus.Publish<ChartProductMasterPublishedEvent>(evt =>
            {
                evt.TeamId = message.TeamId;
                evt.ItemData = new Uri("http://localhost");
            });

            Log.Info($"Published ChartProductMasterPublishedEvent for {message.TeamId}");
        }
    }
}
