namespace DzeTask.Tasks.Dtos
{
    /// <summary>
    /// 给人分配任务Input
    /// </summary>
    public class AssignTaskToPersonInput
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }
    }
}
