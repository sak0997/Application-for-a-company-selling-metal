namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=12345;database=base_Mysqld");

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.Show();
            this.Hide();
        }
    }
}
private void Form1_Load(object sender, EventArgs e)
{

}
    }
}
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapterManager.Fill(this.baseDataSet1.Сотрудники);

        }
        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            сотрудникиBindingSource.EndEdit();
            сотрудникиTableAdapterManager.Update(this.baseDataSet1);
        }
    }
}


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet2.Товары". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapterManager.Fill(this.baseDataSet2.Товары);

        }

        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            клиентыBindingSource.EndEdit();
            клиентыTableAdapterManager.Update(this.baseDataSet2);

        }
    }
}



namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet3.Услуги". При необходимости она может быть перемещена или удалена.
            this.подставщикиTableAdapterManager.Fill(this.baseDataSet3.Услуги);

        }

        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            услугиBindingSource.EndEdit();
            услугиTableAdapterManager.Update(this.baseDataSet3);
        }
    }
}


namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet4._Зарплата". При необходимости она может быть перемещена или удалена.
            this.зарплатаTableAdapterManager.Fill(this.baseDataSet4.зарплата);

        }

        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            товарыУслугиBindingSource.EndEdit();
            товары_УслугиTableAdapterManager.Update(this.baseDataSet4);
        }
    }
}


namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet5.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapterManager.Fill(this.baseDataSet5.Поставщики);

        }

        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            поставщикиBindingSource.EndEdit();
            поставщикиTableAdapterManager.Update(this.baseDataSet5);
        }
    }
}


namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet6.График отпусков". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapterManager.Fill(this.baseDataSet6.График отпусков);

        }

        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            график отпусковBindingSource.EndEdit();
            график отпусковTableAdapterManager.Update(this.baseDataSet6);
        }
    }
}

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet7.Деятельность предприятия". При необходимости она может быть перемещена или удалена.
            this.деятельность предприятияTableAdapterManager.Fill(this.baseDataSet7.Деятельность предприятия);

        }

        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            деятельность предприятияBindingSource.EndEdit();
            деятельность предприятияTableAdapterManager.Update(this.baseDataSet7);
        }
    }
