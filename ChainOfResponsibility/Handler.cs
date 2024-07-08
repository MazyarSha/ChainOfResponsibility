using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler Successor { get; set; }
        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }
        public abstract void HandleRequest(int request);
    }
}
