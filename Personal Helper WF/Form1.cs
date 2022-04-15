﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Helper_WF
{
    public partial class Form1 : Form
    {

        string pomodoroStatus = "POMODORO SLEEP";
        double workingTimeMinutes, breakTimeMinutes, longBreakTimeMinutes;
        double workingTimeSeconds, breakTimeSeconds, longBreakTimeSeconds;
        int workingSessions = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerProcess(double timerSeconds)
        {
            --timerSeconds;
            switch (pomodoroStatus)
            {
                case "WORK TIME":
                    --workingTimeSeconds;
                    break;
                case "BREAK TIME":
                    --breakTimeSeconds;
                    break;
                case "LONG BREAK TIME":
                    --longBreakTimeSeconds;
                    break;
            }

            timerTextLabel.Text = $"{Math.Floor(timerSeconds / 60)}:{timerSeconds % 60}";
            timerTextLabel.Text += $" | {pomodoroStatus}";

            if (Math.Floor(timerSeconds / 60) < 10)
                timerTextLabel.Text = timerTextLabel.Text.Insert(0, "0");

            if (timerSeconds % 60 < 10)
                timerTextLabel.Text = timerTextLabel.Text.Insert(3, "0");

            if (timerSeconds <= 0)
            {
                GoToNextTimerStage();
            }
        }

        private void GoToNextTimerStage()
        {
            if (pomodoroStatus == "WORK TIME")
                {
                    ++workingSessions;

                    if (workingSessions != 0 && workingSessions % 2 == 0)
                    {
                        pomodoroStatus = "LONG BREAK TIME";
                    }
                    else
                    {
                        pomodoroStatus = "BREAK TIME";
                    }
                }
                else if (pomodoroStatus == "BREAK TIME" || pomodoroStatus == "LONG BREAK TIME")
                {
                    pomodoroStatus = "WORK TIME";
                }

                SetEnteredPomodoroSettings();
        }

        private void pomodoroTimer_Tick(object sender, EventArgs e)
        {
            switch (pomodoroStatus)
            {

                case "WORK TIME":
                    TimerProcess(workingTimeSeconds);
                    break;

                case "BREAK TIME":
                    TimerProcess(breakTimeSeconds);
                    break;

                case "LONG BREAK TIME":
                    TimerProcess(longBreakTimeSeconds);
                    break;

                case "POMODORO SLEEP":
                    pomodoroStatus = "WORK TIME";
                    break;
            }
        }

        private void WorkingButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartPomodoroWithCurrentSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Enter correct time in minutes \n \n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SkipStageButton_Click(object sender, EventArgs e)
        {
            GoToNextTimerStage();
        }

        private void StartPomodoroWithCurrentSettings()
        {
            SetEnteredPomodoroSettings();
            pomodoroTimer.Enabled = true;
        }
        private void SetEnteredPomodoroSettings()
        {
            workingTimeMinutes = Double.Parse(setWorkInput.Text);
            breakTimeMinutes = Double.Parse(setBreakInput.Text);
            longBreakTimeMinutes = Double.Parse(setLongBreakInput.Text);

            workingTimeSeconds = workingTimeMinutes * 60;
            breakTimeSeconds = breakTimeMinutes * 60;
            longBreakTimeSeconds = longBreakTimeMinutes * 60;
        }

    }
}
