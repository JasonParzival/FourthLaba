namespace FourthLaba
{
    public partial class Form1 : Form
    {
        // ДОБАВИЛ, важный момент что указываем тип Fruit
        List<Production> fruitsList = new List<Production>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // СЮДА, чтобы при запуске приложения что-то показывалось на форме
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.fruitsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        this.fruitsList.Add(Movie.Generate());
                        break;
                    case 1: // если 1 то виноград
                        this.fruitsList.Add(Series.Generate());
                        break;
                    case 2: // если 2 то арбуз
                        this.fruitsList.Add(TVShow.Generate());
                        break;
                        // появление других чисел маловероятно
                }
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
                if (fruit is Movie) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    mandarinsCount += 1;
                }
                else if (fruit is Series)
                {
                    grapesCount += 1;
                }
                else if (fruit is TVShow)
                {
                    watermellonsCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Фильм\tСериал\tТелепередача"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, watermellonsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.fruitsList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            // взяли первый фрукт
            var fruit = this.fruitsList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.fruitsList.RemoveAt(0);

            // ЗАМЕНИЛ НАШИ if`ы
            txtOut.Text = fruit.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }
    }
}
