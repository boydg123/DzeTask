using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzeTask.Tasks.Dtos
{
    public class UpdateTaskInput : ICustomValidate
    {
        [Range(1, Int32.MaxValue)] 
        public int Id { get; set; }

        public long? AssignedPersonId { get; set; }

        public TaskState? State { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }


        public void AddValidationErrors(CustomValidationContext context)
        {
            throw new NotImplementedException();
        }
    }
}
