using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class HeartrateCalculator
    {
        public IntensityHeartrate addHeartRateIntensity(int age, int restingHeartrate, int intensity)
        {
            IntensityHeartrate intensityHeartrate = new IntensityHeartrate();
            intensityHeartrate.Heartrate = (((220 - age) - restingHeartrate) * intensity / 100) + restingHeartrate;
            intensityHeartrate.Intensity = intensity;
            return intensityHeartrate;
        }
    }
};
