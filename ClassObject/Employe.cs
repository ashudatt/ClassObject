using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
  public class Employe  // by default is internal
    {

        public string GetDay()
        {
            return DateTime.Now.DayOfWeek.ToString();

        }
    }
}
