namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWriter fileWriter = new FileWriter();
            fileWriter.FistQuerry(25000);
            fileWriter.SecondQuerry();
            fileWriter.ThirdQuerry(10000);
            fileWriter.FourthQuerry();
            fileWriter.FifthQuerry();
            fileWriter.SixthQuerry();
            fileWriter.SeventhQuerry();
        }
    }
}