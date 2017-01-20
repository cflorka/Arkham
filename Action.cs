using System;
using System.Collections.Generic;

namespace Arkham
{
    internal abstract class Action
    {
        public bool allowed;
        
        public abstract void Execute();
    }
}