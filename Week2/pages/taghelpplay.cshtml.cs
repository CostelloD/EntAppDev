using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week2.pages
{
    public class taghelpplayModel : PageModel
    {

        [BindProperty]
        public int Number1 { get; set; }


        [BindProperty]
        public int Int1 { get; set; }
        [BindProperty]
        public int? Int2 { get; set; }
        [BindProperty]
        public double Double1 { get; set; }
        [BindProperty]
        public double? Double2 { get; set; }
        [BindProperty]
        public decimal Decimal1 { get; set; }
        [BindProperty]
        public decimal? Decimal2 { get; set; }
        [BindProperty]
        public float Float1 { get; set; }
        [BindProperty]
        public float? Float2 { get; set; }


        [BindProperty]
        public string String { get; set; }

        [BindProperty]
        public DateTime? Datetime { get; set; }

        [BindProperty]
        public bool IsContacAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }

        [BindProperty]
        public string Test { get; set; }


        public void OnGet()
        {

        }
    }
}