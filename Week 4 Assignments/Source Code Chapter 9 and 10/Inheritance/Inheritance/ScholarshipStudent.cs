using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class ScholarshipStudent:Student
    {
        public override int Credits
        {
            set
            {
                credits = value;
                tuition = 0;
            }
        }
    }
}
