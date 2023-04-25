namespace Service;

public class Mailtokilometr
{
    public double B(double c, double d)
    {
        if (c >= 1)
        {
            double kilometer = c * 1.6;
            return kilometer;
        }
        else
        {
            double mile = d / 1.6;
            return mile;
        }
        
    }
}