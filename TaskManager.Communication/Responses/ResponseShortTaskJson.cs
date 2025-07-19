using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses
{
    public class ResponseShortTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public TaskPriorityeEnum Priority { get; set; }
        public TaskStatusEnum Status { get; set; } = TaskStatusEnum.WAITING;
    }
}
