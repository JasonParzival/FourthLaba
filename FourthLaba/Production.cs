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
        public static Random rnd = new Random();

        public int Ripeness = 0;
        // добавил метод
        public virtual String GetInfo()
        {
            var str = String.Format("\nСпелость: {0}", this.Ripeness);
            return str;
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
            str += base.GetInfo();
            str += String.Format("\nКоличество долек: {0}", this.SliceCount);
            str += String.Format("\nНаличие листика: {0}", this.WithLeaf);
            return str;
        }

        public static Mandarin Generate()
        {
            return new Mandarin
            {
                Ripeness = rnd.Next() % 100, // спелость от 0 до 100
                SliceCount = 5 + rnd.Next() % 20, // количество долек от 5 до 25
                WithLeaf = rnd.Next() % 2 == 0 // наличие листика true или false
            };
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
            str += base.GetInfo();
            str += String.Format("\nКоличество ягод: {0}", this.BerriesNumber);
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }

        public static Grapes Generate()
        {
            return new Grapes
            {
                Ripeness = rnd.Next() % 100, // спелость от 0 до 100
                BerriesNumber = 25 + rnd.Next() % 75, // количество ягод от 25 до 100
                type = (GrapesType)rnd.Next(2) // тип винограда
            };
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
            str += base.GetInfo();
            str += String.Format("\nКоличество косточек: {0}", this.BonesNumber);
            str += String.Format("\nНаличие полосок: {0}", this.HasStripes);
            return str;
        }

        public static Watermelon Generate()
        {
            return new Watermelon
            {
                Ripeness = rnd.Next() % 100, // спелость от 0 до 100
                BonesNumber = 250 + rnd.Next(250), // количество ягод от 250 до 500
                HasStripes = rnd.Next(2) == 0 // начличие полосок
            };
        }
    }
}