using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLaba
{
    public enum ProductionTitle { Wolverine, PussInBoots, Transformers }; //Временное решение
    public class Production
    {
        public static Random rnd = new Random();

        public ProductionTitle Title = ProductionTitle.Wolverine;

        public virtual String GetInfo()
        {
            var str = String.Format("\nНазвание: {0}", this.Title);
            return str;
        }
    }

    public class Movie : Production
    {
        public string Timing = "0"; // Хронометраж
        public int AwardCount = 0; // Количество наград

        public override String GetInfo()
        {
            var str = "Я фильм";
            str += base.GetInfo();
            str += String.Format("\nХронометраж: {0}", this.Timing);
            str += String.Format("\nКоличество наград: {0}", this.AwardCount);
            return str;
        }

        public static Movie Generate()
        {
            return new Movie
            {
                Title = (ProductionTitle)rnd.Next(3), // спелость от 0 до 100
                Timing = "1:30 ч", // количество долек от 5 до 25
                AwardCount = rnd.Next() % 10  // Кол-во наград
            };
        }
    }

    // виды винограда
    public enum GrapesType { black, green };
    // собственно сам виноград
    public class Grapes : Production
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
                Title = (ProductionTitle)rnd.Next(3), // спелость от 0 до 100
                BerriesNumber = 25 + rnd.Next() % 75, // количество ягод от 25 до 100
                type = (GrapesType)rnd.Next(2) // тип винограда
            };
        }
    }

    // Арбуз
    public class Watermelon : Production
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
                Title = (ProductionTitle)rnd.Next(3), // спелость от 0 до 100
                BonesNumber = 250 + rnd.Next(250), // количество ягод от 250 до 500
                HasStripes = rnd.Next(2) == 0 // начличие полосок
            };
        }
    }
}