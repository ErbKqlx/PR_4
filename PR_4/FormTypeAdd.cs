using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_4
{
    public partial class FormTypeAdd : Form
    {
        private const string msgError = "Поле не может быть пустым";

        public FormTypeAdd()
        {
            InitializeComponent();
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            ValidateText();
        }

        private void ValidateText()
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
