using DeleteCalculator.DTO;
using DeleteCalculator.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.ComponentModel.DataAnnotations;

namespace DeleteCalculator.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public CalculatorDTO calculatorDTO { get; set; }



        [Display(Name = "Operation")]
        public List<SelectListItem> Operations = new List<SelectListItem>
        {
            new SelectListItem { Value = "+", Text = "+" },
            new SelectListItem { Value = "-", Text = "-" },
            new SelectListItem { Value = "/", Text = "/"  },
              new SelectListItem { Value = "*", Text = "X"  },
        };

        public IndexModel()
        {
            calculatorDTO = new CalculatorDTO { };
        }

        public void OnPostAsync()
        {
            Calculations myCalculations = new Calculations();

            if (ModelState.IsValid)
            {
                calculatorDTO.Result = myCalculations.CalcResult(calculatorDTO.NumberA, calculatorDTO.NumberB, calculatorDTO.Operation);

            }

        }


    }
}