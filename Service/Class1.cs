namespace Service;

public class Cmtoinch
{
    public  double A(double a, double b)
    {
        if (a >= 1)
        {
            double inch;
            inch = 0.3937 * a;
            return inch;
        }
        else
        {
            double sentimetr = b / 0.3937; 
            return sentimetr;
            
        }

    }
    
}
