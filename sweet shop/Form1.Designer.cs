namespace sweet_shop
{
    partial class Form1
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
            this.billingbtn = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONGONESE";
            // 
            // billingbtn
            // 
            this.billingbtn.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingbtn.Location = new System.Drawing.Point(289, 120);
            this.billingbtn.Name = "billingbtn";
            this.billingbtn.Size = new System.Drawing.Size(193, 35);
            this.billingbtn.TabIndex = 1;
            this.billingbtn.Text = "Billing";
            this.billingbtn.UseVisualStyleBackColor = true;
            this.billingbtn.Click += new System.EventHandler(this.billingbtn_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(289, 254);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(193, 37);
            this.update.TabIndex = 2;
            this.update.Text = "Update Stock";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(289, 318);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(193, 36);
            this.add.TabIndex = 3;
            this.add.Text = "Add new product";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.billingbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HOME PAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button billingbtn;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}

