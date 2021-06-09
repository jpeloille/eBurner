using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace eBurner
{
    public partial class Form1 : Form
    {
        public string cmd = string.Empty;

        public delegate void AddDataDelegate(String myString);// Delegate for richtextbox
        public AddDataDelegate myDelegate;// An instance of AddDataDelegate
        public delegate void AddDataDelegate_button(String myString);// Delegate for button
        public AddDataDelegate_button myDelegate_button;// An instance of AddDataDelegate_button

        public SerialPort arduinoPort; // = new SerialPort("COM5", 9600);
        public string[,] sixteenBytes = new string[8192, 16];
        public byte[] dataTAble = new byte[8192];
        
        public Form1()
        {
            InitializeComponent();


            columnHeader1.Text = "00";
            columnHeader2.Text = "01";
            columnHeader3.Text = "02";
            columnHeader4.Text = "03";
            columnHeader5.Text = "04";

            columnHeader6.Text = "05";
            columnHeader7.Text = "06";
            columnHeader8.Text = "07";
            columnHeader9.Text = "08";
            columnHeader10.Text = "09";

            columnHeader11.Text = "0A";
            columnHeader12.Text = "0B";
            columnHeader13.Text = "0C";
            columnHeader14.Text = "0D";
            columnHeader15.Text = "0E";

            columnHeader16.Text = "0F";

            columnHeader1.Width = 30;
            columnHeader2.Width = 30;
            columnHeader3.Width = 30;
            columnHeader4.Width = 30;
            columnHeader5.Width = 30;

            columnHeader6.Width = 30;
            columnHeader7.Width = 30;
            columnHeader8.Width = 30;
            columnHeader9.Width = 30;
            columnHeader10.Width = 30;

            columnHeader11.Width = 30;
            columnHeader12.Width = 30;
            columnHeader13.Width = 30;
            columnHeader14.Width = 30;
            columnHeader15.Width = 30;

            columnHeader16.Width = 30;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string port in SerialPort.GetPortNames())
            {
                cbComSelector.Items.Add(port);
            }            
        }

        private void onDataReceived(object sender, SerialDataReceivedEventArgs arg)
        {
            string s = arduinoPort.ReadExisting();//reads the serialport buffer

                richTextBox1.Invoke(this.myDelegate, new Object[] { s });//adds the recieved bytes to the richtextbox
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pbProcess.Maximum = 8192;
            pbProcess.Value = 0;
            for (int add = 0; add < 8192; add++)
            {
                pbProcess.Value = add;
                arduinoPort.Write(dataTAble,add,1);
                System.Threading.Thread.Sleep(1);

            }
            MessageBox.Show("Terminé.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            string fileName = fileDialog.FileName;

            using ( BinaryReader br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                int pos = 0;
                int i = 0;
                int y = 0;
                

                int length = (int)br.BaseStream.Length;
                while(pos < length)
                {
                    byte v = br.ReadByte();
                    dataTAble[pos] = v;
                    sixteenBytes[y, i] = v.ToString("X2");
                    i++;
                    if (i > 15)
                    {
                        i = 0;
                        y++;
                    }
                    pos += sizeof(byte);
                }

                ListViewItem item;
                for (int n=0; n<=8191; n++)
                {
                    item = new ListViewItem();
                    item.Text = sixteenBytes[n, 0];
                    for (int m=1; m <= 15; m++)
                    {
                        item.SubItems.Add(sixteenBytes[n, m]);
                    }
                    listView1.Items.Add(item);
                } 
            }
        }

        public void AddDataMethod_button(String myString)
        {
            btnWriteDatas.Text = myString;//changes button text
        }

        public void AddDataMethod(String myString)
        {
            richTextBox1.Text = myString + Environment.NewLine;//changes richtextbox text
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string inData = arduinoPort.ReadLine(); // ReadLine includes the + "\n"
            displayToWindow(inData);
        }

        private void displayToWindow(string inData)
        {
            BeginInvoke(new EventHandler(delegate
            {
                richTextBox1.AppendText(inData);
                richTextBox1.ScrollToCaret();
            }));
        }


        #region ButtonClickMethods
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            arduinoPort = new SerialPort(cbComSelector.Text.Trim(), 9600);
            arduinoPort.DataReceived += new SerialDataReceivedEventHandler(mySerialPort_DataReceived);
            arduinoPort.Open();

            this.myDelegate = new AddDataDelegate(AddDataMethod);//Assigning "the function that changes richtextbox text" to the delegate
            this.myDelegate_button = new AddDataDelegate_button(AddDataMethod_button);//Assigning "the function that changes button text" to the delegate

            cmd = "#CNNT " + "\n";
            arduinoPort.Write(cmd);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Thread thread;
            thread = new Thread(() => WriteBlock());
            thread.Start();         
        }

        private void BtnWriteData_Click(object sender, EventArgs e)
        {
            Thread thread;
            thread = new Thread(() => WriteData());
            thread.Start();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            cmd = "#READ 8192 " + "\n";
            arduinoPort.Write(cmd);
        }

        private void btnTestSignal_Click(object sender, EventArgs e)
        {
            string cmd = string.Empty;
            int iAdress = 8177;
            string adress = Convert.ToString(iAdress, 2).PadLeft(16, '0');
            string highAdress = adress.Substring(0, 8);
            string lowAdress = adress.Substring(8, 8);
            string data = Convert.ToString(dataTAble[iAdress], 2).PadLeft(8, '0');

            cmd = "#CNNT " + "\n";
            arduinoPort.Write(cmd);
            System.Threading.Thread.Sleep(5000);

            cmd = "#ADDH " + Convert.ToInt32(highAdress, 2) + " " + "\n";
            arduinoPort.Write(cmd);
            System.Threading.Thread.Sleep(10);

            cmd = "#ADDL " + Convert.ToInt32(lowAdress, 2) + " " + "\n";
            arduinoPort.Write(cmd);
            System.Threading.Thread.Sleep(10);

            cmd = "#DATA " + Convert.ToInt32(data, 2) + " " + "\n";
            arduinoPort.Write(cmd);
            System.Threading.Thread.Sleep(10);

            cmd = "#WRIT " + "\n";
            arduinoPort.Write(cmd);
            System.Threading.Thread.Sleep(5000);

            cmd = "#EOWT " + "\n";
            arduinoPort.Write(cmd);
        }

        #endregion

        #region GeneralMethods
        private int StringToInt(string str)
        {
            int i = 0;
            var isNumeric = int.TryParse(str, out int n);
            if (isNumeric) i = n;
            return i;
        }
        #endregion

        #region CoreMethods
        private void WriteBlock()
        {
            string cmd = string.Empty;
            string data = string.Empty;

            int maxAdress = 8192;
            int endAdress = Convert.ToInt32(tbEndAdress.Text, 16) + 1;
            int startAdress = Convert.ToInt32(tbStartAdress.Text, 16);
            
            SetProgressBarMinimum(0);
            SetProgressBarMaximum(endAdress - startAdress);
            int progessBarValue = 0;

            string adress = string.Empty;
            string highAdress = string.Empty;
            string lowAdress = string.Empty;

            if (endAdress > maxAdress) endAdress = maxAdress;

            SetProgressBarValue(progessBarValue);

            for (int currentAdress = startAdress; currentAdress < endAdress; currentAdress++) //MAX = 8192
            {
                adress = Convert.ToString(currentAdress, 2).PadLeft(16, '0');
                highAdress = adress.Substring(0, 8);
                lowAdress = adress.Substring(8, 8);
                data = Convert.ToString(dataTAble[currentAdress], 2).PadLeft(8, '0');

                cmd = "#ADDH " + Convert.ToInt32(highAdress, 2) + " " + "\n";
                arduinoPort.Write(cmd);
                Thread.Sleep(100);

                cmd = "#ADDL " + Convert.ToInt32(lowAdress, 2) + " " + "\n";
                arduinoPort.Write(cmd);
                Thread.Sleep(100);

                cmd = "#DATA " + Convert.ToInt32(data, 2) + " " + "\n";
                arduinoPort.Write(cmd);
                Thread.Sleep(100);

                cmd = "#WRIT " + "\n";
                arduinoPort.Write(cmd);
                Thread.Sleep(400);

                SetProgressBarValue(progessBarValue++);
            }
        }

        private void WriteData()
        {
            string cmd = string.Empty;
            string data = string.Empty;

            int startAdress = Convert.ToInt32(tbStartAdress.Text, 16);
            byte dataToWrite = Convert.ToByte(tbData.Text, 16);

            string adress = string.Empty;
            string highAdress = string.Empty;
            string lowAdress = string.Empty;

            adress = Convert.ToString(startAdress, 2).PadLeft(16, '0');
            highAdress = adress.Substring(0, 8);
            lowAdress = adress.Substring(8, 8);
            data = Convert.ToString(dataToWrite, 2).PadLeft(8, '0');

            cmd = "#ADDH " + Convert.ToInt32(highAdress, 2) + " " + "\n";
            arduinoPort.Write(cmd);
            Thread.Sleep(100);

            cmd = "#ADDL " + Convert.ToInt32(lowAdress, 2) + " " + "\n";
            arduinoPort.Write(cmd);
            Thread.Sleep(100);

            cmd = "#DATA " + Convert.ToInt32(data, 2) + " " + "\n";
            arduinoPort.Write(cmd);
            Thread.Sleep(100);

            cmd = "#WRIT " + "\n";
            arduinoPort.Write(cmd);
            Thread.Sleep(400);
        }
        #endregion

        #region UiRefreshMethods
        public void printToTerminal(string textToPrint)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(printToTerminal), new object[] { textToPrint });
                return;
            };

            richTextBox1.AppendText(textToPrint);
        }

        public void SetProgressBarMinimum(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(SetProgressBarMinimum), new object[] { value });
                return;
            };

            pbProcess.Minimum = value;
        }

        public void SetProgressBarMaximum(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(SetProgressBarMaximum), new object[] { value });
                return;
            };

            pbProcess.Maximum = value;
        }

        public void SetProgressBarValue(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(SetProgressBarValue), new object[] { value });
                return;
            };

            pbProcess.Value = value;
        }
        #endregion

        private void CbComSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
