using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzeTask.Dto
{
    /// <summary>
    /// 支持分页的Input Dto
    /// </summary>
    public class PagedInputDto : IPagedResultRequest
    {
        /// <summary>
        /// 跳过条数
        /// </summary>
        [Range(1, int.MaxValue)]
        public int SkipCount { get; set; }

        /// <summary>
        /// 最大结果数量
        /// </summary>
        [Range(1, AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }
        public PagedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}
