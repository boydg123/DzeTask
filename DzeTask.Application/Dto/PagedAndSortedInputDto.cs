using Abp.Application.Services.Dto;

namespace DzeTask.Dto
{
    /// <summary>
    /// 支持分页、排序的Input Dto
    /// </summary>
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; }

        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}
