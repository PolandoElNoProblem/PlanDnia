namespace firmaPMS
{
    partial class dChoose
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseDay = new System.Windows.Forms.ComboBox();
            this.can = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz dzien:";
            // 
            // ChooseDay
            // 
            this.ChooseDay.FormattingEnabled = true;
            this.ChooseDay.Items.AddRange(new object[] {
            "Poniedziałek",
            "Wtorek",
            "Środa",
            "Czwartek",
            "Piątek",
            "Sobota",
            "Niedziela",
            "Cały_Tydzień"});
            this.ChooseDay.Location = new System.Drawing.Point(92, 36);
            this.ChooseDay.Name = "ChooseDay";
            this.ChooseDay.Size = new System.Drawing.Size(172, 21);
            this.ChooseDay.TabIndex = 1;
            this.ChooseDay.Text = "Poniedziałek";
            this.ChooseDay.SelectedIndexChanged += new System.EventHandler(this.ChooseDay_SelectedIndexChanged);
            // 
            // can
            // 
            this.can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.can.Location = new System.Drawing.Point(189, 63);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(75, 23);
            this.can.TabIndex = 2;
            this.can.Text = "Anuluj";
            this.can.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(92, 63);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // dChoose
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.can;
            this.ClientSize = new System.Drawing.Size(290, 108);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.can);
            this.Controls.Add(this.ChooseDay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dChoose";
            this.Text = "Wybierz dzien";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseDay;
        private System.Windows.Forms.Button can;
        private System.Windows.Forms.Button ok;
    }
}