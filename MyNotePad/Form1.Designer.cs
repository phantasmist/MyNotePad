
namespace MyNotePad
{
    partial class MyNotePad
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MNOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MNSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MNSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.MnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCallTest = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNToLower = new System.Windows.Forms.ToolStripMenuItem();
            this.MNToUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.MNToHex = new System.Windows.Forms.ToolStripMenuItem();
            this.MNReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.getTokenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(661, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNNew,
            this.MNOpenFile,
            this.MNSave,
            this.MNSaveAs,
            this.toolStripSeparator1,
            this.MnPrint,
            this.MnPrintPreview,
            this.MnExit});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // MNNew
            // 
            this.MNNew.Name = "MNNew";
            this.MNNew.Size = new System.Drawing.Size(181, 26);
            this.MNNew.Text = "New";
            this.MNNew.Click += new System.EventHandler(this.MNNew_Click);
            // 
            // MNOpenFile
            // 
            this.MNOpenFile.Name = "MNOpenFile";
            this.MNOpenFile.Size = new System.Drawing.Size(181, 26);
            this.MNOpenFile.Text = "Open";
            this.MNOpenFile.Click += new System.EventHandler(this.MNOpenFile_Click);
            // 
            // MNSave
            // 
            this.MNSave.Name = "MNSave";
            this.MNSave.Size = new System.Drawing.Size(181, 26);
            this.MNSave.Text = "Save";
            this.MNSave.Click += new System.EventHandler(this.MNSave_Click);
            // 
            // MNSaveAs
            // 
            this.MNSaveAs.Name = "MNSaveAs";
            this.MNSaveAs.Size = new System.Drawing.Size(181, 26);
            this.MNSaveAs.Text = "Save As";
            this.MNSaveAs.Click += new System.EventHandler(this.MNSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // MnPrint
            // 
            this.MnPrint.Name = "MnPrint";
            this.MnPrint.Size = new System.Drawing.Size(181, 26);
            this.MnPrint.Text = "Print";
            // 
            // MnPrintPreview
            // 
            this.MnPrintPreview.Name = "MnPrintPreview";
            this.MnPrintPreview.Size = new System.Drawing.Size(181, 26);
            this.MnPrintPreview.Text = "Print Preview";
            // 
            // MnExit
            // 
            this.MnExit.Name = "MnExit";
            this.MnExit.Size = new System.Drawing.Size(181, 26);
            this.MnExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCallTest,
            this.getTokenTestToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MnCallTest
            // 
            this.MnCallTest.Name = "MnCallTest";
            this.MnCallTest.Size = new System.Drawing.Size(224, 26);
            this.MnCallTest.Text = "CallTest";
            this.MnCallTest.Click += new System.EventHandler(this.MnCallTest_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNToLower,
            this.MNToUpper,
            this.MNToHex,
            this.MNReturn});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // MNToLower
            // 
            this.MNToLower.Name = "MNToLower";
            this.MNToLower.Size = new System.Drawing.Size(179, 26);
            this.MNToLower.Text = "Lowercase";
            this.MNToLower.Click += new System.EventHandler(this.MNToLower_Click);
            // 
            // MNToUpper
            // 
            this.MNToUpper.Name = "MNToUpper";
            this.MNToUpper.Size = new System.Drawing.Size(179, 26);
            this.MNToUpper.Text = "Uppercase";
            this.MNToUpper.Click += new System.EventHandler(this.MNToUpper_Click);
            // 
            // MNToHex
            // 
            this.MNToHex.Name = "MNToHex";
            this.MNToHex.Size = new System.Drawing.Size(179, 26);
            this.MNToHex.Text = "Hexadecimal";
            this.MNToHex.Click += new System.EventHandler(this.MNToHex_Click);
            // 
            // MNReturn
            // 
            this.MNReturn.Name = "MNReturn";
            this.MNReturn.Size = new System.Drawing.Size(179, 26);
            this.MNReturn.Text = "Return";
            this.MNReturn.Click += new System.EventHandler(this.MNReturn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemo.Location = new System.Drawing.Point(0, 33);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(661, 315);
            this.tbMemo.TabIndex = 1;
            this.tbMemo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMemo_KeyUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "모든 파일|*.*|텍스트 파일|*.txt";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(68, 20);
            this.sbLabel1.Text = "sbLabel1";
            // 
            // sbLabel2
            // 
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(68, 20);
            this.sbLabel2.Text = "sbLabel2";
            // 
            // getTokenTestToolStripMenuItem
            // 
            this.getTokenTestToolStripMenuItem.Name = "getTokenTestToolStripMenuItem";
            this.getTokenTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.getTokenTestToolStripMenuItem.Text = "GetTokenTest";
            this.getTokenTestToolStripMenuItem.Click += new System.EventHandler(this.getTokenTestToolStripMenuItem_Click);
            // 
            // MyNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 349);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MyNotePad";
            this.Text = "MyNotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyNotePad_FormClosing);
            this.Load += new System.EventHandler(this.MyNotePad_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNNew;
        private System.Windows.Forms.ToolStripMenuItem MNOpenFile;
        private System.Windows.Forms.ToolStripMenuItem MNSave;
        private System.Windows.Forms.ToolStripMenuItem MNSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MnPrint;
        private System.Windows.Forms.ToolStripMenuItem MnPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem MnExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNToLower;
        private System.Windows.Forms.ToolStripMenuItem MNToUpper;
        private System.Windows.Forms.ToolStripMenuItem MNToHex;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.ToolStripMenuItem MNReturn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem MnCallTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripMenuItem getTokenTestToolStripMenuItem;
    }
}

