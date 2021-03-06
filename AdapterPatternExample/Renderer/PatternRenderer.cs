﻿using System.Collections.Generic;
using AdapterPatternExample.Adapter;
using AdapterPatternExample.Interfaces;
using AdapterPatternExample.Models;

namespace AdapterPatternExample.Renderer
{
    /// <summary>
    /// This is new client which needs the adapter to use DataRenderer.
    /// </summary>
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
