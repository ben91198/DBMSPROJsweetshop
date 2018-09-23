namespace sweet_shop
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bILLINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATESTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWPRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAILYSALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bILLINGToolStripMenuItem,
            this.updatePriceToolStripMenuItem,
            this.uPDATESTOCKToolStripMenuItem,
            this.aDDNEWPRODUCTSToolStripMenuItem,
            this.dAILYSALESToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(973, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 467);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(973, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // bILLINGToolStripMenuItem
            // 
            this.bILLINGToolStripMenuItem.Name = "bILLINGToolStripMenuItem";
            this.bILLINGToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bILLINGToolStripMenuItem.Text = "BILLING";
            this.bILLINGToolStripMenuItem.Click += new System.EventHandler(this.bILLINGToolStripMenuItem_Click);
            // 
            // updatePriceToolStripMenuItem
            // 
            this.updatePriceToolStripMenuItem.Name = "updatePriceToolStripMenuItem";
            this.updatePriceToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.updatePriceToolStripMenuItem.Text = "UPDATE PRICE";
            this.updatePriceToolStripMenuItem.Click += new System.EventHandler(this.updatePriceToolStripMenuItem_Click);
            // 
            // uPDATESTOCKToolStripMenuItem
            // 
            this.uPDATESTOCKToolStripMenuItem.Name = "uPDATESTOCKToolStripMenuItem";
            this.uPDATESTOCKToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.uPDATESTOCKToolStripMenuItem.Text = "UPDATE STOCK";
            this.uPDATESTOCKToolStripMenuItem.Click += new System.EventHandler(this.uPDATESTOCKToolStripMenuItem_Click);
            // 
            // aDDNEWPRODUCTSToolStripMenuItem
            // 
            this.aDDNEWPRODUCTSToolStripMenuItem.Name = "aDDNEWPRODUCTSToolStripMenuItem";
            this.aDDNEWPRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.aDDNEWPRODUCTSToolStripMenuItem.Text = "ADD NEW PRODUCTS";
            this.aDDNEWPRODUCTSToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWPRODUCTSToolStripMenuItem_Click);
            // 
            // dAILYSALESToolStripMenuItem
            // 
            this.dAILYSALESToolStripMenuItem.Name = "dAILYSALESToolStripMenuItem";
            this.dAILYSALESToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dAILYSALESToolStripMenuItem.Text = "SALES";
            this.dAILYSALESToolStripMenuItem.Click += new System.EventHandler(this.dAILYSALESToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 489);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem bILLINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATESTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWPRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dAILYSALESToolStripMenuItem;
    }
}



