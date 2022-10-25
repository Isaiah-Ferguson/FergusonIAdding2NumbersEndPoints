//Isaiah Keith Ferguson
//10/25/2022
//Adding 2 numbers
//This program will have the user input 2 numbers and we will give them the sum.
//Reviewed by: Pedro Castaneda - Isaiah did a great job setting his Endpoint for adding two numbers. Number validation works great and I like the conversion from string to int inside of his function as well as the simplicity of his IF and ELSE statements. Great work!

using Microsoft.AspNetCore.Mvc;

namespace FergusonIAdding2NumbersEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingNumberController : ControllerBase
{

    [HttpGet]
    [Route("Adding/{num1}/{num2}")]

    public string addingNumbers(string num1, string num2)
    {
        double Cnum1 = 0;
        double Cnum2 = 0;
        bool tru1 = true;
        bool tru2 = true;
        tru1 = double.TryParse(num1, out Cnum1);
        tru2 = double.TryParse(num2, out Cnum2);
        if(tru1 == true && tru2 == true)
        {
        return $"The Sum of your numbers is: \n{Cnum1 + Cnum2}";
        }
        else
        {
            return "Error those are not numbers";
        }
    }
}
