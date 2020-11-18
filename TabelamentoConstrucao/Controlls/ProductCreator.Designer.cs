namespace TabelamentoConstrucao.Controlls {
    partial class ProductCreator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.comboBox_brand = new System.Windows.Forms.ComboBox();
            this.label_brand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox_productName);
            this.splitContainer1.Panel1.Controls.Add(this.label_name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(951, 40);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox_productName
            // 
            this.textBox_productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_productName.Location = new System.Drawing.Point(47, 9);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(351, 20);
            this.textBox_productName.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Nome:";
            // 
            // button_create
            // 
            this.button_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_create.Location = new System.Drawing.Point(868, 65);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "Registrar";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.comboBox_category);
            this.splitContainer2.Panel1.Controls.Add(this.label_category);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.comboBox_brand);
            this.splitContainer2.Panel2.Controls.Add(this.label_brand);
            this.splitContainer2.Size = new System.Drawing.Size(537, 40);
            this.splitContainer2.SplitterDistance = 292;
            this.splitContainer2.TabIndex = 0;
            // 
            // comboBox_category
            // 
            this.comboBox_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(62, 8);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(216, 21);
            this.comboBox_category.TabIndex = 5;
            // 
            // label_category
            // 
            this.label_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_category.AutoSize = true;
            this.label_category.Location = new System.Drawing.Point(4, 12);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(52, 13);
            this.label_category.TabIndex = 4;
            this.label_category.Text = "Categoria";
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_brand.FormattingEnabled = true;
            this.comboBox_brand.Location = new System.Drawing.Point(46, 9);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.Size = new System.Drawing.Size(185, 21);
            this.comboBox_brand.TabIndex = 7;
            // 
            // label_brand
            // 
            this.label_brand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_brand.AutoSize = true;
            this.label_brand.Location = new System.Drawing.Point(3, 12);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(37, 13);
            this.label_brand.TabIndex = 6;
            this.label_brand.Text = "Marca";
            // 
            // ProductCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 96);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(0, 135);
            this.Name = "ProductCreator";
            this.Text = "Registro de produtos";
            this.Load += new System.EventHandler(this.ProductCreator_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox comboBox_brand;
        private System.Windows.Forms.Label label_brand;
    }
}