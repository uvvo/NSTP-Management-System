namespace NSTP_Management_System
{
    partial class frmPrintShiftingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintShiftingForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBoPrint = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblDeapart = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCPT = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoPrint)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBoPrint
            // 
            this.pictureBoPrint.Image = global::NSTP_Management_System.Properties.Resources.profile_user;
            this.pictureBoPrint.Location = new System.Drawing.Point(953, 24);
            this.pictureBoPrint.Name = "pictureBoPrint";
            this.pictureBoPrint.Size = new System.Drawing.Size(58, 49);
            this.pictureBoPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoPrint.TabIndex = 1;
            this.pictureBoPrint.TabStop = false;
            this.pictureBoPrint.Click += new System.EventHandler(this.pictureBoPrint_Click);
            this.pictureBoPrint.MouseHover += new System.EventHandler(this.pictureBoPrint_MouseHover);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblCNP);
            this.panel1.Controls.Add(this.lblCPT);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblSn);
            this.panel1.Controls.Add(this.lblReg);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.lblCN);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblDeapart);
            this.panel1.Controls.Add(this.lblCourse);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Location = new System.Drawing.Point(86, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 674);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrint_Paint);
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(156, 288);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(57, 13);
            this.label53.TabIndex = 45;
            this.label53.Text = "Full Name:";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(175, 315);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(43, 13);
            this.label52.TabIndex = 46;
            this.label52.Text = "Course:";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(156, 393);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(65, 13);
            this.label51.TabIndex = 47;
            this.label51.Text = "Department:";
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(176, 447);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(45, 13);
            this.label50.TabIndex = 48;
            this.label50.Text = "Gender:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(265, 288);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 13);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "?";
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(264, 315);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(13, 13);
            this.lblCourse.TabIndex = 50;
            this.lblCourse.Text = "?";
            // 
            // lblDeapart
            // 
            this.lblDeapart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeapart.AutoSize = true;
            this.lblDeapart.Location = new System.Drawing.Point(267, 393);
            this.lblDeapart.Name = "lblDeapart";
            this.lblDeapart.Size = new System.Drawing.Size(13, 13);
            this.lblDeapart.TabIndex = 51;
            this.lblDeapart.Text = "?";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(268, 447);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(13, 13);
            this.lblGender.TabIndex = 52;
            this.lblGender.Text = "?";
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(730, 173);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(13, 13);
            this.label45.TabIndex = 53;
            this.label45.Text = "?";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Location = new System.Drawing.Point(46, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 72);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(314, 55);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(280, 20);
            this.label44.TabIndex = 40;
            this.label44.Text = "EARIST NSTP APPOINTMENT FORM";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(361, 106);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(179, 20);
            this.label43.TabIndex = 41;
            this.label43.Text = "Appointments Schedule";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(99, 137);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(48, 20);
            this.label42.TabIndex = 42;
            this.label42.Text = "Date:";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(99, 173);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(47, 20);
            this.label41.TabIndex = 43;
            this.label41.Text = "Time:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Location = new System.Drawing.Point(694, 211);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(372, 217);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(156, 20);
            this.label40.TabIndex = 54;
            this.label40.Text = "Personal Information";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(705, 290);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 20);
            this.label39.TabIndex = 55;
            this.label39.Text = "Picture";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(172, 338);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 13);
            this.label38.TabIndex = 56;
            this.label38.Text = "Section:";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(134, 254);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(87, 13);
            this.label37.TabIndex = 57;
            this.label37.Text = "Student Number:";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(149, 624);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(145, 13);
            this.label36.TabIndex = 64;
            this.label36.Text = "Conformation NSTP program:";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(353, 510);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(139, 13);
            this.label35.TabIndex = 58;
            this.label35.Text = "NSTP program change form";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(131, 364);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(87, 13);
            this.label34.TabIndex = 59;
            this.label34.Text = "Regular/Iregular:";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(148, 425);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 13);
            this.label33.TabIndex = 60;
            this.label33.Text = "Contact No:";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(187, 474);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 61;
            this.label32.Text = "Email:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(199, 535);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 62;
            this.label31.Text = "Change program to:";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(188, 587);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(111, 13);
            this.label30.TabIndex = 63;
            this.label30.Text = "Change program from:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(268, 474);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(13, 13);
            this.lblEmail.TabIndex = 65;
            this.lblEmail.Text = "?";
            // 
            // lblCN
            // 
            this.lblCN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(267, 425);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(13, 13);
            this.lblCN.TabIndex = 66;
            this.lblCN.Text = "?";
            // 
            // lblSection
            // 
            this.lblSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(264, 338);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(13, 13);
            this.lblSection.TabIndex = 67;
            this.lblSection.Text = "?";
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(265, 364);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(13, 13);
            this.lblReg.TabIndex = 68;
            this.lblReg.Text = "?";
            // 
            // lblSn
            // 
            this.lblSn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSn.AutoSize = true;
            this.lblSn.Location = new System.Drawing.Point(264, 254);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(13, 13);
            this.lblSn.TabIndex = 69;
            this.lblSn.Text = "?";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(157, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 13);
            this.lblDate.TabIndex = 70;
            this.lblDate.Text = "?";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(157, 178);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 71;
            this.lblTime.Text = "?";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(387, 587);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(13, 13);
            this.lblCPF.TabIndex = 72;
            this.lblCPF.Text = "?";
            // 
            // lblCPT
            // 
            this.lblCPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPT.AutoSize = true;
            this.lblCPT.Location = new System.Drawing.Point(387, 540);
            this.lblCPT.Name = "lblCPT";
            this.lblCPT.Size = new System.Drawing.Size(13, 13);
            this.lblCPT.TabIndex = 73;
            this.lblCPT.Text = "?";
            // 
            // lblCNP
            // 
            this.lblCNP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(387, 624);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(13, 13);
            this.lblCNP.TabIndex = 74;
            this.lblCNP.Text = "?";
            // 
            // frmPrintShiftingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 733);
            this.Controls.Add(this.pictureBoPrint);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrintShiftingForm";
            this.Text = "frmPrintShiftingForm";
            this.Load += new System.EventHandler(this.frmPrintShiftingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoPrint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBoPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblCPT;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDeapart;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
    }
}