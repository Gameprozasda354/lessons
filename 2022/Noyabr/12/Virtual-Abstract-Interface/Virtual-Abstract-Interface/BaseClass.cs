using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Abstract_Interface
{
    public class BaseClass
    {
        #region Create and use virtual methods
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public virtual void ShowText(string text)
        {
            Console.WriteLine(text);
        }
        #endregion
    }
}
