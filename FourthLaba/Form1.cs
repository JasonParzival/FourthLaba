namespace FourthLaba
{
    public partial class Form1 : Form
    {
        // ДОБАВИЛ, важный момент что указываем тип Fruit
        List<Fruit> fruitsList = new List<Fruit>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // СЮДА, чтобы при запуске приложения что-то показывалось на форме
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.fruitsList.Clear();
            for (var i = 0; i < 10; ++i)
            {
                // классно да, список типа Fruit, а кладем Mandarin
                // вот она: "сила наследования"
                this.fruitsList.Add(new Mandarin());
            }
            ShowInfo(); // И СЮДА
        }

        // функция выводит информацию о количестве фруктов на форму
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int mandarinsCount = 0;
            int grapesCount = 0;
            int watermellonsCount = 0;

            // пройдемся по всему списку
            foreach (var fruit in this.fruitsList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (fruit is Mandarin) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    mandarinsCount += 1;
                }
                else if (fruit is Grapes)
                {
                    grapesCount += 1;
                }
                else if (fruit is Watermelon)
                {
                    watermellonsCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Мндрн\tВнгрд\tАрбуз"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, watermellonsCount);
        }
    }
}
