using Microsoft.EntityFrameworkCore;
using PR_4.Models;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PR_4
{
    public partial class Form1 : Form
    {
        private PartnersContext db;
        //short id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new PartnersContext();

            db.TypesOfPartners.Load();
            db.TypesOfProducts.Load();

            SetSortedData();

            dataGridViewTypesOfPartners.Columns["Id"].Visible = false;
            dataGridViewTypesOfPartners.Columns["Partners"].Visible = false;

            dataGridViewTypesOfProducts.Columns["Id"].Visible = false;
            dataGridViewTypesOfProducts.Columns["Products"].Visible = false;


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            db?.Dispose();
            db = null;
        }

        private void ButtonAddTypeOfPartner_Click(object sender, EventArgs e)
        {
            FormTypeOfPartnerAdd formTypeAdd = new();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TypesOfPartner typeOfPartner = new();
            typeOfPartner.TypeOfPartner = formTypeAdd.textBoxTypeName.Text;
            db.TypesOfPartners.Add(typeOfPartner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            SetSortedData();
        }

        private void ButtonAddTypeOfProduct_Click(object sender, EventArgs e)
        {
            FormTypeOfProductAdd formTypeAdd = new();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            TypesOfProduct typeOfProduct = new();
            typeOfProduct.TypeOfProduct = formTypeAdd.textBoxTypeName.Text;
            typeOfProduct.TypeCoefficient = Decimal.Parse(formTypeAdd.textBoxCoefficient.Text);
            db.TypesOfProducts.Add(typeOfProduct);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            SetSortedData();
        }

        private void ButtonUpdateTypeOfPartner_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesOfPartners.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypesOfPartners.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypesOfPartners[0, index].Value.ToString(), out id);
            if (!converted)
                return;


            TypesOfPartner typeOfPartner = db.TypesOfPartners.Find(id);


            FormTypeOfPartnerAdd formTypeAdd = new();
            formTypeAdd.textBoxTypeName.Text = typeOfPartner.TypeOfPartner;

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            typeOfPartner.TypeOfPartner = formTypeAdd.textBoxTypeName.Text;

            db.SaveChanges();
            MessageBox.Show("Редактирование объекта завершено");

            SetSortedData();
        }

        private void ButtonUpdateTypeOfProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesOfProducts.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypesOfProducts.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypesOfProducts[0, index].Value.ToString(), out id);
            if (!converted)
                return;


            TypesOfProduct typeOfProduct = db.TypesOfProducts.Find(id);


            FormTypeOfProductAdd formTypeAdd = new();
            formTypeAdd.textBoxTypeName.Text = typeOfProduct.TypeOfProduct;
            formTypeAdd.textBoxCoefficient.Text = typeOfProduct.TypeCoefficient.ToString();

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            typeOfProduct.TypeOfProduct = formTypeAdd.textBoxTypeName.Text;
            typeOfProduct.TypeCoefficient = Decimal.Parse(formTypeAdd.textBoxCoefficient.Text);

            db.SaveChanges();
            MessageBox.Show("Редактирование объекта завершено");

            SetSortedData();
        }

        private void ButtonDeleteTypeOfPartner_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesOfPartners.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить этот объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewTypesOfPartners.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypesOfPartners[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypesOfPartner typesOfPartner = db.TypesOfPartners.Find(id);
            db.TypesOfPartners.Remove(typesOfPartner);

            db.SaveChanges();
            MessageBox.Show("Объект удален");

            SetSortedData();
        }

        private void ButtonDeleteTypeOfProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesOfProducts.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить этот объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewTypesOfProducts.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypesOfProducts[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypesOfProduct typeOfProduct = db.TypesOfProducts.Find(id);
            db.TypesOfProducts.Remove(typeOfProduct);

            db.SaveChanges();
            MessageBox.Show("Объект удален");

            SetSortedData();
        }

        private void SetSortedData()
        {
            dataGridViewTypesOfPartners.DataSource = db.TypesOfPartners.Local
                .OrderBy(t => t.TypeOfPartner).ToList();

            dataGridViewTypesOfProducts.DataSource = db.TypesOfProducts.Local
                .OrderBy(t => t.TypeOfProduct).ToList();
        }
    }
}
