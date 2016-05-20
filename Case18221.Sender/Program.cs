using System;
using Case18221.Messages;
using NServiceBus;

namespace Case18221.Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Case18221.Sender";
            var configuration = new BusConfiguration();
            configuration.EndpointName("Case18221.Sender");

            SharedConfig.ConfigureBus(configuration);

            using (var bus = Bus.CreateSendOnly(configuration))
            {
                do
                {
                    Console.WriteLine("Press Escape to quit or Enter to send");
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key != ConsoleKey.Enter) continue;

                    var teamId = Guid.NewGuid();

                    bus.Send("Case18221.Host", new PublishChartProductMasterCommand
                    {
                        TeamId = teamId
                    });

                    Console.WriteLine($"Sent {teamId}");
                } while (true);
            }
        }
    }
}
