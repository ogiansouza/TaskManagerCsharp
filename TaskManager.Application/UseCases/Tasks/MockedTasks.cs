using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks
{
    public class MockedTasks
    {
        public static List<ResponseDetailedTaskJson> Tasks = new List<ResponseDetailedTaskJson>()
        {
            new ResponseDetailedTaskJson
            {
                Name = "Task 1",
                Description = "Description for Task 1",
                Priority = Communication.Enums.TaskPriorityeEnum.HIGH,
                Status = Communication.Enums.TaskStatusEnum.WAITING,
                Id = 1,
                DueDate = DateTime.Now.AddDays(2)
            },
            new ResponseDetailedTaskJson
            {
                Name = "Task 2",
                Description = "Description for Task 2",
                Priority = Communication.Enums.TaskPriorityeEnum.MEDIUM,
                Status = Communication.Enums.TaskStatusEnum.IN_PROGRESS,
                Id = 2,
                DueDate = DateTime.Now.AddDays(1),
            },
            new ResponseDetailedTaskJson
            {
                Name = "Task 3",
                Description = "Description for Task 3",
                Priority = Communication.Enums.TaskPriorityeEnum.LOW,
                Status = Communication.Enums.TaskStatusEnum.DONE,
                Id = 3,
                DueDate = DateTime.Now.AddDays(3)
            }
        };
    }
}
