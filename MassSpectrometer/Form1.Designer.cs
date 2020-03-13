namespace MassSpectrometer
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
            this.components = new System.ComponentModel.Container();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.positiveCheckBox = new System.Windows.Forms.CheckBox();
            this.neutronsTextBox = new System.Windows.Forms.TextBox();
            this.voltageTextBox = new System.Windows.Forms.TextBox();
            this.electronsTextBox = new System.Windows.Forms.TextBox();
            this.protonsTextBox = new System.Windows.Forms.TextBox();
            this.magneticFieldTextBox = new System.Windows.Forms.TextBox();
            this.neutronLabel = new System.Windows.Forms.Label();
            this.protonsLabel = new System.Windows.Forms.Label();
            this.electronsLabel = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.magneticFieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1585, 860);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 15;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // secondTimer
            // 
            this.secondTimer.Interval = 1000;
            this.secondTimer.Tick += new System.EventHandler(this.secondTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1468, 337);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // positiveCheckBox
            // 
            this.positiveCheckBox.AutoSize = true;
            this.positiveCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.positiveCheckBox.Checked = true;
            this.positiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.positiveCheckBox.Location = new System.Drawing.Point(1438, 418);
            this.positiveCheckBox.Name = "positiveCheckBox";
            this.positiveCheckBox.Size = new System.Drawing.Size(121, 17);
            this.positiveCheckBox.TabIndex = 2;
            this.positiveCheckBox.Text = "Positive to Negative";
            this.positiveCheckBox.UseVisualStyleBackColor = false;
            // 
            // neutronsTextBox
            // 
            this.neutronsTextBox.Location = new System.Drawing.Point(1438, 457);
            this.neutronsTextBox.Name = "neutronsTextBox";
            this.neutronsTextBox.Size = new System.Drawing.Size(121, 20);
            this.neutronsTextBox.TabIndex = 3;
            this.neutronsTextBox.Text = "2";
            // 
            // voltageTextBox
            // 
            this.voltageTextBox.Location = new System.Drawing.Point(1438, 578);
            this.voltageTextBox.Name = "voltageTextBox";
            this.voltageTextBox.Size = new System.Drawing.Size(121, 20);
            this.voltageTextBox.TabIndex = 4;
            this.voltageTextBox.Text = "500";
            // 
            // electronsTextBox
            // 
            this.electronsTextBox.Location = new System.Drawing.Point(1438, 537);
            this.electronsTextBox.Name = "electronsTextBox";
            this.electronsTextBox.Size = new System.Drawing.Size(121, 20);
            this.electronsTextBox.TabIndex = 5;
            this.electronsTextBox.Text = "1";
            // 
            // protonsTextBox
            // 
            this.protonsTextBox.Location = new System.Drawing.Point(1438, 496);
            this.protonsTextBox.Name = "protonsTextBox";
            this.protonsTextBox.Size = new System.Drawing.Size(121, 20);
            this.protonsTextBox.TabIndex = 6;
            this.protonsTextBox.Text = "2";
            // 
            // magneticFieldTextBox
            // 
            this.magneticFieldTextBox.Location = new System.Drawing.Point(1438, 623);
            this.magneticFieldTextBox.Name = "magneticFieldTextBox";
            this.magneticFieldTextBox.Size = new System.Drawing.Size(121, 20);
            this.magneticFieldTextBox.TabIndex = 7;
            this.magneticFieldTextBox.Text = "1";
            // 
            // neutronLabel
            // 
            this.neutronLabel.AutoSize = true;
            this.neutronLabel.Location = new System.Drawing.Point(1368, 460);
            this.neutronLabel.Name = "neutronLabel";
            this.neutronLabel.Size = new System.Drawing.Size(53, 13);
            this.neutronLabel.TabIndex = 8;
            this.neutronLabel.Text = "Neutrons:";
            // 
            // protonsLabel
            // 
            this.protonsLabel.AutoSize = true;
            this.protonsLabel.Location = new System.Drawing.Point(1375, 499);
            this.protonsLabel.Name = "protonsLabel";
            this.protonsLabel.Size = new System.Drawing.Size(46, 13);
            this.protonsLabel.TabIndex = 9;
            this.protonsLabel.Text = "Protons:";
            // 
            // electronsLabel
            // 
            this.electronsLabel.AutoSize = true;
            this.electronsLabel.Location = new System.Drawing.Point(1367, 540);
            this.electronsLabel.Name = "electronsLabel";
            this.electronsLabel.Size = new System.Drawing.Size(54, 13);
            this.electronsLabel.TabIndex = 10;
            this.electronsLabel.Text = "Electrons:";
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Location = new System.Drawing.Point(1375, 581);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(46, 13);
            this.voltageLabel.TabIndex = 11;
            this.voltageLabel.Text = "Voltage:";
            // 
            // magneticFieldLabel
            // 
            this.magneticFieldLabel.AutoSize = true;
            this.magneticFieldLabel.Location = new System.Drawing.Point(1342, 626);
            this.magneticFieldLabel.Name = "magneticFieldLabel";
            this.magneticFieldLabel.Size = new System.Drawing.Size(79, 13);
            this.magneticFieldLabel.TabIndex = 12;
            this.magneticFieldLabel.Text = "Magnetic Field:";
            // 
            // Form1
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 861);
            this.Controls.Add(this.magneticFieldLabel);
            this.Controls.Add(this.voltageLabel);
            this.Controls.Add(this.electronsLabel);
            this.Controls.Add(this.protonsLabel);
            this.Controls.Add(this.neutronLabel);
            this.Controls.Add(this.magneticFieldTextBox);
            this.Controls.Add(this.protonsTextBox);
            this.Controls.Add(this.electronsTextBox);
            this.Controls.Add(this.voltageTextBox);
            this.Controls.Add(this.neutronsTextBox);
            this.Controls.Add(this.positiveCheckBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox positiveCheckBox;
        private System.Windows.Forms.TextBox neutronsTextBox;
        private System.Windows.Forms.TextBox voltageTextBox;
        private System.Windows.Forms.TextBox electronsTextBox;
        private System.Windows.Forms.TextBox protonsTextBox;
        private System.Windows.Forms.TextBox magneticFieldTextBox;
        private System.Windows.Forms.Label neutronLabel;
        private System.Windows.Forms.Label protonsLabel;
        private System.Windows.Forms.Label electronsLabel;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.Label magneticFieldLabel;
    }
}

