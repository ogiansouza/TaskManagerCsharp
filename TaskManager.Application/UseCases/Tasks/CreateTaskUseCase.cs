using TaskManager.Communication.Request;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks
{
    public class CreateTaskUseCase
    {
        public void Execute(CreateTaskRequestJson task)
        {
            MockedTasks.Tasks.Add(new ResponseDetailedTaskJson
            {
                Id = MockedTasks.Tasks.Count + 1, 
                Name = task.Name,
                Description = task.Description,
                Priority = task.Priority,
                Status = task.Status,
                DueDate = task.DueDate
            });
        }
    }
}
