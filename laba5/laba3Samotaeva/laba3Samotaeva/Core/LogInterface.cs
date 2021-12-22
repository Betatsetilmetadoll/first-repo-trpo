using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
    }
}
