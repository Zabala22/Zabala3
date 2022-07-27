namespace contact_tracing_program
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CTFinfobox = new System.Windows.Forms.Label();
            this.CTgenerateqrcodebutton = new System.Windows.Forms.Button();
            this.CTpicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CTpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 23);
            this.textBox1.TabIndex = 0;
            // 
            // CTFinfobox
            // 
            this.CTFinfobox.AutoSize = true;
            this.CTFinfobox.BackColor = System.Drawing.Color.Transparent;
            this.CTFinfobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CTFinfobox.Location = new System.Drawing.Point(12, 114);
            this.CTFinfobox.Name = "CTFinfobox";
            this.CTFinfobox.Size = new System.Drawing.Size(92, 21);
            this.CTFinfobox.TabIndex = 1;
            this.CTFinfobox.Text = "Information";
            // 
            // CTgenerateqrcodebutton
            // 
            this.CTgenerateqrcodebutton.Location = new System.Drawing.Point(348, 311);
            this.CTgenerateqrcodebutton.Name = "CTgenerateqrcodebutton";
            this.CTgenerateqrcodebutton.Size = new System.Drawing.Size(178, 23);
            this.CTgenerateqrcodebutton.TabIndex = 2;
            this.CTgenerateqrcodebutton.Text = "Generate QR Code";
            this.CTgenerateqrcodebutton.UseVisualStyleBackColor = true;
            this.CTgenerateqrcodebutton.Click += new System.EventHandler(this.CTgenerateqrcodebutton_Click);
            // 
            // CTpicturebox
            // 
            this.CTpicturebox.BackColor = System.Drawing.Color.White;
            this.CTpicturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CTpicturebox.Location = new System.Drawing.Point(286, 12);
            this.CTpicturebox.Name = "CTpicturebox";
            this.CTpicturebox.Size = new System.Drawing.Size(291, 293);
            this.CTpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CTpicturebox.TabIndex = 3;
            this.CTpicturebox.TabStop = false;
            // 
            // Form2
            // 
            this.BackgroundImage = global::contact_tracing_program.Properties.Resources.ctf__5_;
            this.ClientSize = new System.Drawing.Size(589, 541);
            this.Controls.Add(this.CTpicturebox);
            this.Controls.Add(this.CTgenerateqrcodebutton);
            this.Controls.Add(this.CTFinfobox);
            this.Name = "Form2";
            this.Text = "QR CODE GENERATOR";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.CTpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label CTFinfobox;
        private Button CTgenerateqrcodebutton;
        private PictureBox CTpicturebox;
    }
}