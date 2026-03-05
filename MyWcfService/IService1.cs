using System.ServiceModel;

[ServiceContract]
public interface IService1
{
    [OperationContract]
    string SayHello(string name);
}