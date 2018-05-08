using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc3Invoker.Target
{
    public class Invoker<TArg1, TArg2, TArg3, TRes>
    {
        public TRes Invoke(Func<TArg1, TArg2, TArg3, TRes> myFunc, params object[] args)
        {
            Console.WriteLine("Do some pre call stuff");
            TRes result = (TRes)myFunc.Method.Invoke(myFunc.Target, args);
            Console.WriteLine("Do some post call stuff");
            return result;
        }
    }
}
