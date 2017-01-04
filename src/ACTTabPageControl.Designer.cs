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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACTTabPageControl));
            this.tabControlExt1 = new ACTTimeline.TabControlExt();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelEndPos = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelCurrPos = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.groupBoxTimelines = new System.Windows.Forms.GroupBox();
            this.buttonResourceDirSelect = new System.Windows.Forms.Button();
            this.buttonResourceDirOpen = new System.Windows.Forms.Button();
            this.labelResourceDir = new System.Windows.Forms.Label();
            this.labelResourceDirStatus = new System.Windows.Forms.Label();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.textBoxResourceDir = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listTimelines = new System.Windows.Forms.ListBox();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelLoadedTimelineLabel = new System.Windows.Forms.Label();
            this.labelLoadedTimeline = new System.Windows.Forms.Label();
            this.tabOption = new System.Windows.Forms.TabPage();
            this.checkBoxShowOverlayButtons = new System.Windows.Forms.CheckBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.checkBoxMoveOverlayByDrag = new System.Windows.Forms.CheckBox();
            this.checkBoxPlaySoundByACT = new System.Windows.Forms.CheckBox();
            this.labelCurrentFont = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.buttonFontSelect = new System.Windows.Forms.Button();
            this.labelOverlayOrientation = new System.Windows.Forms.Label();
            this.labelOverlayY = new System.Windows.Forms.Label();
            this.labelNumRows = new System.Windows.Forms.Label();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.labelBar = new System.Windows.Forms.Label();
            this.labelCurrOpacity = new System.Windows.Forms.Label();
            this.labelTextWidth = new System.Windows.Forms.Label();
            this.labelColumnSize = new System.Windows.Forms.Label();
            this.labelOverlayX = new System.Windows.Forms.Label();
            this.udOverlayX = new System.Windows.Forms.NumericUpDown();
            this.udOverlayY = new System.Windows.Forms.NumericUpDown();
            this.udNumRows = new System.Windows.Forms.NumericUpDown();
            this.udBarWidth = new System.Windows.Forms.NumericUpDown();
            this.udTextWidth = new System.Windows.Forms.NumericUpDown();
            this.tabControlExt1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBoxTimelines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tabOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTextWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlExt1
            // 
            resources.ApplyResources(this.tabControlExt1, "tabControlExt1");
            this.tabControlExt1.Controls.Add(this.tabMain);
            this.tabControlExt1.Controls.Add(this.tabOption);
            this.tabControlExt1.Multiline = true;
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.Controls.Add(this.labelEndPos);
            this.tabMain.Controls.Add(this.labelSlash);
            this.tabMain.Controls.Add(this.buttonPlay);
            this.tabMain.Controls.Add(this.labelCurrPos);
            this.tabMain.Controls.Add(this.buttonPause);
            this.tabMain.Controls.Add(this.groupBoxTimelines);
            this.tabMain.Controls.Add(this.buttonRewind);
            this.tabMain.Controls.Add(this.trackBar);
            this.tabMain.Controls.Add(this.labelLoadedTimelineLabel);
            this.tabMain.Controls.Add(this.labelLoadedTimeline);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            // 
            // labelEndPos
            // 
            resources.ApplyResources(this.labelEndPos, "labelEndPos");
            this.labelEndPos.Name = "labelEndPos";
            // 
            // labelSlash
            // 
            resources.ApplyResources(this.labelSlash, "labelSlash");
            this.labelSlash.BackColor = System.Drawing.Color.Transparent;
            this.labelSlash.Name = "labelSlash";
            // 
            // buttonPlay
            // 
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelCurrPos
            // 
            resources.ApplyResources(this.labelCurrPos, "labelCurrPos");
            this.labelCurrPos.Name = "labelCurrPos";
            // 
            // buttonPause
            // 
            resources.ApplyResources(this.buttonPause, "buttonPause");
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // groupBoxTimelines
            // 
            resources.ApplyResources(this.groupBoxTimelines, "groupBoxTimelines");
            this.groupBoxTimelines.Controls.Add(this.buttonResourceDirSelect);
            this.groupBoxTimelines.Controls.Add(this.buttonResourceDirOpen);
            this.groupBoxTimelines.Controls.Add(this.labelResourceDir);
            this.groupBoxTimelines.Controls.Add(this.labelResourceDirStatus);
            this.groupBoxTimelines.Controls.Add(this.buttonRefreshList);
            this.groupBoxTimelines.Controls.Add(this.textBoxResourceDir);
            this.groupBoxTimelines.Controls.Add(this.buttonLoad);
            this.groupBoxTimelines.Controls.Add(this.listTimelines);
            this.groupBoxTimelines.Name = "groupBoxTimelines";
            this.groupBoxTimelines.TabStop = false;
            // 
            // buttonResourceDirSelect
            // 
            resources.ApplyResources(this.buttonResourceDirSelect, "buttonResourceDirSelect");
            this.buttonResourceDirSelect.Name = "buttonResourceDirSelect";
            this.buttonResourceDirSelect.UseVisualStyleBackColor = true;
            this.buttonResourceDirSelect.Click += new System.EventHandler(this.buttonResourceDirSelect_Click);
            // 
            // buttonResourceDirOpen
            // 
            resources.ApplyResources(this.buttonResourceDirOpen, "buttonResourceDirOpen");
            this.buttonResourceDirOpen.Name = "buttonResourceDirOpen";
            this.buttonResourceDirOpen.UseVisualStyleBackColor = true;
            this.buttonResourceDirOpen.Click += new System.EventHandler(this.buttonResourceDirOpen_Click);
            // 
            // labelResourceDir
            // 
            resources.ApplyResources(this.labelResourceDir, "labelResourceDir");
            this.labelResourceDir.Name = "labelResourceDir";
            // 
            // labelResourceDirStatus
            // 
            resources.ApplyResources(this.labelResourceDirStatus, "labelResourceDirStatus");
            this.labelResourceDirStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResourceDirStatus.Name = "labelResourceDirStatus";
            // 
            // buttonRefreshList
            // 
            resources.ApplyResources(this.buttonRefreshList, "buttonRefreshList");
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // textBoxResourceDir
            // 
            resources.ApplyResources(this.textBoxResourceDir, "textBoxResourceDir");
            this.textBoxResourceDir.Name = "textBoxResourceDir";
            this.textBoxResourceDir.TextChanged += new System.EventHandler(this.textBoxResourceDir_TextChanged);
            // 
            // buttonLoad
            // 
            resources.ApplyResources(this.buttonLoad, "buttonLoad");
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listTimelines
            // 
            resources.ApplyResources(this.listTimelines, "listTimelines");
            this.listTimelines.FormattingEnabled = true;
            this.listTimelines.Name = "listTimelines";
            this.listTimelines.DoubleClick += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonRewind
            // 
            resources.ApplyResources(this.buttonRewind, "buttonRewind");
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // trackBar
            // 
            resources.ApplyResources(this.trackBar, "trackBar");
            this.trackBar.Name = "trackBar";
            this.trackBar.TickFrequency = 30;
            this.trackBar.Scroll += new System.EventHandler(this.trackbar_Scroll);
            // 
            // labelLoadedTimelineLabel
            // 
            resources.ApplyResources(this.labelLoadedTimelineLabel, "labelLoadedTimelineLabel");
            this.labelLoadedTimelineLabel.Name = "labelLoadedTimelineLabel";
            // 
            // labelLoadedTimeline
            // 
            resources.ApplyResources(this.labelLoadedTimeline, "labelLoadedTimeline");
            this.labelLoadedTimeline.Name = "labelLoadedTimeline";
            // 
            // tabOption
            // 
            this.tabOption.BackColor = System.Drawing.Color.White;
            this.tabOption.Controls.Add(this.checkBoxShowOverlayButtons);
            this.tabOption.Controls.Add(this.trackBarOpacity);
            this.tabOption.Controls.Add(this.checkBoxMoveOverlayByDrag);
            this.tabOption.Controls.Add(this.checkBoxPlaySoundByACT);
            this.tabOption.Controls.Add(this.labelCurrentFont);
            this.tabOption.Controls.Add(this.labelFont);
            this.tabOption.Controls.Add(this.buttonFontSelect);
            this.tabOption.Controls.Add(this.labelOverlayOrientation);
            this.tabOption.Controls.Add(this.labelOverlayY);
            this.tabOption.Controls.Add(this.labelNumRows);
            this.tabOption.Controls.Add(this.labelOpacity);
            this.tabOption.Controls.Add(this.labelBar);
            this.tabOption.Controls.Add(this.labelCurrOpacity);
            this.tabOption.Controls.Add(this.labelTextWidth);
            this.tabOption.Controls.Add(this.labelColumnSize);
            this.tabOption.Controls.Add(this.labelOverlayX);
            this.tabOption.Controls.Add(this.udOverlayX);
            this.tabOption.Controls.Add(this.udOverlayY);
            this.tabOption.Controls.Add(this.udNumRows);
            this.tabOption.Controls.Add(this.udBarWidth);
            this.tabOption.Controls.Add(this.udTextWidth);
            resources.ApplyResources(this.tabOption, "tabOption");
            this.tabOption.Name = "tabOption";
            // 
            // checkBoxShowOverlayButtons
            // 
            resources.ApplyResources(this.checkBoxShowOverlayButtons, "checkBoxShowOverlayButtons");
            this.checkBoxShowOverlayButtons.Checked = true;
            this.checkBoxShowOverlayButtons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowOverlayButtons.Name = "checkBoxShowOverlayButtons";
            this.checkBoxShowOverlayButtons.UseVisualStyleBackColor = true;
            this.checkBoxShowOverlayButtons.CheckedChanged += new System.EventHandler(this.checkBoxShowOverlayButtons_CheckedChanged);
            // 
            // trackBarOpacity
            // 
            resources.ApplyResources(this.trackBarOpacity, "trackBarOpacity");
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.TickFrequency = 10;
            this.trackBarOpacity.Value = 1;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            // 
            // checkBoxMoveOverlayByDrag
            // 
            resources.ApplyResources(this.checkBoxMoveOverlayByDrag, "checkBoxMoveOverlayByDrag");
            this.checkBoxMoveOverlayByDrag.Checked = true;
            this.checkBoxMoveOverlayByDrag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMoveOverlayByDrag.Name = "checkBoxMoveOverlayByDrag";
            this.checkBoxMoveOverlayByDrag.UseVisualStyleBackColor = true;
            this.checkBoxMoveOverlayByDrag.CheckedChanged += new System.EventHandler(this.checkBoxMoveOverlayByDrag_CheckedChanged);
            // 
            // checkBoxPlaySoundByACT
            // 
            resources.ApplyResources(this.checkBoxPlaySoundByACT, "checkBoxPlaySoundByACT");
            this.checkBoxPlaySoundByACT.Checked = true;
            this.checkBoxPlaySoundByACT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlaySoundByACT.Name = "checkBoxPlaySoundByACT";
            this.checkBoxPlaySoundByACT.UseVisualStyleBackColor = true;
            this.checkBoxPlaySoundByACT.CheckedChanged += new System.EventHandler(this.checkBoxPlaySoundByACT_CheckedChanged);
            // 
            // labelCurrentFont
            // 
            resources.ApplyResources(this.labelCurrentFont, "labelCurrentFont");
            this.labelCurrentFont.Name = "labelCurrentFont";
            // 
            // labelFont
            // 
            resources.ApplyResources(this.labelFont, "labelFont");
            this.labelFont.Name = "labelFont";
            // 
            // buttonFontSelect
            // 
            resources.ApplyResources(this.buttonFontSelect, "buttonFontSelect");
            this.buttonFontSelect.Name = "buttonFontSelect";
            this.buttonFontSelect.UseVisualStyleBackColor = true;
            this.buttonFontSelect.Click += new System.EventHandler(this.buttonFontSelect_Click);
            // 
            // labelOverlayOrientation
            // 
            resources.ApplyResources(this.labelOverlayOrientation, "labelOverlayOrientation");
            this.labelOverlayOrientation.Name = "labelOverlayOrientation";
            // 
            // labelOverlayY
            // 
            resources.ApplyResources(this.labelOverlayY, "labelOverlayY");
            this.labelOverlayY.Name = "labelOverlayY";
            // 
            // labelNumRows
            // 
            resources.ApplyResources(this.labelNumRows, "labelNumRows");
            this.labelNumRows.Name = "labelNumRows";
            // 
            // labelOpacity
            // 
            resources.ApplyResources(this.labelOpacity, "labelOpacity");
            this.labelOpacity.Name = "labelOpacity";
            // 
            // labelBar
            // 
            resources.ApplyResources(this.labelBar, "labelBar");
            this.labelBar.Name = "labelBar";
            // 
            // labelCurrOpacity
            // 
            resources.ApplyResources(this.labelCurrOpacity, "labelCurrOpacity");
            this.labelCurrOpacity.Name = "labelCurrOpacity";
            // 
            // labelTextWidth
            // 
            resources.ApplyResources(this.labelTextWidth, "labelTextWidth");
            this.labelTextWidth.Name = "labelTextWidth";
            // 
            // labelColumnSize
            // 
            resources.ApplyResources(this.labelColumnSize, "labelColumnSize");
            this.labelColumnSize.Name = "labelColumnSize";
            // 
            // labelOverlayX
            // 
            resources.ApplyResources(this.labelOverlayX, "labelOverlayX");
            this.labelOverlayX.Name = "labelOverlayX";
            // 
            // udOverlayX
            // 
            resources.ApplyResources(this.udOverlayX, "udOverlayX");
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
            this.udOverlayX.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.udOverlayX.ValueChanged += new System.EventHandler(this.udOverlayX_ValueChanged);
            // 
            // udOverlayY
            // 
            resources.ApplyResources(this.udOverlayY, "udOverlayY");
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
            this.udOverlayY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.udOverlayY.ValueChanged += new System.EventHandler(this.udOverlayY_ValueChanged);
            // 
            // udNumRows
            // 
            resources.ApplyResources(this.udNumRows, "udNumRows");
            this.udNumRows.Name = "udNumRows";
            this.udNumRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.udNumRows.ValueChanged += new System.EventHandler(this.udNumRows_ValueChanged);
            // 
            // udBarWidth
            // 
            this.udBarWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.udBarWidth, "udBarWidth");
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
            this.udBarWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udBarWidth.ValueChanged += new System.EventHandler(this.udBarWidth_ValueChanged);
            // 
            // udTextWidth
            // 
            this.udTextWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.udTextWidth, "udTextWidth");
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
            resources.ApplyResources(this, "$this");
            this.tabControlExt1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.groupBoxTimelines.ResumeLayout(false);
            this.groupBoxTimelines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tabOption.ResumeLayout(false);
            this.tabOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOverlayY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTextWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResourceDirSelect;
        private System.Windows.Forms.TextBox textBoxResourceDir;
        private System.Windows.Forms.Label labelResourceDir;
        private System.Windows.Forms.Button buttonResourceDirOpen;
        private System.Windows.Forms.GroupBox groupBoxTimelines;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListBox listTimelines;
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
        private System.Windows.Forms.Label labelCurrentFont;
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
        private TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabOption;
    }
}
