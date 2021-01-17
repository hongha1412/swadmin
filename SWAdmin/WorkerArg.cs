using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin
{
    public class WorkerArg
    {
        private WorkerTypeEnum _workerType;
        private object _argValue;

        public WorkerArg(WorkerTypeEnum workerType, object argValue)
        {
            this._workerType = workerType;
            this._argValue = argValue;
        }

        public WorkerTypeEnum WorkerType { get => _workerType; set => _workerType = value; }
        public object ArgValue { get => _argValue; set => _argValue = value; }
    }
}
