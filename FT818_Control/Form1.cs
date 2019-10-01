using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FT818_Control
{
    
    public partial class Form1 : Form
    {
        const byte LSB = 0x00;   // MODE
        const byte USB = 0x01;
        const byte CW = 0x02;
        const byte AM = 0x04;
        const byte FM = 0x08;
        const byte DIG = 0x0A;

        decimal freq = 7.00000m;           // current frequency
        decimal sfreq;
        decimal efreq;
        Boolean scstop;
        decimal fqstep = 0.005m; // 5KHz
        decimal fupdstep = 1m;  // 1MHz

        byte[] mdwd = { 0x00, 0x00, 0x00, 0x00, 0x07 }; // mode change write data
        byte[] getrsd = { 0x01, 0x00, 0x00, 0x00, 0xe7 }; // get rs report

        Bitmap canvas;
        Graphics g = null;
        Pen p;
        Pen p2;
        Pen p3;
        //
        public Form1()
        {
            InitializeComponent();
        }
        static byte[] DecimalToBCD(decimal dinput)
        {
            int input = Decimal.ToInt32(dinput * 100000);
            if (input > 99999999 || input < 0)
                throw new ArgumentOutOfRangeException("input");
            int tenmillions = input / 10000000;
            int millions = (input -= tenmillions * 10000000)/ 1000000;
            int hndthousands = (input -= millions * 1000000) / 100000;
            int tenthousands = (input -= hndthousands * 100000) / 10000;
            int thousands = (input -= tenthousands * 10000) / 1000;
            int hundreds = (input -= thousands * 1000) / 100;
            int tens = (input -= hundreds * 100) / 10;
            int ones = (input -= tens * 10);

            byte[] bcd = new byte[] {(byte)(tenmillions << 4 |millions),
                           (byte)(hndthousands << 4 |tenthousands),
                           (byte)(thousands << 4 | hundreds),
                           (byte)(tens << 4 | ones),
                           0x01
                         };

            return bcd;
        }
        /* 
         * mode change
         */ 
        private void Change_Mode(byte mode)
        {
            mdwd[0] = mode;
            if (serialPort1.IsOpen)
            {
                Disp_Write_Com(mdwd);
                serialPort1.Write(mdwd, 0, 5);
            }
            System.Threading.Thread.Sleep(200);
        }
        /* 
        * mode frequency
        */
        private void Change_Frequency(decimal fq)
        {
            byte[] wd = DecimalToBCD(fq);
            c_freq.Text = fq.ToString();
            if (serialPort1.IsOpen)
            {
                Disp_Write_Com(wd);
                serialPort1.Write(wd, 0, 5);
            }
            System.Threading.Thread.Sleep(200);
        }

        private void Band_Reset()
        {
            radio7mhz.Checked = false;
            radio15mhz.Checked = false;
            radio14mhz.Checked = false;
            radio50mhz.Checked = false;
            radio144mhz.Checked = false;
            radiocw.Enabled = false;
            radiofm.Enabled = false;
            radioam.Enabled = false;
            radiolsb.Enabled = false;
            radiousb.Enabled = false;
            radiodig.Enabled = false;
            radiowfm.Enabled = true;
            radiowfm.Checked = true;
            start_scan.Enabled = false;
        }
        private void Preset_Reset()
        {
            radiopreset1.Checked = false;
            radiopreset2.Checked = false;
            radiopreset3.Checked = false;
            radiopreset4.Checked = false;
            radiopreset5.Checked = false;
            radiowfm.Checked = false;
            radiowfm.Enabled = false;
            radioam.Enabled = true;
            radiocw.Enabled = true;
            radiofm.Enabled = true;
            radiousb.Enabled = true;
            radiolsb.Enabled = true;
            radiodig.Enabled = true;
            start_scan.Enabled = true;
        }
        private void Disp_Reset()
        {
            canvas = null;
            if (g != null) g.Dispose();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(canvas);
            g.DrawRectangle(p, 1, 1, pictureBox1.Width - 2, pictureBox1.Height - 2);
            g.DrawLine(p2, 1, pictureBox1.Height - 5, pictureBox1.Width - 1, pictureBox1.Height - 5);
            g.DrawLine(p3, 1, pictureBox1.Height / 2, pictureBox1.Width - 1, pictureBox1.Height / 2);
            pictureBox1.Image = canvas;
            pictureBox1.Refresh();
        }

        private void Disp_Write_Com(byte[] ba)
        {
            toolStripStatusLabel2.Text = "To FT818: " + ba[0].ToString("x2") + ba[1].ToString("x2") + ba[2].ToString("x2") + ba[3].ToString("x2") + ba[4].ToString("x2");
        }
        /*
         * 
         */
        private void Disp_Signal_Strength(int rs)
        {
            //Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Graphics g = Graphics.FromImage(canvas);
            //Pen p = new Pen(Color.Black, 1);
            int x;
            double x1 = Decimal.ToDouble((freq - sfreq) * 1000m);
            double x2 = Decimal.ToDouble((efreq - sfreq) * 1000m);
            double x3 = pictureBox1.Width;
            double x4 = (x1 / x2) * x3;
            x = (int)x4;
            if (x == 0) x = 1;

            if (rs == 0)
            {
                g.DrawLine(p, x, pictureBox1.Height - 3, x, pictureBox1.Height - 7);
                //textBox2.AppendText(x.ToString());
            } else {
                g.DrawLine(p, x, pictureBox1.Height - 10, x, pictureBox1.Height - 10 - rs * 6);
                //textBox2.AppendText(x.ToString());
                //p.Dispose();
                //g.Dispose();
            }
            pictureBox1.Image = canvas;
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                toolStripComboBox1.Items.Add(port);
            }
            //if (toolStripComboBox1.Items.Count > 0)
            //    toolStripComboBox1.SelectedIndex = 0;
            //canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //g = Graphics.FromImage(canvas);
            p = new Pen(Color.Black, 1);
            p2 = new Pen(Color.Black, 2);
            p3 = new Pen(Color.Black, 1);
            p3.DashStyle = DashStyle.Dot;
            //g.DrawRectangle(p, 1, 1, pictureBox1.Width-2, pictureBox1.Height-2);
            //g.DrawLine(p2, 1, pictureBox1.Height - 5, pictureBox1.Width-1, pictureBox1.Height - 5 );
            //g.DrawLine(p3, 1, pictureBox1.Height /2, pictureBox1.Width - 1, pictureBox1.Height/2);
            //pictureBox1.Image = canvas;
            //pictureBox1.Refresh();
            Disp_Reset();
            c_freq.Text = freq.ToString();
            this.ActiveControl = this.c_freq;
        }

        delegate void SetTextCallback(string text);
        private void Response(string text)
        {
            if (c_freq.InvokeRequired) // other Thead 
            {
                SetTextCallback d = new SetTextCallback(Response);
                BeginInvoke(d, new object[] { text });      // no blocking
            }
            else
            {
                //textBox1.AppendText(text + "\n");
                toolStripStatusLabel3.Text = "From FT818: " + text;
                string st = (text + "\n");
                int rs = int.Parse(st);
                rs = rs & 0x1f;
                if (start_scan.BackColor == Color.Yellow) // Scan is ongoing
                {
                    Disp_Signal_Strength(rs); // disp signal strength
                }
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string str = serialPort1.ReadLine();
            string str = serialPort1.ReadChar().ToString();
            Response(str);
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ポート");
            //ToolStripComboBox1_TextChanged(sender, e);
        }

        private void ToolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text.Equals("COM1")) {
                // NOP
                c_freq.Focus();
                SendKeys.Send("{ESC}");
            }
            else
            {
                serialPort1.BaudRate = 4800;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.Two;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = toolStripComboBox1.Text;
                //MessageBox.Show(serialPort1.PortName);
                serialPort1.Open();
                toolStripStatusLabel1.Text = "Opened:" + serialPort1.PortName;
                MessageBox.Show("ポート " + serialPort1.PortName + " オープン");
                c_freq.Focus();
                SendKeys.Send("{ESC}");
            }

        }


        private void Ef_down_Click(object sender, EventArgs e)
        {
            efreq = efreq - fupdstep;
            end_freq.Text = efreq.ToString();
        }

        private void Sf_up_Click(object sender, EventArgs e)
        {
            sfreq = sfreq + fupdstep;
            start_freq.Text = sfreq.ToString();
        }
        private void Sf_down_Click(object sender, EventArgs e)
        {
            sfreq = sfreq - fupdstep;
            start_freq.Text = sfreq.ToString();
        }
        private void Ef_up_Click(object sender, EventArgs e)
        {
            efreq = efreq + fupdstep;
            end_freq.Text = efreq.ToString();
        }
        /*
                 */
        private void Start_scan_Click(object sender, EventArgs e)
        {
            freq = sfreq;
            scstop = false;
            Disp_Reset();
            start_scan.BackColor = Color.Yellow;
            do {
                byte[] wd = DecimalToBCD(freq);
                c_freq.Text = freq.ToString();
                if (serialPort1.IsOpen)
                {
                    Disp_Write_Com(wd);
                    serialPort1.Write(wd, 0, 5);
                    System.Threading.Thread.Sleep(200);
                    //Disp_Write_Com(getrsd);
                    serialPort1.Write(getrsd, 0, 5); // get rs report
                }
                c_freq.Refresh();
                Disp_Signal_Strength(0);  /////
                int ii = 10;
                if (radiosinterval_s.Checked)
                {
                    ii = 2;
                } 
                for (int i = 0; i < ii; i++) {
                    System.Windows.Forms.Application.DoEvents();
                    if (scstop) break;
                    System.Threading.Thread.Sleep(500);
                }
                if (scstop) break;
                freq = freq + fqstep;
            } while (freq < efreq);
            start_scan.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Sc_stop_Click(object sender, EventArgs e)
        {
            scstop = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fupdstep = 1m;
        }

        private void Radioupdstep100k_CheckedChanged(object sender, EventArgs e)
        {
            fupdstep = 0.1m;
        }

        private void Radioupd10k_CheckedChanged(object sender, EventArgs e)
        {
            fupdstep = 0.01m;
        }
        private void Radioupd1k_CheckedChanged(object sender, EventArgs e)
        {
            fupdstep = 0.001m;
        }
        private void Radio7mhz_CheckedChanged(object sender, EventArgs e)
        {
            Preset_Reset();
            freq = 7.00000m;
            sfreq = 7.00000m;
            efreq = 7.20000m;
            start_freq.Text = sfreq.ToString();
            end_freq.Text = efreq.ToString();
            fqstep = 0.005m;
            Change_Frequency(freq);
            Change_Mode(LSB);
            radiolsb.Checked = true;
        }
        private void Radio14mhz_Click(object sender, EventArgs e)
        {
            Preset_Reset();
            freq = 14.00000m;
            sfreq =14.00000m;
            efreq =14.35000m;
            start_freq.Text = sfreq.ToString();
            end_freq.Text = efreq.ToString();
            fqstep = 0.005m;
            Change_Frequency(freq);
            Change_Mode(USB);
            radiousb.Checked = true;

        }
        private void Radio15mhz_CheckedChanged(object sender, EventArgs e)
        {
            Preset_Reset();
            freq = 12.00000m;
            sfreq = 12.00000m;
            efreq = 13.00000m;
            start_freq.Text = sfreq.ToString();
            end_freq.Text = efreq.ToString();
            fqstep = 0.005m;
            Change_Frequency(freq);
            Change_Mode(AM);
            radioam.Checked = true;
        }
        private void Radio50mhz_Click(object sender, EventArgs e)
        {
            Preset_Reset();
            freq = 50.00000m;
            sfreq = 50.00000m;
            efreq = 54.00000m;
            start_freq.Text = sfreq.ToString();
            end_freq.Text = efreq.ToString();
            fqstep = 0.1m;
            Change_Frequency(freq);
            Change_Mode(FM);
            radiofm.Checked = true;

        }
        private void Radio144mhz_Click(object sender, EventArgs e)
        {
            Preset_Reset();
            freq = 144.00000m;
            sfreq = 144.00000m;
            efreq = 146.00000m;
            start_freq.Text = sfreq.ToString();
            end_freq.Text = efreq.ToString();
            fqstep = 0.1m;
            Change_Frequency(freq);
            Change_Mode(FM);
            radiofm.Checked = true;

        }

        private void Radiofm_CheckedChanged(object sender, EventArgs e)
        {
            Change_Mode(FM);
        }

        private void Radioam_CheckedChanged(object sender, EventArgs e)
        {
            Change_Mode(AM);
        }

        private void Radiodig_CheckedChanged(object sender, EventArgs e)
        {
            Change_Mode(DIG);
        }

        private void Radiocw_CheckedChanged(object sender, EventArgs e)
        {
            Change_Mode(CW);
        }

        private void Radiousb_CheckedChanged(object sender, EventArgs e)
        {
            Change_Mode(USB);
        }

        private void Radiolsb_CheckedChanged(object sender, EventArgs e)
        {
            Change_Mode(LSB);
        }

        private void Radiopreset1_CheckedChanged(object sender, EventArgs e)
        {
            Band_Reset();
            freq = 80.40000m;  // AIR_G
            Change_Frequency(freq);
            //radiofm.Checked = true;
            //Change_Mode(FM);
        }

        private void Radiopreset2_CheckedChanged(object sender, EventArgs e)
        {
            Band_Reset();
            freq = 90.40000m;  // STV
            Change_Frequency(freq);
            //radiofm.Checked = true;
            //Change_Mode(FM);
        }

        private void Radiopreset3_CheckedChanged(object sender, EventArgs e)
        {
            Band_Reset();
            freq = 82.50000m;  // North Wave
            Change_Frequency(freq);
            //radiofm.Checked = true;
            //Change_Mode(FM);

        }

        private void Radiopreset4_CheckedChanged(object sender, EventArgs e)
        {
            Band_Reset();
            freq = 91.50000m;  // HBC
            Change_Frequency(freq);
            //radiofm.Checked = true;
            //Change_Mode(FM);

        }
        private void Radiopreset5_Click(object sender, EventArgs e)
        {
            Band_Reset();
            freq = 85.20000m;  // NHK
            Change_Frequency(freq);
            //radiofm.Checked = true;
            //Change_Mode(FM);
        }

        private void Cf_down_Click(object sender, EventArgs e)
        {
            freq = freq - fupdstep;
            c_freq.Text = freq.ToString();
        }

        private void Cf_up_Click(object sender, EventArgs e)
        {
            freq = freq + fupdstep;
            c_freq.Text = freq.ToString();
        }

        private void Cf_set_Click(object sender, EventArgs e)
        {
            Change_Frequency(freq);
        }

        private void CLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "COM:None";
            serialPort1.Close();
        }


        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (efreq - sfreq > 0)
            {
                Point getXY = e.Location;
                Decimal x1 = getXY.X;
                Decimal x2 = pictureBox1.Width;
                Decimal x3 = Decimal.Round((efreq - sfreq) * Decimal.Round(x1 / x2, 5) + sfreq, 5);
                Decimal x4 = Decimal.Round(x3 / fqstep);
                Decimal x5 = x4 * fqstep;
                c_freq.Text = x5.ToString("###.00000");
            }

        }
    }
}
