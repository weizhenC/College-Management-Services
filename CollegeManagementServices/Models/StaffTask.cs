using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementServices.Models
{
    public class StaffTask
    {
        public StaffTask() { }
        [Key]
        [DisplayName("ID")]
        public int TaskId{ get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public TaskLocation Location { get; set; }
        public TaskStatus Status { get; set; }
    }

    public enum TaskLocation
    {
        Online,
        Physical,
        Hybrid
    }

    public enum TaskStatus
    {
        Completed,
        InProgress,
        NotStarted
    }

}
