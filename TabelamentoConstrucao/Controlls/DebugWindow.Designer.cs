namespace TabelamentoConstrucao.Controlls {
    partial class DebugWindow {
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.consoleOut = new System.Windows.Forms.RichTextBox();
            this.lowerPanel = new System.Windows.Forms.SplitContainer();
            this.textLine_console = new System.Windows.Forms.TextBox();
            this.button_run = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerPanel)).BeginInit();
            this.lowerPanel.Panel1.SuspendLayout();
            this.lowerPanel.Panel2.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.consoleOut);
            this.mainPanel.Location = new System.Drawing.Point(12, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(381, 556);
            this.mainPanel.TabIndex = 0;
            // 
            // consoleOut
            // 
            this.consoleOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOut.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.consoleOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleOut.ForeColor = System.Drawing.Color.SpringGreen;
            this.consoleOut.Location = new System.Drawing.Point(0, 0);
            this.consoleOut.Name = "consoleOut";
            this.consoleOut.ReadOnly = true;
            this.consoleOut.Size = new System.Drawing.Size(378, 553);
            this.consoleOut.TabIndex = 0;
            this.consoleOut.Text = "";
            // 
            // lowerPanel
            // 
            this.lowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowerPanel.Location = new System.Drawing.Point(12, 561);
            this.lowerPanel.Name = "lowerPanel";
            // 
            // lowerPanel.Panel1
            // 
            this.lowerPanel.Panel1.Controls.Add(this.textLine_console);
            // 
            // lowerPanel.Panel2
            // 
            this.lowerPanel.Panel2.Controls.Add(this.button_run);
            this.lowerPanel.Size = new System.Drawing.Size(378, 23);
            this.lowerPanel.SplitterDistance = 259;
            this.lowerPanel.TabIndex = 1;
            // 
            // textLine_console
            // 
            this.textLine_console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textLine_console.Location = new System.Drawing.Point(0, 0);
            this.textLine_console.Name = "textLine_console";
            this.textLine_console.Size = new System.Drawing.Size(256, 20);
            this.textLine_console.TabIndex = 0;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(-1, 0);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(113, 23);
            this.button_run.TabIndex = 0;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 586);
            this.ControlBox = false;
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.mainPanel);
            this.KeyPreview = true;
            this.Name = "DebugWindow";
            this.Opacity = 0.95D;
            this.Text = "DebugWindow";
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DebugWindow_KeyDown);
            this.mainPanel.ResumeLayout(false);
            this.lowerPanel.Panel1.ResumeLayout(false);
            this.lowerPanel.Panel1.PerformLayout();
            this.lowerPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowerPanel)).EndInit();
            this.lowerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox consoleOut;
        private System.Windows.Forms.SplitContainer lowerPanel;
        private System.Windows.Forms.TextBox textLine_console;
        private System.Windows.Forms.Button button_run;
    }
}