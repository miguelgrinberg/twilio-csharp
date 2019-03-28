/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// QueueResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class QueueResource : Resource 
    {
        private static Request BuildFetchRequest(FetchQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        /// <param name="options"> Fetch Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Fetch(FetchQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        /// <param name="options"> Fetch Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> FetchAsync(FetchQueueOptions options, 
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchQueueOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> FetchAsync(string pathSid, 
                                                                                  string pathAccountSid = null, 
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchQueueOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        /// <param name="options"> Update Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Update(UpdateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        /// <param name="options"> Update Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> UpdateAsync(UpdateQueueOptions options, 
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to update </param>
        /// <param name="friendlyName"> A string to describe this resource </param>
        /// <param name="maxSize"> The max number of calls allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Update(string pathSid, 
                                           string pathAccountSid = null, 
                                           string friendlyName = null, 
                                           int? maxSize = null, 
                                           ITwilioRestClient client = null)
        {
            var options = new UpdateQueueOptions(pathSid){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, MaxSize = maxSize};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to update </param>
        /// <param name="friendlyName"> A string to describe this resource </param>
        /// <param name="maxSize"> The max number of calls allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> UpdateAsync(string pathSid, 
                                                                                   string pathAccountSid = null, 
                                                                                   string friendlyName = null, 
                                                                                   int? maxSize = null, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new UpdateQueueOptions(pathSid){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, MaxSize = maxSize};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Remove an empty queue
        /// </summary>
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static bool Delete(DeleteQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Remove an empty queue
        /// </summary>
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteQueueOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Remove an empty queue
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteQueueOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Remove an empty queue
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, 
                                                                          string pathAccountSid = null, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteQueueOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static ResourceSet<QueueResource> Read(ReadQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<QueueResource>.FromJson("queues", response.Content);
            return new ResourceSet<QueueResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<QueueResource>> ReadAsync(ReadQueueOptions options, 
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<QueueResource>.FromJson("queues", response.Content);
            return new ResourceSet<QueueResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The unique id of the Account responsible for creating this Call </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static ResourceSet<QueueResource> Read(string pathAccountSid = null, 
                                                      int? pageSize = null, 
                                                      long? limit = null, 
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadQueueOptions(){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The unique id of the Account responsible for creating this Call </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<QueueResource>> ReadAsync(string pathAccountSid = null, 
                                                                                              int? pageSize = null, 
                                                                                              long? limit = null, 
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadQueueOptions(){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<QueueResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<QueueResource> NextPage(Page<QueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<QueueResource> PreviousPage(Page<QueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }

        private static Request BuildCreateRequest(CreateQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a queue
        /// </summary>
        /// <param name="options"> Create Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Create(CreateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a queue
        /// </summary>
        /// <param name="options"> Create Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> CreateAsync(CreateQueueOptions options, 
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a queue
        /// </summary>
        /// <param name="friendlyName"> A string to describe this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="maxSize"> The max number of calls allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Create(string friendlyName, 
                                           string pathAccountSid = null, 
                                           int? maxSize = null, 
                                           ITwilioRestClient client = null)
        {
            var options = new CreateQueueOptions(friendlyName){PathAccountSid = pathAccountSid, MaxSize = maxSize};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a queue
        /// </summary>
        /// <param name="friendlyName"> A string to describe this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="maxSize"> The max number of calls allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> CreateAsync(string friendlyName, 
                                                                                   string pathAccountSid = null, 
                                                                                   int? maxSize = null, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new CreateQueueOptions(friendlyName){PathAccountSid = pathAccountSid, MaxSize = maxSize};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a QueueResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> QueueResource object represented by the provided JSON </returns> 
        public static QueueResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<QueueResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created this resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Average wait time of members in the queue
        /// </summary>
        [JsonProperty("average_wait_time")]
        public int? AverageWaitTime { get; private set; }
        /// <summary>
        /// The number of calls currently in the queue.
        /// </summary>
        [JsonProperty("current_size")]
        public int? CurrentSize { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A string that you assigned to describe this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The max number of calls allowed in the queue
        /// </summary>
        [JsonProperty("max_size")]
        public int? MaxSize { get; private set; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The URI of this resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// Queue Instance Subresources
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        private QueueResource()
        {

        }
    }

}