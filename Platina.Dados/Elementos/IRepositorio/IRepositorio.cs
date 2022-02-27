using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platina.Dados.Elementos.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
