using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_CollarTest
{
    public partial class P4_CollarTestForm : Form
    {
        delegate void SetTextCallback(TextBox tbox, string text); /* Delegate for cross-thread invoke on textbox control */
        delegate void SetLabelTextCallback(Label label, string text); /* Delegate for cross-thread invoke on textbox control */

        MsSerialPort msSerialPortGolden;
        MsSerialPort msSerialPortToCheck;
        string comPortGolden = null;
        string comPortCheck = null;
        uint year, week, serial;

        public P4_CollarTestForm()
        {
            InitializeComponent();
            msSerialPortGolden = new MsSerialPort(textBoxUartLog, this);
            msSerialPortToCheck = new MsSerialPort(textBoxUartLog, this);

            String[] comPortStr = msSerialPortGolden.GetPortNames();
            foreach (String name in comPortStr)
            {
                comboBoxComPortGolden.Items.Add(name);
            }

            ResetButton();

            getProperties();

        }

        private void getProperties()
        {
            uint persistentSerial = (uint)Properties.Settings.Default["Serial"];
            uint persistentWeek = (uint)Properties.Settings.Default["Week"];
            uint persistentYear = (uint)Properties.Settings.Default["Year"];

            uint startWeek;
            uint startYear;


            DateTime date = DateTime.Today;
            startYear = (uint)(date.Year - 2000);

            CultureInfo myCI = new CultureInfo("fr-FR");
            Calendar myCal = myCI.Calendar;
            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            startWeek = (uint)myCal.GetWeekOfYear(date, myCWR, myFirstDOW);

            if (startYear == persistentYear && startWeek == persistentWeek && persistentSerial != 0)
            {
                this.serial = persistentSerial + 1;
            }
            else this.serial = 1;

            this.year = startYear;
            this.week = startWeek;

            textBoxSn.Text = "" + this.serial;
            textBoxWeek.Text = "" + this.week;
            textBoxYear.Text = "" + this.year;
        }

        private void setProperties()
        {
            Properties.Settings.Default["Serial"] = this.serial;
            Properties.Settings.Default["Week"] = this.week;
            Properties.Settings.Default["Year"] = this.year;

            Properties.Settings.Default.Save();
        }

        public void SetText(TextBox tbox, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (tbox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { tbox, text });
            }
            else
            {
                tbox.AppendText(text);
            }

        }

        public void SetLabel(Label label, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (label.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabel);
                this.Invoke(d, new object[] { label, text });
            }
            else
            {
                label.Text = text;
            }

        }

        public Boolean parseSn(string strSN, int maxLength, out uint sn)
        {
            bool ret = false;
            if (strSN.Length > maxLength)
            {
                sn = 0;
                ret = false;
            }
            else if (UInt32.TryParse(strSN, out sn))
            {
                ret = true;
            }
            return ret;
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            // uint year=0;

            if (textBoxYear.Text.Length != 2 || !parseSn(textBoxYear.Text, 2, out year))
            {
                SetLabel(labelStatus, "Année doit être deux chiffes");
            }
            else
            {
                SetLabel(labelStatus, "Année OK :" + year);
                //EnableTextBoxWeek();
            }
        }

        private void textBoxWeek_TextChanged(object sender, EventArgs e)
        {
            //uint week = 0;

            if (textBoxWeek.Text.Length > 2 || !parseSn(textBoxWeek.Text, 2, out week))
            {
                SetLabel(labelStatus, "Week doit être deux chiffes (05 ou 23 par exemple)");
            }
            else
            {
                SetLabel(labelStatus, "Week OK :" + week);
                EnableTextBoxSn();
            }
        }

        private void textBoxSn_TextChanged(object sender, EventArgs e)
        {
            //  uint serial = 0;

            if (textBoxSn.Text.Length > 4 || !parseSn(textBoxSn.Text, 4, out serial))
            {
                SetLabel(labelStatus, "Serial doit être un nombre de 4 digits max.");
            }
            else
            {
                SetLabel(labelStatus, "Serial OK :" + serial);
                EnableButtonStart();
            }
        }

        private uint getSerial()
        {
            uint sn;
            sn = year * 1000000 + week * 10000 + serial;
            return sn;
        }

        private void comboBoxComPortGolden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComPortGolden.SelectedIndex == -1)
            {
                SetText(textBoxLog, "no ComPort Golden Choose\r\n");
                return;
            }
            else
            {
                comPortGolden = comboBoxComPortGolden.Text;
                msSerialPortGolden.Open(comboBoxComPortGolden.Text);
                SetText(textBoxLog, "Port com open : " + comPortGolden + "\r\n");
                EnableGolden();
            }
        }

        private void comboBoxComPortToCHeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComPortToTest.SelectedIndex == -1)
            {
                SetText(textBoxLog, "no ComPort For Checking Choose\r\n");
                return;
            }
            else
            {
                comPortCheck = comboBoxComPortToTest.Text;
                msSerialPortToCheck.Open(comboBoxComPortToTest.Text);
                SetText(textBoxLog, "Port com open : " + comPortCheck + "\r\n");
                EnableButtonStart();
            }
        }

        private void EnableGolden()
        {
            DisableAllButton();
            buttonCheckGolden.Enabled = true;
        }

        private void EnableComPortToCheck()
        {
            DisableAllButton();
            comboBoxComPortToTest.Enabled = true;
        }
        private void EnableButtonStart()
        {
            DisableAllButton();
            buttonStart.Enabled = true;
            textBoxYear.Enabled = true;
            textBoxWeek.Enabled = true;
            textBoxSn.Enabled = true;
        }

        private void EnableTextBoxYear()
        {
            DisableAllButton();
            textBoxYear.Enabled = true;
        }
        private void EnableTextBoxWeek()
        {
            DisableAllButton();
            textBoxWeek.Enabled = true;
        }
        private void EnableTextBoxSn()
        {
            DisableAllButton();
            textBoxSn.Enabled = true;
        }

        private void EnableButtonTestRf()
        {
            DisableAllButton();
            buttonTestRf.Enabled = true;
        }
        private void DisableAllButton()
        {
            comboBoxComPortGolden.Enabled = false;
            comboBoxComPortToTest.Enabled = false;
            textBoxYear.Enabled = false;
            textBoxWeek.Enabled = false;
            textBoxSn.Enabled = false;
            buttonStart.Enabled = false;
            buttonCheckGolden.Enabled = false;
            buttonTestRf.Enabled = false;
        }

        private void ClearTextBox()
        {
            textBoxBattery.Text = "";
            textBoxRssiBLE_0.Text = "";
            textBoxRssiRf.Text = "";
        }

        private void ResetButton()
        {
            DisableAllButton();
            comboBoxComPortGolden.Enabled = true;
        }

        private void UpdateComPortToCheck()
        {
            String[] comPortStr = msSerialPortToCheck.GetPortNames();
            foreach (String name in comPortStr)
            {
                comboBoxComPortToTest.Items.Add(name);
            }
        }


    }
}
