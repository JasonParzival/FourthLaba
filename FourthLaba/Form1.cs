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
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        this.fruitsList.Add(Mandarin.Generate());
                        break;
                    case 1: // если 1 то виноград
                        this.fruitsList.Add(Grapes.Generate());
                        break;
                    case 2: // если 2 то арбуз
                        this.fruitsList.Add(Watermelon.Generate());
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
