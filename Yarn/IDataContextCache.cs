﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yarn
{
    public interface IDataContextCache
    {
        void Initialize();
        object Get();
        void Set(object value);
        void Cleanup();
    }
}