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
using System.Text.RegularExpressions;

namespace SomeView
{
    public partial class FormAddSystemUnit : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IComponentLogic logicC;
        private readonly ISystemUnitLogic logicS;
        public FormAddSystemUnit(IComponentLogic logicC, ISystemUnitLogic logicS)
        {
            InitializeComponent();
            this.logicC = logicC;
            this.logicS = logicS;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                
                logicS.CreateOrUpdate(new SystemUnitBindingModel
                {
                    Marka = textBoxName.Text,
                    Type = textBoxType.Text,                    
                    DateOfCreate = DateTime.Now,
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
