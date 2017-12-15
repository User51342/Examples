using System.Collections.Generic;
using AdapterPatternExample.Models;

namespace AdapterPatternExample.Interfaces
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}
