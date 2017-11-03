using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k1aHostToolKit;
using System.Deployment;
using System.Deployment.Application;
using System.Runtime.InteropServices;

namespace RM_Viewer
{
    public partial class MainForm : Form
    {
        //For menu border style
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        string lineNumber = "";

        string remarksType = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            string theme = RM_Viewer.Properties.Settings.Default.Theme;

            if (theme == "" || theme == "BLACK")
            {
                lstBoxAll.BackColor = lstBoxRM.BackColor = lstBoxRMB.BackColor = lstBoxRMQ.BackColor = lstBoxRMT.BackColor
                    = lstBoxRMW.BackColor = lstBoxRTF.BackColor = Color.Black;

                lstBoxAll.ForeColor = lstBoxRM.ForeColor = lstBoxRMB.ForeColor = lstBoxRMQ.ForeColor = lstBoxRMT.ForeColor
                    = lstBoxRMW.ForeColor = lstBoxRTF.ForeColor = Color.LimeGreen;
            }
            else if (theme == "PINK")
            {
                lstBoxAll.BackColor = lstBoxRM.BackColor = lstBoxRMB.BackColor = lstBoxRMQ.BackColor = lstBoxRMT.BackColor
                    = lstBoxRMW.BackColor = lstBoxRTF.BackColor = Color.Pink;

                lstBoxAll.ForeColor = lstBoxRM.ForeColor = lstBoxRMB.ForeColor = lstBoxRMQ.ForeColor = lstBoxRMT.ForeColor
                    = lstBoxRMW.ForeColor = lstBoxRTF.ForeColor = Color.DeepPink;
            }
            else if(theme == "BLUE")
            {
                lstBoxAll.BackColor = lstBoxRM.BackColor = lstBoxRMB.BackColor = lstBoxRMQ.BackColor = lstBoxRMT.BackColor
                       = lstBoxRMW.BackColor = lstBoxRTF.BackColor = Color.LightSteelBlue;

                lstBoxAll.ForeColor = lstBoxRM.ForeColor = lstBoxRMB.ForeColor = lstBoxRMQ.ForeColor = lstBoxRMT.ForeColor
                    = lstBoxRMW.ForeColor = lstBoxRTF.ForeColor = Color.MidnightBlue;
            }
            else if(theme == "WHITE")
            {
                lstBoxAll.BackColor = lstBoxRM.BackColor = lstBoxRMB.BackColor = lstBoxRMQ.BackColor = lstBoxRMT.BackColor
                    = lstBoxRMW.BackColor = lstBoxRTF.BackColor = Color.White;

                lstBoxAll.ForeColor = lstBoxRM.ForeColor = lstBoxRMB.ForeColor = lstBoxRMQ.ForeColor = lstBoxRMT.ForeColor
                    = lstBoxRMW.ForeColor = lstBoxRTF.ForeColor = Color.Black;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void RetrieveRecord()
        {
            lstBoxAll.Items.Clear();
            lstBoxRM.Items.Clear();
            lstBoxRMB.Items.Clear();
            lstBoxRMQ.Items.Clear();
            lstBoxRMT.Items.Clear();
            lstBoxRMW.Items.Clear();

            var session = new k1aHostToolKit.HostSession();

            var PNR = new s1aPNR.PNR();

            if (txtBoxReloc.Text != "" && txtBoxReloc.Text.Length == 6)
            {
                session.Send("IG");

                session.Send("RT" + txtBoxReloc.Text);
            }


            PNR.RetrieveCurrent(session);

            var remarks = PNR.RemarkElements;           

                foreach (s1aPNR.RemarkElement item in remarks)
            {
                var tempRM = item.Text;

                //Get RM Fields
                string[] temp = item.Text.Split(' ');

                if (item.Text.Contains("*FF30"))
                    tempRM = temp[0] + " [Global Customer No] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF31"))
                    tempRM = temp[0] + " [Local Customer No] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF32"))
                    tempRM = temp[0] + " [Employee Number] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF33"))
                    tempRM = temp[0] + " [Traveller Status] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF34"))
                    tempRM = temp[0] + " [Cost Center Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF35"))
                    tempRM = temp[0] + " [Project Number] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF36"))
                    tempRM = temp[0] + " [Department Number] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF37"))
                    tempRM = temp[0] + " [Order Reference No] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF38"))
                    tempRM = temp[0] + " [Approver] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF39"))
                    tempRM = temp[0] + " [Approval Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF40"))
                    tempRM = temp[0] + " [Manager Superior] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF41"))
                    tempRM = temp[0] + " [Reason of Trip] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF42"))
                    tempRM = temp[0] + " [Major Class] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF43"))
                    tempRM = temp[0] + " [Stop Over Flag] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF44"))
                    tempRM = temp[0] + " [Tour Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF45"))
                    tempRM = temp[0] + " [Reason Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF46"))
                    tempRM = temp[0] + " [Reason Code Denied] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF47"))
                    tempRM = temp[0] + " [FFLYR No] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF48"))
                    tempRM = temp[0] + " [Hotel Booked Flag] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF49"))
                    tempRM = temp[0] + " [Air No Accomodation Reason Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF50"))
                    tempRM = temp[0] + " [Hotel Reason Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF51"))
                    tempRM = temp[0] + " [Car Booked Flag] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF52"))
                    tempRM = temp[0] + " [Sales Channel] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF53"))
                    tempRM = temp[0] + " [Record Type] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF54"))
                    tempRM = temp[0] + " [CS Data 1] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF55"))
                    tempRM = temp[0] + " [CS Data 2] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF56"))
                    tempRM = temp[0] + " [CS Data 3] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF57"))
                    tempRM = temp[0] + " [CS Data 4] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF58"))
                    tempRM = temp[0] + " [CS Data 12] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF59"))
                    tempRM = temp[0] + " [CS Data 7] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF60"))
                    tempRM = temp[0] + " [CS Data 8] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF61"))
                    tempRM = temp[0] + " [CS Data 6] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF62"))
                    tempRM = temp[0] + " [CS Data 5] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF70"))
                    tempRM = temp[0] + " [Hotel Chain Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF71"))
                    tempRM = temp[0] + " [Hotel Property Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF72"))
                    tempRM = temp[0] + " [Room Type Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF73"))
                    tempRM = temp[0] + " [Number of Rooms] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF74"))
                    tempRM = temp[0] + " [Rate Type Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF75"))
                    tempRM = temp[0] + " [GDS Room Type Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF80"))
                    tempRM = temp[0] + " [Trip Type] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF81"))
                    tempRM = temp[0] + " [Fuel Surcharge_YQ] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF82"))
                    tempRM = temp[0] + " [PV Tax] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF83"))
                    tempRM = temp[0] + " [Terminal Fee LI] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF84"))
                    tempRM = temp[0] + " [Code Share Flight] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF85"))
                    tempRM = temp[0] + " [Net Ticket] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF86"))
                    tempRM = temp[0] + " [Customer Spec Low Fare] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF87"))
                    tempRM = temp[0] + " [Customer Spec High Fare] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF88"))
                    tempRM = temp[0] + " [E-Ticket Indicator] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF90"))
                    tempRM = temp[0] + " [Delivery/Departure Airport/City Name] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF91"))
                    tempRM = temp[0] + " [Delivery/Departure Country Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF92"))
                    tempRM = temp[0] + " [Delivery/Arrival Airport/ City Name] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF93"))
                    tempRM = temp[0] + " [Delivery/Arrival Countery Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF94"))
                    tempRM = temp[0] + " [Class Code] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF95"))
                    tempRM = temp[0] + " [Reservation Date] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF96"))
                    tempRM = temp[0] + " [Time of Booking] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF98"))
                    tempRM = temp[0] + " [Rail Origin Code New] " + tempRM.Replace(temp[0], "");

                else if (item.Text.Contains("*FF99"))
                    tempRM = temp[0] + " [Rail Destination Code New] " + tempRM.Replace(temp[0], "");

                lstBoxAll.Items.Add(tempRM);

                if (temp[1] == "RM")
                {
                    lstBoxRM.Items.Add(tempRM);
                }
                else if (temp[1] == "RMT")
                    lstBoxRMT.Items.Add(item.Text);
                else if (temp[1] == "RMB")
                    lstBoxRMB.Items.Add(item.Text);
                else if (temp[1] == "RMQ")
                    lstBoxRMQ.Items.Add(item.Text);
                else if (temp[1] == "RMW")
                    lstBoxRMW.Items.Add(item.Text);
            }

            var FA = PNR.FareAutoTktElements;

            foreach (s1aPNR.FareAutoTktElement item in FA)
            {
                lstBoxRTF.Items.Add(item.Text);
            }

            var FE = PNR.FareEndoElements;

            foreach (s1aPNR.FareEndoElement item in FE)
            {
                lstBoxRTF.Items.Add(item.Text);
            }

            var FT = PNR.FareTourCodeElements;

            foreach (s1aPNR.FareTourCodeElement item in FT)
            {
                lstBoxRTF.Items.Add(item.Text);
            }

            var FV = PNR.FareTransmissionElements;

            foreach (s1aPNR.FareTransmissionElement item in FV)
            {
                lstBoxRTF.Items.Add(item.Text);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            RetrieveRecord();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtBoxSelectedRemarks.Text != "" && lineNumber != "")
            {
                var session = new k1aHostToolKit.HostSession();

                session.Send(lineNumber.Replace(" ","") + "/" + txtBoxSelectedRemarks.Text);

                //ALL List
                foreach (var item in lstBoxAll.Items)
                {
                    string[] temp = item.ToString().Split(' ');

                    if (temp[0] == lineNumber)
                    {
                        lstBoxAll.Items[lstBoxAll.Items.IndexOf(item)] = lineNumber + " " + remarksType + " " + txtBoxSelectedRemarks.Text;

                        break;
                    }
                }

                //RM List
                foreach(var item in lstBoxRM.Items)
                {
                    string[] temp = item.ToString().Split(' ');

                    if(temp[0] == lineNumber)
                    {
                        lstBoxRM.Items[lstBoxRM.Items.IndexOf(item)] = lineNumber + " " + remarksType + " " + txtBoxSelectedRemarks.Text;

                        break;
                    }
                }

                //RMB List
                foreach(var item in lstBoxRMB.Items)
                {
                    string[] temp = item.ToString().Split(' ');

                    if(temp[0] == lineNumber)
                    {
                        lstBoxRMB.Items[lstBoxRMB.Items.IndexOf(item)] = lineNumber + " " + remarksType + " " + txtBoxSelectedRemarks.Text;

                        break;
                    }
                }

                //RMT List
                foreach(var item in lstBoxRMT.Items)
                {
                    string[] temp = item.ToString().Split(' ');

                    if(temp[0] == lineNumber)
                    {
                        lstBoxRMT.Items[lstBoxRMT.Items.IndexOf(item)] = lineNumber + " " + remarksType + " " + txtBoxSelectedRemarks.Text;

                        break;
                    }
                }

                //RMQ List
                foreach(var item in lstBoxRMQ.Items)
                {
                    string[] temp = item.ToString().Split(' ');

                    if(temp[0] == lineNumber)
                    {
                        lstBoxRMQ.Items[lstBoxRMQ.Items.IndexOf(item)] = lineNumber + " " + remarksType + " " + txtBoxSelectedRemarks.Text;

                        break;
                    }
                }

                //RMW List
                foreach(var item in lstBoxRMW.Items)
                {
                    string[] temp = item.ToString().Split(' ');

                    if(temp[0] == lineNumber)
                    {
                        lstBoxRMW.Items[lstBoxRMW.Items.IndexOf(item)] = lineNumber + " " + remarksType + " " + txtBoxSelectedRemarks.Text;

                        break;
                    }
                }
            }

            //RetrieveRecord();

            txtBoxSelectedRemarks.Text = lineNumber = remarksType  = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to clear? [Y/N]", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var session = new k1aHostToolKit.HostSession();

                session.Send("IG");

                lstBoxAll.Items.Clear();
                lstBoxRM.Items.Clear();
                lstBoxRMB.Items.Clear();
                lstBoxRMQ.Items.Clear();
                lstBoxRMT.Items.Clear();
                lstBoxRMW.Items.Clear();
                txtBoxReloc.Text = txtBoxSelectedRemarks.Text = "";
            }
        }

        private void lstBoxAll_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickList("ALL");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxSelectedRemarks.Text != "" && lineNumber != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? [Y/N]", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var session = new k1aHostToolKit.HostSession();

                    session.Send("XE" + lineNumber.Replace(" ",""));

                    //ALL list
                    foreach (var item in lstBoxAll.Items)
                    {
                        string[] temp = item.ToString().Split(' ');

                        if (temp[0] == lineNumber)
                        {
                            lstBoxAll.Items.Remove(item);

                            break;
                        }
                    }

                    //RM List
                    foreach (var item in lstBoxRM.Items)
                    {
                        string[] temp = item.ToString().Split(' ');

                        if (temp[0] == lineNumber)
                        {
                            lstBoxRM.Items.Remove(item);

                            break;
                        }
                    }

                    //RMB List
                    foreach (var item in lstBoxRMB.Items)
                    {
                        string[] temp = item.ToString().Split(' ');

                        if (temp[0] == lineNumber)
                        {
                            lstBoxRMB.Items.Remove(item);

                            break;
                        }
                    }

                    //RMT List
                    foreach (var item in lstBoxRMQ.Items)
                    {
                        string[] temp = item.ToString().Split(' ');

                        if (temp[0] == lineNumber)
                        {
                            lstBoxRMQ.Items.Remove(item);

                            break;
                        }
                    }

                    //RMW List
                    foreach (var item in lstBoxRMW.Items)
                    {
                        string[] temp = item.ToString().Split(' ');

                        if (temp[0] == lineNumber)
                        {
                            lstBoxRMW.Items.Remove(item);

                            break;
                        }
                    }

                    txtBoxSelectedRemarks.Text = lineNumber = remarksType  = "";
                }
            }
            else
            {
                MessageBox.Show("Please select remarks to be deleted", "Warning");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach(var item in lstBoxAll.Items)
            {
                string[] temp = item.ToString().Split(' ');

                if(item.ToString().ToUpper().Contains(txtBoxSearch.Text.ToUpper()))
                {
                    lineNumber = temp[0];

                    for (int x = 2; x < temp.Length; x++)
                    {
                        txtBoxSelectedRemarks.Text = txtBoxSelectedRemarks.Text + temp[x];
                    }

                    return;
                }
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var session = new k1aHostToolKit.HostSession();

            txtBoxSelectedRemarks.Text = "";

            session.Send("IR");
        }

        private void DoubleClickList(string type)
        {
            txtBoxSelectedRemarks.Text = "";

            string temp = "";

            if (type == "ALL")
                temp = lstBoxAll.SelectedItem.ToString();
            else if (type == "RM")
                temp = lstBoxRM.SelectedItem.ToString();
            else if (type == "RMB")
                temp = lstBoxRMB.SelectedItem.ToString();
            else if (type == "RMT")
                temp = lstBoxRMT.SelectedItem.ToString();
            else if (type == "RMQ")
                temp = lstBoxRMQ.SelectedItem.ToString();
            else if (type == "RMW")
                temp = lstBoxRMW.SelectedItem.ToString();

            if (temp.Contains("*FF"))
            {
                string[] tempArray = temp.Split('[');

                lineNumber = tempArray[0];

                string[] tempArray2 = tempArray[1].Split(']');
                string[] tempArray3 = tempArray2[1].Split(' ');

                remarksType = tempArray3[0];

                for (int x = 2; x < tempArray3.Length; x++)
                {
                    txtBoxSelectedRemarks.Text = txtBoxSelectedRemarks.Text + tempArray3[x];
                }
            }
            else
            {

                string[] tempArray = temp.Split(' ');

                lineNumber = tempArray[0];//line number

                remarksType = tempArray[1];//Remarks Type

                for (int x = 2; x < tempArray.Length; x++)
                {
                    txtBoxSelectedRemarks.Text = txtBoxSelectedRemarks.Text + tempArray[x];
                }
            }
        }

        private void lstBoxRM_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickList("RM");
        }

        private void lstBoxRMB_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickList("RMB");
        }

        private void lstBoxRMT_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickList("RMT");
        }

        private void lstBoxRMQ_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickList("RMQ");
        }

        private void lstBoxRMW_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickList("RMW");
        }

        private void txtBoxReloc_TextChanged(object sender, EventArgs e)
        {
            txtBoxReloc.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtBoxReloc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxReloc_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                RetrieveRecord();
            }
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            string patchNotes = "";

            patchNotes += "- Added RTF Fields";
            patchNotes += "\n- Will now retrieve record when press ENTER key";
            patchNotes += "\n- User Interface enchancement";
            patchNotes += "\n- Edit function fixes";
            patchNotes += "\n- User Interface Design";

            MessageBox.Show(patchNotes, "Patch Notes " +lblVersion.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeTheme(string type)
        {
            RM_Viewer.Properties.Settings.Default.Theme = type;

            RM_Viewer.Properties.Settings.Default.Save();
        }

        private void btnPinkTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme("PINK");

            LoadTheme();
        }

        private void btnBlackTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme("BLACK");

            LoadTheme();
        }

        private void btnBlueTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme("BLUE");

            LoadTheme();
        }

        private void btnWhiteTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme("WHITE");

            LoadTheme();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_tick_blank;
            }
            else
            {
                WindowState = FormWindowState.Maximized;

                btnMaximized.Image = null;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_duplicate;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_duplicate;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Normal;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_tick_blank;
            }
        }

        private void MenuMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void ChangeFontSize(int _size)
        {
            lstBoxAll.Font = lstBoxRM.Font = lstBoxRMB.Font = 
                lstBoxRMQ.Font = lstBoxRMT.Font = lstBoxRMW.Font = lstBoxRTF.Font = new Font(lstBoxAll.Font.FontFamily, _size);
        }

        private void cmbBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontSize(int.Parse(cmbBoxFontSize.Text));
        }
    }
}
