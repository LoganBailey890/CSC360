using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorConsole.Interface
{
    public interface IBaseItem
    {
        bool HasTitle();
        string? Title();
    }
}
