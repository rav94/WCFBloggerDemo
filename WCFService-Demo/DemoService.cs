using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService_Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DemoService" in both code and config file together.
    public class DemoService : IDemoService
    {
        public int addition(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }

        public int division(int num1, int num2)
        {
            int answer = num1 / num2;
            return answer;
        }

        public int multiplication(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }

        public int substraction(int num1, int num2)
        {
            int answer = num1 - num2;
            return answer;
        }
    }
}
