using DzeTask.Dto;

namespace DzeTask.Tasks.Dtos
{
    /// <summary>
    /// 获取任务列表Input
    /// </summary>
    public class GetTasksInput: PagedSortedAndFilteredInputDto
    {
        public TaskState? State { get; set; }
        public int? AssignedPersonId { get; set; }
    }
}
