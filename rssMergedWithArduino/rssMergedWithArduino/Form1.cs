using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;
using System.IO.Ports;
using System.Data.SqlClient;

namespace rssMergedWithArduino
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        int counterAttentionMessages = 0;
        int counterLife = 0;
        int counteScience = 0;
        int counterSport = 0;
        int counterEconomy = 0;

        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBoxCOM.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBoxCOM.SelectedItem = ports[0];
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader readXml = XmlReader.Create(textBoxURL.Text);
                SyndicationFeed feed = SyndicationFeed.Load(readXml);

                TabPage tab = new TabPage(feed.Title.Text);

                tabControlRSS.TabPages.Add(tab);

                ListBox list = new ListBox();

                tab.Controls.Add(list);

                list.Dock = DockStyle.Fill;

                list.HorizontalScrollbar = true;

                foreach (SyndicationItem item in feed.Items)
                {
                    list.Items.Add(item.Title.Text);
                    list.Items.Add(item.Summary.Text);
                    list.Items.Add("------------------");
                }

                if (textBoxURL.Text.Contains("economie"))
                {

                    counterEconomy++;
                    label2.Text = counterEconomy.ToString();

                }
                else if (textBoxURL.Text.Contains("sport"))
                {
                    counterSport++;
                    label3.Text = counterSport.ToString();

                }
                else if (textBoxURL.Text.Contains("science"))
                {
                    counteScience++;
                    label4.Text = counteScience.ToString();

                }
                else if (textBoxURL.Text.Contains("life"))
                {

                    counterLife++;
                    label5.Text = counterLife.ToString();

                }
            }
            catch { }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBoxCOM.GetItemText(comboBoxCOM.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            buttonConnect.Text = "Disconnect";
            enableControls();
        }



        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            buttonConnect.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void buttonWriteLCD_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#TEXT" + textBoxLCD.Text + "#\n");
            }
        }
        private void enableControls()
        {

            buttonWriteLCD.Enabled = true;
            textBoxLCD.Enabled = true;

            groupBoxLCD.Enabled = true;

        }

        private void disableControls()
        {

            buttonWriteLCD.Enabled = false;
            textBoxLCD.Enabled = false;

            groupBoxLCD.Enabled = false;
        }
        private void resetDefaults()
        {
            textBoxLCD.Text = "";

        }

        private void buttonWriteRSS_Click(object sender, EventArgs e)
        {
            XmlReader readXml = XmlReader.Create(textBoxURL.Text);
            SyndicationFeed feed = SyndicationFeed.Load(readXml);
            string nullText = " ";

            if (isConnected)
            {
                foreach (SyndicationItem item in feed.Items)
                {
                    
                    port.Write("#TEXT" + item.Title.Text + "#\n");
             
                  
                }
            }

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
        }

        private void buttonWriteLCD_MouseClick(object sender, MouseEventArgs e)
        {
            counterAttentionMessages++;
            label1.Text = counterAttentionMessages.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection(@"Data Source=ANDRA;Initial Catalog=AuthenticationCodeFirst;Integrated Security=True");
            con.Open();

            SqlCommand sqlCmd_statistic = new SqlCommand("INSERT INTO dbo.StatisticDataBases (Economy,Sport,Science,Life) VALUES (@economy,@sport,@science,@life)", con);
            sqlCmd_statistic.Parameters.AddWithValue("@economy",counterEconomy.ToString());
            sqlCmd_statistic.Parameters.AddWithValue("@sport", counterSport.ToString());
            sqlCmd_statistic.Parameters.AddWithValue("@science", counteScience.ToString());
            sqlCmd_statistic.Parameters.AddWithValue("@life", counterLife.ToString());

            sqlCmd_statistic.ExecuteNonQuery();

            MessageBox.Show("Registration is successful");
        }
    }
}
