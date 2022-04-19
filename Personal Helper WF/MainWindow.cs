using System;
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
    public partial class MainWindow : Form
    {

        string pomodoroStatus = "POMODORO SLEEP";
        double workingTimeMinutes, breakTimeMinutes, longBreakTimeMinutes;
        double workingTimeSeconds, breakTimeSeconds, longBreakTimeSeconds;
        int workingSessions = 0;
        double totalWorkSeconds = -1;
        double currentTimerMax = 100;
        bool isPomodoroRunning = false;

        public MainWindow()
        {
            InitializeComponent();
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

            switch (pomodoroStatus)
            {
                case "WORK TIME":
                    currentTimerMax = workingTimeSeconds;
                    break;
                case "BREAK TIME":
                    currentTimerMax = breakTimeSeconds;
                    break;
                case "LONG BREAK TIME":
                    currentTimerMax = longBreakTimeSeconds;
                    break;
                default:
                    currentTimerMax = workingTimeSeconds;
                    break;
            }
        }

        private void StopPomodoro()
        {
            pomodoroTimer.Stop();
            pomodoroProgressBar.Value = 0;
            pomodoroStatus = "POMODORO SLEEP";
            workingSessions = 0;
            timerTextLabel.BackColor = Color.DarkSeaGreen;
            timerTextLabel.Text = $"00:00 | POMODORO STOPPED";
            isPomodoroRunning = false;
            SwitchPomodoroButton();
        }

        private void SwitchPomodoroButton()
        {
            if (isPomodoroRunning)
            {
                WorkingButton.Text = "STOP";

                setWorkInput.Enabled = false;
                setBreakInput.Enabled = false;
                setLongBreakInput.Enabled = false;
            }
            else
            {
                WorkingButton.Text = "START";

                setWorkInput.Enabled = true;
                setBreakInput.Enabled = true;
                setLongBreakInput.Enabled = true;
            }
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

            ProgressValueProcess(timerSeconds);

            SetTimerText(timerTextLabel, timerSeconds);
            CorrectTimerText(timerTextLabel, timerSeconds);

            if (timerSeconds <= 0)
                GoToNextTimerStage();
        }

        private void SetTimerText(Label label, double seconds)
        {
            label.Text = $"{Math.Floor(seconds / 60)}:{seconds % 60}";
            label.Text += $" | {pomodoroStatus}";
        }

        private void CorrectTimerText(Label label, double seconds)
        {
            if (Math.Floor(seconds / 60) < 10)
                label.Text = label.Text.Insert(0, "0");
            if (seconds % 60 < 10)
            {
                if (seconds / 60 > 2)
                    label.Text = label.Text.Insert(4, "0");
                else
                    label.Text = label.Text.Insert(3, "0");
            }
        }

        private void ProgressValueProcess(double timeLeft)
        {
            int currentPercent = (int) (timeLeft / (currentTimerMax / 100));
            pomodoroProgressBar.Value = 100 - currentPercent;
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
                    timerTextLabel.BackColor = Color.IndianRed;
                    break;

                case "BREAK TIME":
                    TimerProcess(breakTimeSeconds);
                    timerTextLabel.BackColor = Color.LightGoldenrodYellow;
                    break;

                case "LONG BREAK TIME":
                    TimerProcess(longBreakTimeSeconds);
                    timerTextLabel.BackColor = Color.DarkGray;
                    break;

                case "POMODORO SLEEP":
                    pomodoroStatus = "WORK TIME";
                    break;
            }

            if (pomodoroStatus == "WORK TIME")
            {
                totalWorkSeconds++;
                totalWorkTime.Text = $"{Math.Floor((double)totalWorkSeconds / 60)}:{totalWorkSeconds % 60}";
                totalWorkTime.Text += " | TOTAL WORK TIME";

                CorrectTimerText(totalWorkTime, totalWorkSeconds);
            }

        }

        private void WorkingButton_Click(object sender, EventArgs e)
        {
            if (isPomodoroRunning)
            {
                StopPomodoro();
            }
            else
            {
                try
                {
                    isPomodoroRunning = true;
                    StartPomodoroWithCurrentSettings();
                    SwitchPomodoroButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Enter correct time in minutes \n \n {ex}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SkipStageButton_Click(object sender, EventArgs e)
        {
            GoToNextTimerStage();
        }

        // *** CALCULATOR *** \\

        private void calcInput_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string math = calcInput.Text;
                string value = new DataTable().Compute(math, null).ToString();
                resultLabel.Text = "= " + value;
            }
            catch
            {

            }
        }

        // ****************** \\


    }
}
