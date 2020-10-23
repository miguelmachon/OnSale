using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Data.Entities
{
    class Departament
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Departament")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        public int Name { get; set; }


    }
}
