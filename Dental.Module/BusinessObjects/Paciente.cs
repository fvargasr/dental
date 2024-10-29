using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Module.BusinessObjects
{
    [NavigationItem("Default")]
    public class Paciente : BaseObject
    {
        public virtual string Nombre { get; set; }
        public virtual string Edad { get; set; }
        public virtual string Cedula { get; set; }
        public virtual string Sexo { get; set; }
        public virtual string Seguro { get; set; }
        public virtual string NoAfiliado { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string MotivoDeConsulta { get; set; }
    }
}
