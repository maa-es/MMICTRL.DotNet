namespace MmiCtrlTest.HMI
{
    partial class GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbPfieldIndex = new System.Windows.Forms.TextBox();
            this.tbPfiedVal = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDprAddress = new System.Windows.Forms.TextBox();
            this.tbDprVal = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.cbDprAreas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDataTypes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.tbSingleBlock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFirmware = new System.Windows.Forms.TextBox();
            this.tbMk = new System.Windows.Forms.TextBox();
            this.tbDin = new System.Windows.Forms.TextBox();
            this.tbSps = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Firmware";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnLoadFirmwareClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCloseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Write";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnWritePFieldClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Read";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnReadPFieldClick);
            // 
            // tbPfieldIndex
            // 
            this.tbPfieldIndex.Location = new System.Drawing.Point(16, 427);
            this.tbPfieldIndex.Name = "tbPfieldIndex";
            this.tbPfieldIndex.Size = new System.Drawing.Size(85, 20);
            this.tbPfieldIndex.TabIndex = 4;
            // 
            // tbPfiedVal
            // 
            this.tbPfiedVal.Location = new System.Drawing.Point(105, 427);
            this.tbPfiedVal.Name = "tbPfiedVal";
            this.tbPfiedVal.Size = new System.Drawing.Size(85, 20);
            this.tbPfiedVal.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(380, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Load MK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnLoadMkClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(380, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Load DIN";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnLoadDinClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Get PLC-Version (Send Msg)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnSendMsgClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(289, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Ack Errors";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OnAckErrorsClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Start Prg";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnStartClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(105, 262);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Stop Prg";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.OnStopClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Value";
            // 
            // tbDprAddress
            // 
            this.tbDprAddress.Location = new System.Drawing.Point(16, 555);
            this.tbDprAddress.Name = "tbDprAddress";
            this.tbDprAddress.Size = new System.Drawing.Size(85, 20);
            this.tbDprAddress.TabIndex = 17;
            // 
            // tbDprVal
            // 
            this.tbDprVal.Location = new System.Drawing.Point(107, 555);
            this.tbDprVal.Name = "tbDprVal";
            this.tbDprVal.Size = new System.Drawing.Size(85, 20);
            this.tbDprVal.TabIndex = 18;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(198, 553);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "Read";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.OnDprReadClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(289, 553);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(85, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "Write";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.OnDprWriteClick);
            // 
            // cbDprAreas
            // 
            this.cbDprAreas.FormattingEnabled = true;
            this.cbDprAreas.Location = new System.Drawing.Point(16, 512);
            this.cbDprAreas.Name = "cbDprAreas";
            this.cbDprAreas.Size = new System.Drawing.Size(176, 21);
            this.cbDprAreas.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Area";
            // 
            // cbDataTypes
            // 
            this.cbDataTypes.FormattingEnabled = true;
            this.cbDataTypes.Location = new System.Drawing.Point(198, 512);
            this.cbDataTypes.Name = "cbDataTypes";
            this.cbDataTypes.Size = new System.Drawing.Size(176, 21);
            this.cbDataTypes.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Data Type";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(376, 334);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 23);
            this.button13.TabIndex = 25;
            this.button13.Text = "Execute";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OnSendSingleBlockClick);
            // 
            // tbSingleBlock
            // 
            this.tbSingleBlock.Location = new System.Drawing.Point(16, 336);
            this.tbSingleBlock.Name = "tbSingleBlock";
            this.tbSingleBlock.Size = new System.Drawing.Size(354, 20);
            this.tbSingleBlock.TabIndex = 26;
            this.tbSingleBlock.Text = "G253 F=\"TEST\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Single Block";
            // 
            // tbFirmware
            // 
            this.tbFirmware.Location = new System.Drawing.Point(16, 58);
            this.tbFirmware.Name = "tbFirmware";
            this.tbFirmware.Size = new System.Drawing.Size(358, 20);
            this.tbFirmware.TabIndex = 28;
            // 
            // tbMk
            // 
            this.tbMk.Location = new System.Drawing.Point(16, 146);
            this.tbMk.Name = "tbMk";
            this.tbMk.Size = new System.Drawing.Size(358, 20);
            this.tbMk.TabIndex = 29;
            // 
            // tbDin
            // 
            this.tbDin.Location = new System.Drawing.Point(16, 189);
            this.tbDin.Name = "tbDin";
            this.tbDin.Size = new System.Drawing.Size(358, 20);
            this.tbDin.TabIndex = 30;
            // 
            // tbSps
            // 
            this.tbSps.Location = new System.Drawing.Point(16, 101);
            this.tbSps.Name = "tbSps";
            this.tbSps.Size = new System.Drawing.Size(358, 20);
            this.tbSps.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Firmware";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Boot Project";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "MK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "DIN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Load files to NC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Messages to NC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "P-Field operations";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "DPR";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 600);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSps);
            this.Controls.Add(this.tbDin);
            this.Controls.Add(this.tbMk);
            this.Controls.Add(this.tbFirmware);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSingleBlock);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDataTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDprAreas);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.tbDprVal);
            this.Controls.Add(this.tbDprAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbPfiedVal);
            this.Controls.Add(this.tbPfieldIndex);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GUI";
            this.Text = "MMICTRL HMI-Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbPfieldIndex;
        private System.Windows.Forms.TextBox tbPfiedVal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDprAddress;
        private System.Windows.Forms.TextBox tbDprVal;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox cbDprAreas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDataTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox tbSingleBlock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFirmware;
        private System.Windows.Forms.TextBox tbMk;
        private System.Windows.Forms.TextBox tbDin;
        private System.Windows.Forms.TextBox tbSps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

