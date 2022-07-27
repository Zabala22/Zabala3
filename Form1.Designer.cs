namespace contact_tracing_program
{
    partial class CTF1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTF1));
            this.CTtitle = new System.Windows.Forms.Label();
            this.CTlabelname = new System.Windows.Forms.Label();
            this.CTlabeldate = new System.Windows.Forms.Label();
            this.CTlabelnumber = new System.Windows.Forms.Label();
            this.CTlabelemail = new System.Windows.Forms.Label();
            this.CTlabelsex = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.datetextbox = new System.Windows.Forms.TextBox();
            this.numbertextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CTclearbutton = new System.Windows.Forms.Button();
            this.CTsavebutton = new System.Windows.Forms.Button();
            this.CTexitbutton = new System.Windows.Forms.Button();
            this.CTlabelage = new System.Windows.Forms.Label();
            this.agetextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CTlistbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CTlabel1 = new System.Windows.Forms.Label();
            this.CTqrcodeloginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CTtitle
            // 
            this.CTtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTtitle.AutoSize = true;
            this.CTtitle.BackColor = System.Drawing.Color.Transparent;
            this.CTtitle.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTtitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CTtitle.Location = new System.Drawing.Point(81, 22);
            this.CTtitle.Name = "CTtitle";
            this.CTtitle.Size = new System.Drawing.Size(418, 27);
            this.CTtitle.TabIndex = 0;
            this.CTtitle.Text = "COVID-19 Contact Tracing Form";
            this.CTtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CTtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // CTlabelname
            // 
            this.CTlabelname.AutoSize = true;
            this.CTlabelname.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelname.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTlabelname.Location = new System.Drawing.Point(32, 86);
            this.CTlabelname.Name = "CTlabelname";
            this.CTlabelname.Size = new System.Drawing.Size(44, 17);
            this.CTlabelname.TabIndex = 1;
            this.CTlabelname.Text = "Name";
            this.CTlabelname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CTlabeldate
            // 
            this.CTlabeldate.AutoSize = true;
            this.CTlabeldate.BackColor = System.Drawing.Color.Transparent;
            this.CTlabeldate.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTlabeldate.Location = new System.Drawing.Point(32, 166);
            this.CTlabeldate.Name = "CTlabeldate";
            this.CTlabeldate.Size = new System.Drawing.Size(44, 17);
            this.CTlabeldate.TabIndex = 2;
            this.CTlabeldate.Text = "Date";
            this.CTlabeldate.Click += new System.EventHandler(this.label2_Click);
            // 
            // CTlabelnumber
            // 
            this.CTlabelnumber.AutoSize = true;
            this.CTlabelnumber.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelnumber.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTlabelnumber.Location = new System.Drawing.Point(313, 86);
            this.CTlabelnumber.Name = "CTlabelnumber";
            this.CTlabelnumber.Size = new System.Drawing.Size(134, 17);
            this.CTlabelnumber.TabIndex = 3;
            this.CTlabelnumber.Text = "Contact Number";
            // 
            // CTlabelemail
            // 
            this.CTlabelemail.AutoSize = true;
            this.CTlabelemail.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelemail.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTlabelemail.Location = new System.Drawing.Point(313, 166);
            this.CTlabelemail.Name = "CTlabelemail";
            this.CTlabelemail.Size = new System.Drawing.Size(53, 17);
            this.CTlabelemail.TabIndex = 4;
            this.CTlabelemail.Text = "Email";
            this.CTlabelemail.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // CTlabelsex
            // 
            this.CTlabelsex.AutoSize = true;
            this.CTlabelsex.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelsex.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTlabelsex.Location = new System.Drawing.Point(32, 325);
            this.CTlabelsex.Name = "CTlabelsex";
            this.CTlabelsex.Size = new System.Drawing.Size(35, 17);
            this.CTlabelsex.TabIndex = 5;
            this.CTlabelsex.Text = "Sex";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(32, 108);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(238, 22);
            this.nametextbox.TabIndex = 6;
            // 
            // datetextbox
            // 
            this.datetextbox.Location = new System.Drawing.Point(32, 186);
            this.datetextbox.Name = "datetextbox";
            this.datetextbox.Size = new System.Drawing.Size(238, 22);
            this.datetextbox.TabIndex = 7;
            // 
            // numbertextbox
            // 
            this.numbertextbox.Location = new System.Drawing.Point(313, 108);
            this.numbertextbox.Name = "numbertextbox";
            this.numbertextbox.Size = new System.Drawing.Size(245, 22);
            this.numbertextbox.TabIndex = 8;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(313, 188);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(245, 22);
            this.emailtextbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Name, First Name M.I.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(313, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "example@example.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(313, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "0000-000-0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "MM/DD/YYYY";
            // 
            // CTclearbutton
            // 
            this.CTclearbutton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTclearbutton.Location = new System.Drawing.Point(401, 342);
            this.CTclearbutton.Name = "CTclearbutton";
            this.CTclearbutton.Size = new System.Drawing.Size(68, 23);
            this.CTclearbutton.TabIndex = 18;
            this.CTclearbutton.Text = "Clear";
            this.CTclearbutton.UseVisualStyleBackColor = true;
            this.CTclearbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CTsavebutton
            // 
            this.CTsavebutton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTsavebutton.Location = new System.Drawing.Point(316, 342);
            this.CTsavebutton.Name = "CTsavebutton";
            this.CTsavebutton.Size = new System.Drawing.Size(68, 23);
            this.CTsavebutton.TabIndex = 19;
            this.CTsavebutton.Text = "Save";
            this.CTsavebutton.UseVisualStyleBackColor = true;
            this.CTsavebutton.Click += new System.EventHandler(this.CTsavebutton_Click);
            // 
            // CTexitbutton
            // 
            this.CTexitbutton.Location = new System.Drawing.Point(486, 342);
            this.CTexitbutton.Name = "CTexitbutton";
            this.CTexitbutton.Size = new System.Drawing.Size(68, 23);
            this.CTexitbutton.TabIndex = 20;
            this.CTexitbutton.Text = "Exit";
            this.CTexitbutton.UseVisualStyleBackColor = true;
            this.CTexitbutton.Click += new System.EventHandler(this.CTexitbutton_Click);
            // 
            // CTlabelage
            // 
            this.CTlabelage.AutoSize = true;
            this.CTlabelage.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelage.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTlabelage.Location = new System.Drawing.Point(32, 251);
            this.CTlabelage.Name = "CTlabelage";
            this.CTlabelage.Size = new System.Drawing.Size(31, 16);
            this.CTlabelage.TabIndex = 21;
            this.CTlabelage.Text = "Age";
            // 
            // agetextbox
            // 
            this.agetextbox.Location = new System.Drawing.Point(32, 270);
            this.agetextbox.Name = "agetextbox";
            this.agetextbox.Size = new System.Drawing.Size(238, 22);
            this.agetextbox.TabIndex = 22;
            this.agetextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "00 years old";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(36, 345);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(131, 345);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 20);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CTlistbox
            // 
            this.CTlistbox.FormattingEnabled = true;
            this.CTlistbox.ItemHeight = 16;
            this.CTlistbox.Location = new System.Drawing.Point(313, 272);
            this.CTlistbox.Name = "CTlistbox";
            this.CTlistbox.Size = new System.Drawing.Size(245, 20);
            this.CTlistbox.TabIndex = 27;
            this.CTlistbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.CTlistbox.DoubleClick += new System.EventHandler(this.CTlistbox_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(313, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "Selected:";
            // 
            // CTlabel1
            // 
            this.CTlabel1.AutoSize = true;
            this.CTlabel1.BackColor = System.Drawing.Color.Transparent;
            this.CTlabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTlabel1.Location = new System.Drawing.Point(351, 295);
            this.CTlabel1.Name = "CTlabel1";
            this.CTlabel1.Size = new System.Drawing.Size(30, 12);
            this.CTlabel1.TabIndex = 29;
            this.CTlabel1.Text = "Name";
            // 
            // CTqrcodeloginbutton
            // 
            this.CTqrcodeloginbutton.Location = new System.Drawing.Point(187, 439);
            this.CTqrcodeloginbutton.Name = "CTqrcodeloginbutton";
            this.CTqrcodeloginbutton.Size = new System.Drawing.Size(206, 23);
            this.CTqrcodeloginbutton.TabIndex = 30;
            this.CTqrcodeloginbutton.Text = "Log in using QR code";
            this.CTqrcodeloginbutton.UseVisualStyleBackColor = true;
            this.CTqrcodeloginbutton.Click += new System.EventHandler(this.CTqrcodeloginbutton_Click);
            // 
            // CTF1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(589, 541);
            this.Controls.Add(this.CTqrcodeloginbutton);
            this.Controls.Add(this.CTlabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CTlistbox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.agetextbox);
            this.Controls.Add(this.CTlabelage);
            this.Controls.Add(this.CTexitbutton);
            this.Controls.Add(this.CTsavebutton);
            this.Controls.Add(this.CTclearbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.numbertextbox);
            this.Controls.Add(this.datetextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.CTlabelsex);
            this.Controls.Add(this.CTlabelemail);
            this.Controls.Add(this.CTlabelnumber);
            this.Controls.Add(this.CTlabeldate);
            this.Controls.Add(this.CTlabelname);
            this.Controls.Add(this.CTtitle);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CTF1";
            this.Text = "COVID CTF";
            this.Load += new System.EventHandler(this.CTF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CTtitle;
        private Label CTlabelname;
        private Label CTlabeldate;
        private Label CTlabelnumber;
        private Label CTlabelemail;
        private Label CTlabelsex;
        private TextBox nametextbox;
        private TextBox datetextbox;
        private TextBox numbertextbox;
        private TextBox emailtextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CTclearbutton;
        private Button CTsavebutton;
        private Button CTexitbutton;
        private Label CTlabelage;
        private TextBox agetextbox;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox CTlistbox;
        private Label label5;
        private Label CTlabel1;
        private Button CTqrcodeloginbutton;
    }
}