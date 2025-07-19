using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks;
using TaskManager.Communication.Request;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetTasks()
        {
            var response = new GetAllTasksUseCase().Execute();
            if (response.Tasks.Any())
            {
                return Ok(response);
            }
            else
            {
                return NoContent(); 
            }
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResponseDetailedTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetTaskById([FromRoute]int id)
        {
            var task = new GetTaskByIdUseCase().Execute(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateTask([FromBody] CreateTaskRequestJson task)
        {
            new CreateTaskUseCase().Execute(task);
            return Created("", task);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateTask([FromRoute]int id, [FromBody] EditTaskRequestJson task)
        {
            new EditTaskUseCase().Execute(id, task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteTask([FromRoute]int id)
        {
            var isDeleted = new DeleteTaskUseCase().Execute(id);
            if (isDeleted)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
