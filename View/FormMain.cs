using business.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public readonly IBackUp backUpLogic;
        public FormMain(IBackUp backUp)
        {
            InitializeComponent();
            this.backUpLogic = backUp;
        }

        private void статьиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPapers>();
            form.ShowDialog();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAutor>();
            form.ShowDialog();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReport>();
            form.ShowDialog();
        }

        private void сохранитьВXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (backUpLogic != null)
                {
                    var folder = new FolderBrowserDialog();
                    if(folder.ShowDialog() == DialogResult.OK)
                    {
                        backUpLogic.saveSystemUnit(folder.SelectedPath);
                        backUpLogic.SaveComponent(folder.SelectedPath);
                    }
                    MessageBox.Show("Бекап создан", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
