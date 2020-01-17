using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using MmiCtrlDotNET;

namespace MmiCtrlTest.HMI
{
    public partial class GUI : Form
    {
        MmiCtrDotNet MMICTRL { get; set; }

        public GUI()
        {
            MMICTRL = new MmiCtrDotNet() { IsTraceActive = true };

            MMICTRL.OnTrasnferStateMsg += this.OnTransferStateChanged;
            MMICTRL.OnPlcMsg += this.OnPlcMsg;
            MMICTRL.OnStateMsg += this.OnStateMsg;

            InitializeComponent();

            this.Text += Environment.Is64BitProcess ? " - (64Bit Process)" : " - (32Bit Process)";
            this.cbDprAreas.DataSource = Enum.GetNames(typeof(MmiDpr.Areas));

            this.cbDataTypes.DataSource = new string[] { "Byte", "Word", "Double" };

            var root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MmiCtrlTest");

            if (Directory.Exists(root))
            {
                this.tbFirmware.Text = Directory.GetFiles(root).FirstOrDefault(item => item.ToLower().EndsWith(".rsc"));
                this.tbSps.Text = Directory.GetFiles(root).FirstOrDefault(item => item.ToLower().EndsWith(".prg"));
                this.tbMk.Text = Directory.GetFiles(root).FirstOrDefault(item => item.ToLower().EndsWith(".mk"));
                this.tbDin.Text = Directory.GetFiles(root).FirstOrDefault(item => item.ToLower().EndsWith(".din"));
            }
        }

        private void OnPlcMsg(object sender, byte sb1, byte sb2, byte index, byte[] data)
        {
        }

        private void OnStateMsg(object sender, string message, int time)
        {
            MessageBox.Show(message, "Received display message", MessageBoxButtons.OK);
        }

        private void OnTransferStateChanged(object sender, MmiFileTransfer ftm)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("Transfer state : {0} [{1}]", ftm.State, ftm.Progress));
        }

        private void OnLoadFirmwareClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.DownloadFirmware("SBO", this.tbFirmware.Text, this.tbSps.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.DisConnect();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnWritePFieldClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPfieldIndex.Text) || string.IsNullOrEmpty(tbPfiedVal.Text))
                {
                    return;
                }

                var index = ushort.Parse(tbPfieldIndex.Text);
                var value = double.Parse(tbPfiedVal.Text);

                MMICTRL.WritePField(index, value);

                tbPfieldIndex.Text = null;
                tbPfiedVal.Text = null;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnReadPFieldClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPfieldIndex.Text))
                {
                    return;
                }

                var index = ushort.Parse(tbPfieldIndex.Text);
                var value = MMICTRL.ReadPField(index);

                tbPfiedVal.Text = $"{value}";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnDprWriteClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbDprAddress.Text) || string.IsNullOrEmpty(tbDprVal.Text))
                {
                    return;
                }

                Enum.TryParse<MmiDpr.Areas>(cbDprAreas.SelectedItem.ToString(), out MmiDpr.Areas area);
                var addr = ushort.Parse(tbDprAddress.Text);

                switch (this.cbDataTypes.SelectedItem.ToString().ToLower())
                {
                    case "byte":
                        var valueB = byte.Parse(tbDprVal.Text);
                        MMICTRL.SetDprByte(area, addr, valueB);
                        break;

                    case "word":
                        var valueW = ushort.Parse(tbDprVal.Text);
                        MMICTRL.SetDprWord(area, addr, valueW);

                        break;

                    case "double":
                        var valueD = double.Parse(tbDprVal.Text);
                        MMICTRL.SetDprDouble(area, addr, valueD);

                        break;

                    default:
                        throw new Exception("Unhandled data type: " + this.cbDataTypes.SelectedItem);
                }

                tbDprAddress.Text = null;
                tbDprVal.Text = null;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnDprReadClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbDprAddress.Text))
                {
                    return;
                }

                Enum.TryParse(cbDprAreas.SelectedItem.ToString(), out MmiDpr.Areas area);

                var addr = ushort.Parse(tbDprAddress.Text);
                string value;

                switch (this.cbDataTypes.SelectedItem.ToString().ToLower())
                {
                    case "byte":
                        value = $"{MMICTRL.GetDprByte(area, addr)}";
                        break;

                    case "word":
                        value = $"{MMICTRL.GetDprWord(area, addr)}";
                        break;

                    case "double":
                        value = $"{MMICTRL.GetDprDouble(area, addr)}";
                        break;

                    default:
                        throw new Exception("Unhandled data type: " + this.cbDataTypes.SelectedItem);
                }

                tbDprVal.Text = $"{value}";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnLoadMkClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.DownloadMK(this.tbMk.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnLoadDinClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.DownloadDin(this.tbDin.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnAckErrorsClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.AcknAllErrors();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnStartClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.StartProgram();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnStopClick(object sender, EventArgs e)
        {
            try
            {
                MMICTRL.StopProgram();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnSendMsgClick(object sender, EventArgs e)
        {
            try
            {
                var data = new byte[] {};
                MMICTRL.SendPlcMsg(0xff, 0x80, 0, data);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void OnSendSingleBlockClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbSingleBlock.Text))
                {
                    return;
                }

                MMICTRL.SendSingleBlock(tbSingleBlock.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
