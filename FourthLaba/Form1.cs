namespace FourthLaba
{
    public partial class Form1 : Form
    {
        List<Production> kinoList = new List<Production>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.kinoList.Clear();
            txtTurnLine.Text = "";
            var rnd = new Random();

            //Создаём массивы для присвоения значений
            //Для фильма
            string[] titleMovie = { 
                "Росомаха", "Кот в сапогах", "Трансформеры"
            };
            string[] timingMovie = { 
                "2 часа", "1 час и 30 минут", "2 часа и 10 минут"
            };
            int[] countMovie = { 5, 2, 4 };

            //Для сериала
            string[] titleSeries = {
                "Кухня", "Клинок Рассекающий Демонов", "Король и Шут"
            };
            int[] EcountSeries = { 120, 63, 8 };
            int[] ScountSeries = { 6, 5, 1 };

            //Для фильма
            string[] titleTVShow = {
                "Comedy Club", "60 минут", "Спокойной ночи, малыши!"
            };
            string[] timecountTVShow = {
                "1 час", "1 час", "20 минут"
            };
            string[] timeTVShow = {
                "По пятницам в 21:00", "По будням в 20:00", "По будням в 20:45"
            };

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0: 
                        this.kinoList.Add(Movie.Generate(titleMovie, timingMovie, countMovie, 3));
                        txtTurnLine.Text += "Фильм\n";
                        break;
                    case 1: 
                        this.kinoList.Add(Series.Generate(titleSeries, EcountSeries, ScountSeries, 3));
                        txtTurnLine.Text += "Сериал\n";
                        break;
                    case 2: 
                        this.kinoList.Add(TVShow.Generate(titleTVShow, timecountTVShow, timeTVShow, 3));
                        txtTurnLine.Text += "Телепередача\n";
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int moviesCount = 0;
            int seriesCount = 0;
            int TVshowsCount = 0;
            txtTurnLine.Text = "";

            foreach (var kino in this.kinoList)
            {
                if (kino is Movie)
                {
                    moviesCount += 1;
                    txtTurnLine.Text += "Фильм\n";
                }
                else if (kino is Series)
                {
                    seriesCount += 1;
                    txtTurnLine.Text += "Сериал\n";
                }
                else if (kino is TVShow)
                {
                    TVshowsCount += 1;
                    txtTurnLine.Text += "Телепередача\n";
                }
            }

            txtInfo.Text = "Фильм\tСериал\tТелепередача";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", moviesCount, seriesCount, TVshowsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.kinoList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var kinoListik = this.kinoList[0];

            this.kinoList.RemoveAt(0);

            txtOut.Text = kinoListik.GetInfo();

            ShowInfo();
        }
    }
}
