using System.Runtime.Serialization;

namespace TaskCloud.WebApp.Models.Enum
{
    public enum Status
    {
        [EnumMember(Value = "Not Started")]
        NotStarted,
        Pending,
        [EnumMember(Value = "In Progress")]
        InProgress,
        Completed,
        Cancelled
    }
}
