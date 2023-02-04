using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CleanCodeDemo
    {
        int exchangeRate;

        public bool changename(List<string> name)
        {
            bool fl = true;
            foreach (var n in name)
            {
                if (fl)
                {
                    if (GoesOrNoGoes(n))
                    {
                        fl = false;
                    }
                }
            }
            return fl;
        }
        private bool GoesOrNoGoes(string emp)
        {
            return string.IsNullOrEmpty(emp);
        }

    }
}
