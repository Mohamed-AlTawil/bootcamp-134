// See https://aka.ms/new-console-template for more information


try
{
    String again = "";
    do
    {
        Console.WriteLine(">> Enter The Radius Of The Circle (R)");
        double p = Math.PI;
        double R = Double.Parse(Console.ReadLine());
        double area = p * Math.Pow(R, 2);
        double circumference = 2 * p * R;
        Console.WriteLine($">> The Area of Circle is {area} \n>> The Circumference of Circle is {circumference}");

        Console.WriteLine("\n>> Do you want to enter another value? [Y/N]");
        again = Console.ReadLine();

    } while (again=="Y");

}
catch (Exception)
{
    Console.WriteLine(">> Enter just Number");
}