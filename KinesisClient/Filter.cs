using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinesisClient
{
    public class Filter
    {
        public int EventNotificationType { get; set; }
        public int? SubscriberId { get; set; }
        public int BusinessUnitId { get; set; }
    }

    public class EventNotificationEntity
    {
        public int EventNotificationType { get; set; }
        public string EventNotificationName { get; set; }
        public string Payload { get; set; }
    } 
}
