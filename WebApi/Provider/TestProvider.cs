using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interface;

namespace WebApi.Provider
{
    public class TestProvider : ITest
    {
        public string Test(string msg)
        {
            return "autofac test" + msg;
        }
    }
}
