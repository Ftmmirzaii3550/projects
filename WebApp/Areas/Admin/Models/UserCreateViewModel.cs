using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class UserCreateViewModel
    {

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تکمیل فیلد {0} الزامی است")]
        public string FirstName { get; set; }


        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تکمیل فیلد {0} الزامی است")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "تایید رمز عبور")]
        [Compare(nameof(Password), ErrorMessage = "{0} تطابق ندارد")]
        public string ConfirmPassword { get; set; }
    }
}
