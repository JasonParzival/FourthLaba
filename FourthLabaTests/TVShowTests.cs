using Microsoft.VisualStudio.TestTools.UnitTesting;
using FourthLaba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLaba.Tests
{
    [TestClass()]
    public class TVShowTests
    {
        [TestMethod()]
        public void MovieTest()
        {
            List<Production> kinoList = new List<Production>();

            string[] titleMovie = {
                "Росомаха", "Кот в сапогах", "Трансформеры"
            };
            string[] timingMovie = {
                "2 часа", "1 час и 30 минут", "2 часа и 10 минут"
            };
            int[] countMovie = { 5, 2, 4 };

            kinoList.Add(Movie.Generate(titleMovie, timingMovie, countMovie, 1));

            String message = kinoList[0].GetInfo();

            Assert.AreEqual("Я фильм\nНазвание: Росомаха\nХронометраж: 2 часа\nКоличество наград: 5", message);
        }

        [TestMethod()]
        public void SeriesTest()
        {
            List<Production> kinoList = new List<Production>();

            string[] titleSeries = {
                "Кухня", "Клинок Рассекающий Демонов", "Король и Шут"
            };
            int[] EcountSeries = { 120, 63, 8 };
            int[] ScountSeries = { 6, 5, 1 };

            kinoList.Add(Series.Generate(titleSeries, EcountSeries, ScountSeries, 1));

            String message = kinoList[0].GetInfo();

            Assert.AreEqual("Я Сериал\nНазвание: Кухня\nКоличество серий: 120\nКоличество сезонов: 6", message);
        }

        [TestMethod()]
        public void TVShowTest()
        {
            List<Production> kinoList = new List<Production>();

            string[] titleTVShow = {
                "Comedy Club", "60 минут", "Спокойной ночи, малыши!"
            };
            string[] timecountTVShow = {
                "1 час", "1 час", "20 минут"
            };
            string[] timeTVShow = {
                "По пятницам в 21:00", "По будням в 20:00", "По будням в 20:45"
            };

            kinoList.Add(TVShow.Generate(titleTVShow, timecountTVShow, timeTVShow, 1));

            String message = kinoList[0].GetInfo();

            Assert.AreEqual("Я Телепередача\nНазвание: Comedy Club\nПродолжительность: 1 час\nЭфирное время: По пятницам в 21:00", message);
        }
    }
}