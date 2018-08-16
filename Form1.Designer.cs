namespace tx_sample_line_numbering_gdi
{
    partial class Form1
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
            this.textControl1 = new TXTextControl.TextControl();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textControl1.Location = new System.Drawing.Point(25, 53);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(678, 369);
            this.textControl1.TabIndex = 0;
            this.textControl1.ViewMode = TXTextControl.ViewMode.PageView;
            this.textControl1.VScroll += new System.EventHandler(this.textControl1_VScroll);
            this.textControl1.HScroll += new System.EventHandler(this.textControl1_HScroll);
            this.textControl1.InputPositionChanged += new System.EventHandler(this.textControl1_InputPositionChanged);
            this.textControl1.Changed += new System.EventHandler(this.textControl1_Changed);
            // 
            // rulerBar1
            // 
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar1.Location = new System.Drawing.Point(0, 28);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(703, 25);
            this.rulerBar1.TabIndex = 1;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // rulerBar2
            // 
            this.rulerBar2.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar2.Location = new System.Drawing.Point(0, 53);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(25, 369);
            this.rulerBar2.TabIndex = 2;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // buttonBar1
            // 
            this.buttonBar1.ButtonOffsets = new int[] {
        10,
        0,
        10,
        0,
        0,
        10,
        0,
        0,
        0,
        10,
        0,
        10,
        10,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.buttonBar1.ButtonPositions = new TXTextControl.Button[] {
        TXTextControl.Button.StyleComboBox,
        TXTextControl.Button.FontNameComboBox,
        TXTextControl.Button.FontBoldButton,
        TXTextControl.Button.FontItalicButton,
        TXTextControl.Button.FontUnderlineButton,
        TXTextControl.Button.AlignmentLeftButton,
        TXTextControl.Button.AlignmentRightButton,
        TXTextControl.Button.AlignmentCenteredButton,
        TXTextControl.Button.AlignmentJustifiedButton,
        TXTextControl.Button.ListBulletedButton,
        TXTextControl.Button.ListNumberedButton,
        TXTextControl.Button.ZoomComboBox,
        TXTextControl.Button.ControlCharsButton,
        TXTextControl.Button.TabSelectionButton,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None};
            this.buttonBar1.ButtonSeparators = new bool[] {
        false,
        false,
        true,
        false,
        false,
        true,
        false,
        false,
        false,
        true,
        false,
        true,
        true,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(0, 0);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(703, 28);
            this.buttonBar1.TabIndex = 3;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 422);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(703, 19);
            this.statusBar1.TabIndex = 4;
            this.statusBar1.Text = "statusBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar2);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.buttonBar1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Form1";
            this.Text = "TX Text Control Sample: Line Numbering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.StatusBar statusBar1;
    }
}

