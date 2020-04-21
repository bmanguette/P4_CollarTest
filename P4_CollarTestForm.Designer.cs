namespace P4_CollarTest
{
    partial class P4_CollarTestForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxComPortGolden = new System.Windows.Forms.ComboBox();
            this.comboBoxComPortToTest = new System.Windows.Forms.ComboBox();
            this.buttonCheckGolden = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSn = new System.Windows.Forms.TextBox();
            this.textBoxWeek = new System.Windows.Forms.TextBox();
            this.buttonTestRf = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxUartLog = new System.Windows.Forms.TextBox();
            this.textBoxRssiRf = new System.Windows.Forms.TextBox();
            this.textBoxRssiBLE_0 = new System.Windows.Forms.TextBox();
            this.textBoxBattery = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BgW_CheckGolden = new System.ComponentModel.BackgroundWorker();
            this.BgW_DetectPcb = new System.ComponentModel.BackgroundWorker();
            this.BgW_TestRf = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM Port Golden ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "COM Port PCB à tester ";
            // 
            // comboBoxComPortGolden
            // 
            this.comboBoxComPortGolden.FormattingEnabled = true;
            this.comboBoxComPortGolden.Location = new System.Drawing.Point(147, 40);
            this.comboBoxComPortGolden.Name = "comboBoxComPortGolden";
            this.comboBoxComPortGolden.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPortGolden.TabIndex = 12;
            this.comboBoxComPortGolden.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPortGolden_SelectedIndexChanged);
            // 
            // comboBoxComPortToTest
            // 
            this.comboBoxComPortToTest.FormattingEnabled = true;
            this.comboBoxComPortToTest.Location = new System.Drawing.Point(147, 72);
            this.comboBoxComPortToTest.Name = "comboBoxComPortToTest";
            this.comboBoxComPortToTest.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPortToTest.TabIndex = 13;
            // 
            // buttonCheckGolden
            // 
            this.buttonCheckGolden.Location = new System.Drawing.Point(304, 38);
            this.buttonCheckGolden.Name = "buttonCheckGolden";
            this.buttonCheckGolden.Size = new System.Drawing.Size(119, 23);
            this.buttonCheckGolden.TabIndex = 16;
            this.buttonCheckGolden.Text = "Test Golden";
            this.buttonCheckGolden.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Incrément (1->9999)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Num.Semaine (ie 10)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Année (20)";
            // 
            // textBoxSn
            // 
            this.textBoxSn.Location = new System.Drawing.Point(320, 139);
            this.textBoxSn.Name = "textBoxSn";
            this.textBoxSn.Size = new System.Drawing.Size(46, 20);
            this.textBoxSn.TabIndex = 28;
            // 
            // textBoxWeek
            // 
            this.textBoxWeek.Location = new System.Drawing.Point(209, 139);
            this.textBoxWeek.Name = "textBoxWeek";
            this.textBoxWeek.Size = new System.Drawing.Size(37, 20);
            this.textBoxWeek.TabIndex = 27;
            // 
            // buttonTestRf
            // 
            this.buttonTestRf.Location = new System.Drawing.Point(146, 208);
            this.buttonTestRf.Name = "buttonTestRf";
            this.buttonTestRf.Size = new System.Drawing.Size(119, 23);
            this.buttonTestRf.TabIndex = 26;
            this.buttonTestRf.Text = "Test Radio & BLE";
            this.buttonTestRf.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(146, 179);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 23);
            this.buttonStart.TabIndex = 25;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(144, 136);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(36, 20);
            this.textBoxYear.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Serial Number";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 237);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 31);
            this.labelStatus.TabIndex = 34;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(259, 281);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(238, 157);
            this.textBoxLog.TabIndex = 33;
            // 
            // textBoxUartLog
            // 
            this.textBoxUartLog.Location = new System.Drawing.Point(15, 281);
            this.textBoxUartLog.Multiline = true;
            this.textBoxUartLog.Name = "textBoxUartLog";
            this.textBoxUartLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUartLog.Size = new System.Drawing.Size(238, 157);
            this.textBoxUartLog.TabIndex = 32;
            // 
            // textBoxRssiRf
            // 
            this.textBoxRssiRf.Enabled = false;
            this.textBoxRssiRf.Location = new System.Drawing.Point(662, 211);
            this.textBoxRssiRf.Name = "textBoxRssiRf";
            this.textBoxRssiRf.Size = new System.Drawing.Size(86, 20);
            this.textBoxRssiRf.TabIndex = 42;
            // 
            // textBoxRssiBLE_0
            // 
            this.textBoxRssiBLE_0.Enabled = false;
            this.textBoxRssiBLE_0.Location = new System.Drawing.Point(662, 185);
            this.textBoxRssiBLE_0.Name = "textBoxRssiBLE_0";
            this.textBoxRssiBLE_0.Size = new System.Drawing.Size(86, 20);
            this.textBoxRssiBLE_0.TabIndex = 40;
            // 
            // textBoxBattery
            // 
            this.textBoxBattery.Enabled = false;
            this.textBoxBattery.Location = new System.Drawing.Point(662, 159);
            this.textBoxBattery.Name = "textBoxBattery";
            this.textBoxBattery.Size = new System.Drawing.Size(86, 20);
            this.textBoxBattery.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "RSSI RF (RX & TX) : > -40dBm :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "RSSI BLE 0 : > -40dBm :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Batterie : 3400mV <mV<3700mV :";
            // 
            // P4_CollarTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRssiRf);
            this.Controls.Add(this.textBoxRssiBLE_0);
            this.Controls.Add(this.textBoxBattery);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.textBoxUartLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSn);
            this.Controls.Add(this.textBoxWeek);
            this.Controls.Add(this.buttonTestRf);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCheckGolden);
            this.Controls.Add(this.comboBoxComPortToTest);
            this.Controls.Add(this.comboBoxComPortGolden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "P4_CollarTestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxComPortGolden;
        private System.Windows.Forms.ComboBox comboBoxComPortToTest;
        private System.Windows.Forms.Button buttonCheckGolden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSn;
        private System.Windows.Forms.TextBox textBoxWeek;
        private System.Windows.Forms.Button buttonTestRf;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxUartLog;
        private System.Windows.Forms.TextBox textBoxRssiRf;
        private System.Windows.Forms.TextBox textBoxRssiBLE_0;
        private System.Windows.Forms.TextBox textBoxBattery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker BgW_CheckGolden;
        private System.ComponentModel.BackgroundWorker BgW_DetectPcb;
        private System.ComponentModel.BackgroundWorker BgW_TestRf;
    }
}

