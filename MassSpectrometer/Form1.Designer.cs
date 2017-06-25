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
            this.voltageLabel = new System.Windows.Forms.Label();
            this.voltageTrackBar = new System.Windows.Forms.TrackBar();
            this.voltageValueLabel = new System.Windows.Forms.Label();
            this.distanceValueLabel = new System.Windows.Forms.Label();
            this.distanceTrackBar = new System.Windows.Forms.TrackBar();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.plateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltageTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTrackBar)).BeginInit();
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
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.Location = new System.Drawing.Point(1224, 462);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(67, 23);
            this.voltageLabel.TabIndex = 2;
            this.voltageLabel.Text = "Voltage";
            // 
            // voltageTrackBar
            // 
            this.voltageTrackBar.Location = new System.Drawing.Point(1312, 452);
            this.voltageTrackBar.Maximum = 2000;
            this.voltageTrackBar.Name = "voltageTrackBar";
            this.voltageTrackBar.Size = new System.Drawing.Size(139, 45);
            this.voltageTrackBar.TabIndex = 3;
            this.voltageTrackBar.ValueChanged += new System.EventHandler(this.voltageTrackBar_ValueChanged);
            // 
            // voltageValueLabel
            // 
            this.voltageValueLabel.AutoSize = true;
            this.voltageValueLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageValueLabel.Location = new System.Drawing.Point(1463, 462);
            this.voltageValueLabel.Name = "voltageValueLabel";
            this.voltageValueLabel.Size = new System.Drawing.Size(67, 23);
            this.voltageValueLabel.TabIndex = 5;
            this.voltageValueLabel.Text = "Voltage";
            // 
            // distanceValueLabel
            // 
            this.distanceValueLabel.AutoSize = true;
            this.distanceValueLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceValueLabel.Location = new System.Drawing.Point(1463, 534);
            this.distanceValueLabel.Name = "distanceValueLabel";
            this.distanceValueLabel.Size = new System.Drawing.Size(76, 23);
            this.distanceValueLabel.TabIndex = 8;
            this.distanceValueLabel.Text = "Distance";
            // 
            // distanceTrackBar
            // 
            this.distanceTrackBar.Location = new System.Drawing.Point(1312, 524);
            this.distanceTrackBar.Maximum = 1000;
            this.distanceTrackBar.Minimum = 100;
            this.distanceTrackBar.Name = "distanceTrackBar";
            this.distanceTrackBar.Size = new System.Drawing.Size(139, 45);
            this.distanceTrackBar.TabIndex = 7;
            this.distanceTrackBar.Value = 1000;
            this.distanceTrackBar.Scroll += new System.EventHandler(this.distanceTrackBar_Scroll);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(1224, 534);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(76, 23);
            this.distanceLabel.TabIndex = 6;
            this.distanceLabel.Text = "Distance";
            // 
            // plateLabel
            // 
            this.plateLabel.AutoSize = true;
            this.plateLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateLabel.Location = new System.Drawing.Point(1351, 401);
            this.plateLabel.Name = "plateLabel";
            this.plateLabel.Size = new System.Drawing.Size(56, 26);
            this.plateLabel.TabIndex = 9;
            this.plateLabel.Text = "Plate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 861);
            this.Controls.Add(this.plateLabel);
            this.Controls.Add(this.distanceValueLabel);
            this.Controls.Add(this.distanceTrackBar);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.voltageValueLabel);
            this.Controls.Add(this.voltageTrackBar);
            this.Controls.Add(this.voltageLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltageTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.TrackBar voltageTrackBar;
        private System.Windows.Forms.Label voltageValueLabel;
        private System.Windows.Forms.Label distanceValueLabel;
        private System.Windows.Forms.TrackBar distanceTrackBar;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label plateLabel;
    }
}

