using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tester
{
    internal class ThreadWorker<TResult>
    {
        private TResult _result;
        Func<object, TResult> _func;
        public bool IsSuccess { get; set; }
        public bool IsFaulted { get; set; }
        public bool IsCompleted { get; set; }
        public Exception Exception { get; set; }
        public TResult Result
        {
            get
            {
                while (!IsCompleted) Thread.Sleep(50);
                return IsSuccess == true ? _result : throw Exception;
            }
        }
        public ThreadWorker(Func<object, TResult> func)
        {
            _func = func ?? throw new ArgumentException(nameof(func));
            _result = default;
        }
        public void Start(object state)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadExecution),state);
        }


        public void ThreadExecution(object state)
        {
                try
                {
                    var _result = _func.Invoke(state);
                    IsSuccess = true;
                    IsFaulted = false;
                }
                catch (Exception ex)
                {
                    IsSuccess = false;
                    IsFaulted = true;
                    Exception = ex;
                }
                finally
                {
                    IsCompleted = true;
                }
        }
    }
}
