/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// FetchTaskQueueOptions
    /// </summary>
    public class FetchTaskQueueOptions : IOptions<TaskQueueResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchTaskQueueOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    /// UpdateTaskQueueOptions
    /// </summary>
    public class UpdateTaskQueueOptions : IOptions<TaskQueueResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Human readable description of this TaskQueue
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A string describing the Worker selection criteria for any Tasks that enter this TaskQueue.
        /// </summary>
        public string TargetWorkers { get; set; }
        /// <summary>
        /// ActivitySID that will be assigned to Workers when they are reserved for a task from this TaskQueue.
        /// </summary>
        public string ReservationActivitySid { get; set; }
        /// <summary>
        /// ActivitySID that will be assigned to Workers when they are assigned a task from this TaskQueue.
        /// </summary>
        public string AssignmentActivitySid { get; set; }
        /// <summary>
        /// The maximum amount of workers to create reservations for the assignment of a task while in this queue.
        /// </summary>
        public int? MaxReservedWorkers { get; set; }
        /// <summary>
        /// TaskOrder will determine which order the Tasks will be assigned to Workers.
        /// </summary>
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }

        /// <summary>
        /// Construct a new UpdateTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateTaskQueueOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }

            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid.ToString()));
            }

            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid.ToString()));
            }

            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.Value.ToString()));
            }

            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadTaskQueueOptions
    /// </summary>
    public class ReadTaskQueueOptions : ReadOptions<TaskQueueResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Filter by a human readable description of a TaskQueue
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Provide a Worker attributes expression, and this will return the list of TaskQueues that would distribute tasks to a worker with these attributes.
        /// </summary>
        public string EvaluateWorkerAttributes { get; set; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; set; }

        /// <summary>
        /// Construct a new ReadTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public ReadTaskQueueOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (EvaluateWorkerAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateWorkerAttributes", EvaluateWorkerAttributes));
            }

            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateTaskQueueOptions
    /// </summary>
    public class CreateTaskQueueOptions : IOptions<TaskQueueResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Human readable description of this TaskQueue
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// A string describing the Worker selection criteria for any Tasks that enter this TaskQueue.
        /// </summary>
        public string TargetWorkers { get; set; }
        /// <summary>
        /// The maximum amount of workers to create reservations for the assignment of a task while in this queue.
        /// </summary>
        public int? MaxReservedWorkers { get; set; }
        /// <summary>
        /// TaskOrder will determine which order the Tasks will be assigned to Workers.
        /// </summary>
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }
        /// <summary>
        /// ActivitySID to assign workers once a task is reserved for them
        /// </summary>
        public string ReservationActivitySid { get; set; }
        /// <summary>
        /// ActivitySID to assign workers once a task is assigned for them
        /// </summary>
        public string AssignmentActivitySid { get; set; }

        /// <summary>
        /// Construct a new CreateTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> Human readable description of this TaskQueue </param>
        public CreateTaskQueueOptions(string pathWorkspaceSid, string friendlyName)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }

            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.Value.ToString()));
            }

            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }

            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid.ToString()));
            }

            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteTaskQueueOptions
    /// </summary>
    public class DeleteTaskQueueOptions : IOptions<TaskQueueResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteTaskQueueOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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