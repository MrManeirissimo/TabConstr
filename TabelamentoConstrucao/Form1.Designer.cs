namespace TabelamentoConstrucao
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.button_newConstruction = new System.Windows.Forms.Button();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.button_NewProduct = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.mainControl.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainControl.Controls.Add(this.tabPage1);
            this.mainControl.Controls.Add(this.tabPage2);
            this.mainControl.Location = new System.Drawing.Point(2, 2);
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 0;
            this.mainControl.Size = new System.Drawing.Size(1155, 413);
            this.mainControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lowerPanel
            // 
            this.lowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowerPanel.Controls.Add(this.button_newConstruction);
            this.lowerPanel.Controls.Add(this.button_addProduct);
            this.lowerPanel.Controls.Add(this.button_NewProduct);
            this.lowerPanel.Controls.Add(this.button_update);
            this.lowerPanel.Location = new System.Drawing.Point(2, 417);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(1151, 29);
            this.lowerPanel.TabIndex = 1;
            // 
            // button_newConstruction
            // 
            this.button_newConstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_newConstruction.Location = new System.Drawing.Point(177, 3);
            this.button_newConstruction.Name = "button_newConstruction";
            this.button_newConstruction.Size = new System.Drawing.Size(91, 23);
            this.button_newConstruction.TabIndex = 3;
            this.button_newConstruction.Text = "Nova obra";
            this.button_newConstruction.UseVisualStyleBackColor = true;
            this.button_newConstruction.Click += new System.EventHandler(this.button_newConstruction_Click);
            // 
            // button_addProduct
            // 
            this.button_addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_addProduct.Location = new System.Drawing.Point(6, 3);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(108, 23);
            this.button_addProduct.TabIndex = 2;
            this.button_addProduct.Text = "Adicionar produto";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // button_NewProduct
            // 
            this.button_NewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_NewProduct.Location = new System.Drawing.Point(274, 3);
            this.button_NewProduct.Name = "button_NewProduct";
            this.button_NewProduct.Size = new System.Drawing.Size(91, 23);
            this.button_NewProduct.TabIndex = 1;
            this.button_NewProduct.Text = "Novo produto";
            this.button_NewProduct.UseVisualStyleBackColor = true;
            this.button_NewProduct.Click += new System.EventHandler(this.button_NewProduct_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.Location = new System.Drawing.Point(1071, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 0;
            this.button_update.Text = "Salvar";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.mainControl);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainControl.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_NewProduct;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Button button_newConstruction;
    }
}

