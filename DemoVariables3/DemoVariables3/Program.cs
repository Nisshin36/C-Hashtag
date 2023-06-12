/* Anh-Tu Ngoc Chapter 2 You Do It "DemoVariables3" */ 
class DemoVariables3
{
    static void Main()
    {
        int value = 4;
        bool IsSixMore = 6 > value;
        System.Console.WriteLine("When value is {0} IsSixMore is {1}", value, IsSixMore);
        value = 35;
        IsSixMore = 6 > value;
        System.Console.WriteLine("When value is {0} IsSixMore is {1}", value, IsSixMore);
        /* Custom test codes */ 
        value = 21;
        IsSixMore = 6 > value;
        System.Console.WriteLine("When the value is {0}, six is greater than that number. {1}", value, IsSixMore);
        System.Console.ReadLine();
    }
}

