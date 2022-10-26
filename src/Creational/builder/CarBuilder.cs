public class CarBuilder : IBuilder
{
    private Car car=default!;
    public Car Build()
    {
        return car;
    }
    public void Reset()
    {
        car = new Car();
    }
    public void SetEngine(string engine)
    {
         car.Engine =engine;
    }
    public void SetGPS(string gps)
    {
        car.Gps=gps;
    }
    public void SetSeats(int number)
    {
       car.Seats=number;
    }
    public void SetTripComputer(string computer)
    {
        car.TripComputer=computer;
    }

}