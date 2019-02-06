using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Week2.pages
{
    public class timeModel : PageModel
    {


        public string[] DaysOfWeek { get; set; } =
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public int MyProperty { get; set; }

        [BindProperty]
        public bool[] DaysSelected { get; set; } = { false, false, false, false, false, false, false };

        #region
        //Properties for the checkboxes

        [BindProperty]
        public bool Monday { get; set; }
        [BindProperty]
        public bool Tuesday { get; set; }
        [BindProperty]
        public bool Wednesday { get; set; }
        [BindProperty]
        public bool Thursday { get; set; }
        [BindProperty]
        public bool Friday { get; set; }
        [BindProperty]
        public bool Saturday { get; set; }
        [BindProperty]
        public bool Sunday { get; set; }
        [BindProperty]
        public bool [] CheckedList { get; set; }
        #endregion

        public enum Datatype {


        }


        [BindProperty]
        public List<SelectListItem> Months { get; set; } = new List<SelectListItem>
        {
            new SelectListItem {Value="January", Text = "January"},
            new SelectListItem {Value="February", Text = "February"},
            new SelectListItem {Value="March", Text = "March"},
            new SelectListItem {Value="April", Text = "April"},
            new SelectListItem {Value="May", Text = "May"},
            new SelectListItem {Value="June", Text = "June"},
            new SelectListItem {Value="July", Text = "July"},
            new SelectListItem {Value="August", Text = "August"},
            new SelectListItem {Value="September", Text = "September"},
            new SelectListItem {Value="October", Text = "October"},
            new SelectListItem {Value="November", Text = "November"},
            new SelectListItem {Value="December", Text = "December"}

        };

        [BindProperty]
        public List<string> MonthsSelected { get; set; }

        public void OnGet()
        {

        }


        public void OnPost()
        {


        }
    }
}