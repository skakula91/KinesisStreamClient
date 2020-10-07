using System;
using System.Collections.Generic;
using System.IO;
using Amazon;
using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace KinesisClient
{
    public class Actions
    {
        private static RegionEndpoint _regionEndpoint;
        private static AmazonKinesisClient _amazonKinesisClient;
        private static string _streamName;
        private static DateTime _timePeriod;

        public Actions(RegionEndpoint regionEndpoint, string streamName, DateTime timePeriod, string awsAccessKey, string awsSecretKey)
        {
            _streamName = streamName;
            _regionEndpoint = regionEndpoint;
            _timePeriod = timePeriod;
            _amazonKinesisClient = new AmazonKinesisClient(new BasicAWSCredentials(awsAccessKey, awsSecretKey),
                regionEndpoint);
        }

        public List<JObject> GetRecords(Filter filter, string additionalFilterStr)
        {
            List<JObject> jsonObjects = new List<JObject>();
            try
            {
                var response = _amazonKinesisClient.DescribeStream(new DescribeStreamRequest() { StreamName = _streamName });
                
                foreach (var shard in response.StreamDescription.Shards)
                {
                    var getRecordsRequest = new GetRecordsRequest();
                    getRecordsRequest.ShardIterator =
                        _amazonKinesisClient.GetShardIterator(new GetShardIteratorRequest()
                        {
                            StreamName = _streamName,
                            ShardIteratorType = ShardIteratorType.AT_TIMESTAMP,
                            ShardId = shard.ShardId,
                            Timestamp = _timePeriod
                        })
                            .ShardIterator;
                    getRecordsRequest.Limit = ConfigurationManager.AppSettings["FetchRecordsLimit"] != null? int.Parse(ConfigurationManager.AppSettings["FetchRecordsLimit"]) : 100;


                    GetRecordsResponse recordResponse;
                    dynamic additionalFilter = JObject.Parse(additionalFilterStr);
                    
                    do
                    {
                        recordResponse = _amazonKinesisClient.GetRecords(getRecordsRequest);
                        getRecordsRequest.ShardIterator = recordResponse.NextShardIterator;


                        
                        foreach (var record in recordResponse.Records)
                        {
                            var sr = new StreamReader(record.Data);
                            var myStr = sr.ReadToEnd();
                            dynamic jsonStr = JObject.Parse(myStr);

                            bool isObjectQualified = FilterJsonObjectArray(filter, additionalFilter, jsonStr);
                            if (isObjectQualified)
                            {
                                jsonObjects.Add(jsonStr);
                            }
                        }

                    } while (recordResponse.MillisBehindLatest > 0);


                    Console.Out.WriteLine("response = {0}", recordResponse);                  
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return jsonObjects;
        }

        private bool FilterJsonObjectArray(Filter filter, JObject additionalFilter, JObject jsonObject)
        {
            if (jsonObject.ContainsKey(nameof(filter.EventNotificationType)))
            {
                if (jsonObject[nameof(filter.EventNotificationType)].ToString() != filter.EventNotificationType.ToString())
                    return false;
            }
            if (filter.BusinessUnitId !=0 && jsonObject.ContainsKey(nameof(filter.BusinessUnitId)))
            {
                if (jsonObject[nameof(filter.BusinessUnitId)].ToString() != filter.BusinessUnitId.ToString())
                    return false;
            }
            if (filter.SubscriberId.HasValue && jsonObject.ContainsKey(nameof(filter.SubscriberId)))
            {
                if (jsonObject[nameof(filter.SubscriberId)].ToString() != filter.SubscriberId.ToString())
                    return false;
            }

            foreach (var additionalFil in additionalFilter)
            {
                if (jsonObject.ContainsKey(additionalFil.Key))
                {
                    if (jsonObject[additionalFil.Key].ToString() != additionalFil.Value.ToString())
                        return false;
                }            
            }

            return true;
        }
        //Just use for testing to put fake data into stream
        public void PutRecordsInStream()
        {
            try
            {
                var detail = new MyDetail()
                {
                    SubscriberId = 1234567,
                    FirstName = "test",
                    LastName = "record"
                };
                var myDetails = JsonConvert.SerializeObject(detail);

                var putRecordRequest = new PutRecordRequest()
                {
                    Data = Utility.GenerateStreamFromString(myDetails),
                    StreamName = _streamName,
                    PartitionKey = "partitionKey-" + detail.FirstName
                };

                var response = _amazonKinesisClient.PutRecord(putRecordRequest);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
    public class MyDetail
    {
        public long? SubscriberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
