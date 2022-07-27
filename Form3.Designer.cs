namespace contact_tracing_program
{
    partial class Form3
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
            this.CTcombobox = new System.Windows.Forms.ComboBox();
            this.CTlabelcamera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CTloginlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CTcombobox
            // 
            this.CTcombobox.FormattingEnabled = true;
            this.CTcombobox.Location = new System.Drawing.Point(87, 39);
            this.CTcombobox.Name = "CTcombobox";
            this.CTcombobox.Size = new System.Drawing.Size(174, 23);
            this.CTcombobox.TabIndex = 0;
            // 
            // CTlabelcamera
            // 
            this.CTlabelcamera.AutoSize = true;
            this.CTlabelcamera.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelcamera.Location = new System.Drawing.Point(21, 42);
            this.CTlabelcamera.Name = "CTlabelcamera";
            this.CTlabelcamera.Size = new System.Drawing.Size(48, 15);
            this.CTlabelcamera.TabIndex = 1;
            this.CTlabelcamera.Text = "Camera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 383);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CTloginlabel
            // 
            this.CTloginlabel.AutoSize = true;
            this.CTloginlabel.BackColor = System.Drawing.Color.Transparent;
            this.CTloginlabel.Location = new System.Drawing.Point(305, 39);
            this.CTloginlabel.Name = "CTloginlabel";
            this.CTloginlabel.Size = new System.Drawing.Size(38, 15);
            this.CTloginlabel.TabIndex = 5;
            this.CTloginlabel.Text = "label1";
            this.CTloginlabel.Click += new System.EventHandler(this.CTloginlabel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::contact_tracing_program.Properties.Resources.ctf__5_;
            this.ClientSize = new System.Drawing.Size(563, 545);
            this.Controls.Add(this.CTloginlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTlabelcamera);
            this.Controls.Add(this.CTcombobox);
            this.Name = "Form3";
            this.Text = "QR CODE LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CTcombobox;
        private Label CTlabelcamera;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label CTloginlabel;
        private System.Windows.Forms.Timer timer1;
    }
}