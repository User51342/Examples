using System.Collections.Generic;
using AdapterPatternExample.Adapter;
using AdapterPatternExample.Interfaces;
using AdapterPatternExample.Models;

namespace AdapterPatternExample.Renderer
{
    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapter _DataPatternRendererAdapter;

        public PatternRenderer() : this(new PatternRendererAdapter())
        {
            
        }

        public PatternRenderer(IDataPatternRendererAdapter _dataPatternRendererAdapter)
        {
            _DataPatternRendererAdapter = _dataPatternRendererAdapter;
        }
        public string ListPatterns(List<Pattern> patterns)
        {
            return _DataPatternRendererAdapter.ListPatterns(patterns);
        }
    }
}
