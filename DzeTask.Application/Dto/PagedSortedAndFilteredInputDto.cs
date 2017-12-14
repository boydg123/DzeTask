namespace DzeTask.Dto
{
    /// <summary>
    /// 支持分页、排序和过滤的Input Dto
    /// </summary>
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        public string Filter { get; set; }
    }
}
