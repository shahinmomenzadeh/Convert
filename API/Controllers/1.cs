using Service;
using Microsoft.AspNetCore.Mvc;

namespace Webchange_service.Controllers;

[ApiController]
[Route("[controller]")]
public class a_run_centimeter_to_inch_and_b_is_reverse_a_Controller : ControllerBase
{
    [HttpPost]
    public double main(double a,double b)
    {
        Cmtoinch cmtoinch = new Cmtoinch();
        
        return Cmtoinch.A(a,b);
       
    }
    
}

   