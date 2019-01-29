using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week2.pages
{
    public class ws1bModel : PageModel
    {
        public int sum { get; set; }
        public int Output { get; set; }
        public string Operation { get; set; }


        public void OnGet()
        {

        }

        public void OnPost(int number1, int number2, string radiobutton1)
        {

            Operation = radiobutton1;

            switch (radiobutton1)
            {

                case "Sum":
                    Output = number1 + number2;
                    break;
                case "Difference":
                    Output = number1 - number2;
                    break;
                case "Product":
                    Output = number1 * number2;
                    break;
                case "Quotient":
                    Output = number1 / number2;
                    break;

                default:
                    Output = 0;
                    break;
            }


            sum = number1 + number2;

        }
    }
}