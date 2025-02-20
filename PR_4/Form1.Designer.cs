namespace PR_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            dataGridViewTypesOfPartners = new DataGridView();
            dataGridViewTypesOfProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfPartners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 97);
            panel1.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.White;
            buttonUpdate.Location = new Point(200, 25);
            buttonUpdate.Margin = new Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(164, 52);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Location = new Point(382, 25);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(164, 52);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(19, 23);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(164, 52);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // dataGridViewTypesOfPartners
            // 
            dataGridViewTypesOfPartners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTypesOfPartners.BackgroundColor = Color.White;
            dataGridViewTypesOfPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypesOfPartners.Dock = DockStyle.Left;
            dataGridViewTypesOfPartners.Location = new Point(10, 107);
            dataGridViewTypesOfPartners.MultiSelect = false;
            dataGridViewTypesOfPartners.Name = "dataGridViewTypesOfPartners";
            dataGridViewTypesOfPartners.ReadOnly = true;
            dataGridViewTypesOfPartners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypesOfPartners.Size = new Size(560, 496);
            dataGridViewTypesOfPartners.TabIndex = 1;
            dataGridViewTypesOfPartners.MouseDown += SelectDataGridView;
            // 
            // dataGridViewTypesOfProducts
            // 
            dataGridViewTypesOfProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTypesOfProducts.BackgroundColor = Color.White;
            dataGridViewTypesOfProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypesOfProducts.Dock = DockStyle.Right;
            dataGridViewTypesOfProducts.Location = new Point(576, 107);
            dataGridViewTypesOfProducts.MultiSelect = false;
            dataGridViewTypesOfProducts.Name = "dataGridViewTypesOfProducts";
            dataGridViewTypesOfProducts.ReadOnly = true;
            dataGridViewTypesOfProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypesOfProducts.Size = new Size(581, 496);
            dataGridViewTypesOfProducts.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1167, 613);
            Controls.Add(dataGridViewTypesOfProducts);
            Controls.Add(dataGridViewTypesOfPartners);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfPartners).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonAdd;
        private DataGridView dataGridViewTypesOfPartners;
        private DataGridView dataGridViewTypesOfProducts;
    }
}
