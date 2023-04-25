using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using WebApplication1.db;
using WebApplication1.db.Entities;

namespace Service;

public class TestService
{
    private readonly Db _context;

    public TestService(Db context)
    {
        _context = context;
    }

    public void SaveMyRecord(string record)
    {
        Result toBeSaved = new Result();
        toBeSaved.Dis = record;
        _context.Results.Add(toBeSaved);
        _context.SaveChanges();
    }

    protected double CountRecords()
    {
        return _context.Results.Count();
    }
    
}