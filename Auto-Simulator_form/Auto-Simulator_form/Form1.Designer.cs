namespace Auto_Simulator_form
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_Fahrzeug = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PS = new System.Windows.Forms.Label();
            this.btn_Gas = new System.Windows.Forms.Button();
            this.btn_Brake = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ShowGear = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ShowSpeed = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_gear = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_honk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Fahrzeug
            // 
            this.cbx_Fahrzeug.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Fahrzeug.FormattingEnabled = true;
            this.cbx_Fahrzeug.Location = new System.Drawing.Point(290, 31);
            this.cbx_Fahrzeug.Name = "cbx_Fahrzeug";
            this.cbx_Fahrzeug.Size = new System.Drawing.Size(221, 28);
            this.cbx_Fahrzeug.TabIndex = 0;
            this.cbx_Fahrzeug.SelectedIndexChanged += new System.EventHandler(this.cbx_Cars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wählen Sie Ihr Fahrzeug:";
            // 
            // lbl_PS
            // 
            this.lbl_PS.AutoSize = true;
            this.lbl_PS.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PS.Location = new System.Drawing.Point(491, 34);
            this.lbl_PS.Name = "lbl_PS";
            this.lbl_PS.Size = new System.Drawing.Size(0, 20);
            this.lbl_PS.TabIndex = 2;
            // 
            // btn_Gas
            // 
            this.btn_Gas.Location = new System.Drawing.Point(535, 228);
            this.btn_Gas.Name = "btn_Gas";
            this.btn_Gas.Size = new System.Drawing.Size(77, 153);
            this.btn_Gas.TabIndex = 3;
            this.btn_Gas.Text = "Gas";
            this.btn_Gas.UseVisualStyleBackColor = true;
            this.btn_Gas.MouseHover += new System.EventHandler(this.btn_Gas_MouseHover_1);
            // 
            // btn_Brake
            // 
            this.btn_Brake.Location = new System.Drawing.Point(380, 228);
            this.btn_Brake.Name = "btn_Brake";
            this.btn_Brake.Size = new System.Drawing.Size(125, 153);
            this.btn_Brake.TabIndex = 4;
            this.btn_Brake.Text = "Brake";
            this.btn_Brake.UseVisualStyleBackColor = true;
            this.btn_Brake.Click += new System.EventHandler(this.btn_Brake_Click);
            this.btn_Brake.MouseHover += new System.EventHandler(this.btn_Brake_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_speed);
            this.panel1.Controls.Add(this.lbl_gear);
            this.panel1.Location = new System.Drawing.Point(194, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 123);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.lbl_ShowGear);
            this.panel3.Location = new System.Drawing.Point(301, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 60);
            this.panel3.TabIndex = 5;
            // 
            // lbl_ShowGear
            // 
            this.lbl_ShowGear.AutoSize = true;
            this.lbl_ShowGear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ShowGear.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowGear.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ShowGear.Location = new System.Drawing.Point(30, 18);
            this.lbl_ShowGear.Name = "lbl_ShowGear";
            this.lbl_ShowGear.Size = new System.Drawing.Size(0, 24);
            this.lbl_ShowGear.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lbl_ShowSpeed);
            this.panel2.Location = new System.Drawing.Point(25, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 60);
            this.panel2.TabIndex = 4;
            // 
            // lbl_ShowSpeed
            // 
            this.lbl_ShowSpeed.AutoSize = true;
            this.lbl_ShowSpeed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ShowSpeed.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowSpeed.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ShowSpeed.Location = new System.Drawing.Point(97, 18);
            this.lbl_ShowSpeed.Name = "lbl_ShowSpeed";
            this.lbl_ShowSpeed.Size = new System.Drawing.Size(0, 24);
            this.lbl_ShowSpeed.TabIndex = 0;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(33, 24);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(32, 13);
            this.lbl_speed.TabIndex = 3;
            this.lbl_speed.Text = "km/h";
            // 
            // lbl_gear
            // 
            this.lbl_gear.AutoSize = true;
            this.lbl_gear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_gear.Location = new System.Drawing.Point(307, 24);
            this.lbl_gear.Name = "lbl_gear";
            this.lbl_gear.Size = new System.Drawing.Size(30, 13);
            this.lbl_gear.TabIndex = 2;
            this.lbl_gear.Text = "Gear";
            // 
            // lbl_status
            // 
            this.lbl_status.Location = new System.Drawing.Point(46, 161);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(90, 26);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.UseVisualStyleBackColor = true;
            this.lbl_status.Click += new System.EventHandler(this.lbl_status_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Auto_Simulator_form.Properties.Resources.istockphoto_1066947774_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(46, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Auto_Simulator_form.Properties.Resources.emoji_key_full;
            this.pictureBox1.Location = new System.Drawing.Point(46, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_honk
            // 
            this.btn_honk.Location = new System.Drawing.Point(49, 282);
            this.btn_honk.Name = "btn_honk";
            this.btn_honk.Size = new System.Drawing.Size(87, 25);
            this.btn_honk.TabIndex = 9;
            this.btn_honk.Text = "Honk!";
            this.btn_honk.UseVisualStyleBackColor = true;
            this.btn_honk.Click += new System.EventHandler(this.btn_honk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 404);
            this.Controls.Add(this.btn_honk);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Brake);
            this.Controls.Add(this.btn_Gas);
            this.Controls.Add(this.lbl_PS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Fahrzeug);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Fahrzeug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PS;
        private System.Windows.Forms.Button btn_Gas;
        private System.Windows.Forms.Button btn_Brake;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_gear;
        private System.Windows.Forms.Button lbl_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ShowSpeed;
        private System.Windows.Forms.Label lbl_ShowGear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_honk;
    }
}

