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
        public int Ripeness = 0;
        // добавил метод
        public virtual String GetInfo()
        {
            return "Я фрукт";
        }
    }

    public class Mandarin : Fruit
    {
        //public int Ripeness = 0; // спелость
        public int SliceCount = 0; // количество долек
        public bool WithLeaf = false; // наличие листика

        // А ТУТ ПЕРЕОПРЕДЕЛИЛ МЕТОД
        public override String GetInfo()
        {
            var str = "Я мандарин";
            str += String.Format("\nСпелость{0}", this.Ripeness);
            return str;
        }
    }

    // виды винограда
    public enum GrapesType { black, green };
    // собственно сам виноград
    public class Grapes : Fruit
    {
        //public int Ripeness = 0;
        public int BerriesNumber = 0; // количество ягод
        public GrapesType type = GrapesType.black; // тип

        // ДОБАВИЛ ПЕРЕОПРЕДЛЕНИЕ
        public override String GetInfo()
        {
            var str = "Я Виноград";
            str += String.Format("\nСпелость{0}", this.Ripeness);
            return str;
        }
    }

    // Арбуз
    public class Watermelon : Fruit
    {
        //public int Ripeness = 0;
        public int BonesNumber = 0; // количество косточек
        public bool HasStripes = false; // полосатость арбуза

        // ДОБАВИЛ ПЕРЕОПРЕДЛЕНИЕ
        public override String GetInfo()
        {
            var str = "Я Арбуз";
            str += String.Format("\nСпелость{0}", this.Ripeness);
            return str;
        }
    }
}