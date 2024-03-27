namespace WinFormsNetApp
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            ListViewItem listViewItem5 = new ListViewItem("");
            ListViewItem listViewItem6 = new ListViewItem("");
            ListViewItem listViewItem7 = new ListViewItem("");
            TreeNode treeNode1 = new TreeNode("Bilgisayar");
            TreeNode treeNode2 = new TreeNode("İnşaat");
            TreeNode treeNode3 = new TreeNode("Mühendislik Fakültesi", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Bilgisayar Programcılğıı");
            TreeNode treeNode5 = new TreeNode("Harita");
            TreeNode treeNode6 = new TreeNode("MYO", new TreeNode[] { treeNode4, treeNode5 });
            button1 = new Button();
            cb_HazirlikDurum = new CheckBox();
            clb_IlListesi = new CheckedListBox();
            cb_MeslekListe = new ComboBox();
            lbl_AnaBaslik = new Label();
            ll_universiteBaglanti = new LinkLabel();
            lb_BolumListe = new ListBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            maskedTextBox1 = new MaskedTextBox();
            monthCalendar1 = new MonthCalendar();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            birinciMenüToolStripMenuItem = new ToolStripMenuItem();
            ikinciMenüToolStripMenuItem = new ToolStripMenuItem();
            üçüncüMenüToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            printDialog1 = new PrintDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            openFileDialog1 = new OpenFileDialog();
            propertyGrid1 = new PropertyGrid();
            process1 = new System.Diagnostics.Process();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 207);
            button1.Name = "button1";
            button1.Size = new Size(133, 48);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_HazirlikDurum
            // 
            cb_HazirlikDurum.AutoSize = true;
            cb_HazirlikDurum.Location = new Point(197, 236);
            cb_HazirlikDurum.Name = "cb_HazirlikDurum";
            cb_HazirlikDurum.Size = new Size(149, 19);
            cb_HazirlikDurum.TabIndex = 2;
            cb_HazirlikDurum.Text = "Hazırlık Okudunuz Mu?";
            cb_HazirlikDurum.UseVisualStyleBackColor = true;
            // 
            // clb_IlListesi
            // 
            clb_IlListesi.FormattingEnabled = true;
            clb_IlListesi.Items.AddRange(new object[] { "Bilecik", "Hakkari", "Van", "Bitlis", "Trabzon", "Antalya", "İzmir", "İstanbul", "Erzurum" });
            clb_IlListesi.Location = new Point(148, 12);
            clb_IlListesi.Name = "clb_IlListesi";
            clb_IlListesi.Size = new Size(86, 166);
            clb_IlListesi.TabIndex = 3;
            clb_IlListesi.SelectedIndexChanged += clb_IlListesi_SelectedIndexChanged;
            // 
            // cb_MeslekListe
            // 
            cb_MeslekListe.ForeColor = Color.Red;
            cb_MeslekListe.FormattingEnabled = true;
            cb_MeslekListe.Items.AddRange(new object[] { "Mühendis", "Doktor", "Hemşire", "Uzman", "Teknisyen", "Tekniker", "Öğretmen" });
            cb_MeslekListe.Location = new Point(197, 28);
            cb_MeslekListe.Name = "cb_MeslekListe";
            cb_MeslekListe.Size = new Size(121, 23);
            cb_MeslekListe.TabIndex = 4;
            // 
            // lbl_AnaBaslik
            // 
            lbl_AnaBaslik.AutoSize = true;
            lbl_AnaBaslik.Font = new Font("Verdana", 33F);
            lbl_AnaBaslik.Location = new Point(96, 79);
            lbl_AnaBaslik.Name = "lbl_AnaBaslik";
            lbl_AnaBaslik.Size = new Size(590, 53);
            lbl_AnaBaslik.TabIndex = 5;
            lbl_AnaBaslik.Text = "Windows Form Kontrolleri";
            // 
            // ll_universiteBaglanti
            // 
            ll_universiteBaglanti.AutoSize = true;
            ll_universiteBaglanti.Location = new Point(197, 68);
            ll_universiteBaglanti.Name = "ll_universiteBaglanti";
            ll_universiteBaglanti.Size = new Size(104, 15);
            ll_universiteBaglanti.TabIndex = 6;
            ll_universiteBaglanti.TabStop = true;
            ll_universiteBaglanti.Text = "Bilecik Üniversitesi";
            // 
            // lb_BolumListe
            // 
            lb_BolumListe.FormattingEnabled = true;
            lb_BolumListe.ItemHeight = 15;
            lb_BolumListe.Items.AddRange(new object[] { "Bilgisayar Proglama", "Harita kadastro", "İnşaat", "Gıda", "Makina", "İşletme", "Diş Hekimliği" });
            lb_BolumListe.Location = new Point(6, 12);
            lb_BolumListe.Name = "lb_BolumListe";
            lb_BolumListe.Size = new Size(126, 169);
            lb_BolumListe.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7 });
            listView1.Location = new Point(22, 14);
            listView1.Name = "listView1";
            listView1.Size = new Size(147, 168);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Başlık 1";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Başlık 2";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 9);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(168, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(246, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 142);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(204, 57);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(10, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 13;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(197, 100);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Bilgisayar";
            treeNode2.Name = "Node2";
            treeNode2.Text = "İnşaat";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Mühendislik Fakültesi";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Bilgisayar Programcılğıı";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Harita";
            treeNode6.Name = "Node3";
            treeNode6.Text = "MYO";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6 });
            treeView1.Size = new Size(227, 112);
            treeView1.TabIndex = 14;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1235, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { birinciMenüToolStripMenuItem, ikinciMenüToolStripMenuItem, üçüncüMenüToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(42, 20);
            toolStripMenuItem2.Text = "Giriş";
            // 
            // birinciMenüToolStripMenuItem
            // 
            birinciMenüToolStripMenuItem.Name = "birinciMenüToolStripMenuItem";
            birinciMenüToolStripMenuItem.Size = new Size(180, 22);
            birinciMenüToolStripMenuItem.Text = "Birinci Menü";
            // 
            // ikinciMenüToolStripMenuItem
            // 
            ikinciMenüToolStripMenuItem.Name = "ikinciMenüToolStripMenuItem";
            ikinciMenüToolStripMenuItem.Size = new Size(180, 22);
            ikinciMenüToolStripMenuItem.Text = "İkinci Menü";
            // 
            // üçüncüMenüToolStripMenuItem
            // 
            üçüncüMenüToolStripMenuItem.Name = "üçüncüMenüToolStripMenuItem";
            üçüncüMenüToolStripMenuItem.Size = new Size(180, 22);
            üçüncüMenüToolStripMenuItem.Text = "Üçüncü Menü";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(52, 20);
            toolStripMenuItem3.Text = "Düzen";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(56, 20);
            toolStripMenuItem4.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(232, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(213, 168);
            dataGridView1.TabIndex = 16;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(26, 145);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(492, 378);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(484, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hesap Alma";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lb_BolumListe);
            tabPage2.Controls.Add(clb_IlListesi);
            tabPage2.Controls.Add(monthCalendar1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(484, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sipariş";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listView1);
            tabPage3.Controls.Add(treeView1);
            tabPage3.Controls.Add(cb_HazirlikDurum);
            tabPage3.Controls.Add(cb_MeslekListe);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(ll_universiteBaglanti);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(484, 350);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Müşteri Sipariy";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(535, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 187);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "User İşlemleri";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(41, 81);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(50, 56);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(49, 549);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 152);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(231, 610);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(412, 39);
            progressBar1.TabIndex = 22;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(748, 622);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(291, 45);
            trackBar1.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(692, 27);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(405, 130);
            propertyGrid1.TabIndex = 24;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 745);
            Controls.Add(propertyGrid1);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Controls.Add(lbl_AnaBaslik);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox cb_HazirlikDurum;
        private CheckedListBox clb_IlListesi;
        private ComboBox cb_MeslekListe;
        private Label lbl_AnaBaslik;
        private LinkLabel ll_universiteBaglanti;
        private ListBox lb_BolumListe;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaskedTextBox maskedTextBox1;
        private MonthCalendar monthCalendar1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private TreeView treeView1;
        private NotifyIcon notifyIcon1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem birinciMenüToolStripMenuItem;
        private ToolStripMenuItem ikinciMenüToolStripMenuItem;
        private ToolStripMenuItem üçüncüMenüToolStripMenuItem;
        private DataGridView dataGridView1;
        private PrintDialog printDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private OpenFileDialog openFileDialog1;
        private PropertyGrid propertyGrid1;
        private System.Diagnostics.Process process1;
    }
}
