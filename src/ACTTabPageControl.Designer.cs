namespace ACTTimeline
{
    partial class ACTTabPageControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlExt1 = new ACTTimeline.TabControlExt();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListItems = new System.Windows.Forms.Panel();
            this.buttonResourceDirOpen = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.labelResourceDirStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelResourceDir = new System.Windows.Forms.Label();
            this.textBoxResourceDir = new System.Windows.Forms.TextBox();
            this.buttonResourceDirSelect = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelCurrPos = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.labelEndPos = new System.Windows.Forms.Label();
            this.lblCtrl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoadedTimelineLabel = new System.Windows.Forms.Label();
            this.labelLoadedTimeline = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabOption = new System.Windows.Forms.TabPage();
            this.checkBoxAutohide = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoloadAfterChangeZone = new System.Windows.Forms.CheckBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.checkBoxPlaySoundByACT = new System.Windows.Forms.CheckBox();
            this.checkBoxShowOverlayButtons = new System.Windows.Forms.CheckBox();
            this.labelOverlayOrientation = new System.Windows.Forms.Label();
            this.checkBoxMoveOverlayByDrag = new System.Windows.Forms.CheckBox();
            this.labelNumRows = new System.Windows.Forms.Label();
            this.labelOverlayY = new System.Windows.Forms.Label();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.buttonFontSelect = new System.Windows.Forms.Button();
            this.labelCurrOpacity = new System.Windows.Forms.Label();
            this.labelBar = new System.Windows.Forms.Label();
            this.labelColumnSize = new System.Windows.Forms.Label();
            this.labelTextWidth = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelOverlayX = new System.Windows.Forms.Label();
            this.udOverlayY = new System.Windows.Forms.NumericUpDown();
            this.udOverlayX = new System.Windows.Forms.NumericUpDown();
            this.udBarWidth = new System.Windows.Forms.NumericUpDown();
            this.udNumRows = new System.Windows.Forms.NumericUpDown();
            this.udTextWidth = new System.Windows.Forms.NumericUpDown();
            this.tabControlExt1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTextWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlExt1.Controls.Add(this.tabMain);
            this.tabControlExt1.Controls.Add(this.tabOption);
            this.tabControlExt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(30, 110);
            this.tabControlExt1.Location = new System.Drawing.Point(0, 0);
            this.tabControlExt1.Multiline = true;
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(982, 632);
            this.tabControlExt1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlExt1.TabIndex = 7;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.Controls.Add(this.panel4);
            this.tabMain.Controls.Add(this.labelResourceDirStatus);
            this.tabMain.Controls.Add(this.panel3);
            this.tabMain.Controls.Add(this.lblList);
            this.tabMain.Controls.Add(this.panel2);
            this.tabMain.Controls.Add(this.lblCtrl);
            this.tabMain.Controls.Add(this.panel1);
            this.tabMain.Controls.Add(this.lblInfo);
            this.tabMain.Location = new System.Drawing.Point(114, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(2);
            this.tabMain.Size = new System.Drawing.Size(864, 624);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "tabMain";
            this.tabMain.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ListItems);
            this.panel4.Controls.Add(this.buttonResourceDirOpen);
            this.panel4.Controls.Add(this.buttonLoad);
            this.panel4.Controls.Add(this.buttonRefreshList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 353);
            this.panel4.TabIndex = 12;
            // 
            // ListItems
            // 
            this.ListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListItems.AutoScroll = true;
            this.ListItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListItems.Location = new System.Drawing.Point(9, 10);
            this.ListItems.Name = "ListItems";
            this.ListItems.Padding = new System.Windows.Forms.Padding(2);
            this.ListItems.Size = new System.Drawing.Size(732, 334);
            this.ListItems.TabIndex = 2;
            // 
            // buttonResourceDirOpen
            // 
            this.buttonResourceDirOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResourceDirOpen.Location = new System.Drawing.Point(747, 10);
            this.buttonResourceDirOpen.Name = "buttonResourceDirOpen";
            this.buttonResourceDirOpen.Size = new System.Drawing.Size(104, 25);
            this.buttonResourceDirOpen.TabIndex = 0;
            this.buttonResourceDirOpen.Text = "Open Folder";
            this.buttonResourceDirOpen.UseVisualStyleBackColor = true;
            this.buttonResourceDirOpen.Click += new System.EventHandler(this.buttonResourceDirOpen_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(747, 72);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(104, 25);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshList.Location = new System.Drawing.Point(747, 41);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(104, 25);
            this.buttonRefreshList.TabIndex = 1;
            this.buttonRefreshList.Text = "Refresh List";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // labelResourceDirStatus
            // 
            this.labelResourceDirStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelResourceDirStatus.Location = new System.Drawing.Point(2, 245);
            this.labelResourceDirStatus.Name = "labelResourceDirStatus";
            this.labelResourceDirStatus.Padding = new System.Windows.Forms.Padding(5);
            this.labelResourceDirStatus.Size = new System.Drawing.Size(860, 24);
            this.labelResourceDirStatus.TabIndex = 3;
            this.labelResourceDirStatus.Text = "Resource Dir Status";
            this.labelResourceDirStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.labelResourceDir);
            this.panel3.Controls.Add(this.textBoxResourceDir);
            this.panel3.Controls.Add(this.buttonResourceDirSelect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 38);
            this.panel3.TabIndex = 11;
            // 
            // labelResourceDir
            // 
            this.labelResourceDir.Location = new System.Drawing.Point(4, 9);
            this.labelResourceDir.Name = "labelResourceDir";
            this.labelResourceDir.Size = new System.Drawing.Size(146, 21);
            this.labelResourceDir.TabIndex = 2;
            this.labelResourceDir.Text = "Resources Directory:";
            this.labelResourceDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxResourceDir
            // 
            this.textBoxResourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResourceDir.Location = new System.Drawing.Point(156, 8);
            this.textBoxResourceDir.Name = "textBoxResourceDir";
            this.textBoxResourceDir.Size = new System.Drawing.Size(615, 21);
            this.textBoxResourceDir.TabIndex = 1;
            this.textBoxResourceDir.TextChanged += new System.EventHandler(this.textBoxResourceDir_TextChanged);
            // 
            // buttonResourceDirSelect
            // 
            this.buttonResourceDirSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResourceDirSelect.Location = new System.Drawing.Point(777, 7);
            this.buttonResourceDirSelect.Name = "buttonResourceDirSelect";
            this.buttonResourceDirSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonResourceDirSelect.TabIndex = 0;
            this.buttonResourceDirSelect.Text = "Choose";
            this.buttonResourceDirSelect.UseVisualStyleBackColor = true;
            this.buttonResourceDirSelect.Click += new System.EventHandler(this.buttonResourceDirSelect_Click);
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblList.Location = new System.Drawing.Point(2, 183);
            this.lblList.Name = "lblList";
            this.lblList.Padding = new System.Windows.Forms.Padding(5);
            this.lblList.Size = new System.Drawing.Size(860, 24);
            this.lblList.TabIndex = 10;
            this.lblList.Text = "Timeline List";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackBar);
            this.panel2.Controls.Add(this.buttonRewind);
            this.panel2.Controls.Add(this.buttonPause);
            this.panel2.Controls.Add(this.buttonPlay);
            this.panel2.Controls.Add(this.labelCurrPos);
            this.panel2.Controls.Add(this.labelSlash);
            this.panel2.Controls.Add(this.labelEndPos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 101);
            this.panel2.TabIndex = 9;
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.AutoSize = false;
            this.trackBar.Location = new System.Drawing.Point(11, 12);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(837, 45);
            this.trackBar.TabIndex = 0;
            this.trackBar.TickFrequency = 30;
            this.trackBar.Scroll += new System.EventHandler(this.trackbar_Scroll);
            // 
            // buttonRewind
            // 
            this.buttonRewind.Location = new System.Drawing.Point(11, 67);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(101, 24);
            this.buttonRewind.TabIndex = 5;
            this.buttonRewind.Text = "<< Rewind";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(118, 67);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(101, 24);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(225, 67);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(101, 24);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelCurrPos
            // 
            this.labelCurrPos.AutoSize = true;
            this.labelCurrPos.Location = new System.Drawing.Point(344, 73);
            this.labelCurrPos.Name = "labelCurrPos";
            this.labelCurrPos.Size = new System.Drawing.Size(33, 12);
            this.labelCurrPos.TabIndex = 3;
            this.labelCurrPos.Text = "00:00";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.BackColor = System.Drawing.Color.Transparent;
            this.labelSlash.Location = new System.Drawing.Point(392, 72);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(11, 12);
            this.labelSlash.TabIndex = 4;
            this.labelSlash.Text = "/";
            // 
            // labelEndPos
            // 
            this.labelEndPos.AutoSize = true;
            this.labelEndPos.Location = new System.Drawing.Point(418, 73);
            this.labelEndPos.Name = "labelEndPos";
            this.labelEndPos.Size = new System.Drawing.Size(33, 12);
            this.labelEndPos.TabIndex = 3;
            this.labelEndPos.Text = "00:00";
            // 
            // lblCtrl
            // 
            this.lblCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCtrl.Location = new System.Drawing.Point(2, 58);
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Padding = new System.Windows.Forms.Padding(5);
            this.lblCtrl.Size = new System.Drawing.Size(860, 24);
            this.lblCtrl.TabIndex = 8;
            this.lblCtrl.Text = "Timeline Control";
            this.lblCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLoadedTimelineLabel);
            this.panel1.Controls.Add(this.labelLoadedTimeline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 32);
            this.panel1.TabIndex = 7;
            // 
            // labelLoadedTimelineLabel
            // 
            this.labelLoadedTimelineLabel.AutoSize = true;
            this.labelLoadedTimelineLabel.Location = new System.Drawing.Point(9, 8);
            this.labelLoadedTimelineLabel.Name = "labelLoadedTimelineLabel";
            this.labelLoadedTimelineLabel.Size = new System.Drawing.Size(104, 12);
            this.labelLoadedTimelineLabel.TabIndex = 1;
            this.labelLoadedTimelineLabel.Text = "Loaded Timeline:";
            // 
            // labelLoadedTimeline
            // 
            this.labelLoadedTimeline.AutoSize = true;
            this.labelLoadedTimeline.Location = new System.Drawing.Point(146, 8);
            this.labelLoadedTimeline.Name = "labelLoadedTimeline";
            this.labelLoadedTimeline.Size = new System.Drawing.Size(138, 12);
            this.labelLoadedTimeline.TabIndex = 2;
            this.labelLoadedTimeline.Text = "-- No active timeline --";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Location = new System.Drawing.Point(2, 2);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lblInfo.Size = new System.Drawing.Size(860, 24);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Timeline Information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabOption
            // 
            this.tabOption.BackColor = System.Drawing.Color.White;
            this.tabOption.Controls.Add(this.checkBoxAutohide);
            this.tabOption.Controls.Add(this.checkBoxAutoloadAfterChangeZone);
            this.tabOption.Controls.Add(this.trackBarOpacity);
            this.tabOption.Controls.Add(this.checkBoxPlaySoundByACT);
            this.tabOption.Controls.Add(this.checkBoxShowOverlayButtons);
            this.tabOption.Controls.Add(this.labelOverlayOrientation);
            this.tabOption.Controls.Add(this.checkBoxMoveOverlayByDrag);
            this.tabOption.Controls.Add(this.labelNumRows);
            this.tabOption.Controls.Add(this.labelOverlayY);
            this.tabOption.Controls.Add(this.labelOpacity);
            this.tabOption.Controls.Add(this.buttonFontSelect);
            this.tabOption.Controls.Add(this.labelCurrOpacity);
            this.tabOption.Controls.Add(this.labelBar);
            this.tabOption.Controls.Add(this.labelColumnSize);
            this.tabOption.Controls.Add(this.labelTextWidth);
            this.tabOption.Controls.Add(this.labelFont);
            this.tabOption.Controls.Add(this.labelOverlayX);
            this.tabOption.Controls.Add(this.udOverlayY);
            this.tabOption.Controls.Add(this.udOverlayX);
            this.tabOption.Controls.Add(this.udBarWidth);
            this.tabOption.Controls.Add(this.udNumRows);
            this.tabOption.Controls.Add(this.udTextWidth);
            this.tabOption.Location = new System.Drawing.Point(114, 4);
            this.tabOption.Name = "tabOption";
            this.tabOption.Padding = new System.Windows.Forms.Padding(3);
            this.tabOption.Size = new System.Drawing.Size(864, 624);
            this.tabOption.TabIndex = 1;
            this.tabOption.Text = "tabOption";
            // 
            // checkBoxAutohide
            // 
            this.checkBoxAutohide.AutoSize = true;
            this.checkBoxAutohide.Checked = true;
            this.checkBoxAutohide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutohide.Location = new System.Drawing.Point(12, 101);
            this.checkBoxAutohide.Name = "checkBoxAutohide";
            this.checkBoxAutohide.Size = new System.Drawing.Size(77, 16);
            this.checkBoxAutohide.TabIndex = 5;
            this.checkBoxAutohide.Text = "Auto hide";
            this.checkBoxAutohide.UseVisualStyleBackColor = true;
            this.checkBoxAutohide.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAutoloadAfterChangeZone
            // 
            this.checkBoxAutoloadAfterChangeZone.AutoSize = true;
            this.checkBoxAutoloadAfterChangeZone.Location = new System.Drawing.Point(12, 35);
            this.checkBoxAutoloadAfterChangeZone.Name = "checkBoxAutoloadAfterChangeZone";
            this.checkBoxAutoloadAfterChangeZone.Size = new System.Drawing.Size(179, 16);
            this.checkBoxAutoloadAfterChangeZone.TabIndex = 4;
            this.checkBoxAutoloadAfterChangeZone.Text = "Autoload after change zone";
            this.checkBoxAutoloadAfterChangeZone.UseVisualStyleBackColor = true;
            this.checkBoxAutoloadAfterChangeZone.CheckedChanged += new System.EventHandler(this.checkBoxAutoloadAfterChangeZone_CheckedChanged);
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Location = new System.Drawing.Point(186, 269);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(273, 45);
            this.trackBarOpacity.TabIndex = 4;
            this.trackBarOpacity.TickFrequency = 10;
            this.trackBarOpacity.Value = 1;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            // 
            // checkBoxPlaySoundByACT
            // 
            this.checkBoxPlaySoundByACT.AutoSize = true;
            this.checkBoxPlaySoundByACT.Checked = true;
            this.checkBoxPlaySoundByACT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlaySoundByACT.Location = new System.Drawing.Point(12, 13);
            this.checkBoxPlaySoundByACT.Name = "checkBoxPlaySoundByACT";
            this.checkBoxPlaySoundByACT.Size = new System.Drawing.Size(135, 16);
            this.checkBoxPlaySoundByACT.TabIndex = 3;
            this.checkBoxPlaySoundByACT.Text = "Play sound by ACT";
            this.checkBoxPlaySoundByACT.UseVisualStyleBackColor = true;
            this.checkBoxPlaySoundByACT.CheckedChanged += new System.EventHandler(this.checkBoxPlaySoundByACT_CheckedChanged);
            // 
            // checkBoxShowOverlayButtons
            // 
            this.checkBoxShowOverlayButtons.AutoSize = true;
            this.checkBoxShowOverlayButtons.Checked = true;
            this.checkBoxShowOverlayButtons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowOverlayButtons.Location = new System.Drawing.Point(12, 79);
            this.checkBoxShowOverlayButtons.Name = "checkBoxShowOverlayButtons";
            this.checkBoxShowOverlayButtons.Size = new System.Drawing.Size(175, 16);
            this.checkBoxShowOverlayButtons.TabIndex = 3;
            this.checkBoxShowOverlayButtons.Text = "Show mini button controls.";
            this.checkBoxShowOverlayButtons.UseVisualStyleBackColor = true;
            this.checkBoxShowOverlayButtons.CheckedChanged += new System.EventHandler(this.checkBoxShowOverlayButtons_CheckedChanged);
            // 
            // labelOverlayOrientation
            // 
            this.labelOverlayOrientation.AutoSize = true;
            this.labelOverlayOrientation.Location = new System.Drawing.Point(10, 179);
            this.labelOverlayOrientation.Name = "labelOverlayOrientation";
            this.labelOverlayOrientation.Size = new System.Drawing.Size(112, 12);
            this.labelOverlayOrientation.TabIndex = 0;
            this.labelOverlayOrientation.Text = "Overlay Orientation";
            // 
            // checkBoxMoveOverlayByDrag
            // 
            this.checkBoxMoveOverlayByDrag.AutoSize = true;
            this.checkBoxMoveOverlayByDrag.Checked = true;
            this.checkBoxMoveOverlayByDrag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMoveOverlayByDrag.Location = new System.Drawing.Point(12, 57);
            this.checkBoxMoveOverlayByDrag.Name = "checkBoxMoveOverlayByDrag";
            this.checkBoxMoveOverlayByDrag.Size = new System.Drawing.Size(256, 16);
            this.checkBoxMoveOverlayByDrag.TabIndex = 3;
            this.checkBoxMoveOverlayByDrag.Text = "Move by drag && right doubleclick to hide.";
            this.checkBoxMoveOverlayByDrag.UseVisualStyleBackColor = true;
            this.checkBoxMoveOverlayByDrag.CheckedChanged += new System.EventHandler(this.checkBoxMoveOverlayByDrag_CheckedChanged);
            // 
            // labelNumRows
            // 
            this.labelNumRows.AutoSize = true;
            this.labelNumRows.Location = new System.Drawing.Point(10, 207);
            this.labelNumRows.Name = "labelNumRows";
            this.labelNumRows.Size = new System.Drawing.Size(159, 12);
            this.labelNumRows.TabIndex = 0;
            this.labelNumRows.Text = "Number of rows to display:";
            // 
            // labelOverlayY
            // 
            this.labelOverlayY.AutoSize = true;
            this.labelOverlayY.Location = new System.Drawing.Point(294, 179);
            this.labelOverlayY.Name = "labelOverlayY";
            this.labelOverlayY.Size = new System.Drawing.Size(17, 12);
            this.labelOverlayY.TabIndex = 2;
            this.labelOverlayY.Text = "Y:";
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(10, 273);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(52, 12);
            this.labelOpacity.TabIndex = 0;
            this.labelOpacity.Text = "Opacity:";
            // 
            // buttonFontSelect
            // 
            this.buttonFontSelect.Location = new System.Drawing.Point(49, 134);
            this.buttonFontSelect.Name = "buttonFontSelect";
            this.buttonFontSelect.Size = new System.Drawing.Size(486, 28);
            this.buttonFontSelect.TabIndex = 0;
            this.buttonFontSelect.Text = "Select Font";
            this.buttonFontSelect.UseVisualStyleBackColor = true;
            this.buttonFontSelect.Click += new System.EventHandler(this.buttonFontSelect_Click);
            // 
            // labelCurrOpacity
            // 
            this.labelCurrOpacity.AutoSize = true;
            this.labelCurrOpacity.Location = new System.Drawing.Point(466, 273);
            this.labelCurrOpacity.Name = "labelCurrOpacity";
            this.labelCurrOpacity.Size = new System.Drawing.Size(27, 12);
            this.labelCurrOpacity.TabIndex = 0;
            this.labelCurrOpacity.Text = "??%";
            // 
            // labelBar
            // 
            this.labelBar.AutoSize = true;
            this.labelBar.Location = new System.Drawing.Point(294, 238);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(28, 12);
            this.labelBar.TabIndex = 2;
            this.labelBar.Text = "Bar:";
            this.labelBar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelColumnSize
            // 
            this.labelColumnSize.AutoSize = true;
            this.labelColumnSize.Location = new System.Drawing.Point(10, 238);
            this.labelColumnSize.Name = "labelColumnSize";
            this.labelColumnSize.Size = new System.Drawing.Size(83, 12);
            this.labelColumnSize.TabIndex = 0;
            this.labelColumnSize.Text = "Column Width";
            // 
            // labelTextWidth
            // 
            this.labelTextWidth.AutoSize = true;
            this.labelTextWidth.Location = new System.Drawing.Point(143, 238);
            this.labelTextWidth.Name = "labelTextWidth";
            this.labelTextWidth.Size = new System.Drawing.Size(34, 12);
            this.labelTextWidth.TabIndex = 2;
            this.labelTextWidth.Text = "Text:";
            this.labelTextWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(10, 142);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(33, 12);
            this.labelFont.TabIndex = 0;
            this.labelFont.Text = "Font:";
            // 
            // labelOverlayX
            // 
            this.labelOverlayX.AutoSize = true;
            this.labelOverlayX.Location = new System.Drawing.Point(163, 179);
            this.labelOverlayX.Name = "labelOverlayX";
            this.labelOverlayX.Size = new System.Drawing.Size(17, 12);
            this.labelOverlayX.TabIndex = 2;
            this.labelOverlayX.Text = "X:";
            // 
            // udOverlayY
            // 
            this.udOverlayY.Location = new System.Drawing.Point(335, 177);
            this.udOverlayY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udOverlayY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.udOverlayY.Name = "udOverlayY";
            this.udOverlayY.Size = new System.Drawing.Size(93, 21);
            this.udOverlayY.TabIndex = 1;
            this.udOverlayY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.udOverlayY.ValueChanged += new System.EventHandler(this.udOverlayY_ValueChanged);
            // 
            // udOverlayX
            // 
            this.udOverlayX.Location = new System.Drawing.Point(186, 177);
            this.udOverlayX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udOverlayX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.udOverlayX.Name = "udOverlayX";
            this.udOverlayX.Size = new System.Drawing.Size(93, 21);
            this.udOverlayX.TabIndex = 1;
            this.udOverlayX.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.udOverlayX.ValueChanged += new System.EventHandler(this.udOverlayX_ValueChanged);
            // 
            // udBarWidth
            // 
            this.udBarWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udBarWidth.Location = new System.Drawing.Point(335, 236);
            this.udBarWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udBarWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udBarWidth.Name = "udBarWidth";
            this.udBarWidth.Size = new System.Drawing.Size(93, 21);
            this.udBarWidth.TabIndex = 1;
            this.udBarWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udBarWidth.ValueChanged += new System.EventHandler(this.udBarWidth_ValueChanged);
            // 
            // udNumRows
            // 
            this.udNumRows.Location = new System.Drawing.Point(186, 205);
            this.udNumRows.Name = "udNumRows";
            this.udNumRows.Size = new System.Drawing.Size(47, 21);
            this.udNumRows.TabIndex = 1;
            this.udNumRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.udNumRows.ValueChanged += new System.EventHandler(this.udNumRows_ValueChanged);
            // 
            // udTextWidth
            // 
            this.udTextWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udTextWidth.Location = new System.Drawing.Point(186, 236);
            this.udTextWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udTextWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udTextWidth.Name = "udTextWidth";
            this.udTextWidth.Size = new System.Drawing.Size(93, 21);
            this.udTextWidth.TabIndex = 1;
            this.udTextWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udTextWidth.ValueChanged += new System.EventHandler(this.udTextWidth_ValueChanged);
            // 
            // ACTTabPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControlExt1);
            this.Name = "ACTTabPageControl";
            this.Size = new System.Drawing.Size(982, 632);
            this.tabControlExt1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabOption.ResumeLayout(false);
            this.tabOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTextWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResourceDirSelect;
        private System.Windows.Forms.TextBox textBoxResourceDir;
        private System.Windows.Forms.Label labelResourceDir;
        private System.Windows.Forms.Button buttonResourceDirOpen;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Label labelResourceDirStatus;
        private System.Windows.Forms.Label labelOverlayY;
        private System.Windows.Forms.Label labelOverlayX;
        private System.Windows.Forms.NumericUpDown udOverlayY;
        private System.Windows.Forms.NumericUpDown udNumRows;
        private System.Windows.Forms.NumericUpDown udOverlayX;
        private System.Windows.Forms.Label labelNumRows;
        private System.Windows.Forms.Label labelOverlayOrientation;
        private System.Windows.Forms.CheckBox checkBoxPlaySoundByACT;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Label labelEndPos;
        private System.Windows.Forms.Label labelCurrPos;
        private System.Windows.Forms.Label labelSlash;
        private System.Windows.Forms.Label labelLoadedTimeline;
        private System.Windows.Forms.Label labelLoadedTimelineLabel;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.CheckBox checkBoxShowOverlayButtons;
        private System.Windows.Forms.Button buttonFontSelect;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelColumnSize;
        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.Label labelTextWidth;
        private System.Windows.Forms.NumericUpDown udBarWidth;
        private System.Windows.Forms.NumericUpDown udTextWidth;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.Label labelCurrOpacity;
        private System.Windows.Forms.CheckBox checkBoxMoveOverlayByDrag;
        private System.Windows.Forms.CheckBox checkBoxAutoloadAfterChangeZone;
        private System.Windows.Forms.CheckBox checkBoxAutohide;
        private TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCtrl;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel ListItems;
    }
}