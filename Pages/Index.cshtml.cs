using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.ComponentModel.DataAnnotations;

namespace DeleteCalculator.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        [Display(Name = "First Number")] //these are attributes that you can use to change and control what is seen and done int he front end
        public double NumberA { get; set; }

        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [Display(Name = "Result")] //holds the result of the operation
        public double Result { get; set; }


        public string? Operation { get; set; }
        [Display(Name = "Operation")]
        public List<SelectListItem> Operations { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "+", Text = "+" },
            new SelectListItem { Value = "-", Text = "-" },
            new SelectListItem { Value = "/", Text = "/"  },
              new SelectListItem { Value = "*", Text = "X"  },
        };


        //   public EnumOperationType OperationType { get; set; } //this is the Enum which is a handy way to make a list easily.

        //this runs when you submit the form
        public void OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (Operation == "+")
                    Result = NumberA + NumberB;
                if (Operation == "/")
                    Result = NumberA / NumberB;
                if (Operation == "-")
                    Result = NumberA - NumberB;
                if (Operation == "*")
                    Result = NumberA * NumberB;

                //if (OperationType == EnumOperationType.Addition)
                //    Result = NumberA + NumberB;
                //if (OperationType == EnumOperationType.Division)
                //    Result = NumberA / NumberB;
                //if (OperationType == EnumOperationType.Subtraction)
                //    Result = NumberA - NumberB;
                //if (OperationType == EnumOperationType.Multiplication)
                //    Result = NumberA * NumberB;
            }

        }

    }
}