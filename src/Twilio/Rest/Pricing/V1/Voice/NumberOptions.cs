/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Pricing.V1.Voice 
{

    /// <summary>
    /// FetchNumberOptions
    /// </summary>
    public class FetchNumberOptions : IOptions<NumberResource> 
    {
        /// <summary>
        /// The phone number to fetch
        /// </summary>
        public Types.PhoneNumber PathNumber { get; }

        /// <summary>
        /// Construct a new FetchNumberOptions
        /// </summary>
        /// <param name="pathNumber"> The phone number to fetch </param>
        public FetchNumberOptions(Types.PhoneNumber pathNumber)
        {
            PathNumber = pathNumber;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}