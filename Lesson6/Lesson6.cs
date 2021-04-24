using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    [Serializable]
    class MyArrayDataExeption : Exception
    {
        int row, column;

        public MyArrayDataExeption(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
