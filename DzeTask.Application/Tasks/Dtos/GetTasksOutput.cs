using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzeTask.Tasks.Dtos
{
    /// <summary>
    /// 获取Tasks OutPut
    /// </summary>
    public class GetTasksOutput
    {
        public List<TaskDto> Tasks { get; set; }
    }
}
