using System.ComponentModel;

namespace PR_4
{
    public partial class FormTypeOfProductAdd : Form
    {
        private const string msgError = "Поле не может быть пустым";
        private const string convertError = "Не удается преобразовать строку в число";
        public FormTypeOfProductAdd()
        {
            InitializeComponent();
            buttonSave.Enabled = false;
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                if (!String.IsNullOrEmpty(textBoxCoefficient.Text))
                {
                    errorProvider.Clear();
                    buttonSave.Enabled = true;
                }
            }
        }

        private void TextBoxCoefficient_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxCoefficient.Text))
            {
                bool converted = Decimal.TryParse(textBoxCoefficient.Text, out decimal coefficient);
                if (!converted)
                {
                    errorProvider.SetError(textBoxCoefficient, convertError);
                    buttonSave.Enabled = false;
                }
                else
                {
                    errorProvider.Clear();
                    buttonSave.Enabled = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxCoefficient, msgError);
                buttonSave.Enabled = false;
            }
        }



    }
}
