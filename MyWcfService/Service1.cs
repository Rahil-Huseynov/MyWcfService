using System.ServiceModel;

public class Service1 : IService1
{
    public string SayHello(string name)
    {
        return "Hello " + name + " from WCF!";
    }
}