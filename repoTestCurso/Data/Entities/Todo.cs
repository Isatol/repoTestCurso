using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace repoTestCurso.Data.Entities
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [StringLength (20, ErrorMessage = "El título debe contener hasta 20 caracteres")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsComplete { get; set; }
    }
}
