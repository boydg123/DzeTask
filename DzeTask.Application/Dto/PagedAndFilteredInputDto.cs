namespace DzeTask.Dto
{
    /// <summary>
    /// 支持分页过滤的Input Dto
    /// </summary>
    public class PagedAndFilteredInputDto : PagedInputDto
    {
        public string Filter { get; set; }

        public PagedAndFilteredInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}
