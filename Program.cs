using AOPDemo;
using AOPDemo.Services;

internal class Program
{
    public static void Main(string[] args)
    {
        IDummyService dummyService = new DummyService();
        dummyService = Dispatcher<IDummyService>
            .Create(dummyService);

        dummyService.Add();
        dummyService.GetLast();
    }
}