using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfaces
{
    public interface ICommunication
    {
        short ReceiveData(short slaveId, int address);
        string ReceiveErrorMessage(short slaveId, int address);
    }
}
