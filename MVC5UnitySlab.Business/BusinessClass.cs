using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5UnitySlab.Business.Logging;
using MVC5UnitySlab.Business.Attributes;

namespace MVC5UnitySlab.Business
{
    [UnityIoCTransientLifetime]
    public class BusinessClass : IBusinessClass
    {
        private IUnitOfWorkExample _unitOfWorkExample;

        public BusinessClass(IUnitOfWorkExample unitOfWorkExample)
        {
            _unitOfWorkExample = unitOfWorkExample;
            UnityEventLogger.Log.CreateUnityMessage("BusinessClass");
        }

        private bool _disposed = false;

        public string Hello()
        {
            return _unitOfWorkExample.HelloFromUnitOfWorkExample();
        }

        public void Dispose()
        {
            _unitOfWorkExample.Dispose();
            UnityEventLogger.Log.DisposeUnityMessage("BusinessClass");
            if (!_disposed)
            {
                _disposed = true;
            }
        }
    }
}