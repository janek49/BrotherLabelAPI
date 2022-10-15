namespace BrotherLabelAPI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBaselinkerProduct = new System.Windows.Forms.TabPage();
            this.btnPrintSmal = new System.Windows.Forms.Button();
            this.cbAutoPrint = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabBaselinkerProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBaselinkerProduct);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ImageList = this.imgList;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBaselinkerProduct
            // 
            this.tabBaselinkerProduct.Controls.Add(this.btnPrintSmal);
            this.tabBaselinkerProduct.Controls.Add(this.cbAutoPrint);
            this.tabBaselinkerProduct.Controls.Add(this.btnPrint);
            this.tabBaselinkerProduct.Controls.Add(this.txtSKU);
            this.tabBaselinkerProduct.Controls.Add(this.txtEAN);
            this.tabBaselinkerProduct.Controls.Add(this.txtID);
            this.tabBaselinkerProduct.Controls.Add(this.txtProduct);
            this.tabBaselinkerProduct.Controls.Add(this.label4);
            this.tabBaselinkerProduct.Controls.Add(this.label3);
            this.tabBaselinkerProduct.Controls.Add(this.label2);
            this.tabBaselinkerProduct.Controls.Add(this.label1);
            this.tabBaselinkerProduct.ImageIndex = 2;
            this.tabBaselinkerProduct.Location = new System.Drawing.Point(4, 31);
            this.tabBaselinkerProduct.Name = "tabBaselinkerProduct";
            this.tabBaselinkerProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaselinkerProduct.Size = new System.Drawing.Size(792, 415);
            this.tabBaselinkerProduct.TabIndex = 0;
            this.tabBaselinkerProduct.Text = "Etykieta produktu BaseLinker";
            this.tabBaselinkerProduct.UseVisualStyleBackColor = true;
            // 
            // btnPrintSmal
            // 
            this.btnPrintSmal.Image = global::BrotherLabelAPI.Properties.Resources.filequickprint;
            this.btnPrintSmal.Location = new System.Drawing.Point(18, 162);
            this.btnPrintSmal.Name = "btnPrintSmal";
            this.btnPrintSmal.Size = new System.Drawing.Size(152, 35);
            this.btnPrintSmal.TabIndex = 12;
            this.btnPrintSmal.Text = "Drukuj";
            this.btnPrintSmal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSmal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintSmal.UseVisualStyleBackColor = true;
            this.btnPrintSmal.Click += new System.EventHandler(this.btnPrintSmal_Click);
            // 
            // cbAutoPrint
            // 
            this.cbAutoPrint.AutoSize = true;
            this.cbAutoPrint.Location = new System.Drawing.Point(195, 168);
            this.cbAutoPrint.Name = "cbAutoPrint";
            this.cbAutoPrint.Size = new System.Drawing.Size(181, 24);
            this.cbAutoPrint.TabIndex = 11;
            this.cbAutoPrint.Text = "Drukuj automatycznie";
            this.cbAutoPrint.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BrotherLabelAPI.Properties.Resources.filequickprint;
            this.btnPrint.Location = new System.Drawing.Point(18, 203);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 35);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Drukuj długą";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(524, 103);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(247, 26);
            this.txtSKU.TabIndex = 9;
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(271, 103);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(247, 26);
            this.txtEAN.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(247, 26);
            this.txtID.TabIndex = 5;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(18, 39);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(753, 26);
            this.txtProduct.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SKU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "EAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa produktu:";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "editdelete.png");
            this.imgList.Images.SetKeyName(1, "package.png");
            this.imgList.Images.SetKeyName(2, "kuser2.png");
            // 
            // taskbarIcon
            // 
            this.taskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarIcon.Icon")));
            this.taskbarIcon.Text = "Brother Label API";
            this.taskbarIcon.Visible = true;
            this.taskbarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskbarIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brother Label API";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabBaselinkerProduct.ResumeLayout(false);
            this.tabBaselinkerProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBaselinkerProduct;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox cbAutoPrint;
        private System.Windows.Forms.Button btnPrintSmal;
        private System.Windows.Forms.NotifyIcon taskbarIcon;
    }
}

