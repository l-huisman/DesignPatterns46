using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public abstract class ComputerFactory
    {
        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();
        public abstract IMonitor CreateMonitor();
    }
}

