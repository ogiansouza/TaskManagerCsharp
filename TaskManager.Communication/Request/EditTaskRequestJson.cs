using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Request
{
    public class EditTaskRequestJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public TaskPriorityeEnum Priority { get; set; }
        public TaskStatusEnum Status { get; set; } = TaskStatusEnum.WAITING;
    }
}
