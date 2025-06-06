namespace HomeLibrary.Forms
{
    partial class ExportOptionsForm
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
            groupBox1 = new GroupBox();
            radioReadable = new RadioButton();
            radioLibrary = new RadioButton();
            btnExport = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioLibrary);
            groupBox1.Controls.Add(radioReadable);
            groupBox1.Location = new Point(165, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Export Format";
            // 
            // radioReadable
            // 
            radioReadable.AutoSize = true;
            radioReadable.Checked = true;
            radioReadable.Location = new Point(74, 68);
            radioReadable.Name = "radioReadable";
            radioReadable.Size = new Size(275, 29);
            radioReadable.TabIndex = 0;
            radioReadable.TabStop = true;
            radioReadable.Text = "Books Information (Inventory)";
            radioReadable.UseVisualStyleBackColor = true;
            // 
            // radioLibrary
            // 
            radioLibrary.AutoSize = true;
            radioLibrary.Location = new Point(76, 135);
            radioLibrary.Name = "radioLibrary";
            radioLibrary.Size = new Size(309, 29);
            radioLibrary.TabIndex = 1;
            radioLibrary.TabStop = true;
            radioLibrary.Text = "Books Library (Importable Format)";
            radioLibrary.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.DialogResult = DialogResult.OK;
            btnExport.Location = new Point(143, 363);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 34);
            btnExport.TabIndex = 1;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(469, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ExportOptionsForm
            // 
            AcceptButton = btnExport;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnExport);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportOptionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExportOptionsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioLibrary;
        private RadioButton radioReadable;
        private Button btnExport;
        private Button btnCancel;
    }
}