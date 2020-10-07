using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Amazon;
using ContentDirect.Framework.Eventing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KinesisClient
{
    public static class Utility
    {
        public static List<EventNotificationEntity> EventNotificationEntites = null;
        public static MemoryStream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static string PrettyJson(List<JObject> jObjectList)
        {
            try
            {
                var str = @"{""Event Notifications"":"+ JsonConvert.SerializeObject(jObjectList) + "}";
                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(str), Formatting.Indented);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string CopyClipBoard(string jsonStr)
        {
            try
            {
                return JsonConvert.SerializeObject(jsonStr, Formatting.Indented);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static List<EventNotificationEntity> GetAllEntities()
        {
            if (EventNotificationEntites != null)
                return EventNotificationEntites;

            EventNotificationEntites = new List<EventNotificationEntity>();
            Assembly myAssembly = Assembly.LoadFrom(@"ContentDirect.CoreService.dll");

            //Gets all referenced Types of an assembly that implement a specific interface
            List<Type> otherAssemblyTypes = myAssembly.GetTypes().Where(y => typeof(IDomainNotificationEvent).IsAssignableFrom(y) && !y.IsAbstract && !y.IsInterface).ToList();
            foreach (var t in otherAssemblyTypes)
            {
                object obj = System.Runtime.Serialization.FormatterServices.GetUninitializedObject(t);
                var s = (IDomainNotificationEvent)obj;
                EventNotificationEntites.Add(new EventNotificationEntity()
                {
                    EventNotificationType = (int)s.EventNotificationType,
                    EventNotificationName = t.Name ,
                    Payload = JsonConvert.SerializeObject(obj)

                });
            }
            EventNotificationEntites.Sort((x,y) => x.EventNotificationType.CompareTo(y.EventNotificationType));
            return EventNotificationEntites;
        }

        public static RegionEndpoint GetRegion(string value)
        {
            switch (value)
            {
               case "USEast1":
                   return RegionEndpoint.USEast1;
               case "USEast1Regional":
                   return RegionEndpoint.USEast1;
                case "USEast2":
                    return RegionEndpoint.USEast2;
                case "USWest1":
                    return RegionEndpoint.USWest1;
                case "USWest2":
                    return RegionEndpoint.USWest2;
                case "EUNorth1":
                    return RegionEndpoint.EUNorth1;
               case "APSoutheast1":
                   return RegionEndpoint.APNortheast1;
               case "EUWest1":
                   return RegionEndpoint.EUWest1;
               case "EUWest2":
                   return RegionEndpoint.EUWest2;
               case "EUWest3":
                   return RegionEndpoint.EUWest3;
               case "EUCentral1":
                   return RegionEndpoint.EUCentral1;
               case "APEast1":
                   return RegionEndpoint.APEast1;
               case "APNortheast1":
                   return RegionEndpoint.APNortheast1;
               case "APNortheast2":
                   return RegionEndpoint.APNortheast2;
               case "APNortheast3":
                   return RegionEndpoint.APNortheast3;
               case "APSouth1":
                   return RegionEndpoint.APSouth1;
               case "APSoutheast2":
                   return RegionEndpoint.APSoutheast2;
               case "SAEast1":
                   return RegionEndpoint.SAEast1;
               case "USGovCloudEast1":
                   return RegionEndpoint.USGovCloudEast1;
               case "USGovCloudWest1":
                   return RegionEndpoint.USGovCloudWest1;
               case "CNNorth1":
                   return RegionEndpoint.CNNorth1;
               case "CNNorthWest1":
                   return RegionEndpoint.CNNorthWest1;    
               case "CACentral1":
                   return RegionEndpoint.CACentral1;
               case "MESouth1":
                   return RegionEndpoint.MESouth1;
                default:
                    return RegionEndpoint.USEast1;
            }
        }

        public static DateTime GetStreamFromPeriod(string value)
        {
            switch (value)
            {
                case "LastFiveMinutes":
                    return DateTime.Now.AddMinutes(-5);
                case "LastFifteenMinutes":
                    return DateTime.Now.AddMinutes(-15);
                case "LastHour":
                    return DateTime.Now.AddHours(-1);
                case "LastThreeHours":
                    return DateTime.Now.AddHours(-3);
                case "LastTwelveHours":
                    return DateTime.Now.AddHours(-12);
                case "LastTwentyFourHours":
                    return DateTime.Now.AddDays(-1);
                case "LastFortyEightHours":
                    return DateTime.Now.AddDays(-2);
                default:
                    return DateTime.Now.AddHours(-1);
            }
        }

    }
}
