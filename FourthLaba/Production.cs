using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLaba
{
    public enum ProductionTitle { 
        Wolverine, PussInBoots, Transformers, 
        Kitchen, DemonSlayer, KorolIShut, 
        ComedyClub, Minut60, GoodNightChildren 
    }; //Временное решение
    public enum MovieTiming { hour2, hour1minut30, hour2minut10 }; //Временное решение
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

    /*
     public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.bi:
                    typeVerbose = "(2)";
                    break;
                case MeasureType.oc:
                    typeVerbose = "(8)";
                    break;
                case MeasureType.de:
                    typeVerbose = "(10)";
                    break;
                case MeasureType.he:
                    typeVerbose = "(16)";
                    break;
            }
            return this.value + typeVerbose;
        }
     */

    public class Movie : Production
    {
        public MovieTiming Timing = MovieTiming.hour2; // Хронометраж
        public int AwardCount = 0; // Количество наград
        public static int[] AwardCounts =
        {
            5, 2, 4
        };

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
            int chose = rnd.Next(3);
            return new Movie
            {
                Title = (ProductionTitle)chose, 
                Timing = (MovieTiming)chose,
                AwardCount = AwardCounts[chose]
            };
        }
    }

    public class Series : Production
    {
        public int EpisodeCount = 0; // количество серий
        public int SeasonCount = 0; // кол-во сезонов
        public static int[] EpisodeCounts =
        {
            120, 63, 8
        };
        public static int[] SeasonCounts =
        {
            6, 5, 1
        };

        public override String GetInfo()
        {
            var str = "Я Сериал";
            str += base.GetInfo();
            str += String.Format("\nКоличество серий: {0}", this.EpisodeCount);
            str += String.Format("\nКоличество сезонов: {0}", this.SeasonCount);
            return str;
        }

        public static Series Generate()
        {
            int chose = rnd.Next(3);
            return new Series
            {
                Title = (ProductionTitle)chose + 3, 
                EpisodeCount = EpisodeCounts[chose],
                SeasonCount = SeasonCounts[chose]
            };
        }
    }

    public enum TVShowTiming { hour1, hour1minut10, minut20 }; //Временное решение
    public enum TVShowTime { FR2100, Budni2000, Budni2045 }; //Временное решение

    // Арбуз
    public class TVShow : Production
    {
        public TVShowTiming TimeCount = TVShowTiming.hour1; // продолжительность
        public TVShowTime Time = TVShowTime.FR2100; // эфирное время

        public override String GetInfo()
        {
            var str = "Я Телепередача";
            str += base.GetInfo();
            str += String.Format("\nПродолжительность: {0}", this.TimeCount);
            str += String.Format("\nЭфирное время: {0}", this.Time);
            return str;
        }

        public static TVShow Generate()
        {
            int chose = rnd.Next(3);
            return new TVShow
            {
                Title = (ProductionTitle)chose + 6, 
                TimeCount = (TVShowTiming)chose, 
                Time = (TVShowTime)chose 
            };
        }
    }
}