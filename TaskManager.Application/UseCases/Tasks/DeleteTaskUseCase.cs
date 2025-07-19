namespace TaskManager.Application.UseCases.Tasks
{
    public class DeleteTaskUseCase
    {
        public bool Execute(int id)
        {
            var task = MockedTasks.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return false;
            }
            MockedTasks.Tasks.Remove(task);
            return true;
        }
    }
}
