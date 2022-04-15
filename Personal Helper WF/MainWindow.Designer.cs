﻿namespace Personal_Helper_WF
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
            this.SuspendLayout();
            // 
            // WorkingButton
            // 
            this.WorkingButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WorkingButton.Location = new System.Drawing.Point(377, 228);
            this.WorkingButton.Name = "WorkingButton";
            this.WorkingButton.Size = new System.Drawing.Size(177, 32);
            this.WorkingButton.TabIndex = 0;
            this.WorkingButton.Text = "START";
            this.WorkingButton.UseVisualStyleBackColor = true;
            this.WorkingButton.Click += new System.EventHandler(this.WorkingButton_Click);
            // 
            // SkipStageButton
            // 
            this.SkipStageButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipStageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SkipStageButton.Location = new System.Drawing.Point(377, 258);
            this.SkipStageButton.Name = "SkipStageButton";
            this.SkipStageButton.Size = new System.Drawing.Size(177, 33);
            this.SkipStageButton.TabIndex = 1;
            this.SkipStageButton.Text = "SKIP STAGE";
            this.SkipStageButton.UseVisualStyleBackColor = true;
            this.SkipStageButton.Click += new System.EventHandler(this.SkipStageButton_Click);
            // 
            // setWorkLabel
            // 
            this.setWorkLabel.AutoSize = true;
            this.setWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setWorkLabel.Location = new System.Drawing.Point(373, 179);
            this.setWorkLabel.Name = "setWorkLabel";
            this.setWorkLabel.Size = new System.Drawing.Size(42, 20);
            this.setWorkLabel.TabIndex = 2;
            this.setWorkLabel.Text = "work";
            // 
            // setBreakLabel
            // 
            this.setBreakLabel.AutoSize = true;
            this.setBreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBreakLabel.Location = new System.Drawing.Point(434, 179);
            this.setBreakLabel.Name = "setBreakLabel";
            this.setBreakLabel.Size = new System.Drawing.Size(49, 20);
            this.setBreakLabel.TabIndex = 3;
            this.setBreakLabel.Text = "break";
            // 
            // setLongBreakLabel
            // 
            this.setLongBreakLabel.AutoSize = true;
            this.setLongBreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLongBreakLabel.Location = new System.Drawing.Point(495, 179);
            this.setLongBreakLabel.Name = "setLongBreakLabel";
            this.setLongBreakLabel.Size = new System.Drawing.Size(57, 20);
            this.setLongBreakLabel.TabIndex = 4;
            this.setLongBreakLabel.Text = "l-break";
            // 
            // pomodoroProgressBar
            // 
            this.pomodoroProgressBar.Location = new System.Drawing.Point(0, 297);
            this.pomodoroProgressBar.Name = "pomodoroProgressBar";
            this.pomodoroProgressBar.Size = new System.Drawing.Size(566, 23);
            this.pomodoroProgressBar.TabIndex = 6;
            // 
            // setLongBreakInput
            // 
            this.setLongBreakInput.Location = new System.Drawing.Point(499, 202);
            this.setLongBreakInput.Name = "setLongBreakInput";
            this.setLongBreakInput.Size = new System.Drawing.Size(55, 20);
            this.setLongBreakInput.TabIndex = 7;
            this.setLongBreakInput.Text = "20";
            // 
            // setBreakInput
            // 
            this.setBreakInput.Location = new System.Drawing.Point(438, 202);
            this.setBreakInput.Name = "setBreakInput";
            this.setBreakInput.Size = new System.Drawing.Size(55, 20);
            this.setBreakInput.TabIndex = 8;
            this.setBreakInput.Text = "5";
            // 
            // setWorkInput
            // 
            this.setWorkInput.Location = new System.Drawing.Point(377, 202);
            this.setWorkInput.Name = "setWorkInput";
            this.setWorkInput.Size = new System.Drawing.Size(55, 20);
            this.setWorkInput.TabIndex = 9;
            this.setWorkInput.Text = "25";
            // 
            // pomodoroTimer
            // 
            this.pomodoroTimer.Interval = 1000;
            this.pomodoroTimer.Tick += new System.EventHandler(this.pomodoroTimer_Tick);
            // 
            // timerTextLabel
            // 
            this.timerTextLabel.AutoSize = true;
            this.timerTextLabel.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTextLabel.Location = new System.Drawing.Point(12, 263);
            this.timerTextLabel.Name = "timerTextLabel";
            this.timerTextLabel.Size = new System.Drawing.Size(252, 21);
            this.timerTextLabel.TabIndex = 10;
            this.timerTextLabel.Text = "00:00 | POMODORO SLEEP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 320);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}
