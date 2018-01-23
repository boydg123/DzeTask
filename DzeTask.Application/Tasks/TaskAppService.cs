using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using DzeTask.Tasks.Dtos;

namespace DzeTask.Tasks
{
    public class TaskAppService : ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;
        //新式构造函数
        public TaskAppService(IRepository<Task> taskRepository) => _taskRepository = taskRepository;

        public int CreateTask(CreateTaskInput input)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTask(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public IList<TaskDto> GetAllTasks()
        {
            throw new System.NotImplementedException();
        }

        public PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input)
        {
            throw new System.NotImplementedException();
        }

        public TaskDto GetTaskById(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskDto> GetTaskByIdAsync(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public TaskCacheItem GetTaskFromCacheById(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}
