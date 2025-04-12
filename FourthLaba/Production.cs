using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace FourthLaba
{
    public class Fruit
    {
    }

    public class Mandarin : Fruit
    {
        public int Ripeness = 0; // спелость
        public int SliceCount = 0; // количество долек
        public bool WithLeaf = false; // наличие листика
    }

    // виды винограда
    public enum GrapesType { black, green };
    // собственно сам виноград
    public class Grapes : Fruit
    {
        public int Ripeness = 0;
        public int BerriesNumber = 0; // количество ягод
        public GrapesType type = GrapesType.black; // тип
    }

    // Арбуз
    public class Watermelon : Fruit
    {
        public int Ripeness = 0;
        public int BonesNumber = 0; // количество косточек
        public bool HasStripes = false; // полосатость арбуза
    }
}