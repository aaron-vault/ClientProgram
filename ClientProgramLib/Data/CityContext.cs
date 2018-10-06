using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProgramLib.Data
{
    public class CityContext
    {
        public readonly List<string> _cities = new List<string>
        {
            "Москва",
            "Санкт-Петербург",
            "Тюмень",
            "Челябинск",
            "Казань",
            "Екатеринбург",
            "Владимир",
            "Томск",
            "Владивосток"
        };

        public List<string> Cities
        {
            get { return _cities; }
        }
    }
}
