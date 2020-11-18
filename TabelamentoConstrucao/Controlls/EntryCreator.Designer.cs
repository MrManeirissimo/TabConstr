namespace TabelamentoConstrucao.Controlls {
    partial class EntryCreator {
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
            this.entryLine1 = new TabelamentoConstrucao.Controlls.EntryLine();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryLine1
            // 
            this.entryLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryLine1.AutoSize = true;
            this.entryLine1.Index = 0;
            this.entryLine1.Location = new System.Drawing.Point(11, 12);
            this.entryLine1.Name = "entryLine1";
            this.entryLine1.Size = new System.Drawing.Size(998, 57);
            this.entryLine1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(934, 75);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Adicionar";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // EntryCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 110);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.entryLine1);
            this.Name = "EntryCreator";
            this.Text = "EntryCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryLine entryLine1;
        private System.Windows.Forms.Button button_add;
    }
}