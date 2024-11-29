using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_test
{
    public class MyEventArgs:EventArgs
    {
        public string Message { get; set; }
        public MyEventArgs(string message)
        {
            Message = message;
        }

    }
}
