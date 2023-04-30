using ConsoleApp2;
class Program
{
    static ILogger Logger { get; set; }
    static void Main(string[] args)
    {
        Logger = new Logger();
        var calculate = new Calculate(Logger);
        int _event = 0;
        double x;
        double y;
        do
        {
            try 
            {
              x = Convert.ToDouble(Console.ReadLine());
              y = Convert.ToDouble(Console.ReadLine()); 
              calculate.Sum(x, y);
              _event=Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex) {Logger.Error(ex.Message);}

        } while (_event == 0);
    }
}