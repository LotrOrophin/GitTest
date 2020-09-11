using BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPapers : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPaperLogic logic;
        public FormPapers(IPaperLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddPaper>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                //Program.ConfigGrid(logic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormPapers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
