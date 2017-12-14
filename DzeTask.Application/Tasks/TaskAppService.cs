using Abp.Domain.Repositories;

namespace DzeTask.Tasks
{
    public class TaskAppService : ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;
        //新式构造函数
        public TaskAppService(IRepository<Task> taskRepository) => _taskRepository = taskRepository;
    }
}
