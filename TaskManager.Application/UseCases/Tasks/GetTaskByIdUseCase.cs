using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks
{
    public class GetTaskByIdUseCase
    {
        public ResponseDetailedTaskJson Execute(int id)
        {
            var tasks = MockedTasks.Tasks.Select(task => new ResponseDetailedTaskJson
            {
                Name = task.Name,
                Priority = task.Priority,
                Status = task.Status,
                DueDate = task.DueDate,
                Description = task.Description,
                Id = task.Id
            }).ToList();

            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return null;
            }
            return new ResponseDetailedTaskJson
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                Priority = task.Priority,
                Status = task.Status,
                DueDate = task.DueDate
            };
        }
    }
}
