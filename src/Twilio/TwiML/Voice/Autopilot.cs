/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Autopilot TwiML Noun
    /// </summary>
    public class Autopilot : TwiML 
    {
        /// <summary>
        /// Autopilot assistant sid or unique name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create a new Autopilot
        /// </summary>
        /// <param name="name"> Autopilot assistant sid or unique name, the body of the TwiML Element. </param>
        public Autopilot(string name = null) : base("Autopilot")
        {
            this.Name = name;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Name != null ? this.Name : string.Empty;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Autopilot Append(TwiML childElem)
        {
            return (Autopilot) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Autopilot SetOption(string key, object value)
        {
            return (Autopilot) base.SetOption(key, value);
        }
    }

}