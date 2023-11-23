using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
      => speed == 0 ? 0 :
        speed is >= 1 and <= 4 ? 1 :
        speed is >= 5 and <= 8 ? 0.9 :
        speed == 9 ? 0.8 : 0.77;
    
    public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * (speed * 221);

    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed) / 60;
}
