using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLaba
{
    //Придумать иерархию классов.
    //1. Должен быть 1 базовый класс, и 3 класса наследника.У базового класса должно быть,
    //как минимум одно свойство передающиеся по наследству остальным, у каждого из классов
    //наследников должно быть как минимум два уникальных свойства.
    //2. Реализовать эмулятор торгового автомата по образу и подобию как описано тут
    //3. Если вы обычно делаете желтые задачки, то в эмуляторе надо реализовать отображение
    //состояния очереди (чтобы было видно какие объекты в каком порядке сейчас находятся в автомате)
    //4. Если чувствуете склонность к красным, добавьте картинки для каждого типа объектов,
    //которые будут видны при выводе очереди

    //Для раздачи кино (рейтинг)
    // * Фильм(хронометраж, количество наград, тип (художественный, документальный и т.п.))
    // * Сериал(общее количество серий, количество сезонов)
    // * Телепередача(продолжительность, эфирное время)

    public class Production
    {
        public static Random rnd = new Random();

        public string Title = "";

        public virtual String GetInfo()
        {
            var str = String.Format("\nНазвание: {0}", this.Title);
            return str;
        }
    }

    public class Movie : Production
    {
        public string Timing = ""; // Хронометраж
        public int AwardCount = 0; // Количество наград

        public override String GetInfo()
        {
            var str = "Я фильм";
            str += base.GetInfo();
            str += String.Format("\nХронометраж: {0}", this.Timing);
            str += String.Format("\nКоличество наград: {0}", this.AwardCount);
            return str;
        }

        public static Movie Generate(string[] title, string[] timing, int[] count, int random)
        {
            int chose = rnd.Next(random);
            return new Movie
            {
                Title = title[chose], 
                Timing = timing[chose],
                AwardCount = count[chose]
            };
        }
    }

    public class Series : Production
    {
        public int EpisodeCount = 0; // количество серий
        public int SeasonCount = 0; // кол-во сезонов

        public override String GetInfo()
        {
            var str = "Я Сериал";
            str += base.GetInfo();
            str += String.Format("\nКоличество серий: {0}", this.EpisodeCount);
            str += String.Format("\nКоличество сезонов: {0}", this.SeasonCount);
            return str;
        }

        public static Series Generate(string[] title, int[] Ecount, int[] Scount, int random)
        {
            int chose = rnd.Next(random);
            return new Series
            {
                Title = title[chose], 
                EpisodeCount = Ecount[chose],
                SeasonCount = Scount[chose]
            };
        }
    }

    public class TVShow : Production
    {
        public string TimeCount = ""; // продолжительность
        public string Time = ""; // эфирное время

        public override String GetInfo()
        {
            var str = "Я Телепередача";
            str += base.GetInfo();
            str += String.Format("\nПродолжительность: {0}", this.TimeCount);
            str += String.Format("\nЭфирное время: {0}", this.Time);
            return str;
        }

        public static TVShow Generate(string[] title, string[] timecount, string[] time, int random)
        {
            int chose = rnd.Next(random);
            return new TVShow
            {
                Title = title[chose], 
                TimeCount = timecount[chose], 
                Time = time[chose]
            };
        }
    }
}