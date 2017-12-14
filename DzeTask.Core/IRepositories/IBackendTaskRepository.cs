using Abp.Domain.Repositories;
using DzeTask.Tasks;
using System.Collections.Generic;

namespace DzeTask.IRepositories
{
    /// <summary>
    /// 自定义仓储
    /// </summary>
    public interface IBackendTaskRepository : IRepository<Task>
    {
        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId">用户Id</param>
        /// <returns>任务列表</returns>
        List<Task> GetTaskByAssignedPersonId(long personId);
    }
}
