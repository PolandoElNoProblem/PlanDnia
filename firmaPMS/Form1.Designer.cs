namespace firmaPMS
{
    partial class Glowny
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glowny));
            this.wiseTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DodajDzienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ok = new System.Windows.Forms.Button();
            this.zamknij = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wiseTree
            // 
            this.wiseTree.AllowDrop = true;
            this.wiseTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wiseTree.ContextMenuStrip = this.contextMenuStrip1;
            this.wiseTree.FullRowSelect = true;
            this.wiseTree.Location = new System.Drawing.Point(30, 12);
            this.wiseTree.Name = "wiseTree";
            this.wiseTree.Size = new System.Drawing.Size(416, 416);
            this.wiseTree.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajDzienToolStripMenuItem,
            this.dodajPodToolStripMenuItem,
            this.usunToolStripMenuItem,
            this.zmienToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 92);
            // 
            // DodajDzienToolStripMenuItem
            // 
            this.DodajDzienToolStripMenuItem.Name = "DodajDzienToolStripMenuItem";
            this.DodajDzienToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.DodajDzienToolStripMenuItem.Text = "Dodaj Dzień";
            this.DodajDzienToolStripMenuItem.Click += new System.EventHandler(this.DodajGalazToolStripMenuItem_Click);
            // 
            // dodajPodToolStripMenuItem
            // 
            this.dodajPodToolStripMenuItem.Name = "dodajPodToolStripMenuItem";
            this.dodajPodToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dodajPodToolStripMenuItem.Text = "Dodaj podgalaz ";
            this.dodajPodToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem
            // 
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            this.usunToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.usunToolStripMenuItem.Text = "Usun";
            this.usunToolStripMenuItem.Click += new System.EventHandler(this.usunToolStripMenuItem_Click);
            // 
            // zmienToolStripMenuItem
            // 
            this.zmienToolStripMenuItem.Name = "zmienToolStripMenuItem";
            this.zmienToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.zmienToolStripMenuItem.Text = "Zmien";
            this.zmienToolStripMenuItem.Click += new System.EventHandler(this.zmienToolStripMenuItem_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(452, 292);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // zamknij
            // 
            this.zamknij.Location = new System.Drawing.Point(452, 334);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(75, 23);
            this.zamknij.TabIndex = 2;
            this.zamknij.Text = "Zamknij";
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // Glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.wiseTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glowny";
            this.Text = "Jaki masz plan?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Glowny_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView wiseTree;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DodajDzienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmienToolStripMenuItem;
    }
}

