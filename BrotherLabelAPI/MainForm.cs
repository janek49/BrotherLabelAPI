using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bpac;

namespace BrotherLabelAPI
{
    public partial class MainForm : Form
    {
        private static MainForm instance;

        public MainForm()
        {
            instance = this;
            InitializeComponent();
            LocalServer server = new LocalServer();
            server.Start();
        }

        private string fileBaseLinkerProductTemplate = "BASELINKER_PRODUKT.lbx";
        private string fileBaseLinkerProductTemplateSmall = "BASELINKER_PRODUKT_SMALL.lbx";

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            await prePrint(fileBaseLinkerProductTemplate);
        }

        async Task<bool> prePrint(string file)
        {
            tabControl1.Enabled = false;
            WaitDialog wd = new WaitDialog();
            wd.Show();

            await Task.Run(() => startPrint(file));

            wd.Close();
            tabControl1.Enabled = true;
            return true;
        }

        void startPrint(string file)
        {
            //fixes bug which causes the font to shrink over time
            string tempFile = "temp.lbx";
            File.Copy(file, tempFile);

            DocumentClass doc = new DocumentClass();

            if (doc.Open(tempFile))
            {
                string sku = txtSKU.Text.Trim();
                if (sku.Length == 0)
                    sku = txtID.Text.Trim();

                setTextField(doc.GetObject("textSKU"), "SKU:", sku);
                setTextField(doc.GetObject("textEAN"), "EAN:", txtEAN.Text);

                doc.GetObject("textProductName").Text = txtProduct.Text;

                doc.GetObject("barcodeMain").Text = sku;

                doc.Save();
                doc.StartPrint("", PrintOptionConstants.bpoHighSpeed);
                doc.PrintOut(1, PrintOptionConstants.bpoHighSpeed);
                doc.EndPrint();
                doc.Close();
            }
            else
            {
                MessageBox.Show("Błąd drukowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void setTextField(bpac.Object obj, string lbl, string text)
        {
            obj.Text = lbl + "\n";
            int skip = obj.Text.Length - 1;
            obj.SetSelection(0, skip);
            obj.SetFontBold(true);
            obj.Text += text;
            obj.SetSelection(skip, obj.Text.Length);
            obj.SetFontBold(false);
        }

        public static void HandleRequest(string name, string id, string ean, string sku)
        {
            instance.BeginInvoke(new Action(() =>
            {
                instance.txtProduct.Text = name;
                instance.txtID.Text = id;
                instance.txtEAN.Text = ean;
                instance.txtSKU.Text = sku;
                if (instance.cbAutoPrint.Checked)
                {
                    instance.Invoke(new Action(() => instance.btnPrintSmal_Click(null, null)));
                }
                else
                {
                    instance.Show();
                    instance.WindowState = FormWindowState.Normal;
                    instance.Activate();
                }
            }));
        }

        private async void btnPrintSmal_Click(object sender, EventArgs e)
        {
            await prePrint(fileBaseLinkerProductTemplateSmall);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void taskbarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
