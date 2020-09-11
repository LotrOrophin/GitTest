using business.BindingModels;
using business.Interfaces;
using business.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormAddAutor : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPaperLogic logicP;
        private readonly IAutorLogic logicA;
        public FormAddAutor(IPaperLogic logicP, IAutorLogic logicA)
        {
            InitializeComponent();
            this.logicA = logicA;
            this.logicP = logicP;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                logicA.CreateOrUpdate(new AutorBindingModel
                {
                    FIO = textBoxName.Text,
                    Email = textBoxEmail.Text,
                    PaperId = Convert.ToInt32(ComboBoxPaper.SelectedValue),
                    DateOfCreate = dateTimePicker.Value,
                    PlaceWork = textBoxPlase.Text,
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void FormAddAutor_Load(object sender, EventArgs e)
        {
            try
            {
                List<PaperViewModel> list = logicP.Read(null);
                if (list != null)
                {
                    ComboBoxPaper.DisplayMember = "Name";
                    ComboBoxPaper.ValueMember = "Id";
                    ComboBoxPaper.DataSource = list;
                    ComboBoxPaper.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
