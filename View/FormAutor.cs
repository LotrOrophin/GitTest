using BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormAutor : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IAutorLogic autorLogic;
        public FormAutor(IAutorLogic autorLogic)
        {
            InitializeComponent();
            this.autorLogic = autorLogic;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddAutor>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = autorLogic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                //Program.ConfigGrid(logic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
