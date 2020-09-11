using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using business.Interfaces;
using business.BindingModels;
using business.ViewModels;

namespace SomeView
{
    public partial class FormAddComponent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly IComponentLogic logic;
        private readonly ISystemUnitLogic systemUnitLogic;
        public FormAddComponent(IComponentLogic logic,ISystemUnitLogic systemUnitLogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.systemUnitLogic = systemUnitLogic;
        }

        private void FormAddPaper_Load(object sender, EventArgs e)
        {
                try
                {
                    var sysU = systemUnitLogic.Read(null);
                    if (sysU != null)
                    {
                        comboBoxSystemUnit.DisplayMember = "Marka";
                        comboBoxSystemUnit.ValueMember = "Id";
                        comboBoxSystemUnit.DataSource = sysU;
                        comboBoxSystemUnit.SelectedItem = null;
                    }
                    var view = logic.Read(new ComponentBindingModel { Id = id })?[0];
                    if (view != null)
                    {                        
                        textBoxName.Text = view.Name;
                        textBoxPrice.Text = view.Price.ToString();
                        textBoxFirm.Text = view.NameFirm;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPrice.Text, @"\d\,\d"))
            {
                MessageBox.Show("Неверная цена", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new ComponentBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Price = Convert.ToDecimal(textBoxPrice.Text),
                    NameFirm = textBoxFirm.Text,
                    SystemUnitId = Convert.ToInt32(comboBoxSystemUnit.SelectedValue),
                    DateCreate = DateTime.Now
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

