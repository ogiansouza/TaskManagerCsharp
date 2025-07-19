using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks
{
    public class GetAllTasksUseCase
    {
        public ResponseAllTasksJson Execute()
        {
            var response = new ResponseAllTasksJson
            {
                Tasks = MockedTasks.Tasks.Select(task => new ResponseShortTaskJson
                {
                    Name = task.Name,
                    Priority = task.Priority,
                    Status = task.Status
                }).ToList()
            };
            return response;
        }
    }
}
