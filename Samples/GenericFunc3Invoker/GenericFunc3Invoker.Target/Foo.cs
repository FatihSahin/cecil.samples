using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc3Invoker.Target
{
    public class Foo
    {
        public TRes GetFoo<TArg1, TArg2, TRes>(TArg1 req1, TArg2 req2, string arg3) where TRes : new()
        {
            return new TRes();
        }

        //WHAT I am expecting to weave foo like below (example with bar)

        public TRes GetBar<TArg1, TArg2, TRes>(TArg1 req1, TArg2 req2, string arg3) where TRes : new()
        {
            Invoker<TArg1, TArg2, string, TRes> invoker = new Invoker<TArg1, TArg2, string, TRes>();
            return invoker.Invoke(GetBar_Original<TArg1, TArg2, TRes>, req1, req2, arg3);
        }

        public TRes GetBar_Original<TArg1, TArg2, TRes>(TArg1 req1, TArg2 req2, string arg3) where TRes : new()
        {
            Console.WriteLine("Do some get foo stuff");
            return new TRes();
        }
    }
}
