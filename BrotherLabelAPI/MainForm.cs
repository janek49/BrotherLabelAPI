using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bpac;

namespace BrotherLabelAPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string fileBaseLinkerProductTemplate = "BASELINKER_PRODUKT.lbx";

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DocumentClass doc = new DocumentClass();

            if (doc.Open(fileBaseLinkerProductTemplate))
            {
                doc.GetObject("textProductName").Text = txtProduct.Text;

                setTextField(doc.GetObject("textProductID"), "ID:", txtID.Text);
                setTextField(doc.GetObject("textSKU"), "SKU:", txtSKU.Text);
                setTextField(doc.GetObject("textEAN"), "EAN:", txtEAN.Text);

                doc.GetObject("barcodeMain").Text = txtID.Text;

                doc.Save();
                //   doc.StartPrint("", PrintOptionConstants.bpoHighSpeed);
                //  doc.PrintOut(1, PrintOptionConstants.bpoHighSpeed);
                //   doc.EndPrint();
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
    }
}
