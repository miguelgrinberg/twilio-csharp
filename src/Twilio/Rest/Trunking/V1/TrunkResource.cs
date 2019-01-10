/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// TrunkResource
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

namespace Twilio.Rest.Trunking.V1 
{

    public class TrunkResource : Resource 
    {
        public sealed class RecordingSettingEnum : StringEnum 
        {
            private RecordingSettingEnum(string value) : base(value) {}
            public RecordingSettingEnum() {}
            public static implicit operator RecordingSettingEnum(string value)
            {
                return new RecordingSettingEnum(value);
            }

            public static readonly RecordingSettingEnum DoNotRecord = new RecordingSettingEnum("do-not-record");
            public static readonly RecordingSettingEnum RecordFromRinging = new RecordingSettingEnum("record-from-ringing");
            public static readonly RecordingSettingEnum RecordFromAnswer = new RecordingSettingEnum("record-from-answer");
        }

        private static Request BuildFetchRequest(FetchTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Fetch(FetchTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> FetchAsync(FetchTrunkOptions options, 
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the SIP Trunk in Twilio. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTrunkOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the SIP Trunk in Twilio. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> FetchAsync(string pathSid, 
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchTrunkOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static bool Delete(DeleteTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTrunkOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the SIP Trunk in Twilio. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTrunkOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the SIP Trunk in Twilio. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTrunkOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                "/v1/Trunks",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Create(CreateTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> CreateAsync(CreateTrunkOptions options, 
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A human-readable name for the Trunk. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. </param>
        /// <param name="disasterRecoveryUrl"> The HTTP URL that Twilio will request if an error occurs while sending SIP
        ///                           traffic towards your configured Origination URL. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        ///                              </param>
        /// <param name="recording"> The recording settings for this trunk. </param>
        /// <param name="secure"> The Secure Trunking  settings for this trunk. </param>
        /// <param name="cnamLookupEnabled"> The Caller ID Name (CNAM) lookup setting for this trunk. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Create(string friendlyName = null, 
                                           string domainName = null, 
                                           Uri disasterRecoveryUrl = null, 
                                           Twilio.Http.HttpMethod disasterRecoveryMethod = null, 
                                           TrunkResource.RecordingSettingEnum recording = null, 
                                           bool? secure = null, 
                                           bool? cnamLookupEnabled = null, 
                                           ITwilioRestClient client = null)
        {
            var options = new CreateTrunkOptions(){FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure, CnamLookupEnabled = cnamLookupEnabled};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A human-readable name for the Trunk. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. </param>
        /// <param name="disasterRecoveryUrl"> The HTTP URL that Twilio will request if an error occurs while sending SIP
        ///                           traffic towards your configured Origination URL. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        ///                              </param>
        /// <param name="recording"> The recording settings for this trunk. </param>
        /// <param name="secure"> The Secure Trunking  settings for this trunk. </param>
        /// <param name="cnamLookupEnabled"> The Caller ID Name (CNAM) lookup setting for this trunk. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> CreateAsync(string friendlyName = null, 
                                                                                   string domainName = null, 
                                                                                   Uri disasterRecoveryUrl = null, 
                                                                                   Twilio.Http.HttpMethod disasterRecoveryMethod = null, 
                                                                                   TrunkResource.RecordingSettingEnum recording = null, 
                                                                                   bool? secure = null, 
                                                                                   bool? cnamLookupEnabled = null, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new CreateTrunkOptions(){FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure, CnamLookupEnabled = cnamLookupEnabled};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                "/v1/Trunks",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static ResourceSet<TrunkResource> Read(ReadTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<TrunkResource>.FromJson("trunks", response.Content);
            return new ResourceSet<TrunkResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TrunkResource>> ReadAsync(ReadTrunkOptions options, 
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TrunkResource>.FromJson("trunks", response.Content);
            return new ResourceSet<TrunkResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static ResourceSet<TrunkResource> Read(int? pageSize = null, 
                                                      long? limit = null, 
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadTrunkOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TrunkResource>> ReadAsync(int? pageSize = null, 
                                                                                              long? limit = null, 
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadTrunkOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<TrunkResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<TrunkResource> NextPage(Page<TrunkResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Trunking,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<TrunkResource> PreviousPage(Page<TrunkResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Trunking,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Update(UpdateTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> UpdateAsync(UpdateTrunkOptions options, 
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
        /// <param name="pathSid"> A 34 character string that uniquely identifies the SIP Trunk in Twilio. </param>
        /// <param name="friendlyName"> A human-readable name for the Trunk. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. </param>
        /// <param name="disasterRecoveryUrl"> The HTTP URL that Twilio will request if an error occurs while sending SIP
        ///                           traffic towards your configured Origination URL. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        ///                              </param>
        /// <param name="recording"> The recording settings for this trunk. </param>
        /// <param name="secure"> The Secure Trunking  settings for this trunk. </param>
        /// <param name="cnamLookupEnabled"> The Caller ID Name (CNAM) lookup setting for this trunk. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Update(string pathSid, 
                                           string friendlyName = null, 
                                           string domainName = null, 
                                           Uri disasterRecoveryUrl = null, 
                                           Twilio.Http.HttpMethod disasterRecoveryMethod = null, 
                                           TrunkResource.RecordingSettingEnum recording = null, 
                                           bool? secure = null, 
                                           bool? cnamLookupEnabled = null, 
                                           ITwilioRestClient client = null)
        {
            var options = new UpdateTrunkOptions(pathSid){FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure, CnamLookupEnabled = cnamLookupEnabled};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the SIP Trunk in Twilio. </param>
        /// <param name="friendlyName"> A human-readable name for the Trunk. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. </param>
        /// <param name="disasterRecoveryUrl"> The HTTP URL that Twilio will request if an error occurs while sending SIP
        ///                           traffic towards your configured Origination URL. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        ///                              </param>
        /// <param name="recording"> The recording settings for this trunk. </param>
        /// <param name="secure"> The Secure Trunking  settings for this trunk. </param>
        /// <param name="cnamLookupEnabled"> The Caller ID Name (CNAM) lookup setting for this trunk. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> UpdateAsync(string pathSid, 
                                                                                   string friendlyName = null, 
                                                                                   string domainName = null, 
                                                                                   Uri disasterRecoveryUrl = null, 
                                                                                   Twilio.Http.HttpMethod disasterRecoveryMethod = null, 
                                                                                   TrunkResource.RecordingSettingEnum recording = null, 
                                                                                   bool? secure = null, 
                                                                                   bool? cnamLookupEnabled = null, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new UpdateTrunkOptions(pathSid){FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure, CnamLookupEnabled = cnamLookupEnabled};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TrunkResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TrunkResource object represented by the provided JSON </returns> 
        public static TrunkResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TrunkResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account that owns this Trunk.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique address you reserve on Twilio to which you route your SIP traffic.
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the DisasterRecoveryUrl.
        /// </summary>
        [JsonProperty("disaster_recovery_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; private set; }
        /// <summary>
        /// The HTTP URL that Twilio will request if an error occurs while sending SIP traffic towards your configured Origination URL.
        /// </summary>
        [JsonProperty("disaster_recovery_url")]
        public Uri DisasterRecoveryUrl { get; private set; }
        /// <summary>
        /// A human-readable name for the Trunk.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The Secure Trunking  settings for this trunk.
        /// </summary>
        [JsonProperty("secure")]
        public bool? Secure { get; private set; }
        /// <summary>
        /// The recording settings for this trunk.
        /// </summary>
        [JsonProperty("recording")]
        public object Recording { get; private set; }
        /// <summary>
        /// The Caller ID Name (CNAM) lookup setting for this trunk.
        /// </summary>
        [JsonProperty("cnam_lookup_enabled")]
        public bool? CnamLookupEnabled { get; private set; }
        /// <summary>
        /// The types of authentication you have mapped to your domain.
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; private set; }
        /// <summary>
        /// The auth_type_set
        /// </summary>
        [JsonProperty("auth_type_set")]
        public List<string> AuthTypeSet { get; private set; }
        /// <summary>
        /// The date this Activity was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Activity was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A 34 character string that uniquely identifies the SIP Trunk in Twilio.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The URL for this resource, relative to https://trunking.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private TrunkResource()
        {

        }
    }

}