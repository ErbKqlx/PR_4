using System.ComponentModel;

namespace PR_4
{
    public partial class FormTypeOfPartnerAdd : Form
    {
        private const string msgError = "Поле не может быть пустым";
        public FormTypeOfPartnerAdd()
        {
            InitializeComponent();
            buttonSave.Enabled = false;
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
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
