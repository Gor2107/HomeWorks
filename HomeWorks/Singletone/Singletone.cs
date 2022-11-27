using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Singletone
    {
        private static volatile Singletone _instance;
        public static Singletone GetInstance() => _instance;
        Singletone() { }
       //Աշխատում է նաև ասինխրոն ծրագրավորման ժամանակ, քանի որ static կոնստրուկտորը
       //երաշխավորված է, որ կխատի միայն է անգմա
        static Singletone() => _instance = new Singletone();

    }
}
