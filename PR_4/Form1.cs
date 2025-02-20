using Microsoft.EntityFrameworkCore;
using PR_4.Models;
using System.ComponentModel;

namespace PR_4
{
    public partial class Form1 : Form
    {
        private PartnersContext db;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new PartnersContext();
            db.TypesOfPartners.Load();
            dataGridViewTypesOfPartners.DataSource = this.db.TypesOfPartners.Local
                .OrderBy(t => t.TypeOfPartner).ToList();

            dataGridViewTypesOfPartners.Columns["Id"].Visible = false;
            dataGridViewTypesOfPartners.Columns["Partners"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            db?.Dispose();
            db = null;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormTypeAdd formTypeAdd = new();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TypesOfPartner typesOfPartner = new();
            typesOfPartner.TypeOfPartner = formTypeAdd.textBoxTypeName.Text;

            db.TypesOfPartners.Add(typesOfPartner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            dataGridViewTypesOfPartners.DataSource = db.TypesOfPartners.Local
                .OrderBy(t => t.TypeOfPartner).ToList();
        }
    }
}
