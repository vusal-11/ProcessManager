using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessesManager
{
    internal class ProcessManager
    {





        List<Process> GetProcesses()
        {
            return Process.GetProcesses().ToList();
        }

    }
}
