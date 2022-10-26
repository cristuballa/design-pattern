public class Director
{
    public void MakeSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetEngine("SportsSuv Automatic");
        builder.SetGPS("Active");
        builder.SetSeats(7);
        builder.SetTripComputer("Manual");
    }
    public void MakeSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetEngine("SportsEngine Automatic");
        builder.SetGPS("Active");
        builder.SetSeats(8);
        builder.SetTripComputer("AI");
    }
}


