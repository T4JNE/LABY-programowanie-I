using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABY_programowanie_I
{
    class TestException : Exception
    {
        public TestException()
        {
        }
        public static void TestThrow()
        {
            throw new TestException();
        }
    }
}
