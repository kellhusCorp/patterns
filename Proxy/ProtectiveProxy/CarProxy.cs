namespace ProtectiveProxy;

public class CarProxy : ICar
{
    private Car car = new();

    private Driver driver;
    
    public CarProxy(Driver driver)
    {
        this.driver = driver;
    }
    
    public void Move()
    {
        if (driver.Age >= 18)
        {
            car.Move();
        }
        else
        {
            Console.WriteLine("Данный водитель не может управлять ТС, ввиду своей молодости.");
        }
    }
}