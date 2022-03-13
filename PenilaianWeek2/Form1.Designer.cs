namespace PenilaianWeek2
{
    partial class FormPengaturanWarna
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
            this.LabelInputData = new System.Windows.Forms.Label();
            this.TextBoxInputData = new System.Windows.Forms.TextBox();
            this.ButtonProses = new System.Windows.Forms.Button();
            this.LabelOutputData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelInputData
            // 
            this.LabelInputData.AutoSize = true;
            this.LabelInputData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInputData.Location = new System.Drawing.Point(30, 38);
            this.LabelInputData.Name = "LabelInputData";
            this.LabelInputData.Size = new System.Drawing.Size(76, 19);
            this.LabelInputData.TabIndex = 0;
            this.LabelInputData.Text = "Input Data:";
            // 
            // TextBoxInputData
            // 
            this.TextBoxInputData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInputData.Location = new System.Drawing.Point(34, 71);
            this.TextBoxInputData.Name = "TextBoxInputData";
            this.TextBoxInputData.Size = new System.Drawing.Size(343, 26);
            this.TextBoxInputData.TabIndex = 1;
            // 
            // ButtonProses
            // 
            this.ButtonProses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProses.Location = new System.Drawing.Point(34, 115);
            this.ButtonProses.Name = "ButtonProses";
            this.ButtonProses.Size = new System.Drawing.Size(75, 23);
            this.ButtonProses.TabIndex = 2;
            this.ButtonProses.Text = "Proses";
            this.ButtonProses.UseVisualStyleBackColor = true;
            this.ButtonProses.Click += new System.EventHandler(this.ButtonProses_Click);
            // 
            // LabelOutputData
            // 
            this.LabelOutputData.AutoSize = true;
            this.LabelOutputData.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutputData.Location = new System.Drawing.Point(28, 154);
            this.LabelOutputData.Name = "LabelOutputData";
            this.LabelOutputData.Size = new System.Drawing.Size(123, 31);
            this.LabelOutputData.TabIndex = 3;
            this.LabelOutputData.Text = "[EMPTY]";
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(472, 267);
            this.Controls.Add(this.LabelOutputData);
            this.Controls.Add(this.ButtonProses);
            this.Controls.Add(this.TextBoxInputData);
            this.Controls.Add(this.LabelInputData);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInputData;
        private System.Windows.Forms.TextBox TextBoxInputData;
        private System.Windows.Forms.Button ButtonProses;
        private System.Windows.Forms.Label LabelOutputData;
    }
}

