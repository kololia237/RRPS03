using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns
{
    //Singleton//якщо працівник зайнятий, то повертатиметься значення false
    public class FreeWorkers
    {
        private FreeWorkers() { }
        private static FreeWorkers _instance;
        private static readonly object _instanceLock = new object();

        public static FreeWorkers GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new FreeWorkers();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
        public string Value { get; set; }

        //public void SetWorker(bool state)
        //{
        //    if (state == true)
        //    {
        //        _instance.Value = "Вільний";
        //    }
        //    else _instance.Value = "Зайнятий";
        //}

    }
}
