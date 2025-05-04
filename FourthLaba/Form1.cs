using System.Windows.Forms;

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

    public partial class Form1 : Form
    {
        List<Production> kinoList = new List<Production>();

        Image[] images = new Image[]
        {
            Image.FromFile("images/Movie.jpg"),
            Image.FromFile("images/Series.jpg"),
            Image.FromFile("images/TVShow.png"),
        };

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

            if (kinoListik is Movie)
            {
                pictureBox.Image = images[0];
            }
            else if (kinoListik is Series)
            {
                pictureBox.Image = images[1];
            }
            else if (kinoListik is TVShow)
            {
                pictureBox.Image = images[2];
            }

            this.kinoList.RemoveAt(0);

            txtOut.Text = kinoListik.GetInfo();

            ShowInfo();
        }
    }
}
