namespace FourthLaba
{
    public partial class Form1 : Form
    {
        // �������, ������ ������ ��� ��������� ��� Fruit
        List<Fruit> fruitsList = new List<Fruit>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // ����, ����� ��� ������� ���������� ���-�� ������������ �� �����
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.fruitsList.Clear();
            for (var i = 0; i < 10; ++i)
            {
                // ������� ��, ������ ���� Fruit, � ������ Mandarin
                // ��� ���: "���� ������������"
                this.fruitsList.Add(new Mandarin());
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
                if (fruit is Mandarin) // �������� ����� ��� ������ ������, "���� fruit ���� ��������"
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

            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "�����\t�����\t�����"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, watermellonsCount);
        }
    }
}
