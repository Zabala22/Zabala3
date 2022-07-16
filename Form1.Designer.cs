namespace contact_tracing_program
{
    partial class CTF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTF));
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CTqrcodebox = new System.Windows.Forms.PictureBox();
            this.CTqrcodebutton = new System.Windows.Forms.Button();
            this.CTclearbutton = new System.Windows.Forms.Button();
            this.CTsavebutton = new System.Windows.Forms.Button();
            this.CTexitbutton = new System.Windows.Forms.Button();
            this.CTlabelage = new System.Windows.Forms.Label();
            this.agetextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CTqrcodebox)).BeginInit();
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(35, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Male";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(132, 346);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 20);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Female";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // CTqrcodebox
            // 
            this.CTqrcodebox.BackColor = System.Drawing.SystemColors.Control;
            this.CTqrcodebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CTqrcodebox.Location = new System.Drawing.Point(313, 251);
            this.CTqrcodebox.Name = "CTqrcodebox";
            this.CTqrcodebox.Size = new System.Drawing.Size(245, 216);
            this.CTqrcodebox.TabIndex = 16;
            this.CTqrcodebox.TabStop = false;
            // 
            // CTqrcodebutton
            // 
            this.CTqrcodebutton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTqrcodebutton.Location = new System.Drawing.Point(365, 473);
            this.CTqrcodebutton.Name = "CTqrcodebutton";
            this.CTqrcodebutton.Size = new System.Drawing.Size(144, 25);
            this.CTqrcodebutton.TabIndex = 17;
            this.CTqrcodebutton.Text = "Generate QR Code";
            this.CTqrcodebutton.UseVisualStyleBackColor = true;
            // 
            // CTclearbutton
            // 
            this.CTclearbutton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTclearbutton.Location = new System.Drawing.Point(117, 405);
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
            this.CTsavebutton.Location = new System.Drawing.Point(32, 405);
            this.CTsavebutton.Name = "CTsavebutton";
            this.CTsavebutton.Size = new System.Drawing.Size(68, 23);
            this.CTsavebutton.TabIndex = 19;
            this.CTsavebutton.Text = "Save";
            this.CTsavebutton.UseVisualStyleBackColor = true;
            // 
            // CTexitbutton
            // 
            this.CTexitbutton.Location = new System.Drawing.Point(202, 405);
            this.CTexitbutton.Name = "CTexitbutton";
            this.CTexitbutton.Size = new System.Drawing.Size(68, 23);
            this.CTexitbutton.TabIndex = 20;
            this.CTexitbutton.Text = "Exit";
            this.CTexitbutton.UseVisualStyleBackColor = true;
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
            // CTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(589, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.agetextbox);
            this.Controls.Add(this.CTlabelage);
            this.Controls.Add(this.CTexitbutton);
            this.Controls.Add(this.CTsavebutton);
            this.Controls.Add(this.CTclearbutton);
            this.Controls.Add(this.CTqrcodebutton);
            this.Controls.Add(this.CTqrcodebox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
            this.Name = "CTF";
            this.Text = "COVID CTF";
            ((System.ComponentModel.ISupportInitialize)(this.CTqrcodebox)).EndInit();
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox CTqrcodebox;
        private Button CTqrcodebutton;
        private Button CTclearbutton;
        private Button CTsavebutton;
        private Button CTexitbutton;
        private Label CTlabelage;
        private TextBox agetextbox;
        private Label label6;
    }
}