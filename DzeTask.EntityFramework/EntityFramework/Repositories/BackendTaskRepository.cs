using System.Collections.Generic;
using System.Linq;
using Abp.EntityFramework;
using DzeTask.IRepositories;
using DzeTask.Tasks;

namespace DzeTask.EntityFramework.Repositories
{
    /// <summary>
    /// 默认仓储实现
    /// </summary>
    public class BackendTaskRepository : DzeTaskRepositoryBase<Task>, IBackendTaskRepository
    {
        /// <summary>
        /// 该仓储实现，继承自模板生成的LearningMpaAbpRepositoryBase泛型抽象类，然后再实现IBackendTaskRepository接口。
        /// 这里要显示声明实现类的有参构造函数，使用泛型的IDbContextProvider将数据库上下文的子类ChargeStationContext传给父类的构造函数。
        /// </summary>
        /// <param name="dbContextProvider"></param>
        protected BackendTaskRepository(IDbContextProvider<DzeTaskDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId">用户ID</param>
        /// <returns></returns>
        public List<Task> GetTaskByAssignedPersonId(long personId)
        {
            var query = GetAll();
            if (personId > 0)
            {
                query = query.Where(t => t.AssignedPersonId == personId);
            }
            return query.ToList();
        }

        //仓储方法中，ABP自动进行数据库连接的开启和关闭。
        //仓储方法被调用时，数据库连接自动开启且启动事务。
        //当仓储方法调用另外一个仓储的方法，它们实际上共享的是同一个数据库连接和事务。
        //仓储对象都是暂时性的，因为IRepository接口默认继承自ITransientDependency接口。
        //所以，仓储对象只有在需要注入的时候，才会由Ioc容器自动创建新实例。
        //默认的泛型仓储能满足我们大部分的需求。只有在不满足的情况下，才创建定制化的仓储。
    }
}
