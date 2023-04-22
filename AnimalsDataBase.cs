using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examin_typa
{
    public class AnimalsDataBase
    {
        internal List<Animals> zivotnie { get; private set; }

        public void InInitialize()
        {
            zivotnie = new List<Animals>
            {
                new Animals("Животное 1", "Абакан", 28),
                new Animals("Животное 2", "Минусинкс", 54),
                new Animals("Животное 3", "Красноярск", 7)

            };

        }
    }
}
