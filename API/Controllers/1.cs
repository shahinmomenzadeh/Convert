using Service;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.db.Entities;

namespace Webchange_service.Controllers;

[ApiController]
[Route("[controller]")]
public class a_run_centimeter_to_inch_and_b_is_reverse_a_Controller : ControllerBase
{
    private Result _testResult;
    private readonly TestService _savingService;
    private readonly Cmtoinch _convertor;
    private readonly TestService _testService;

    public a_run_centimeter_to_inch_and_b_is_reverse_a_Controller(Result result,TestService savingService,Cmtoinch convertor)
    {
        _testResult = result;
        _savingService = savingService;
        _convertor = convertor;
    }

    [HttpPost]
    public double main(double a, double b)
    {

        double result = _convertor.A(a, b);

        _savingService.SaveMyRecord(result.ToString());
        
        return result;
    }
}