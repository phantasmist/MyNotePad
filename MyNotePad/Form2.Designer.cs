
namespace MyNotePad
{
    partial class Form2
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

            this.label1 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.rbCOM1 = new System.Windows.Forms.RadioButton();
            this.rbCOM2 = new System.Windows.Forms.RadioButton();
            this.gbCOMPort = new System.Windows.Forms.GroupBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCOMPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(55, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed";
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnOK.Location = new System.Drawing.Point(18, 290);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(133, 40);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancel.Location = new System.Drawing.Point(192, 290);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(133, 40);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // cbSpeed
            // 
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbSpeed.Location = new System.Drawing.Point(151, 133);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(138, 23);
            this.cbSpeed.TabIndex = 3;
            // 
            // rbCOM1
            // 
            this.rbCOM1.AutoSize = true;
            this.rbCOM1.Location = new System.Drawing.Point(25, 44);
            this.rbCOM1.Name = "rbCOM1";
            this.rbCOM1.Size = new System.Drawing.Size(70, 19);
            this.rbCOM1.TabIndex = 4;
            this.rbCOM1.TabStop = true;
            this.rbCOM1.Text = "COM1";
            this.rbCOM1.UseVisualStyleBackColor = true;
            // 
            // rbCOM2
            // 
            this.rbCOM2.AutoSize = true;
            this.rbCOM2.Location = new System.Drawing.Point(133, 44);
            this.rbCOM2.Name = "rbCOM2";
            this.rbCOM2.Size = new System.Drawing.Size(70, 19);
            this.rbCOM2.TabIndex = 5;
            this.rbCOM2.TabStop = true;
            this.rbCOM2.Text = "COM2";
            this.rbCOM2.UseVisualStyleBackColor = true;
            // 
            // gbCOMPort
            // 
            this.gbCOMPort.Controls.Add(this.rbCOM1);
            this.gbCOMPort.Controls.Add(this.rbCOM2);
            this.gbCOMPort.Location = new System.Drawing.Point(59, 30);
            this.gbCOMPort.Name = "gbCOMPort";
            this.gbCOMPort.Size = new System.Drawing.Size(230, 75);
            this.gbCOMPort.TabIndex = 7;
            this.gbCOMPort.TabStop = false;
            this.gbCOMPort.Text = "COM Port";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(151, 171);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(138, 23);
            this.cbParity.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(55, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parity";
            // 
            // cbDataBit
            // 
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbDataBit.Location = new System.Drawing.Point(151, 208);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(138, 23);
            this.cbDataBit.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(55, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "DataBit";
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "0"});
            this.cbStopBit.Location = new System.Drawing.Point(151, 243);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(138, 23);
            this.cbStopBit.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(55, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "StopBit";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 356);
            this.Controls.Add(this.cbStopBit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDataBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbCOMPort);
            this.Controls.Add(this.cbSpeed);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "COM Port Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbCOMPort.ResumeLayout(false);
            this.gbCOMPort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.GroupBox gbCOMPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbParity;
        public System.Windows.Forms.RadioButton rbCOM1;
        public System.Windows.Forms.RadioButton rbCOM2;
        public System.Windows.Forms.ComboBox cbDataBit;
        public System.Windows.Forms.ComboBox cbStopBit;
    }
}