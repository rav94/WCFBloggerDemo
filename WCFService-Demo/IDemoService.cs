using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService_Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDemoService" in both code and config file together.
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        int addition(int num1, int num2);
        [OperationContract]
        int substraction(int num1, int num2);
        [OperationContract]
        int division(int num1, int num2);
        [OperationContract]
        int multiplication(int num1, int num2);
    }
}
