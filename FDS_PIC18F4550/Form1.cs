using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDS_PIC18F4550
{
    public partial class Form1 : Form
    {
        //Create a delegate function for this thread that will take
        //  in a string and will write it to the any Received textbox
        delegate void SetTextCallback(string text);
        string DataReceived;

        

        public Form1()
        {
            InitializeComponent();

            //Initialize the COM ports list
            UpdateCOMPortList();

            btnConnect.Text = "CONECTAR";

            

        }

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    AD0_MediaGauge.Value = trackBar1.Value;
        //    AD1_MediaGauge.Value = trackBar1.Value;
        //    AD0_InstGauge.Value = trackBar1.Value;
        //    AD1_InstGauge.Value = trackBar1.Value;
        //}

        /****************************************************************************
          Function:
            private void timer1_Tick(object sender, EventArgs e)

          Summary:
            This function updates the COM ports listbox.

          Description:
            This function updates the COM ports listbox.  This function is launched 
            periodically based on its Interval attribute (set in the form editor under
            the properties window).
         
          Precondition:
            None

          Parameters:
            object sender     - Sender of the event (this form)
            EventArgs e       - The event arguments

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            //Update the COM ports list so that we can detect
            //  new COM ports that have been added.
            UpdateCOMPortList();
        }

        /****************************************************************************
          Function:
            private void UpdateCOMPortList()

          Summary:
            This function updates the COM ports listbox.

          Description:
            This function updates the COM ports listbox.  This function is launched 
            periodically based on its Interval attribute (set in the form editor under
            the properties window).
         
          Precondition:
            None

          Parameters:
            None

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void UpdateCOMPortList()
        {
            int i;
            bool foundDifference;

            i = 0;
            foundDifference = false;

            //If the number of COM ports is different than the last time we
            //  checked, then we know that the COM ports have changed and we
            //  don't need to verify each entry.
            if (lstCOMPorts.Items.Count == SerialPort.GetPortNames().Length)
            {
                //Search the entire SerialPort object.  Look at COM port name
                //  returned and see if it already exists in the list.
                foreach (string s in SerialPort.GetPortNames())
                {
                    //If any of the names have changed then we need to update 
                    //  the list
                    if (lstCOMPorts.Items[i++].Equals(s) == false)
                    {
                        foundDifference = true;
                    }
                }
            }
            else
            {
                foundDifference = true;
            }

            //If nothing has changed, exit the function.
            if (foundDifference == false)
            {
                return;
            }

            //If something has changed, then clear the list
            lstCOMPorts.Items.Clear();

            //Add all of the current COM ports to the list
            foreach (string s in SerialPort.GetPortNames())
            {
                lstCOMPorts.Items.Add(s);
            }
            //Set the listbox to point to the first entry in the list
            lstCOMPorts.SelectedIndex = 0;
        }

        /****************************************************************************
          Function:
            private void btnConnect_Click(object sender, EventArgs e)

          Summary:
            This function opens the COM port.

          Description:
            This function opens the COM port.  This function is launched when the 
            btnConnect button is clicked.  In addition to opening the COM port, this 
            function will also change the Enable attribute of several of the form
            objects to disable the user from opening a new COM port.
         
          Precondition:
            None

          Parameters:
            object sender     - Sender of the event (this form)
            EventArgs e       - The event arguments

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void btnConnect_Click(object sender, System.EventArgs e)
        {

            if (btnConnect.Text == "CONECTAR")
            {
                //This section of code will try to open the COM port.
                //  Please note that it is important to use a try/catch
                //  statement when opening the COM port.  If a USB virtual
                //  COM port is removed and the PC software tries to open
                //  the COM port before it detects its removal then
                //  an exeception is thrown.  If the execption is not in a
                //  try/catch statement this could result in the application
                //  crashing.
                try
                {
                    //Get the port name from the application list box.
                    //  the PortName attribute is a string name of the COM
                    //  port (e.g. - "COM1").
                    serialPort1.PortName = lstCOMPorts.Items[lstCOMPorts.SelectedIndex].ToString();

                    //Open the COM port.
                    serialPort1.Open();

                    //Change the state of the application objects
                    btnConnect.Text = "DESCONECTAR";
                    lstCOMPorts.Enabled = false;
                    gbADC.Enabled = true;
                    gbLEDs.Enabled = true;
                    gbEEPROM.Enabled = true;
                    gbSwiths.Enabled = true;

                }
                catch 
                {
                    //If there was an exception, then close the handle to 
                    //  the device and assume that the device was removed
                    CloseExeption(this, null); 
                }

            }
            else
            {
                try
                {
                    //Change the state of the application objects
                    btnConnect.Text = "CONECTAR";
                    lstCOMPorts.Enabled = true;
                    gbADC.Enabled = false;
                    gbLEDs.Enabled = false;
                    gbEEPROM.Enabled = false;
                    gbSwiths.Enabled = false;

                    //Dispose the In and Out buffers;
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();

                    //Close the COM port
                    serialPort1.Close();
                }
                //If there was an exeception then there isn't much we can
                //  do.  The port is no longer available.
                catch { CloseExeption(this, null); }

            }

        }

        /****************************************************************************
          Function:
            private void serialPort1_DataReceived(  object sender, 
                                                    SerialDataReceivedEventArgs e)

          Summary:
            This function prints any data received on the COM port.

          Description:
            This function is called when the data is received on the COM port.  This
            function attempts to write that data to the txtDataReceived textbox.  If
            an exception occurs the btnClose_Click() function is called in order to
            close the COM port that caused the exception.

          Precondition:
            None

          Parameters:
            object sender     - Sender of the event (this form)
            SerialDataReceivedEventArgs e       - The event arguments

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //The ReadExisting() function will read all of the data that
            //  is currently available in the COM port buffer.  In this 
            //  example we are sending all of the available COM port data
            //  to the SetText() function.
            //
            //  NOTE: the <SerialPort>_DataReceived() function is launched
            //  in a seperate thread from the rest of the application.  A
            //  delegate function is required in order to properly access
            //  any managed objects inside of the other thread.  Since we
            //  will be writing to a textBox (a managed object) the delegate
            //  function is required.  Please see the SetText() function for 
            //  more information about delegate functions and how to use them.
            try
            {
                DataReceived = serialPort1.ReadExisting();
                SetText(DataReceived);
                
            }
            catch
            { CloseExeption(this, null); }
        }

        /****************************************************************************
          Function:
            private void SetText(string text)

          Summary:
            This function prints the input text to the txtDataReceived textbox.

          Description:
            This function prints the input text to the txtDataReceived textbox.  If
            the calling thread is the same as the thread that owns the textbox, then
            the AppendText() method is called directly.  If a thread other than the
            main thread calls this function, then an instance of the delegate function
            is created so that the function runs again in the main thread.

          Precondition:
            None

          Parameters:
            string text     - Text that needs to be printed to the textbox

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void SetText(string text)
        {
            if (txtReadData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                //enquanto não chegar o valor, a caixa fica vermelha, apos receber, fica verde.
                //textBox1.Clear();
                //textBox1.AppendText(text);
                recebe_usb(text);
            }
        }

        /****************************************************************************
          Function:
            private void SendDataToDevice(string text)

          Summary:
            This function prints the input text.

          Description:
            This function prints the input text.  If
            the calling thread is the same as the thread that owns the text, then
            the AppendText() method is called directly.  If a thread other than the
            main thread calls this function, then an instance of the delegate function
            is created so that the function runs again in the main thread.

          Precondition:
            None

          Parameters:
            string text     - Text that needs to be printed to the textbox

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void SendDataToDevice(string data)
        {
            try
            {
                //Write the data in the text box to the open serial port
                serialPort1.Write(data);
            }
            catch
            { CloseExeption(this, null); }
        }

        /****************************************************************************
          Function:
            private void CloseExeption(object sender, EventArgs e)

          Summary:
            This function closes the COM port.

          Description:
            This function closes the COM port.  This function is launched when the 
            btnClose button is clicked.  This function can also be called directly
            from other functions.  In addition to closing the COM port, this 
            function will also change the Enable attribute of several of the form
            objects to enable the user to open a new COM port.

          Precondition:
            None

          Parameters:
            object sender     - Sender of the event (this form)
            EventArgs e       - The event arguments

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void CloseExeption(object sender, System.EventArgs e)
        {
            //Reset the state of the application objects
            btnConnect.Text = "CONECTAR";
            lstCOMPorts.Enabled = true;

            //This section of code will try to close the COM port.
            //  Please note that it is important to use a try/catch
            //  statement when closing the COM port.  If a USB virtual
            //  COM port is removed and the PC software tries to close
            //  the COM port before it detects its removal then
            //  an exeception is thrown.  If the execption is not in a
            //  try/catch statement this could result in the application
            //  crashing.
            try
            {
                //Dispose the In and Out buffers;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();

                //Close the COM port
                serialPort1.Close();
            }
            //If there was an exeception then there isn't much we can
            //  do.  The port is no longer available.
            catch { }
        }

        private void recebe_usb(string a)
        {
            // /#AD0M0658#\  -> 12
            // /#SWST00#\    -> 10
            // /#EEPR00#\    -> 10

            string str1, str2, str3, str4, str5;
            int valueConverted, SizeOfString = a.Length;

            try
            {
                if(SizeOfString == 12)
                {
                    str1 = a.Substring(0, 2);// /#
                    str2 = a.Substring(2, 3);// AD0
                    str3 = a.Substring(5, 1);// M
                    str4 = a.Substring(6, 4);// 0658
                    str5 = a.Substring(10, 2);// #\
                }
                else
                {
                    str1 = a.Substring(0, 2);// /#
                    str2 = a.Substring(2, 4);// EEPR
                    str3 = a.Substring(6, 2);// 00
                    str4 = a.Substring(6, 2);// 
                    str5 = a.Substring(8, 2);// #\
                }

                if (str1 == "/#" && str5 == @"#\")
                {
                    if (str2 == "AD0")
                    {
                        if (str3 == "M")
                        {
                            AD0_MediaGauge.Value = (int)Convert.ToInt32(str4);
                            lbAD0_MediaGauge.Text = Convert.ToInt32(str4).ToString();
                            AD0_MediaGauge.BackColor = Color.WhiteSmoke;
                            btnAD0_media.Enabled = true;
                        }
                        if (str3 == "I")
                        {
                            AD0_InstGauge.Value = (int)Convert.ToInt32(str4);
                            lbAD0_InstaGauge.Text = Convert.ToInt32(str4).ToString();
                            AD0_InstGauge.BackColor = Color.WhiteSmoke;
                            btnAD0_instante.Enabled = true;
                        }

                    }
                    if (str2 == "AD1")
                    {
                        if (str3 == "M")
                        {
                            AD1_MediaGauge.Value = (int)Convert.ToInt32(str4);
                            lbAD1_MediaGauge.Text = Convert.ToInt32(str4).ToString();
                            AD1_MediaGauge.BackColor = Color.WhiteSmoke;
                            btnAD1_media.Enabled = true;
                        }
                        if (str3 == "I")
                        {
                            AD1_InstGauge.Value = (int)Convert.ToInt32(str4);
                            lbAD1_InstaGauge.Text = Convert.ToInt32(str4).ToString();
                            AD1_InstGauge.BackColor = Color.WhiteSmoke;
                            btnAD1_instante.Enabled = true;
                        }
                    }
                    if (str2 == "EEPR")
                    {
                        txtReadData.Text = str3;
                    }
                    if (str2 == "SWST")
                    {
                        //txtReadData.Text = Convert.ToDecimal(str3).ToString();
                        //txtReadData.Text =  string.Join("", str3.Select
                        //    (c => String.Format("{0:X2}", Convert.ToInt32(c)))) ;

                        //txtReadData.Text = ConvertStringToHex(str3);
                        //txtReadData.Text = Convert.ToUInt16(str3).ToString("X2");
                        //MessageBox.Show(Convert.ToUInt16(str3, 2).ToString());
                        //txtReadData.Text = Convert.ToSByte(str3).ToString();
                        valueConverted = Int16.Parse(str3, System.Globalization.NumberStyles.HexNumber);

                        if (Convert.ToBoolean(valueConverted & 0x01)) btnStatusSW1.Text = "ON";
                        else btnStatusSW1.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x02)) btnStatusSW2.Text = "ON";
                        else btnStatusSW2.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x04)) btnStatusSW3.Text = "ON";
                        else btnStatusSW3.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x08)) btnStatusSW4.Text = "ON";
                        else btnStatusSW4.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x10)) btnStatusSW5.Text = "ON";
                        else btnStatusSW5.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x20)) btnStatusSW6.Text = "ON";
                        else btnStatusSW6.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x40)) btnStatusSW7.Text = "ON";
                        else btnStatusSW7.Text = "OFF";

                        if (Convert.ToBoolean(valueConverted & 0x80)) btnStatusSW8.Text = "ON";
                        else btnStatusSW8.Text = "OFF";

                    }
                }
            }
            catch
            { }

        }
        private string ConvertStringToHex(String input)
        {
            int Index = 0;
            int Decimal = 0;
            foreach (char Char in input.Reverse())
            {
                if (Index != 0)
                {
                    Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                    Index = Index * 2;
                }
                else
                {
                    Decimal += Convert.ToInt32(Char.ToString());
                    Index++;
                }
            }

            //return toHex(Convert.ToInt64(Decimal));
            return Convert.ToInt64(Decimal).ToString();
        }

        private string toHex(Int64 d)
        {
            var r = d % 16;
            string result;
            if (d - r == 0)
                result = toChar(Convert.ToInt32(r));
            else
                result = toHex((d - r) / 16) + toChar(Convert.ToInt32(r));
            return result;
        }

        private string toChar(int n)
        {
            const string alpha = "0123456789ABCDEF";
            return alpha.Substring(n, 1);
        }

        /****************************************************************************
          Function:
            private void LED0_CheckedChanged(object sender, EventArgs e)

          Summary:
            This function will attempt to send the contents of LED0 state over the COM port

          Description:
            This function is called when the SendDataToDevice is checked/unchecked.  It will 
            attempt to send the contents of LED0 state over the COM port. 

          Precondition:
            None

          Parameters:
            object sender     - Sender of the event (this form)
            EventArgs e       - The event arguments

          Return Values:
            None

          Remarks:
            None
          ***************************************************************************/
        private void LED0_CheckedChanged(object sender, EventArgs e)
        {            
            
        }


        private void sendToLED( bool onOff, string ValueToSend)
        {
            try
            {
                //This section of code will try to write to the COM port.
                //  Please note that it is important to use a try/catch
                //  statement when writing to the COM port.  If a USB virtual
                //  COM port is removed and the PC software tries to write
                //  to the COM port before it detects its removal then
                //  an exeception is thrown.  If the execption is not in a
                //  try/catch statement this could result in the application
                //  crashing.

                if (onOff)
                {
                    string valueMsgLength = "9";
                    string valueMsgID = "06";
                    string valueMsgValue = ValueToSend;

                    string valueToSend = "/<" +
                        valueMsgLength +
                        valueMsgID +
                        valueMsgValue +
                        @">\";

                    SendDataToDevice(valueToSend);
                }
                else
                {
                    string valueMsgLength = "9";
                    string valueMsgID = "06";
                    string valueMsgValue = ValueToSend;

                    string valueToSend = "/<" +
                        valueMsgLength +
                        valueMsgID +
                        valueMsgValue +
                        @">\";

                    SendDataToDevice(valueToSend);
                }
            }
            catch
            { }
        }

        private void btnAD0_instante_Click(object sender, EventArgs e)
        {//AD0_Inst
            string valueMsgLength = "7";
            string valueMsgID = "0";
            string valueMsgValue = "0";

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
            AD0_InstGauge.BackColor = Color.Red;
            btnAD0_instante.Enabled = false;
        }
        
        private void btnAD1_instante_Click(object sender, EventArgs e)
        {//AD1_Inst
            string valueMsgLength = "7";
            string valueMsgID = "0";
            string valueMsgValue = "1";

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
            AD1_InstGauge.BackColor = Color.Red;
            btnAD1_instante.Enabled = false;
        }


        private void btnAD0_media_Click(object sender, EventArgs e)
        {//AD0_media
            string valueMsgLength = "7";
            string valueMsgID = "0";
            string valueMsgValue = "2";

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
            AD0_MediaGauge.BackColor = Color.Red;
            btnAD0_media.Enabled = false;
        }

        private void btnAD1_media_Click(object sender, EventArgs e)
        {//AD1_media
            string valueMsgLength = "7";
            string valueMsgID = "0";
            string valueMsgValue = "3";

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
            AD1_MediaGauge.BackColor = Color.Red;
            btnAD1_media.Enabled = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string valueMsgLength = "B";
            string valueMsgID = "07";
            string valueMsgValue = numericUpDown1.Value.ToString() +
                                numericUpDown2.Value.ToString();

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string valueMsgLength = "B";
            string valueMsgID = "05";
            string valueMsgValue = numericUpDown3.Value.ToString();

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
        }

        private void btnReadSwitchs_Click(object sender, EventArgs e)
        {
            string valueMsgLength = "7";
            string valueMsgID = "0";
            string valueMsgValue = "4";

            string valueToSend = "/<" +
                valueMsgLength +
                valueMsgID +
                valueMsgValue +
                @">\";

            SendDataToDevice(valueToSend);
        }
    }
}
