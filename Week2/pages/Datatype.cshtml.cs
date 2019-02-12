using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week2.pages
{
    public class DatatypeModel : PageModel
    {

        //[DataType(DataType.Custom)]
        //[BindProperty]
        //public string Custom { get; set; }

        //[DataType(DataType.DateTime)]
        //[BindProperty]
        //public string Datetime { get; set; }

        //[DataType(DataType.Date)]
        //[BindProperty]
        //public string Date { get; set; }

        //[DataType(DataType.Time)]
        //[BindProperty]
        //public string Time { get; set; }

        //[DataType(DataType.Duration)]
        //[BindProperty]
        //public string Duration { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //[BindProperty]
        //public string Phone { get; set; }

        //[DataType(DataType.Currency)]
        //[BindProperty]
        //public string Currency { get; set; }

        //[DataType(DataType.Text)]
        //[BindProperty]
        //public string Text { get; set; }

        //[DataType(DataType.Html)]
        //[BindProperty]
        //public string Html { get; set; }

        //[DataType(DataType.MultilineText)]
        //[BindProperty]
        //public string Multiline { get; set; }

        //[DataType(DataType.EmailAddress)]
        //[BindProperty]
        //public string Email { get; set; }

        //[DataType(DataType.Password)]
        //[BindProperty]
        //public string Password { get; set; }

        //[DataType(DataType.Url)]
        //[BindProperty]
        //public string Day { get; set; }

        //[DataType(DataType.ImageUrl)]
        //[BindProperty]
        //public string ImageUrl { get; set; }

        //[DataType(DataType.CreditCard)]
        //[BindProperty]
        //public string CreditCArd { get; set; }

        //[DataType(DataType.PostalCode)]
        //[BindProperty]
        //public string Postal { get; set; }

        //[DataType(DataType.Upload)]
        //[BindProperty]
        //public string Upload { get; set; }


        [BindProperty]
        public List <string> typelist { get; set; } = new List<string>{ "wer", "ert", "werf" };

        [BindProperty]
        public List<string> selectlist { get; set; } = new List<string>{ "wer", "ert", "werf" };




        public void OnPost()
        {
            foreach (var item in Enum.GetNames(typeof(DataType)))
            {
                typelist.Add(item);
            }
        }



    }
}