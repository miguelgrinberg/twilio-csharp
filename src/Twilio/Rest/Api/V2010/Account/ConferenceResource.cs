/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// ConferenceResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class ConferenceResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Init = new StatusEnum("init");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
        }

        public sealed class UpdateStatusEnum : StringEnum 
        {
            private UpdateStatusEnum(string value) : base(value) {}
            public UpdateStatusEnum() {}
            public static implicit operator UpdateStatusEnum(string value)
            {
                return new UpdateStatusEnum(value);
            }

            public static readonly UpdateStatusEnum Completed = new UpdateStatusEnum("completed");
        }

        private static Request BuildFetchRequest(FetchConferenceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        /// <param name="options"> Fetch Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Fetch(FetchConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        /// <param name="options"> Fetch Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> FetchAsync(FetchConferenceOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchConferenceOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of a conference
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> FetchAsync(string pathSid, 
                                                                                       string pathAccountSid = null, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchConferenceOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadConferenceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ResourceSet<ConferenceResource> Read(ReadConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ConferenceResource>.FromJson("conferences", response.Content);
            return new ResourceSet<ConferenceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceResource>> ReadAsync(ReadConferenceOptions options, 
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ConferenceResource>.FromJson("conferences", response.Content);
            return new ResourceSet<ConferenceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to read </param>
        /// <param name="dateCreatedBefore"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateCreated"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateCreatedAfter"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateUpdatedBefore"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateUpdated"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateUpdatedAfter"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="friendlyName"> The string that identifies the Conference resources to read </param>
        /// <param name="status"> The status of the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ResourceSet<ConferenceResource> Read(string pathAccountSid = null, 
                                                           DateTime? dateCreatedBefore = null, 
                                                           DateTime? dateCreated = null, 
                                                           DateTime? dateCreatedAfter = null, 
                                                           DateTime? dateUpdatedBefore = null, 
                                                           DateTime? dateUpdated = null, 
                                                           DateTime? dateUpdatedAfter = null, 
                                                           string friendlyName = null, 
                                                           ConferenceResource.StatusEnum status = null, 
                                                           int? pageSize = null, 
                                                           long? limit = null, 
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadConferenceOptions(){PathAccountSid = pathAccountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, DateUpdatedBefore = dateUpdatedBefore, DateUpdated = dateUpdated, DateUpdatedAfter = dateUpdatedAfter, FriendlyName = friendlyName, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of conferences belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to read </param>
        /// <param name="dateCreatedBefore"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateCreated"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateCreatedAfter"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateUpdatedBefore"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateUpdated"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="dateUpdatedAfter"> The `YYYY-MM-DD` value of the resources to read </param>
        /// <param name="friendlyName"> The string that identifies the Conference resources to read </param>
        /// <param name="status"> The status of the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceResource>> ReadAsync(string pathAccountSid = null, 
                                                                                                   DateTime? dateCreatedBefore = null, 
                                                                                                   DateTime? dateCreated = null, 
                                                                                                   DateTime? dateCreatedAfter = null, 
                                                                                                   DateTime? dateUpdatedBefore = null, 
                                                                                                   DateTime? dateUpdated = null, 
                                                                                                   DateTime? dateUpdatedAfter = null, 
                                                                                                   string friendlyName = null, 
                                                                                                   ConferenceResource.StatusEnum status = null, 
                                                                                                   int? pageSize = null, 
                                                                                                   long? limit = null, 
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadConferenceOptions(){PathAccountSid = pathAccountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, DateUpdatedBefore = dateUpdatedBefore, DateUpdated = dateUpdated, DateUpdatedAfter = dateUpdatedAfter, FriendlyName = friendlyName, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ConferenceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ConferenceResource>.FromJson("conferences", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ConferenceResource> NextPage(Page<ConferenceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ConferenceResource>.FromJson("conferences", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ConferenceResource> PreviousPage(Page<ConferenceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ConferenceResource>.FromJson("conferences", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateConferenceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Update(UpdateConferenceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Conference parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> UpdateAsync(UpdateConferenceOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to update </param>
        /// <param name="status"> The new status of the resource </param>
        /// <param name="announceUrl"> The URL we should call to announce something into the conference </param>
        /// <param name="announceMethod"> he HTTP method used to call announce_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conference </returns> 
        public static ConferenceResource Update(string pathSid, 
                                                string pathAccountSid = null, 
                                                ConferenceResource.UpdateStatusEnum status = null, 
                                                Uri announceUrl = null, 
                                                Twilio.Http.HttpMethod announceMethod = null, 
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateConferenceOptions(pathSid){PathAccountSid = pathAccountSid, Status = status, AnnounceUrl = announceUrl, AnnounceMethod = announceMethod};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource(s) to update </param>
        /// <param name="status"> The new status of the resource </param>
        /// <param name="announceUrl"> The URL we should call to announce something into the conference </param>
        /// <param name="announceMethod"> he HTTP method used to call announce_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conference </returns> 
        public static async System.Threading.Tasks.Task<ConferenceResource> UpdateAsync(string pathSid, 
                                                                                        string pathAccountSid = null, 
                                                                                        ConferenceResource.UpdateStatusEnum status = null, 
                                                                                        Uri announceUrl = null, 
                                                                                        Twilio.Http.HttpMethod announceMethod = null, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateConferenceOptions(pathSid){PathAccountSid = pathAccountSid, Status = status, AnnounceUrl = announceUrl, AnnounceMethod = announceMethod};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ConferenceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConferenceResource object represented by the provided JSON </returns> 
        public static ConferenceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ConferenceResource>(json);
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
        /// The API version used to create this conference
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// A string that you assigned to describe this conference room
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A string that represents the Twilio Region where the conference was mixed
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status of this conference
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The URI of this resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// A list of related resources identified by their relative URIs
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        private ConferenceResource()
        {

        }
    }

}