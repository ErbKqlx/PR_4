using Microsoft.EntityFrameworkCore;
using PR_4.Models;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PR_4
{
    public partial class Form1 : Form
    {
        private PartnersContext db;
        private DataGridView dataGridView;

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

            SetSortedData();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            int index = dataGridView.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridView[0, index].Value.ToString(), out id);
            if (!converted)
                return;


            TypesOfPartner typesOfPartner = db.TypesOfPartners.Find(id);


            FormTypeAdd formTypeAdd = new();
            formTypeAdd.textBoxTypeName.Text = typesOfPartner.TypeOfPartner;

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            typesOfPartner.TypeOfPartner = formTypeAdd.textBoxTypeName.Text;

            db.SaveChanges();
            MessageBox.Show("Редактирование объекта завершено");

            SetSortedData();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить этот объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridView.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridView[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypesOfPartner typesOfPartner = db.TypesOfPartners.Find(id);
            db.TypesOfPartners.Remove(typesOfPartner);

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

        private void SelectDataGridView(object sender, MouseEventArgs e)
        {
            dataGridView = sender as DataGridView;
        }



        //private Object CreateObject(Object obj)
        //{
        //    if (obj == db.TypesOfPartners)
        //    {

        //    }
        //}
    }
}
