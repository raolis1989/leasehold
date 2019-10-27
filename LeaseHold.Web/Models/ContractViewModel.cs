using LeaseHold.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace LeaseHold.Web.Models
{
    public class ContractViewModel : Contract
    {
        public int OwnerId { get; set; }
        public int PropertyId { get; set; }

        [Required(ErrorMessage ="The field {0} is mandatory.")]
        [Display(Name ="Lessee")]
        [Range(1, int.MaxValue, ErrorMessage ="You must select a lessess")]
        public int LesseeId { get; set; }

        public IEnumerable<SelectListItem> Lessees { get; set; }

    }
}
