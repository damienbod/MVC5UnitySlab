using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5UnitySlab.Business.Logging;
using MVC5UnitySlab.Business.Attributes;

namespace MVC5UnitySlab.Business
{
    [UnityIoCTransientLifetime]
    public class UnitOfWorkExample : IUnitOfWorkExample
    {
        static int _counter = 0; 
        public UnitOfWorkExample()
        {
            _counter++;
            UnityEventLogger.Log.CreateUnityMessage("UnitOfWorkExampleTest " + _counter );
        }

        public virtual void Deposit(decimal depositAmount)
        {
            string x = "";
        }

        private bool _disposed = false;

        public void Dispose()
        {
            if (!_disposed)
            {
                _counter--;
                UnityEventLogger.Log.DisposeUnityMessage("UnitOfWorkExampleTest " + _counter);
                _disposed = true;
            }
        }

        public string HelloFromUnitOfWorkExample()
        {
            UnityEventLogger.Log.LogUnityMessage("Hello UnitOfWorkExampleTest " + _counter);
            return "HelloFromUnitOfWorkExample";
        }
    }
}