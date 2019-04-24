/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant.Task 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchSampleOptions
    /// </summary>
    public class FetchSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the resource to fetch
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The SID of the Task associated with the Sample resource to create
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to fetch </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to create </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchSampleOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
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
    /// ReadSampleOptions
    /// </summary>
    public class ReadSampleOptions : ReadOptions<SampleResource> 
    {
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the resources to read
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The SID of the Task associated with the Sample resources to read
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The ISO language-country string that specifies the language used for the sample
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Construct a new ReadSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to read </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resources to read </param>
        public ReadSampleOptions(string pathAssistantSid, string pathTaskSid)
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
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

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
    /// CreateSampleOptions
    /// </summary>
    public class CreateSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the new resource
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The SID of the Task associated with the Sample resource to create
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The ISO language-country string that specifies the language used for the new sample
        /// </summary>
        public string Language { get; }
        /// <summary>
        /// The text example of how end users might express the task
        /// </summary>
        public string TaggedText { get; }
        /// <summary>
        /// The communication channel from which the new sample was captured
        /// </summary>
        public string SourceChannel { get; set; }

        /// <summary>
        /// Construct a new CreateSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the new
        ///                        resource </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to create </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the new sample </param>
        /// <param name="taggedText"> The text example of how end users might express the task </param>
        public CreateSampleOptions(string pathAssistantSid, string pathTaskSid, string language, string taggedText)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            Language = language;
            TaggedText = taggedText;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

            if (TaggedText != null)
            {
                p.Add(new KeyValuePair<string, string>("TaggedText", TaggedText));
            }

            if (SourceChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceChannel", SourceChannel));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateSampleOptions
    /// </summary>
    public class UpdateSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the resource to update
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The SID of the Task associated with the Sample resource to update
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The ISO language-country string that specifies the language used for the sample
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// The text example of how end users might express the task
        /// </summary>
        public string TaggedText { get; set; }
        /// <summary>
        /// The communication channel from which the sample was captured
        /// </summary>
        public string SourceChannel { get; set; }

        /// <summary>
        /// Construct a new UpdateSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to update </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to update </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateSampleOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
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
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

            if (TaggedText != null)
            {
                p.Add(new KeyValuePair<string, string>("TaggedText", TaggedText));
            }

            if (SourceChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceChannel", SourceChannel));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteSampleOptions
    /// </summary>
    public class DeleteSampleOptions : IOptions<SampleResource> 
    {
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the resources to delete
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The SID of the Task associated with the Sample resource to delete
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSampleOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to delete </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteSampleOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
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