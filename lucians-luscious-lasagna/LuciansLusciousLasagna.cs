class Lasagna
{
  // TODO: define the 'ExpectedMinutesInOven()' method
  public int ExpectedMinutesInOven() => 40;

  // TODO: define the 'RemainingMinutesInOven()' method
  public int RemainingMinutesInOven(int pastTime)
    => ExpectedMinutesInOven() - pastTime;

  // TODO: define the 'PreparationTimeInMinutes()' method
  public int PreparationTimeInMinutes(int numberOfLayers)
    => numberOfLayers * 2;

  // TODO: define the 'ElapsedTimeInMinutes()' method
  public int ElapsedTimeInMinutes(int numberOfLayers, int timeInTheOver)
    => PreparationTimeInMinutes(numberOfLayers) + timeInTheOver;
}
