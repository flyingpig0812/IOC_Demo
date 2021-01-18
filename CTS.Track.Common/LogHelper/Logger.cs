using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Common.LogHelper
{
    public class Logger
    {

        private static readonly log4net.ILog _ilog = log4net.LogManager.GetLogger("LogHelper");
        public static void Debug(string message)
        {
            if (_ilog.IsDebugEnabled)
            {
                _ilog.Debug(message);
            }
        }

        public static void Debug(Object message, Exception exception)
        {
            if (_ilog.IsErrorEnabled)
            {
                _ilog.Debug(message, exception);
            }
        }
        public static void Error(string message)
        {
            if (_ilog.IsErrorEnabled)
            {
                _ilog.Error(message);
            }
        }

        public static void Error(Object message, Exception exception)
        {
            if (_ilog.IsErrorEnabled)
            {
                _ilog.Error(message, exception);
            }
        }
        public static void Fatal(string message)
        {
            if (_ilog.IsFatalEnabled)
            {
                _ilog.Fatal(message);
            }
        }
        public static void Fatal(Object message, Exception exception)
        {
            if (_ilog.IsFatalEnabled)
            {
                _ilog.Fatal(message, exception);
            }
        }

        public static void Info(string message)
        {
            if (_ilog.IsInfoEnabled)
            {
                _ilog.Info(message);
            }
        }
        public static void Info(Object message, Exception exception)
        {

            _ilog.Info(message, exception);
        }
        public static void Warn(string message)
        {
            if (_ilog.IsWarnEnabled)
            {
                _ilog.Warn(message);
            }
        }
        public static void Warn(Object message, Exception exception)
        {
            _ilog.Warn(message, exception);
        }


    }
}
