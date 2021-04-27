
namespace baseRR
{
    partial class formBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBase));
            this.pButtons = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHC = new System.Windows.Forms.Button();
            this.btnMPA = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.nudJuros = new System.Windows.Forms.NumericUpDown();
            this.nudDesconto = new System.Windows.Forms.NumericUpDown();
            this.txtbResul = new System.Windows.Forms.TextBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.mcMes = new System.Windows.Forms.MonthCalendar();
            this.chkbCalendario = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chkbDesconto = new System.Windows.Forms.CheckBox();
            this.chkbAtrasado = new System.Windows.Forms.CheckBox();
            this.nudMora = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbAPD = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudResJuros = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkbDEP = new System.Windows.Forms.CheckBox();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJuros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMora)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResJuros)).BeginInit();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pButtons.Controls.Add(this.pictureBox1);
            this.pButtons.Controls.Add(this.btnLogout);
            this.pButtons.Controls.Add(this.btnHC);
            this.pButtons.Controls.Add(this.btnMPA);
            this.pButtons.Controls.Add(this.btnReminder);
            this.pButtons.Location = new System.Drawing.Point(-2, -1);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(182, 572);
            this.pButtons.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::baseRR.Properties.Resources.RR__2_;
            this.pictureBox1.Location = new System.Drawing.Point(14, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(15, 457);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 97);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHC
            // 
            this.btnHC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnHC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHC.FlatAppearance.BorderSize = 0;
            this.btnHC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHC.Location = new System.Drawing.Point(14, 286);
            this.btnHC.Name = "btnHC";
            this.btnHC.Size = new System.Drawing.Size(150, 43);
            this.btnHC.TabIndex = 2;
            this.btnHC.Text = "HC";
            this.btnHC.UseVisualStyleBackColor = false;
            // 
            // btnMPA
            // 
            this.btnMPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMPA.FlatAppearance.BorderSize = 0;
            this.btnMPA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMPA.Location = new System.Drawing.Point(14, 178);
            this.btnMPA.Name = "btnMPA";
            this.btnMPA.Size = new System.Drawing.Size(150, 43);
            this.btnMPA.TabIndex = 0;
            this.btnMPA.Text = "MPA";
            this.btnMPA.UseVisualStyleBackColor = false;
            // 
            // btnReminder
            // 
            this.btnReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReminder.FlatAppearance.BorderSize = 0;
            this.btnReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReminder.Location = new System.Drawing.Point(14, 232);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(150, 43);
            this.btnReminder.TabIndex = 1;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(200, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor do boleto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(200, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(200, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mora por dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(200, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(200, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor final:";
            // 
            // nudValor
            // 
            this.nudValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.nudValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.ForeColor = System.Drawing.SystemColors.Window;
            this.nudValor.Location = new System.Drawing.Point(416, 55);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(175, 34);
            this.nudValor.TabIndex = 8;
            this.nudValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudValor.ValueChanged += new System.EventHandler(this.nudValor_ValueChanged);
            // 
            // nudJuros
            // 
            this.nudJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.nudJuros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudJuros.DecimalPlaces = 2;
            this.nudJuros.ForeColor = System.Drawing.SystemColors.Window;
            this.nudJuros.Location = new System.Drawing.Point(416, 185);
            this.nudJuros.Name = "nudJuros";
            this.nudJuros.Size = new System.Drawing.Size(175, 34);
            this.nudJuros.TabIndex = 9;
            this.nudJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudJuros.Value = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            // 
            // nudDesconto
            // 
            this.nudDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.nudDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDesconto.DecimalPlaces = 2;
            this.nudDesconto.ForeColor = System.Drawing.SystemColors.Window;
            this.nudDesconto.Location = new System.Drawing.Point(416, 250);
            this.nudDesconto.Name = "nudDesconto";
            this.nudDesconto.Size = new System.Drawing.Size(175, 34);
            this.nudDesconto.TabIndex = 10;
            this.nudDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbResul
            // 
            this.txtbResul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtbResul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbResul.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbResul.Location = new System.Drawing.Point(416, 482);
            this.txtbResul.Name = "txtbResul";
            this.txtbResul.ReadOnly = true;
            this.txtbResul.Size = new System.Drawing.Size(153, 31);
            this.txtbResul.TabIndex = 13;
            this.txtbResul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(416, 120);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpVencimento.Size = new System.Drawing.Size(153, 38);
            this.dtpVencimento.TabIndex = 14;
            // 
            // mcMes
            // 
            this.mcMes.BackColor = System.Drawing.SystemColors.Window;
            this.mcMes.Enabled = false;
            this.mcMes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mcMes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mcMes.Location = new System.Drawing.Point(606, 146);
            this.mcMes.Name = "mcMes";
            this.mcMes.TabIndex = 15;
            this.mcMes.Visible = false;
            // 
            // chkbCalendario
            // 
            this.chkbCalendario.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.chkbCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkbCalendario.Location = new System.Drawing.Point(631, 55);
            this.chkbCalendario.Name = "chkbCalendario";
            this.chkbCalendario.Size = new System.Drawing.Size(212, 41);
            this.chkbCalendario.TabIndex = 17;
            this.chkbCalendario.Text = "Exibir calendário";
            this.chkbCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbCalendario.UseVisualStyleBackColor = false;
            this.chkbCalendario.CheckedChanged += new System.EventHandler(this.chkbCalendario_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnCalc.Enabled = false;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Location = new System.Drawing.Point(416, 315);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 38);
            this.btnCalc.TabIndex = 18;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chkbDesconto
            // 
            this.chkbDesconto.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbDesconto.AutoSize = true;
            this.chkbDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.chkbDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkbDesconto.Location = new System.Drawing.Point(647, 378);
            this.chkbDesconto.Name = "chkbDesconto";
            this.chkbDesconto.Size = new System.Drawing.Size(181, 41);
            this.chkbDesconto.TabIndex = 19;
            this.chkbDesconto.Text = "desconto em %";
            this.chkbDesconto.UseVisualStyleBackColor = false;
            this.chkbDesconto.CheckedChanged += new System.EventHandler(this.chkbDesconto_CheckedChanged);
            // 
            // chkbAtrasado
            // 
            this.chkbAtrasado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbAtrasado.AutoSize = true;
            this.chkbAtrasado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.chkbAtrasado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkbAtrasado.Location = new System.Drawing.Point(596, 425);
            this.chkbAtrasado.Name = "chkbAtrasado";
            this.chkbAtrasado.Size = new System.Drawing.Size(282, 41);
            this.chkbAtrasado.TabIndex = 20;
            this.chkbAtrasado.Text = "Atrasado perde desconto";
            this.chkbAtrasado.UseVisualStyleBackColor = false;
            this.chkbAtrasado.CheckedChanged += new System.EventHandler(this.chkbAtrasado_CheckedChanged);
            // 
            // nudMora
            // 
            this.nudMora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.nudMora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMora.DecimalPlaces = 2;
            this.nudMora.ForeColor = System.Drawing.SystemColors.Window;
            this.nudMora.Location = new System.Drawing.Point(416, 431);
            this.nudMora.Name = "nudMora";
            this.nudMora.ReadOnly = true;
            this.nudMora.Size = new System.Drawing.Size(175, 34);
            this.nudMora.TabIndex = 21;
            this.nudMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(200, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor da mora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(200, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "geralmente R$0,33";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbAPD);
            this.panel1.Location = new System.Drawing.Point(569, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 415);
            this.panel1.TabIndex = 24;
            // 
            // chkbAPD
            // 
            this.chkbAPD.AutoSize = true;
            this.chkbAPD.Enabled = false;
            this.chkbAPD.Location = new System.Drawing.Point(4, 376);
            this.chkbAPD.Name = "chkbAPD";
            this.chkbAPD.Size = new System.Drawing.Size(85, 35);
            this.chkbAPD.TabIndex = 28;
            this.chkbAPD.TabStop = false;
            this.chkbAPD.Text = "chkb";
            this.chkbAPD.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "Valor do juros:";
            // 
            // nudResJuros
            // 
            this.nudResJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.nudResJuros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudResJuros.DecimalPlaces = 2;
            this.nudResJuros.ForeColor = System.Drawing.SystemColors.Window;
            this.nudResJuros.Location = new System.Drawing.Point(416, 380);
            this.nudResJuros.Name = "nudResJuros";
            this.nudResJuros.ReadOnly = true;
            this.nudResJuros.Size = new System.Drawing.Size(175, 34);
            this.nudResJuros.TabIndex = 26;
            this.nudResJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(200, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 38);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Limpar campos";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkbDEP
            // 
            this.chkbDEP.AutoSize = true;
            this.chkbDEP.Enabled = false;
            this.chkbDEP.Location = new System.Drawing.Point(626, 383);
            this.chkbDEP.Name = "chkbDEP";
            this.chkbDEP.Size = new System.Drawing.Size(143, 35);
            this.chkbDEP.TabIndex = 28;
            this.chkbDEP.TabStop = false;
            this.chkbDEP.Text = "checkBox1";
            this.chkbDEP.UseVisualStyleBackColor = true;
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.chkbAtrasado);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudResJuros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudMora);
            this.Controls.Add(this.chkbDesconto);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chkbCalendario);
            this.Controls.Add(this.mcMes);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.txtbResul);
            this.Controls.Add(this.nudDesconto);
            this.Controls.Add(this.nudJuros);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.chkbDEP);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formBase";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPA";
            this.pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJuros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMora)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResJuros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHC;
        private System.Windows.Forms.Button btnMPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.NumericUpDown nudJuros;
        private System.Windows.Forms.TextBox txtbResul;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.MonthCalendar mcMes;
        private System.Windows.Forms.CheckBox chkbCalendario;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.NumericUpDown nudDesconto;
        private System.Windows.Forms.CheckBox chkbDesconto;
        private System.Windows.Forms.CheckBox chkbAtrasado;
        private System.Windows.Forms.NumericUpDown nudMora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudResJuros;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkbAPD;
        private System.Windows.Forms.CheckBox chkbDEP;
    }
}

