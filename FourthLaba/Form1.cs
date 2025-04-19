using System.Windows.Forms;

namespace FourthLaba
{
    //��������� �������� �������.
    //1. ������ ���� 1 ������� �����, � 3 ������ ����������.� �������� ������ ������ ����,
    //��� ������� ���� �������� ������������ �� ���������� ���������, � ������� �� �������
    //����������� ������ ���� ��� ������� ��� ���������� ��������.
    //2. ����������� �������� ��������� �������� �� ������ � ������� ��� ������� ���
    //3. ���� �� ������ ������� ������ �������, �� � ��������� ���� ����������� �����������
    //��������� ������� (����� ���� ����� ����� ������� � ����� ������� ������ ��������� � ��������)
    //4. ���� ���������� ���������� � �������, �������� �������� ��� ������� ���� ��������,
    //������� ����� ����� ��� ������ �������

    //��� ������� ���� (�������)
    // * �����(�����������, ���������� ������, ��� (��������������, �������������� � �.�.))
    // * ������(����� ���������� �����, ���������� �������)
    // * ������������(�����������������, ������� �����)

    public partial class Form1 : Form
    {
        List<Production> kinoList = new List<Production>();

        Image[] images = new Image[]
        {
            Image.FromFile("images/Movie.jpg"),
            Image.FromFile("images/Series.jpg"),
            Image.FromFile("images/TVShow.png")
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

            //������ ������� ��� ���������� ��������
            //��� ������
            string[] titleMovie = { 
                "��������", "��� � �������", "������������"
            };
            string[] timingMovie = { 
                "2 ����", "1 ��� � 30 �����", "2 ���� � 10 �����"
            };
            int[] countMovie = { 5, 2, 4 };

            //��� �������
            string[] titleSeries = {
                "�����", "������ ����������� �������", "������ � ���"
            };
            int[] EcountSeries = { 120, 63, 8 };
            int[] ScountSeries = { 6, 5, 1 };

            //��� ������
            string[] titleTVShow = {
                "Comedy Club", "60 �����", "��������� ����, ������!"
            };
            string[] timecountTVShow = {
                "1 ���", "1 ���", "20 �����"
            };
            string[] timeTVShow = {
                "�� �������� � 21:00", "�� ������ � 20:00", "�� ������ � 20:45"
            };

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0: 
                        this.kinoList.Add(Movie.Generate(titleMovie, timingMovie, countMovie, 3));
                        txtTurnLine.Text += "�����\n";
                        break;
                    case 1: 
                        this.kinoList.Add(Series.Generate(titleSeries, EcountSeries, ScountSeries, 3));
                        txtTurnLine.Text += "������\n";
                        break;
                    case 2: 
                        this.kinoList.Add(TVShow.Generate(titleTVShow, timecountTVShow, timeTVShow, 3));
                        txtTurnLine.Text += "������������\n";
                        break;
                        // ��������� ������ ����� ������������
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
                    txtTurnLine.Text += "�����\n";
                }
                else if (kino is Series)
                {
                    seriesCount += 1;
                    txtTurnLine.Text += "������\n";
                }
                else if (kino is TVShow)
                {
                    TVshowsCount += 1;
                    txtTurnLine.Text += "������������\n";
                }
            }

            txtInfo.Text = "�����\t������\t������������";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", moviesCount, seriesCount, TVshowsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.kinoList.Count == 0)
            {
                txtOut.Text = "����� Q_Q";
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
