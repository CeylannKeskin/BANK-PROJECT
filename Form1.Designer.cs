namespace MONEYBANK_PROJECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnSiraAl = new Button();
            label2 = new Label();
            cmbIslem = new ComboBox();
            label1 = new Label();
            txtTc = new TextBox();
            lstVip = new ListBox();
            lstBireysel = new ListBox();
            lstGise = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(380, 81);
            button1.Name = "button1";
            button1.Size = new Size(106, 62);
            button1.TabIndex = 0;
            button1.Text = "Banka Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSiraAl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbIslem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Location = new Point(25, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnSiraAl
            // 
            btnSiraAl.BackColor = Color.RosyBrown;
            btnSiraAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiraAl.Location = new Point(200, 125);
            btnSiraAl.Name = "btnSiraAl";
            btnSiraAl.Size = new Size(90, 32);
            btnSiraAl.TabIndex = 4;
            btnSiraAl.Text = "Sıra Al";
            btnSiraAl.UseVisualStyleBackColor = false;
            btnSiraAl.Click += btnSiraAl_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "İşlem";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbIslem
            // 
            cmbIslem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbIslem.FormattingEnabled = true;
            cmbIslem.Location = new Point(123, 67);
            cmbIslem.Name = "cmbIslem";
            cmbIslem.Size = new Size(167, 23);
            cmbIslem.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTc
            // 
            txtTc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTc.Location = new Point(123, 24);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(167, 23);
            txtTc.TabIndex = 0;
            // 
            // lstVip
            // 
            lstVip.FormattingEnabled = true;
            lstVip.ItemHeight = 15;
            lstVip.Location = new Point(25, 328);
            lstVip.Name = "lstVip";
            lstVip.Size = new Size(141, 184);
            lstVip.TabIndex = 5;
            // 
            // lstBireysel
            // 
            lstBireysel.FormattingEnabled = true;
            lstBireysel.ItemHeight = 15;
            lstBireysel.Location = new Point(180, 328);
            lstBireysel.Name = "lstBireysel";
            lstBireysel.Size = new Size(141, 184);
            lstBireysel.TabIndex = 6;
            // 
            // lstGise
            // 
            lstGise.FormattingEnabled = true;
            lstGise.ItemHeight = 15;
            lstGise.Location = new Point(345, 328);
            lstGise.Name = "lstGise";
            lstGise.Size = new Size(141, 184);
            lstGise.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(25, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(240, 12);
            button2.Name = "button2";
            button2.Size = new Size(110, 78);
            button2.TabIndex = 0;
            button2.Text = "Gişe Oluştur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(627, 524);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lstGise);
            Controls.Add(lstBireysel);
            Controls.Add(lstVip);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Button btnSiraAl;
        private Label label2;
        private ComboBox cmbIslem;
        private Label label1;
        private TextBox txtTc;
        private ListBox lstVip;
        private ListBox lstBireysel;
        private ListBox lstGise;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
    }
}