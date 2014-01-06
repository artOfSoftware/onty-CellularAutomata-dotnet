namespace Toom.CellularAutomata.GUI
{
	partial class FormCaGui
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
			this.buttonInitRandom = new System.Windows.Forms.Button();
			this.buttonInitBar = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.textboxFieldSizeCols = new System.Windows.Forms.TextBox();
			this.textBoxAutomataValMax = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelFieldHeading = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageGraphical = new System.Windows.Forms.TabPage();
			this.pictureBoxFieldTitle = new System.Windows.Forms.PictureBox();
			this.pictureBoxField = new System.Windows.Forms.PictureBox();
			this.tabPageText = new System.Windows.Forms.TabPage();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.textboxField = new System.Windows.Forms.TextBox();
			this.tabPageDebug = new System.Windows.Forms.TabPage();
			this.textBoxAutomataValMin = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textboxFieldSizeRows = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonTransOnce = new System.Windows.Forms.Button();
			this.buttonTransRun = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textboxWorkerSleep = new System.Windows.Forms.TextBox();
			this.comboBoxWhichGame = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxUserRule = new System.Windows.Forms.TextBox();
			this.radioButtonRuleCustom = new System.Windows.Forms.RadioButton();
			this.radioButtonRuleCanned = new System.Windows.Forms.RadioButton();
			this.buttonInitDiamond = new System.Windows.Forms.Button();
			this.buttonInitCircle = new System.Windows.Forms.Button();
			this.buttonInitHalfZeroHalfTwo = new System.Windows.Forms.Button();
			this.textBoxDebug = new System.Windows.Forms.TextBox();
			this.buttonSizeMax = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPageGraphical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFieldTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
			this.tabPageText.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonInitRandom
			// 
			this.buttonInitRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInitRandom.ForeColor = System.Drawing.Color.Blue;
			this.buttonInitRandom.Location = new System.Drawing.Point(11, 226);
			this.buttonInitRandom.Name = "buttonInitRandom";
			this.buttonInitRandom.Size = new System.Drawing.Size(124, 52);
			this.buttonInitRandom.TabIndex = 21;
			this.buttonInitRandom.Text = "Init Random";
			this.buttonInitRandom.UseVisualStyleBackColor = true;
			this.buttonInitRandom.Click += new System.EventHandler(this.buttonInitRandom_Click);
			// 
			// buttonInitBar
			// 
			this.buttonInitBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInitBar.ForeColor = System.Drawing.Color.Blue;
			this.buttonInitBar.Location = new System.Drawing.Point(11, 65);
			this.buttonInitBar.Name = "buttonInitBar";
			this.buttonInitBar.Size = new System.Drawing.Size(209, 36);
			this.buttonInitBar.TabIndex = 11;
			this.buttonInitBar.Text = "Init Bars";
			this.buttonInitBar.UseVisualStyleBackColor = true;
			this.buttonInitBar.Click += new System.EventHandler(this.buttonInitBar_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// textboxFieldSizeCols
			// 
			this.textboxFieldSizeCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textboxFieldSizeCols.ForeColor = System.Drawing.Color.Blue;
			this.textboxFieldSizeCols.Location = new System.Drawing.Point(169, 11);
			this.textboxFieldSizeCols.Name = "textboxFieldSizeCols";
			this.textboxFieldSizeCols.Size = new System.Drawing.Size(50, 26);
			this.textboxFieldSizeCols.TabIndex = 3;
			this.textboxFieldSizeCols.Text = "400";
			// 
			// textBoxAutomataValMax
			// 
			this.textBoxAutomataValMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAutomataValMax.ForeColor = System.Drawing.Color.Blue;
			this.textBoxAutomataValMax.Location = new System.Drawing.Point(191, 252);
			this.textBoxAutomataValMax.Name = "textBoxAutomataValMax";
			this.textBoxAutomataValMax.Size = new System.Drawing.Size(28, 26);
			this.textBoxAutomataValMax.TabIndex = 25;
			this.textBoxAutomataValMax.Text = "1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(28, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Field size:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(116, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Cols:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(149, 255);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 17);
			this.label5.TabIndex = 24;
			this.label5.Text = "Max:";
			// 
			// labelFieldHeading
			// 
			this.labelFieldHeading.AutoSize = true;
			this.labelFieldHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFieldHeading.Location = new System.Drawing.Point(308, 9);
			this.labelFieldHeading.Name = "labelFieldHeading";
			this.labelFieldHeading.Size = new System.Drawing.Size(251, 20);
			this.labelFieldHeading.TabIndex = 71;
			this.labelFieldHeading.Text = "Welcome to Cellular Automata";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageGraphical);
			this.tabControl1.Controls.Add(this.tabPageText);
			this.tabControl1.Controls.Add(this.tabPageDebug);
			this.tabControl1.Location = new System.Drawing.Point(312, 38);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(508, 464);
			this.tabControl1.TabIndex = 72;
			// 
			// tabPageGraphical
			// 
			this.tabPageGraphical.Controls.Add(this.pictureBoxFieldTitle);
			this.tabPageGraphical.Controls.Add(this.pictureBoxField);
			this.tabPageGraphical.Location = new System.Drawing.Point(4, 22);
			this.tabPageGraphical.Name = "tabPageGraphical";
			this.tabPageGraphical.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGraphical.Size = new System.Drawing.Size(500, 438);
			this.tabPageGraphical.TabIndex = 2;
			this.tabPageGraphical.Text = "Graphical";
			this.tabPageGraphical.UseVisualStyleBackColor = true;
			// 
			// pictureBoxFieldTitle
			// 
			this.pictureBoxFieldTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxFieldTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxFieldTitle.Location = new System.Drawing.Point(7, 5);
			this.pictureBoxFieldTitle.Name = "pictureBoxFieldTitle";
			this.pictureBoxFieldTitle.Size = new System.Drawing.Size(487, 21);
			this.pictureBoxFieldTitle.TabIndex = 1;
			this.pictureBoxFieldTitle.TabStop = false;
			// 
			// pictureBoxField
			// 
			this.pictureBoxField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxField.Location = new System.Drawing.Point(3, 32);
			this.pictureBoxField.Name = "pictureBoxField";
			this.pictureBoxField.Size = new System.Drawing.Size(494, 403);
			this.pictureBoxField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxField.TabIndex = 0;
			this.pictureBoxField.TabStop = false;
			this.pictureBoxField.SizeChanged += new System.EventHandler(this.pictureBoxField_SizeChanged);
			// 
			// tabPageText
			// 
			this.tabPageText.Controls.Add(this.buttonPrint);
			this.tabPageText.Controls.Add(this.textboxField);
			this.tabPageText.Location = new System.Drawing.Point(4, 22);
			this.tabPageText.Name = "tabPageText";
			this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageText.Size = new System.Drawing.Size(500, 438);
			this.tabPageText.TabIndex = 1;
			this.tabPageText.Text = "Plain";
			this.tabPageText.UseVisualStyleBackColor = true;
			// 
			// buttonPrint
			// 
			this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPrint.Location = new System.Drawing.Point(6, 3);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(96, 25);
			this.buttonPrint.TabIndex = 7;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// textboxField
			// 
			this.textboxField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.textboxField.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textboxField.Location = new System.Drawing.Point(3, 34);
			this.textboxField.Multiline = true;
			this.textboxField.Name = "textboxField";
			this.textboxField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textboxField.Size = new System.Drawing.Size(491, 602);
			this.textboxField.TabIndex = 6;
			this.textboxField.WordWrap = false;
			// 
			// tabPageDebug
			// 
			this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
			this.tabPageDebug.Name = "tabPageDebug";
			this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDebug.Size = new System.Drawing.Size(500, 438);
			this.tabPageDebug.TabIndex = 3;
			this.tabPageDebug.Text = "Debug";
			this.tabPageDebug.UseVisualStyleBackColor = true;
			// 
			// textBoxAutomataValMin
			// 
			this.textBoxAutomataValMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAutomataValMin.ForeColor = System.Drawing.Color.Blue;
			this.textBoxAutomataValMin.Location = new System.Drawing.Point(191, 226);
			this.textBoxAutomataValMin.Name = "textBoxAutomataValMin";
			this.textBoxAutomataValMin.Size = new System.Drawing.Size(28, 26);
			this.textBoxAutomataValMin.TabIndex = 23;
			this.textBoxAutomataValMin.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(149, 229);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 17);
			this.label6.TabIndex = 22;
			this.label6.Text = "Min:";
			// 
			// textboxFieldSizeRows
			// 
			this.textboxFieldSizeRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textboxFieldSizeRows.ForeColor = System.Drawing.Color.Blue;
			this.textboxFieldSizeRows.Location = new System.Drawing.Point(169, 36);
			this.textboxFieldSizeRows.Name = "textboxFieldSizeRows";
			this.textboxFieldSizeRows.Size = new System.Drawing.Size(50, 26);
			this.textboxFieldSizeRows.TabIndex = 5;
			this.textboxFieldSizeRows.Text = "200";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(116, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "Rows:";
			// 
			// buttonTransOnce
			// 
			this.buttonTransOnce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTransOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTransOnce.ForeColor = System.Drawing.Color.Purple;
			this.buttonTransOnce.Location = new System.Drawing.Point(0, 226);
			this.buttonTransOnce.Name = "buttonTransOnce";
			this.buttonTransOnce.Size = new System.Drawing.Size(292, 32);
			this.buttonTransOnce.TabIndex = 51;
			this.buttonTransOnce.Text = "Transform Once";
			this.buttonTransOnce.UseVisualStyleBackColor = true;
			this.buttonTransOnce.Click += new System.EventHandler(this.buttonTransform_Click);
			// 
			// buttonTransRun
			// 
			this.buttonTransRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTransRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTransRun.ForeColor = System.Drawing.Color.Purple;
			this.buttonTransRun.Location = new System.Drawing.Point(1, 264);
			this.buttonTransRun.Name = "buttonTransRun";
			this.buttonTransRun.Size = new System.Drawing.Size(291, 33);
			this.buttonTransRun.TabIndex = 52;
			this.buttonTransRun.Text = "Run Until Stopped";
			this.buttonTransRun.UseVisualStyleBackColor = true;
			this.buttonTransRun.Click += new System.EventHandler(this.buttonTransRun_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Purple;
			this.label1.Location = new System.Drawing.Point(3, 310);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 23);
			this.label1.TabIndex = 61;
			this.label1.Text = "Wait between iterations:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Purple;
			this.label2.Location = new System.Drawing.Point(205, 310);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 17);
			this.label2.TabIndex = 22;
			this.label2.Text = "sec";
			// 
			// textboxWorkerSleep
			// 
			this.textboxWorkerSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textboxWorkerSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textboxWorkerSleep.ForeColor = System.Drawing.Color.Purple;
			this.textboxWorkerSleep.Location = new System.Drawing.Point(161, 304);
			this.textboxWorkerSleep.Name = "textboxWorkerSleep";
			this.textboxWorkerSleep.Size = new System.Drawing.Size(43, 26);
			this.textboxWorkerSleep.TabIndex = 62;
			this.textboxWorkerSleep.Text = "?";
			// 
			// comboBoxWhichGame
			// 
			this.comboBoxWhichGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxWhichGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWhichGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxWhichGame.ForeColor = System.Drawing.Color.Purple;
			this.comboBoxWhichGame.FormattingEnabled = true;
			this.comboBoxWhichGame.Items.AddRange(new object[] {
            "Conway",
            "NEC Min",
            "NEC Max",
            "NEC Median",
            "Swap 0s and 2s"});
			this.comboBoxWhichGame.Location = new System.Drawing.Point(29, 186);
			this.comboBoxWhichGame.Name = "comboBoxWhichGame";
			this.comboBoxWhichGame.Size = new System.Drawing.Size(217, 28);
			this.comboBoxWhichGame.TabIndex = 34;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBoxUserRule);
			this.panel1.Controls.Add(this.comboBoxWhichGame);
			this.panel1.Controls.Add(this.textboxWorkerSleep);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonTransRun);
			this.panel1.Controls.Add(this.buttonTransOnce);
			this.panel1.Controls.Add(this.radioButtonRuleCustom);
			this.panel1.Controls.Add(this.radioButtonRuleCanned);
			this.panel1.Location = new System.Drawing.Point(11, 339);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(295, 360);
			this.panel1.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(17, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(0, 17);
			this.label9.TabIndex = 26;
			// 
			// textBoxUserRule
			// 
			this.textBoxUserRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxUserRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserRule.ForeColor = System.Drawing.Color.Purple;
			this.textBoxUserRule.Location = new System.Drawing.Point(23, 24);
			this.textBoxUserRule.Multiline = true;
			this.textBoxUserRule.Name = "textBoxUserRule";
			this.textBoxUserRule.Size = new System.Drawing.Size(259, 139);
			this.textBoxUserRule.TabIndex = 32;
			// 
			// radioButtonRuleCustom
			// 
			this.radioButtonRuleCustom.AutoSize = true;
			this.radioButtonRuleCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonRuleCustom.ForeColor = System.Drawing.Color.Purple;
			this.radioButtonRuleCustom.Location = new System.Drawing.Point(3, 4);
			this.radioButtonRuleCustom.Name = "radioButtonRuleCustom";
			this.radioButtonRuleCustom.Size = new System.Drawing.Size(172, 21);
			this.radioButtonRuleCustom.TabIndex = 31;
			this.radioButtonRuleCustom.TabStop = true;
			this.radioButtonRuleCustom.Text = "Custom transformation:";
			this.radioButtonRuleCustom.UseVisualStyleBackColor = true;
			// 
			// radioButtonRuleCanned
			// 
			this.radioButtonRuleCanned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.radioButtonRuleCanned.AutoSize = true;
			this.radioButtonRuleCanned.Checked = true;
			this.radioButtonRuleCanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonRuleCanned.ForeColor = System.Drawing.Color.Purple;
			this.radioButtonRuleCanned.Location = new System.Drawing.Point(6, 163);
			this.radioButtonRuleCanned.Name = "radioButtonRuleCanned";
			this.radioButtonRuleCanned.Size = new System.Drawing.Size(194, 21);
			this.radioButtonRuleCanned.TabIndex = 33;
			this.radioButtonRuleCanned.TabStop = true;
			this.radioButtonRuleCanned.Text = "Predefined transformation:";
			this.radioButtonRuleCanned.UseVisualStyleBackColor = true;
			// 
			// buttonInitDiamond
			// 
			this.buttonInitDiamond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInitDiamond.ForeColor = System.Drawing.Color.Blue;
			this.buttonInitDiamond.Location = new System.Drawing.Point(11, 106);
			this.buttonInitDiamond.Name = "buttonInitDiamond";
			this.buttonInitDiamond.Size = new System.Drawing.Size(209, 36);
			this.buttonInitDiamond.TabIndex = 12;
			this.buttonInitDiamond.Text = "Init Diamond";
			this.buttonInitDiamond.UseVisualStyleBackColor = true;
			this.buttonInitDiamond.Click += new System.EventHandler(this.buttonInitDiamond_Click);
			// 
			// buttonInitCircle
			// 
			this.buttonInitCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInitCircle.ForeColor = System.Drawing.Color.Blue;
			this.buttonInitCircle.Location = new System.Drawing.Point(11, 145);
			this.buttonInitCircle.Name = "buttonInitCircle";
			this.buttonInitCircle.Size = new System.Drawing.Size(209, 36);
			this.buttonInitCircle.TabIndex = 13;
			this.buttonInitCircle.Text = "Init Circle";
			this.buttonInitCircle.UseVisualStyleBackColor = true;
			this.buttonInitCircle.Click += new System.EventHandler(this.buttonInitCircle_Click);
			// 
			// buttonInitHalfZeroHalfTwo
			// 
			this.buttonInitHalfZeroHalfTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInitHalfZeroHalfTwo.ForeColor = System.Drawing.Color.Blue;
			this.buttonInitHalfZeroHalfTwo.Location = new System.Drawing.Point(11, 184);
			this.buttonInitHalfZeroHalfTwo.Name = "buttonInitHalfZeroHalfTwo";
			this.buttonInitHalfZeroHalfTwo.Size = new System.Drawing.Size(209, 36);
			this.buttonInitHalfZeroHalfTwo.TabIndex = 14;
			this.buttonInitHalfZeroHalfTwo.Text = "Init 0 && 2";
			this.buttonInitHalfZeroHalfTwo.UseVisualStyleBackColor = true;
			this.buttonInitHalfZeroHalfTwo.Click += new System.EventHandler(this.buttonInitHalfZeroHalfTwo_Click);
			// 
			// textBoxDebug
			// 
			this.textBoxDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBoxDebug.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDebug.Location = new System.Drawing.Point(312, 511);
			this.textBoxDebug.Multiline = true;
			this.textBoxDebug.Name = "textBoxDebug";
			this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDebug.Size = new System.Drawing.Size(504, 188);
			this.textBoxDebug.TabIndex = 99;
			// 
			// buttonSizeMax
			// 
			this.buttonSizeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSizeMax.ForeColor = System.Drawing.Color.Blue;
			this.buttonSizeMax.Location = new System.Drawing.Point(225, 23);
			this.buttonSizeMax.Name = "buttonSizeMax";
			this.buttonSizeMax.Size = new System.Drawing.Size(73, 28);
			this.buttonSizeMax.TabIndex = 100;
			this.buttonSizeMax.Text = "Maximize";
			this.buttonSizeMax.UseVisualStyleBackColor = true;
			this.buttonSizeMax.Click += new System.EventHandler(this.buttonSizeMax_Click);
			// 
			// FormCaGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 718);
			this.Controls.Add(this.buttonSizeMax);
			this.Controls.Add(this.textBoxDebug);
			this.Controls.Add(this.buttonInitHalfZeroHalfTwo);
			this.Controls.Add(this.buttonInitCircle);
			this.Controls.Add(this.buttonInitDiamond);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.labelFieldHeading);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxAutomataValMin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxAutomataValMax);
			this.Controls.Add(this.textboxFieldSizeRows);
			this.Controls.Add(this.textboxFieldSizeCols);
			this.Controls.Add(this.buttonInitBar);
			this.Controls.Add(this.buttonInitRandom);
			this.Name = "FormCaGui";
			this.Text = "[autoset at runtime]";
			this.Load += new System.EventHandler(this.FormCaGui_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPageGraphical.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFieldTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
			this.tabPageText.ResumeLayout(false);
			this.tabPageText.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonInitRandom;
		private System.Windows.Forms.Button buttonInitBar;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox textboxFieldSizeCols;
		private System.Windows.Forms.TextBox textBoxAutomataValMax;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelFieldHeading;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageText;
		private System.Windows.Forms.TextBox textboxField;
		private System.Windows.Forms.TabPage tabPageGraphical;
		private System.Windows.Forms.PictureBox pictureBoxField;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.TextBox textBoxAutomataValMin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textboxFieldSizeRows;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBoxFieldTitle;
		private System.Windows.Forms.Button buttonTransOnce;
		private System.Windows.Forms.Button buttonTransRun;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textboxWorkerSleep;
		private System.Windows.Forms.ComboBox comboBoxWhichGame;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonInitDiamond;
		private System.Windows.Forms.Button buttonInitCircle;
		private System.Windows.Forms.Button buttonInitHalfZeroHalfTwo;
		private System.Windows.Forms.RadioButton radioButtonRuleCanned;
		private System.Windows.Forms.RadioButton radioButtonRuleCustom;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxUserRule;
		private System.Windows.Forms.TabPage tabPageDebug;
		public System.Windows.Forms.TextBox textBoxDebug;
		private System.Windows.Forms.Button buttonSizeMax;
	}
}

