using Service;
using Microsoft.AspNetCore.Mvc;

namespace Webchange_service.Controllers;

[ApiController]
[Route("[controller]")]
public class c_run_mail_to_kilometer_d_reverse_Controller : ControllerBase
{
    [HttpPost]
    public double main(double c,double d)
    {
        Mailtokilometr mailtokilometr = new Mailtokilometr();
        
        return Mailtokilometr.B(c,d);
       
    }
    
}