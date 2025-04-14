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
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0: 
                        this.kinoList.Add(Movie.Generate());
                        break;
                    case 1: 
                        this.kinoList.Add(Series.Generate());
                        break;
                    case 2: 
                        this.kinoList.Add(TVShow.Generate());
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

            foreach (var kino in this.kinoList)
            {
                if (kino is Movie)
                {
                    moviesCount += 1;
                }
                else if (kino is Series)
                {
                    seriesCount += 1;
                }
                else if (kino is TVShow)
                {
                    TVshowsCount += 1;
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

            var fruit = this.kinoList[0];

            this.kinoList.RemoveAt(0);

            txtOut.Text = fruit.GetInfo();

            ShowInfo();
        }
    }
}
