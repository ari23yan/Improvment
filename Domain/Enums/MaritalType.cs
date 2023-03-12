using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Enums
{
    public enum MaritalType : byte
    {
        [Display(Name = "مجرد")]
        Single = 1,
        [Display(Name = "متاهل")]
        Married = 2,
        [Display(Name = "مجردسرپرست خانه")]
        SingleHousehold = 3
    }
}
