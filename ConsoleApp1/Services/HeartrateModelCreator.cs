using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class HeartrateModelCreator
    {
        public ListIntensityHeartrate createModel(int age, int restingHeartrate)
        {
            ListIntensityHeartrate list = new ListIntensityHeartrate();
            for (var i = 55; i <= 95; i = i + 5)
            {
                IntensityHeartrate intensityHeartrate = new IntensityHeartrate();
                HeartrateCalculator calc = new HeartrateCalculator();
                intensityHeartrate = calc.addHeartRateIntensity(age, restingHeartrate, i);
                list.ListOfIntensityHeartrates.Add(intensityHeartrate);
            }
            return list;
        }
    }
}