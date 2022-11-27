using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.pattern2
{
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            Exam();
            GetDocument();
        }
        protected abstract void Enter();
        protected abstract void Study();
        protected abstract void Exam();
        protected abstract void GetDocument();
    }
    class School : Education
    {
        protected override void Enter()=>Console.WriteLine("Entered School");
        protected override void Study() => Console.WriteLine("studied 10 years");
        protected override void Exam() => Console.WriteLine("passed  school exams");
        protected override void GetDocument() => Console.WriteLine("recieved atestat");

    }
    class HighUniversity : Education
    {
        protected override void Enter() => Console.WriteLine("Entered High University");
        protected override void Study() => Console.WriteLine("studied 5 years");
        protected override void Exam() => Console.WriteLine("passed  High University exams");
        protected override void GetDocument() => Console.WriteLine("recieved diploma");

    }
}
