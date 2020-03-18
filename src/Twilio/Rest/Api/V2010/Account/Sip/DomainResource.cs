/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// DomainResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip
{

    public class DomainResource : Resource
    {
        private static Request BuildReadRequest(ReadDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static ResourceSet<DomainResource> Read(ReadDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<DomainResource>.FromJson("domains", response.Content);
            return new ResourceSet<DomainResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        /// <param name="options"> Read Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DomainResource>> ReadAsync(ReadDomainOptions options,
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DomainResource>.FromJson("domains", response.Content);
            return new ResourceSet<DomainResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static ResourceSet<DomainResource> Read(string pathAccountSid = null,
                                                       int? pageSize = null,
                                                       long? limit = null,
                                                       ITwilioRestClient client = null)
        {
            var options = new ReadDomainOptions(){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DomainResource>> ReadAsync(string pathAccountSid = null,
                                                                                               int? pageSize = null,
                                                                                               long? limit = null,
                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadDomainOptions(){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<DomainResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DomainResource>.FromJson("domains", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<DomainResource> NextPage(Page<DomainResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DomainResource>.FromJson("domains", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<DomainResource> PreviousPage(Page<DomainResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DomainResource>.FromJson("domains", response.Content);
        }

        private static Request BuildCreateRequest(CreateDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Domain
        /// </summary>
        /// <param name="options"> Create Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static DomainResource Create(CreateDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Domain
        /// </summary>
        /// <param name="options"> Create Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<DomainResource> CreateAsync(CreateDomainOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Domain
        /// </summary>
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="voiceUrl"> The URL we should call when receiving a call </param>
        /// <param name="voiceMethod"> The HTTP method to use with voice_url </param>
        /// <param name="voiceFallbackUrl"> The URL we should call when an error occurs in executing TwiML </param>
        /// <param name="voiceFallbackMethod"> The HTTP method to use with voice_fallback_url </param>
        /// <param name="voiceStatusCallbackUrl"> The URL that we should call to pass status updates </param>
        /// <param name="voiceStatusCallbackMethod"> The HTTP method we should use to call `voice_status_callback_url` </param>
        /// <param name="sipRegistration"> Whether SIP registration is allowed </param>
        /// <param name="emergencyCallingEnabled"> Whether emergency calling is enabled for the domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static DomainResource Create(string domainName,
                                            string pathAccountSid = null,
                                            string friendlyName = null,
                                            Uri voiceUrl = null,
                                            Twilio.Http.HttpMethod voiceMethod = null,
                                            Uri voiceFallbackUrl = null,
                                            Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                            Uri voiceStatusCallbackUrl = null,
                                            Twilio.Http.HttpMethod voiceStatusCallbackMethod = null,
                                            bool? sipRegistration = null,
                                            bool? emergencyCallingEnabled = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateDomainOptions(domainName){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceStatusCallbackMethod = voiceStatusCallbackMethod, SipRegistration = sipRegistration, EmergencyCallingEnabled = emergencyCallingEnabled};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Domain
        /// </summary>
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="voiceUrl"> The URL we should call when receiving a call </param>
        /// <param name="voiceMethod"> The HTTP method to use with voice_url </param>
        /// <param name="voiceFallbackUrl"> The URL we should call when an error occurs in executing TwiML </param>
        /// <param name="voiceFallbackMethod"> The HTTP method to use with voice_fallback_url </param>
        /// <param name="voiceStatusCallbackUrl"> The URL that we should call to pass status updates </param>
        /// <param name="voiceStatusCallbackMethod"> The HTTP method we should use to call `voice_status_callback_url` </param>
        /// <param name="sipRegistration"> Whether SIP registration is allowed </param>
        /// <param name="emergencyCallingEnabled"> Whether emergency calling is enabled for the domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<DomainResource> CreateAsync(string domainName,
                                                                                    string pathAccountSid = null,
                                                                                    string friendlyName = null,
                                                                                    Uri voiceUrl = null,
                                                                                    Twilio.Http.HttpMethod voiceMethod = null,
                                                                                    Uri voiceFallbackUrl = null,
                                                                                    Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                                                                    Uri voiceStatusCallbackUrl = null,
                                                                                    Twilio.Http.HttpMethod voiceStatusCallbackMethod = null,
                                                                                    bool? sipRegistration = null,
                                                                                    bool? emergencyCallingEnabled = null,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateDomainOptions(domainName){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceStatusCallbackMethod = voiceStatusCallbackMethod, SipRegistration = sipRegistration, EmergencyCallingEnabled = emergencyCallingEnabled};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        /// <param name="options"> Fetch Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static DomainResource Fetch(FetchDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        /// <param name="options"> Fetch Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<DomainResource> FetchAsync(FetchDomainOptions options,
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static DomainResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<DomainResource> FetchAsync(string pathSid,
                                                                                   string pathAccountSid = null,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        /// <param name="options"> Update Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static DomainResource Update(UpdateDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        /// <param name="options"> Update Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<DomainResource> UpdateAsync(UpdateDomainOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to update </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="voiceFallbackMethod"> The HTTP method used with voice_fallback_url </param>
        /// <param name="voiceFallbackUrl"> The URL we should call when an error occurs in executing TwiML </param>
        /// <param name="voiceMethod"> The HTTP method we should use with voice_url </param>
        /// <param name="voiceStatusCallbackMethod"> The HTTP method we should use to call voice_status_callback_url </param>
        /// <param name="voiceStatusCallbackUrl"> The URL that we should call to pass status updates </param>
        /// <param name="voiceUrl"> The URL we should call when receiving a call </param>
        /// <param name="sipRegistration"> Whether SIP registration is allowed </param>
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        /// <param name="emergencyCallingEnabled"> Whether emergency calling is enabled for the domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static DomainResource Update(string pathSid,
                                            string pathAccountSid = null,
                                            string friendlyName = null,
                                            Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                            Uri voiceFallbackUrl = null,
                                            Twilio.Http.HttpMethod voiceMethod = null,
                                            Twilio.Http.HttpMethod voiceStatusCallbackMethod = null,
                                            Uri voiceStatusCallbackUrl = null,
                                            Uri voiceUrl = null,
                                            bool? sipRegistration = null,
                                            string domainName = null,
                                            bool? emergencyCallingEnabled = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateDomainOptions(pathSid){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceStatusCallbackMethod = voiceStatusCallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceUrl = voiceUrl, SipRegistration = sipRegistration, DomainName = domainName, EmergencyCallingEnabled = emergencyCallingEnabled};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to update </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="voiceFallbackMethod"> The HTTP method used with voice_fallback_url </param>
        /// <param name="voiceFallbackUrl"> The URL we should call when an error occurs in executing TwiML </param>
        /// <param name="voiceMethod"> The HTTP method we should use with voice_url </param>
        /// <param name="voiceStatusCallbackMethod"> The HTTP method we should use to call voice_status_callback_url </param>
        /// <param name="voiceStatusCallbackUrl"> The URL that we should call to pass status updates </param>
        /// <param name="voiceUrl"> The URL we should call when receiving a call </param>
        /// <param name="sipRegistration"> Whether SIP registration is allowed </param>
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        /// <param name="emergencyCallingEnabled"> Whether emergency calling is enabled for the domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<DomainResource> UpdateAsync(string pathSid,
                                                                                    string pathAccountSid = null,
                                                                                    string friendlyName = null,
                                                                                    Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                                                                    Uri voiceFallbackUrl = null,
                                                                                    Twilio.Http.HttpMethod voiceMethod = null,
                                                                                    Twilio.Http.HttpMethod voiceStatusCallbackMethod = null,
                                                                                    Uri voiceStatusCallbackUrl = null,
                                                                                    Uri voiceUrl = null,
                                                                                    bool? sipRegistration = null,
                                                                                    string domainName = null,
                                                                                    bool? emergencyCallingEnabled = null,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateDomainOptions(pathSid){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceStatusCallbackMethod = voiceStatusCallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceUrl = voiceUrl, SipRegistration = sipRegistration, DomainName = domainName, EmergencyCallingEnabled = emergencyCallingEnabled};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete an instance of a Domain
        /// </summary>
        /// <param name="options"> Delete Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static bool Delete(DeleteDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete an instance of a Domain
        /// </summary>
        /// <param name="options"> Delete Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteDomainOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete an instance of a Domain
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete an instance of a Domain
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid,
                                                                          string pathAccountSid = null,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a DomainResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DomainResource object represented by the provided JSON </returns>
        public static DomainResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DomainResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The API version used to process the call
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The types of authentication mapped to the domain
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The unique address on Twilio to route SIP traffic
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The URI of the resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The HTTP method used with voice_fallback_url
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// The URL we call when an error occurs while executing TwiML
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// The HTTP method to use with voice_url
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// The HTTP method we use to call voice_status_callback_url
        /// </summary>
        [JsonProperty("voice_status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; private set; }
        /// <summary>
        /// The URL that we call with status updates
        /// </summary>
        [JsonProperty("voice_status_callback_url")]
        public Uri VoiceStatusCallbackUrl { get; private set; }
        /// <summary>
        /// The URL we call when receiving a call
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
        /// <summary>
        /// A list mapping resources associated with the SIP Domain resource
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
        /// <summary>
        /// Whether SIP registration is allowed
        /// </summary>
        [JsonProperty("sip_registration")]
        public bool? SipRegistration { get; private set; }
        /// <summary>
        /// Whether emergency calling is enabled for the domain.
        /// </summary>
        [JsonProperty("emergency_calling_enabled")]
        public bool? EmergencyCallingEnabled { get; private set; }

        private DomainResource()
        {

        }
    }

}