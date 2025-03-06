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
            buttonDeleteTypeOfProduct = new Button();
            buttonUpdateTypeOfProduct = new Button();
            buttonAddTypeOfProduct = new Button();
            buttonUpdateTypeOfPartner = new Button();
            buttonDeleteTypeOfPartner = new Button();
            buttonAddTypeOfPartner = new Button();
            dataGridViewTypesOfPartners = new DataGridView();
            dataGridViewTypesOfProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfPartners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDeleteTypeOfProduct);
            panel1.Controls.Add(buttonUpdateTypeOfProduct);
            panel1.Controls.Add(buttonAddTypeOfProduct);
            panel1.Controls.Add(buttonUpdateTypeOfPartner);
            panel1.Controls.Add(buttonDeleteTypeOfPartner);
            panel1.Controls.Add(buttonAddTypeOfPartner);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 97);
            panel1.TabIndex = 0;
            // 
            // buttonDeleteTypeOfProduct
            // 
            buttonDeleteTypeOfProduct.BackColor = Color.White;
            buttonDeleteTypeOfProduct.Location = new Point(949, 25);
            buttonDeleteTypeOfProduct.Margin = new Padding(5);
            buttonDeleteTypeOfProduct.Name = "buttonDeleteTypeOfProduct";
            buttonDeleteTypeOfProduct.Size = new Size(164, 64);
            buttonDeleteTypeOfProduct.TabIndex = 6;
            buttonDeleteTypeOfProduct.Text = "Удалить тип продукции";
            buttonDeleteTypeOfProduct.UseVisualStyleBackColor = false;
            buttonDeleteTypeOfProduct.Click += ButtonDeleteTypeOfProduct_Click;
            // 
            // buttonUpdateTypeOfProduct
            // 
            buttonUpdateTypeOfProduct.BackColor = Color.White;
            buttonUpdateTypeOfProduct.Location = new Point(765, 25);
            buttonUpdateTypeOfProduct.Margin = new Padding(5);
            buttonUpdateTypeOfProduct.Name = "buttonUpdateTypeOfProduct";
            buttonUpdateTypeOfProduct.Size = new Size(165, 64);
            buttonUpdateTypeOfProduct.TabIndex = 5;
            buttonUpdateTypeOfProduct.Text = "Редактировать тип продукции";
            buttonUpdateTypeOfProduct.UseVisualStyleBackColor = false;
            buttonUpdateTypeOfProduct.Click += ButtonUpdateTypeOfProduct_Click;
            // 
            // buttonAddTypeOfProduct
            // 
            buttonAddTypeOfProduct.BackColor = Color.White;
            buttonAddTypeOfProduct.Location = new Point(582, 25);
            buttonAddTypeOfProduct.Margin = new Padding(5);
            buttonAddTypeOfProduct.Name = "buttonAddTypeOfProduct";
            buttonAddTypeOfProduct.Size = new Size(164, 64);
            buttonAddTypeOfProduct.TabIndex = 4;
            buttonAddTypeOfProduct.Text = "Добавить тип продукции";
            buttonAddTypeOfProduct.UseVisualStyleBackColor = false;
            buttonAddTypeOfProduct.Click += ButtonAddTypeOfProduct_Click;
            // 
            // buttonUpdateTypeOfPartner
            // 
            buttonUpdateTypeOfPartner.BackColor = Color.White;
            buttonUpdateTypeOfPartner.Location = new Point(200, 25);
            buttonUpdateTypeOfPartner.Margin = new Padding(5);
            buttonUpdateTypeOfPartner.Name = "buttonUpdateTypeOfPartner";
            buttonUpdateTypeOfPartner.Size = new Size(164, 64);
            buttonUpdateTypeOfPartner.TabIndex = 3;
            buttonUpdateTypeOfPartner.Text = "Редактировать тип партнера";
            buttonUpdateTypeOfPartner.UseVisualStyleBackColor = false;
            buttonUpdateTypeOfPartner.Click += ButtonUpdateTypeOfPartner_Click;
            // 
            // buttonDeleteTypeOfPartner
            // 
            buttonDeleteTypeOfPartner.BackColor = Color.White;
            buttonDeleteTypeOfPartner.Location = new Point(382, 25);
            buttonDeleteTypeOfPartner.Margin = new Padding(5);
            buttonDeleteTypeOfPartner.Name = "buttonDeleteTypeOfPartner";
            buttonDeleteTypeOfPartner.Size = new Size(164, 64);
            buttonDeleteTypeOfPartner.TabIndex = 2;
            buttonDeleteTypeOfPartner.Text = "Удалить тип партнера";
            buttonDeleteTypeOfPartner.UseVisualStyleBackColor = false;
            buttonDeleteTypeOfPartner.Click += ButtonDeleteTypeOfPartner_Click;
            // 
            // buttonAddTypeOfPartner
            // 
            buttonAddTypeOfPartner.BackColor = Color.White;
            buttonAddTypeOfPartner.Location = new Point(19, 23);
            buttonAddTypeOfPartner.Margin = new Padding(5);
            buttonAddTypeOfPartner.Name = "buttonAddTypeOfPartner";
            buttonAddTypeOfPartner.Size = new Size(164, 66);
            buttonAddTypeOfPartner.TabIndex = 0;
            buttonAddTypeOfPartner.Text = "Добавить тип партнера";
            buttonAddTypeOfPartner.UseVisualStyleBackColor = false;
            buttonAddTypeOfPartner.Click += ButtonAddTypeOfPartner_Click;
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
            Text = "Типы партнеров и продукции";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfPartners).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonUpdateTypeOfPartner;
        private Button buttonDeleteTypeOfPartner;
        private Button buttonAddTypeOfPartner;
        private DataGridView dataGridViewTypesOfPartners;
        private DataGridView dataGridViewTypesOfProducts;
        private Button buttonDeleteTypeOfProduct;
        private Button buttonUpdateTypeOfProduct;
        private Button buttonAddTypeOfProduct;
    }
}
