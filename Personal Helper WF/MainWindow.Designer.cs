namespace Personal_Helper_WF
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.WorkingButton = new System.Windows.Forms.Button();
            this.SkipStageButton = new System.Windows.Forms.Button();
            this.setWorkLabel = new System.Windows.Forms.Label();
            this.setBreakLabel = new System.Windows.Forms.Label();
            this.setLongBreakLabel = new System.Windows.Forms.Label();
            this.pomodoroProgressBar = new System.Windows.Forms.ProgressBar();
            this.setLongBreakInput = new System.Windows.Forms.TextBox();
            this.setBreakInput = new System.Windows.Forms.TextBox();
            this.setWorkInput = new System.Windows.Forms.TextBox();
            this.pomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.timerTextLabel = new System.Windows.Forms.Label();
            this.totalWorkTime = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.upperText = new System.Windows.Forms.Label();
            this.calcInput = new System.Windows.Forms.TextBox();
            this.calcLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkingButton
            // 
            this.WorkingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WorkingButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WorkingButton.Location = new System.Drawing.Point(292, 157);
            this.WorkingButton.Name = "WorkingButton";
            this.WorkingButton.Size = new System.Drawing.Size(164, 46);
            this.WorkingButton.TabIndex = 0;
            this.WorkingButton.Text = "START";
            this.WorkingButton.UseVisualStyleBackColor = true;
            this.WorkingButton.Click += new System.EventHandler(this.WorkingButton_Click);
            // 
            // SkipStageButton
            // 
            this.SkipStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkipStageButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipStageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SkipStageButton.Location = new System.Drawing.Point(292, 209);
            this.SkipStageButton.Name = "SkipStageButton";
            this.SkipStageButton.Size = new System.Drawing.Size(164, 33);
            this.SkipStageButton.TabIndex = 1;
            this.SkipStageButton.Text = "SKIP STAGE";
            this.SkipStageButton.UseVisualStyleBackColor = true;
            this.SkipStageButton.Click += new System.EventHandler(this.SkipStageButton_Click);
            // 
            // setWorkLabel
            // 
            this.setWorkLabel.AutoSize = true;
            this.setWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setWorkLabel.Location = new System.Drawing.Point(394, 79);
            this.setWorkLabel.Name = "setWorkLabel";
            this.setWorkLabel.Size = new System.Drawing.Size(62, 20);
            this.setWorkLabel.TabIndex = 2;
            this.setWorkLabel.Text = "WORK";
            // 
            // setBreakLabel
            // 
            this.setBreakLabel.AutoSize = true;
            this.setBreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBreakLabel.Location = new System.Drawing.Point(387, 105);
            this.setBreakLabel.Name = "setBreakLabel";
            this.setBreakLabel.Size = new System.Drawing.Size(69, 20);
            this.setBreakLabel.TabIndex = 3;
            this.setBreakLabel.Text = "BREAK";
            // 
            // setLongBreakLabel
            // 
            this.setLongBreakLabel.AutoSize = true;
            this.setLongBreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLongBreakLabel.Location = new System.Drawing.Point(371, 131);
            this.setLongBreakLabel.Name = "setLongBreakLabel";
            this.setLongBreakLabel.Size = new System.Drawing.Size(85, 20);
            this.setLongBreakLabel.TabIndex = 4;
            this.setLongBreakLabel.Text = "L-BREAK";
            // 
            // pomodoroProgressBar
            // 
            this.pomodoroProgressBar.Location = new System.Drawing.Point(0, 297);
            this.pomodoroProgressBar.Name = "pomodoroProgressBar";
            this.pomodoroProgressBar.Size = new System.Drawing.Size(469, 23);
            this.pomodoroProgressBar.TabIndex = 6;
            // 
            // setLongBreakInput
            // 
            this.setLongBreakInput.Location = new System.Drawing.Point(292, 131);
            this.setLongBreakInput.Name = "setLongBreakInput";
            this.setLongBreakInput.Size = new System.Drawing.Size(71, 20);
            this.setLongBreakInput.TabIndex = 7;
            this.setLongBreakInput.Text = "20";
            this.setLongBreakInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setBreakInput
            // 
            this.setBreakInput.Location = new System.Drawing.Point(292, 105);
            this.setBreakInput.Name = "setBreakInput";
            this.setBreakInput.Size = new System.Drawing.Size(71, 20);
            this.setBreakInput.TabIndex = 8;
            this.setBreakInput.Text = "5";
            this.setBreakInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setWorkInput
            // 
            this.setWorkInput.BackColor = System.Drawing.SystemColors.Window;
            this.setWorkInput.Location = new System.Drawing.Point(292, 79);
            this.setWorkInput.Name = "setWorkInput";
            this.setWorkInput.Size = new System.Drawing.Size(71, 20);
            this.setWorkInput.TabIndex = 9;
            this.setWorkInput.Text = "25";
            this.setWorkInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pomodoroTimer
            // 
            this.pomodoroTimer.Interval = 1000;
            this.pomodoroTimer.Tick += new System.EventHandler(this.pomodoroTimer_Tick);
            // 
            // timerTextLabel
            // 
            this.timerTextLabel.AutoSize = true;
            this.timerTextLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.timerTextLabel.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTextLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timerTextLabel.Location = new System.Drawing.Point(23, 249);
            this.timerTextLabel.Name = "timerTextLabel";
            this.timerTextLabel.Size = new System.Drawing.Size(252, 21);
            this.timerTextLabel.TabIndex = 10;
            this.timerTextLabel.Text = "00:00 | POMODORO SLEEP";
            // 
            // totalWorkTime
            // 
            this.totalWorkTime.AutoSize = true;
            this.totalWorkTime.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWorkTime.Location = new System.Drawing.Point(23, 270);
            this.totalWorkTime.Name = "totalWorkTime";
            this.totalWorkTime.Size = new System.Drawing.Size(263, 21);
            this.totalWorkTime.TabIndex = 11;
            this.totalWorkTime.Text = "00:00 | TOTAL WORK TIME";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 209);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // upperText
            // 
            this.upperText.AutoSize = true;
            this.upperText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.upperText.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upperText.Location = new System.Drawing.Point(23, 9);
            this.upperText.Name = "upperText";
            this.upperText.Size = new System.Drawing.Size(118, 21);
            this.upperText.TabIndex = 13;
            this.upperText.Text = "DONE LIST";
            // 
            // calcInput
            // 
            this.calcInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcInput.Location = new System.Drawing.Point(292, 33);
            this.calcInput.Name = "calcInput";
            this.calcInput.Size = new System.Drawing.Size(164, 19);
            this.calcInput.TabIndex = 14;
            this.calcInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calcInput.TextChanged += new System.EventHandler(this.calcInput_TextChanged);
            // 
            // calcLabel
            // 
            this.calcLabel.AutoSize = true;
            this.calcLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.calcLabel.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcLabel.Location = new System.Drawing.Point(312, 9);
            this.calcLabel.Name = "calcLabel";
            this.calcLabel.Size = new System.Drawing.Size(130, 21);
            this.calcLabel.TabIndex = 16;
            this.calcLabel.Text = "CALCULATOR";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.resultLabel.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultLabel.Location = new System.Drawing.Point(292, 55);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(32, 21);
            this.resultLabel.TabIndex = 17;
            this.resultLabel.Text = "= ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(469, 320);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calcLabel);
            this.Controls.Add(this.calcInput);
            this.Controls.Add(this.upperText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.totalWorkTime);
            this.Controls.Add(this.timerTextLabel);
            this.Controls.Add(this.setWorkInput);
            this.Controls.Add(this.setBreakInput);
            this.Controls.Add(this.setLongBreakInput);
            this.Controls.Add(this.pomodoroProgressBar);
            this.Controls.Add(this.setLongBreakLabel);
            this.Controls.Add(this.setBreakLabel);
            this.Controls.Add(this.setWorkLabel);
            this.Controls.Add(this.SkipStageButton);
            this.Controls.Add(this.WorkingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Personal Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WorkingButton;
        private System.Windows.Forms.Button SkipStageButton;
        private System.Windows.Forms.Label setWorkLabel;
        private System.Windows.Forms.Label setBreakLabel;
        private System.Windows.Forms.Label setLongBreakLabel;
        private System.Windows.Forms.ProgressBar pomodoroProgressBar;
        private System.Windows.Forms.TextBox setLongBreakInput;
        private System.Windows.Forms.TextBox setBreakInput;
        private System.Windows.Forms.TextBox setWorkInput;
        private System.Windows.Forms.Timer pomodoroTimer;
        private System.Windows.Forms.Label timerTextLabel;
        private System.Windows.Forms.Label totalWorkTime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label upperText;
        private System.Windows.Forms.TextBox calcInput;
        private System.Windows.Forms.Label calcLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

