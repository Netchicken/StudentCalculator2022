using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace DeleteCalculator.DTO
{
    public class CalculatorDTO
    {

        [Display(Name = "First Number")] //these are attributes that you can use to change and control what is seen and done int he front end
        public double NumberA { get; set; }

        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [Display(Name = "Result")] //holds the result of the operation
        public double Result { get; set; }


        public string? Operation { get; set; }
        





    }
}
