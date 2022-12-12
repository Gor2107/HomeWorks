using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2_3
{

    class ThreadWorker<TResult>
    {
        private TResult _result;
        public Func<object, TResult> func;
        public bool IsCompleted { get; private set; }
        public bool IsFaulted { get; private set; }
        public bool IsSuccess { get; private set; }
        public Exception Exception { get; private set; }
        public TResult Result
        {
            get
            {
                while (!IsCompleted)
                {
                    Thread.Sleep(150);
                }

                return IsSuccess == true && Exception == null ? _result : throw Exception;

            }
            private set { }
        }
        public ThreadWorker(Func<object, TResult> action)
        {
            this.func = action ?? throw new ArgumentNullException(nameof(action));
            this._result = default;
        }
        public void Start(object state)
        {
            var thread = new Thread(new ParameterizedThreadStart(Executer));
            thread.Start(state);
        }
        public void Executer(object state)
        {

            try
            {
                _result = func.Invoke(state);
                IsSuccess = true;
            }
            catch (Exception ex)
            {
                IsSuccess = false;
                IsFaulted = true;
                Exception = ex;
                throw;
            }
            finally
            {
                IsCompleted = true;
            }
        }

    }
}
