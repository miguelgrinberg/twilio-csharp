/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// LocalResource
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

namespace Twilio.Rest.Api.V2010.Account.IncomingPhoneNumber
{

    public class LocalResource : Resource
    {
        public sealed class AddressRequirementEnum : StringEnum
        {
            private AddressRequirementEnum(string value) : base(value) {}
            public AddressRequirementEnum() {}
            public static implicit operator AddressRequirementEnum(string value)
            {
                return new AddressRequirementEnum(value);
            }

            public static readonly AddressRequirementEnum None = new AddressRequirementEnum("none");
            public static readonly AddressRequirementEnum Any = new AddressRequirementEnum("any");
            public static readonly AddressRequirementEnum Local = new AddressRequirementEnum("local");
            public static readonly AddressRequirementEnum Foreign = new AddressRequirementEnum("foreign");
        }

        public sealed class EmergencyStatusEnum : StringEnum
        {
            private EmergencyStatusEnum(string value) : base(value) {}
            public EmergencyStatusEnum() {}
            public static implicit operator EmergencyStatusEnum(string value)
            {
                return new EmergencyStatusEnum(value);
            }

            public static readonly EmergencyStatusEnum Active = new EmergencyStatusEnum("Active");
            public static readonly EmergencyStatusEnum Inactive = new EmergencyStatusEnum("Inactive");
        }

        public sealed class VoiceReceiveModeEnum : StringEnum
        {
            private VoiceReceiveModeEnum(string value) : base(value) {}
            public VoiceReceiveModeEnum() {}
            public static implicit operator VoiceReceiveModeEnum(string value)
            {
                return new VoiceReceiveModeEnum(value);
            }

            public static readonly VoiceReceiveModeEnum Voice = new VoiceReceiveModeEnum("voice");
            public static readonly VoiceReceiveModeEnum Fax = new VoiceReceiveModeEnum("fax");
        }

