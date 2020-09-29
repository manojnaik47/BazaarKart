using System;
using System.Collections.Generic;
using System.Text;
using BKart.Domain.Logging;

namespace BKart.Services.Logger
{
    public interface ILoggerService
    {
        void Exception(Log log);
    }
}
