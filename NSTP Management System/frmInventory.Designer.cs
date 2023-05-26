namespace NSTP_Management_System
{
    partial class frmInventory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnPos);
            this.panel1.Location = new System.Drawing.Point(-6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 499);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "REPORT SALE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(40, 301);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(82, 59);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "STOCK";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(40, 223);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(82, 59);
            this.btnPos.TabIndex = 0;
            this.btnPos.Text = "POS";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(189, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 506);
            this.panel2.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(18, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(71, 35);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturn;
    }
}