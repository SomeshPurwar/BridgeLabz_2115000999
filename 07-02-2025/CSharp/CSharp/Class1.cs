using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Class1
    {
        public int number = 1;
        private int Id = 101;
        protected string password1 = "Somesh321";
        internal bool isValid = true;
        protected internal int secret = 98765;

        public int getId()
        {
            return Id;
        }
    }
}