        private static Request BuildReadRequest(ReadLocalOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/Local.json",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static ResourceSet<LocalResource> Read(ReadLocalOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
            return new ResourceSet<LocalResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<LocalResource>> ReadAsync(ReadLocalOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
            return new ResourceSet<LocalResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="beta"> Whether to include new phone numbers </param>
        /// <param name="friendlyName"> A string that identifies the resources to read </param>
        /// <param name="phoneNumber"> The phone numbers of the resources to read </param>
        /// <param name="origin"> Include phone numbers based on their origin. By default, phone numbers of all origin are
        ///              included. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static ResourceSet<LocalResource> Read(string pathAccountSid = null,
                                                      bool? beta = null,
                                                      string friendlyName = null,
                                                      Types.PhoneNumber phoneNumber = null,
                                                      string origin = null,
                                                      int? pageSize = null,
                                                      long? limit = null,
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadLocalOptions(){PathAccountSid = pathAccountSid, Beta = beta, FriendlyName = friendlyName, PhoneNumber = phoneNumber, Origin = origin, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="beta"> Whether to include new phone numbers </param>
        /// <param name="friendlyName"> A string that identifies the resources to read </param>
        /// <param name="phoneNumber"> The phone numbers of the resources to read </param>
        /// <param name="origin"> Include phone numbers based on their origin. By default, phone numbers of all origin are
        ///              included. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<LocalResource>> ReadAsync(string pathAccountSid = null,
                                                                                              bool? beta = null,
                                                                                              string friendlyName = null,
                                                                                              Types.PhoneNumber phoneNumber = null,
                                                                                              string origin = null,
                                                                                              int? pageSize = null,
                                                                                              long? limit = null,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadLocalOptions(){PathAccountSid = pathAccountSid, Beta = beta, FriendlyName = friendlyName, PhoneNumber = phoneNumber, Origin = origin, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<LocalResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<LocalResource> NextPage(Page<LocalResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<LocalResource> PreviousPage(Page<LocalResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
        }

        private static Request BuildCreateRequest(CreateLocalOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/Local.json",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static LocalResource Create(CreateLocalOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<LocalResource> CreateAsync(CreateLocalOptions options,
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
        /// <param name="phoneNumber"> The phone number to purchase in E.164 format </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="apiVersion"> The API version to use for incoming calls made to the new phone number </param>
        /// <param name="friendlyName"> A string to describe the new phone number </param>
        /// <param name="smsApplicationSid"> The SID of the application to handle SMS messages </param>
        /// <param name="smsFallbackMethod"> The HTTP method we use to call status_callback </param>
        /// <param name="smsFallbackUrl"> The URL we call when an error occurs while executing TwiML </param>
        /// <param name="smsMethod"> The HTTP method to use with sms url </param>
        /// <param name="smsUrl"> The URL we should call when the new phone number receives an incoming SMS message </param>
        /// <param name="statusCallback"> The URL we should call to send status information to your application </param>
        /// <param name="statusCallbackMethod"> HTTP method we should use to call status_callback </param>
        /// <param name="voiceApplicationSid"> The SID of the application to handle the new phone number </param>
        /// <param name="voiceCallerIdLookup"> Whether to lookup the caller's name </param>
        /// <param name="voiceFallbackMethod"> The HTTP method used with voice_fallback_url </param>
        /// <param name="voiceFallbackUrl"> The URL we will call when an error occurs in TwiML </param>
        /// <param name="voiceMethod"> The HTTP method used with the voice_url </param>
        /// <param name="voiceUrl"> The URL we should call when the phone number receives a call </param>
        /// <param name="identitySid"> The SID of the Identity resource to associate with the new phone number </param>
        /// <param name="addressSid"> The SID of the Address resource associated with the phone number </param>
        /// <param name="emergencyStatus"> Displays if emergency calling is enabled for this number. </param>
        /// <param name="emergencyAddressSid"> The emergency address configuration to use for emergency calling </param>
        /// <param name="trunkSid"> SID of the trunk to handle calls to the new phone number </param>
        /// <param name="voiceReceiveMode"> Incoming call type: fax or voice </param>
        /// <param name="bundleSid"> The SID of the Bundle resource associated with number </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static LocalResource Create(Types.PhoneNumber phoneNumber,
                                           string pathAccountSid = null,
                                           string apiVersion = null,
                                           string friendlyName = null,
                                           string smsApplicationSid = null,
                                           Twilio.Http.HttpMethod smsFallbackMethod = null,
                                           Uri smsFallbackUrl = null,
                                           Twilio.Http.HttpMethod smsMethod = null,
                                           Uri smsUrl = null,
                                           Uri statusCallback = null,
                                           Twilio.Http.HttpMethod statusCallbackMethod = null,
                                           string voiceApplicationSid = null,
                                           bool? voiceCallerIdLookup = null,
                                           Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                           Uri voiceFallbackUrl = null,
                                           Twilio.Http.HttpMethod voiceMethod = null,
                                           Uri voiceUrl = null,
                                           string identitySid = null,
                                           string addressSid = null,
                                           LocalResource.EmergencyStatusEnum emergencyStatus = null,
                                           string emergencyAddressSid = null,
                                           string trunkSid = null,
                                           LocalResource.VoiceReceiveModeEnum voiceReceiveMode = null,
                                           string bundleSid = null,
                                           ITwilioRestClient client = null)
        {
            var options = new CreateLocalOptions(phoneNumber){PathAccountSid = pathAccountSid, ApiVersion = apiVersion, FriendlyName = friendlyName, SmsApplicationSid = smsApplicationSid, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceApplicationSid = voiceApplicationSid, VoiceCallerIdLookup = voiceCallerIdLookup, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl, IdentitySid = identitySid, AddressSid = addressSid, EmergencyStatus = emergencyStatus, EmergencyAddressSid = emergencyAddressSid, TrunkSid = trunkSid, VoiceReceiveMode = voiceReceiveMode, BundleSid = bundleSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="phoneNumber"> The phone number to purchase in E.164 format </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="apiVersion"> The API version to use for incoming calls made to the new phone number </param>
        /// <param name="friendlyName"> A string to describe the new phone number </param>
        /// <param name="smsApplicationSid"> The SID of the application to handle SMS messages </param>
        /// <param name="smsFallbackMethod"> The HTTP method we use to call status_callback </param>
        /// <param name="smsFallbackUrl"> The URL we call when an error occurs while executing TwiML </param>
        /// <param name="smsMethod"> The HTTP method to use with sms url </param>
        /// <param name="smsUrl"> The URL we should call when the new phone number receives an incoming SMS message </param>
        /// <param name="statusCallback"> The URL we should call to send status information to your application </param>
        /// <param name="statusCallbackMethod"> HTTP method we should use to call status_callback </param>
        /// <param name="voiceApplicationSid"> The SID of the application to handle the new phone number </param>
        /// <param name="voiceCallerIdLookup"> Whether to lookup the caller's name </param>
        /// <param name="voiceFallbackMethod"> The HTTP method used with voice_fallback_url </param>
        /// <param name="voiceFallbackUrl"> The URL we will call when an error occurs in TwiML </param>
        /// <param name="voiceMethod"> The HTTP method used with the voice_url </param>
        /// <param name="voiceUrl"> The URL we should call when the phone number receives a call </param>
        /// <param name="identitySid"> The SID of the Identity resource to associate with the new phone number </param>
        /// <param name="addressSid"> The SID of the Address resource associated with the phone number </param>
        /// <param name="emergencyStatus"> Displays if emergency calling is enabled for this number. </param>
        /// <param name="emergencyAddressSid"> The emergency address configuration to use for emergency calling </param>
        /// <param name="trunkSid"> SID of the trunk to handle calls to the new phone number </param>
        /// <param name="voiceReceiveMode"> Incoming call type: fax or voice </param>
        /// <param name="bundleSid"> The SID of the Bundle resource associated with number </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<LocalResource> CreateAsync(Types.PhoneNumber phoneNumber,
                                                                                   string pathAccountSid = null,
                                                                                   string apiVersion = null,
                                                                                   string friendlyName = null,
                                                                                   string smsApplicationSid = null,
                                                                                   Twilio.Http.HttpMethod smsFallbackMethod = null,
                                                                                   Uri smsFallbackUrl = null,
                                                                                   Twilio.Http.HttpMethod smsMethod = null,
                                                                                   Uri smsUrl = null,
                                                                                   Uri statusCallback = null,
                                                                                   Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                   string voiceApplicationSid = null,
                                                                                   bool? voiceCallerIdLookup = null,
                                                                                   Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                                                                   Uri voiceFallbackUrl = null,
                                                                                   Twilio.Http.HttpMethod voiceMethod = null,
                                                                                   Uri voiceUrl = null,
                                                                                   string identitySid = null,
                                                                                   string addressSid = null,
                                                                                   LocalResource.EmergencyStatusEnum emergencyStatus = null,
                                                                                   string emergencyAddressSid = null,
                                                                                   string trunkSid = null,
                                                                                   LocalResource.VoiceReceiveModeEnum voiceReceiveMode = null,
                                                                                   string bundleSid = null,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new CreateLocalOptions(phoneNumber){PathAccountSid = pathAccountSid, ApiVersion = apiVersion, FriendlyName = friendlyName, SmsApplicationSid = smsApplicationSid, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceApplicationSid = voiceApplicationSid, VoiceCallerIdLookup = voiceCallerIdLookup, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl, IdentitySid = identitySid, AddressSid = addressSid, EmergencyStatus = emergencyStatus, EmergencyAddressSid = emergencyAddressSid, TrunkSid = trunkSid, VoiceReceiveMode = voiceReceiveMode, BundleSid = bundleSid};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a LocalResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> LocalResource object represented by the provided JSON </returns>
        public static LocalResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<LocalResource>(json);
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
        /// The SID of the Address resource associated with the phone number
        /// </summary>
        [JsonProperty("address_sid")]
        public string AddressSid { get; private set; }
        /// <summary>
        /// Whether the phone number requires an Address registered with Twilio.
        /// </summary>
        [JsonProperty("address_requirements")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LocalResource.AddressRequirementEnum AddressRequirements { get; private set; }
        /// <summary>
        /// The API version used to start a new TwiML session
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// Whether the phone number is new to the Twilio platform
        /// </summary>
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }
        /// <summary>
        /// Indicate if a phone can receive calls or messages
        /// </summary>
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }
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
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The SID of the Identity resource associated with number
        /// </summary>
        [JsonProperty("identity_sid")]
        public string IdentitySid { get; private set; }
        /// <summary>
        /// The phone number in E.164 format
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// The phone number's origin. Can be twilio or hosted.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Application resource to handle SMS messages
        /// </summary>
        [JsonProperty("sms_application_sid")]
        public string SmsApplicationSid { get; private set; }
        /// <summary>
        /// The HTTP method used with sms_fallback_url
        /// </summary>
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }
        /// <summary>
        /// The URL that we call when an error occurs while retrieving or executing the TwiML
        /// </summary>
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }
        /// <summary>
        /// The HTTP method to use with sms_url
        /// </summary>
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }
        /// <summary>
        /// The URL we call when the phone number receives an incoming SMS message
        /// </summary>
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }
        /// <summary>
        /// The URL to send status information to your application
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The HTTP method we use to call status_callback
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The SID of the Trunk that handles calls to the phone number
        /// </summary>
        [JsonProperty("trunk_sid")]
        public string TrunkSid { get; private set; }
        /// <summary>
        /// The URI of the resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The voice_receive_mode
        /// </summary>
        [JsonProperty("voice_receive_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LocalResource.VoiceReceiveModeEnum VoiceReceiveMode { get; private set; }
        /// <summary>
        /// The SID of the application that handles calls to the phone number
        /// </summary>
        [JsonProperty("voice_application_sid")]
        public string VoiceApplicationSid { get; private set; }
        /// <summary>
        /// Whether to lookup the caller's name
        /// </summary>
        [JsonProperty("voice_caller_id_lookup")]
        public bool? VoiceCallerIdLookup { get; private set; }
        /// <summary>
        /// The HTTP method used with voice_fallback_url
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// The URL we call when an error occurs in TwiML
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// The HTTP method used with the voice_url
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// The URL we call when this phone number receives a call
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
        /// <summary>
        /// Displays if emergency calling is enabled for this number.
        /// </summary>
        [JsonProperty("emergency_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LocalResource.EmergencyStatusEnum EmergencyStatus { get; private set; }
        /// <summary>
        /// The emergency address configuration to use for emergency calling
        /// </summary>
        [JsonProperty("emergency_address_sid")]
        public string EmergencyAddressSid { get; private set; }
        /// <summary>
        /// The SID of the Bundle resource associated with number
        /// </summary>
        [JsonProperty("bundle_sid")]
        public string BundleSid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }

        private LocalResource()
        {

        }
    }

}