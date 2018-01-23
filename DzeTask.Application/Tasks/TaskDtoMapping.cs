using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DzeTask.Tasks.Dtos;

namespace DzeTask.Tasks
{
    public class TaskDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            //定义单向映射
            mapperConfig.CreateMap<CreateTaskInput, Task>();
            mapperConfig.CreateMap<UpdateTaskInput, Task>();
            mapperConfig.CreateMap<TaskDto, UpdateTaskInput>();

            //自定义映射
            var taskDtoMapper = mapperConfig.CreateMap<Task,TaskDto>();
            //TaskDto 的 AssignedPersonName 是由Task 的 User 对象的 FullName
            taskDtoMapper.ForMember(dto => dto.AssignedPersonName,map => map.MapFrom(m => m.AssignedPerson.FullName));
        }
    }
}
