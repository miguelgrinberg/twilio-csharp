/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Understand.Assistant.Task 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchFieldOptions
    /// </summary>
    public class FetchFieldOptions : IOptions<FieldResource> 
    {
        /// <summary>
        /// The unique ID of the Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The unique ID of the Task associated with this Field.
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFieldOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task associated with this Field. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchFieldOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            PathSid = pathSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadFieldOptions
    /// </summary>
    public class ReadFieldOptions : ReadOptions<FieldResource> 
    {
        /// <summary>
        /// The unique ID of the Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The unique ID of the Task associated with this Field.
        /// </summary>
        public string PathTaskSid { get; }

        /// <summary>
        /// Construct a new ReadFieldOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task associated with this Field. </param>
        public ReadFieldOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateFieldOptions
    /// </summary>
    public class CreateFieldOptions : IOptions<FieldResource> 
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The unique ID of the Task associated with this Field.
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The unique name or sid of the FieldType. It can be any Built-in Field Type or the unique_name or sid of a custom Field Type.
        /// </summary>
        public string FieldType { get; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long.
        /// </summary>
        public string UniqueName { get; }

        /// <summary>
        /// Construct a new CreateFieldOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task associated with this Field. </param>
        /// <param name="fieldType"> The unique name or sid of the FieldType. It can be any Built-in Field Type or the
        ///                 unique_name or sid of a custom Field Type. </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the
        ///                  sid. Unique up to 64 characters long. </param>
        public CreateFieldOptions(string pathAssistantSid, string pathTaskSid, string fieldType, string uniqueName)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            FieldType = fieldType;
            UniqueName = uniqueName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FieldType != null)
            {
                p.Add(new KeyValuePair<string, string>("FieldType", FieldType));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteFieldOptions
    /// </summary>
    public class DeleteFieldOptions : IOptions<FieldResource> 
    {
        /// <summary>
        /// The unique ID of the Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The unique ID of the Task associated with this Field.
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteFieldOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task associated with this Field. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteFieldOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            PathSid = pathSid;
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