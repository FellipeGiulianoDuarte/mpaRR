
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
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJuros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pButtons.Controls.Add(this.btnLogout);
            this.pButtons.Controls.Add(this.btnHC);
            this.pButtons.Controls.Add(this.btnMPA);
            this.pButtons.Controls.Add(this.btnReminder);
            this.pButtons.Location = new System.Drawing.Point(-2, -1);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(182, 572);
            this.pButtons.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(15, 457);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 97);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
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
            this.btnMPA.TabIndex = 1;
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
            this.btnReminder.TabIndex = 0;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor do boleto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mora por dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor final:";
            // 
            // nudValor
            // 
            this.nudValor.BackColor = System.Drawing.SystemColors.Window;
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudValor.Location = new System.Drawing.Point(445, 48);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(150, 38);
            this.nudValor.TabIndex = 8;
            // 
            // nudJuros
            // 
            this.nudJuros.DecimalPlaces = 2;
            this.nudJuros.Location = new System.Drawing.Point(445, 174);
            this.nudJuros.Name = "nudJuros";
            this.nudJuros.Size = new System.Drawing.Size(150, 38);
            this.nudJuros.TabIndex = 9;
            this.nudJuros.ValueChanged += new System.EventHandler(this.nudJuros_ValueChanged);
            // 
            // nudDesconto
            // 
            this.nudDesconto.DecimalPlaces = 2;
            this.nudDesconto.Location = new System.Drawing.Point(445, 235);
            this.nudDesconto.Name = "nudDesconto";
            this.nudDesconto.Size = new System.Drawing.Size(150, 38);
            this.nudDesconto.TabIndex = 10;
            // 
            // txtbResul
            // 
            this.txtbResul.Location = new System.Drawing.Point(445, 486);
            this.txtbResul.Name = "txtbResul";
            this.txtbResul.ReadOnly = true;
            this.txtbResul.Size = new System.Drawing.Size(150, 38);
            this.txtbResul.TabIndex = 13;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpVencimento.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(445, 107);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(150, 38);
            this.dtpVencimento.TabIndex = 14;
            // 
            // mcMes
            // 
            this.mcMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.mcMes.Enabled = false;
            this.mcMes.Location = new System.Drawing.Point(607, 174);
            this.mcMes.Name = "mcMes";
            this.mcMes.TabIndex = 15;
            this.mcMes.Visible = false;
            // 
            // chkbCalendario
            // 
            this.chkbCalendario.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbCalendario.AutoSize = true;
            this.chkbCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.chkbCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkbCalendario.Location = new System.Drawing.Point(634, 108);
            this.chkbCalendario.Name = "chkbCalendario";
            this.chkbCalendario.Size = new System.Drawing.Size(194, 41);
            this.chkbCalendario.TabIndex = 17;
            this.chkbCalendario.Text = "Exibir calendário";
            this.chkbCalendario.UseVisualStyleBackColor = false;
            this.chkbCalendario.CheckedChanged += new System.EventHandler(this.chkbCalendario_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Location = new System.Drawing.Point(445, 432);
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
            this.chkbDesconto.Location = new System.Drawing.Point(212, 310);
            this.chkbDesconto.Name = "chkbDesconto";
            this.chkbDesconto.Size = new System.Drawing.Size(181, 41);
            this.chkbDesconto.TabIndex = 19;
            this.chkbDesconto.Text = "desconto em %";
            this.chkbDesconto.UseVisualStyleBackColor = false;
            // 
            // chkbAtrasado
            // 
            this.chkbAtrasado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbAtrasado.AutoSize = true;
            this.chkbAtrasado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.chkbAtrasado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkbAtrasado.Location = new System.Drawing.Point(212, 357);
            this.chkbAtrasado.Name = "chkbAtrasado";
            this.chkbAtrasado.Size = new System.Drawing.Size(282, 41);
            this.chkbAtrasado.TabIndex = 20;
            this.chkbAtrasado.Text = "Atrasado perde desconto";
            this.chkbAtrasado.UseVisualStyleBackColor = false;
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.chkbAtrasado);
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
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formBase";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Reminder";
            this.Load += new System.EventHandler(this.formBase_Load);
            this.pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJuros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
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
    }
}

