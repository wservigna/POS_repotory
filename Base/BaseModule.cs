using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WSF.Modules;

namespace Base
{
    public class BaseModule : WSFModule
    {
        public override void Initialize()
        {
            //Este código se utiliza para registrar las clases del sistema de Dependency Injection usando convenciones.

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
        public class PrototipoConstantes
        {
            public const string LocalizationSourceName = "Hola";
        }
    }
}
