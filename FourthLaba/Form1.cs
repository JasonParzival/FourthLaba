namespace FourthLaba
{
    public partial class Form1 : Form
    {
        // �������, ������ ������ ��� ��������� ��� Fruit
        List<Production> fruitsList = new List<Production>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // ����, ����� ��� ������� ���������� ���-�� ������������ �� �����
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.fruitsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0: // ���� 0, �� ��������
                        this.fruitsList.Add(Movie.Generate());
                        break;
                    case 1: // ���� 1 �� ��������
                        this.fruitsList.Add(Series.Generate());
                        break;
                    case 2: // ���� 2 �� �����
                        this.fruitsList.Add(TVShow.Generate());
                        break;
                        // ��������� ������ ����� ������������
                }
            }
            ShowInfo(); // � ����
        }

        // ������� ������� ���������� � ���������� ������� �� �����
        private void ShowInfo()
        {
            // ������� �������� ��� ������ ���
            int mandarinsCount = 0;
            int grapesCount = 0;
            int watermellonsCount = 0;

            // ��������� �� ����� ������
            foreach (var fruit in this.fruitsList)
            {
                // �������, ��� � ������ � ��� ����� ������,
                // �� ���� ������� ���� Fruit
                // ������� ����� ��������� ����� ������ �����
                // �� � ������ ������ ����������, �� ���������� �������� ����� is
                if (fruit is Movie) // �������� ����� ��� ������ ������, "���� fruit ���� ��������"
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

            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "�����\t������\t������������"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, watermellonsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // ���� ������ ����, �� ������� ��� ����� � ������ �� �������
            if (this.fruitsList.Count == 0)
            {
                txtOut.Text = "����� Q_Q";
                return;
            }

            // ����� ������ �����
            var fruit = this.fruitsList[0];
            // ��� ��� �� ����������, ������ ��� �� ����� ���� �������� ��������� �� ������� � ������
            // ��� �������� ��������� ������, ��� ��� ���� ������ �������, ����� ��� ���
            this.fruitsList.RemoveAt(0);

            // ������� ���� if`�
            txtOut.Text = fruit.GetInfo();

            // ������� ���������� � ���������� ������ �� �����
            ShowInfo();
        }
    }
}
