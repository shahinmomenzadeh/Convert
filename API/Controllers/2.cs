using Service;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.db.Entities;

namespace Webchange_service.Controllers;

[ApiController]
[Route("[controller]")]
public class c_run_mail_to_kilometer_d_reverse_Controller : ControllerBase
{
    private Result _testResult;
    private readonly TestService _savingService;
    private readonly Mailtokilometr _convertor;
    private readonly TestService _testService;

    public c_run_mail_to_kilometer_d_reverse_Controller(Result rresult,TestService savingService,Mailtokilometr converto)
    {
        _testResult = rresult;
        _savingService = savingService;
        _convertor = converto;
    }
    
    [HttpPost]
    public double main(double c,double d)
    {
        double rresult = _convertor.B(c, d);
        _savingService.SaveMyRecord(rresult.ToString());
        return rresult;
       
    }
    
}