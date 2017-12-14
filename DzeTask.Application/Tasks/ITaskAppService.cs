using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DzeTask.Tasks.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DzeTask.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);

        PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input);

        void UpdateTask(UpdateTaskInput input);

        int CreateTask(CreateTaskInput input);

        Task<TaskDto> GetTaskByIdAsync(int taskId);

        TaskDto GetTaskById(int taskId);

        void DeleteTask(int taskId);

        TaskCacheItem GetTaskFromCacheById(int taskId);

        IList<TaskDto> GetAllTasks();
    }
}
