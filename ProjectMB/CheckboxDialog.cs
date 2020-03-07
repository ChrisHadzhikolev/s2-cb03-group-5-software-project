using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public static class CheckboxDialog
    {
        public static bool[] ShowDialog(string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 500;
            prompt.Text = caption;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Size = new System.Drawing.Size(550, 550);
            CheckBox chkM = new CheckBox();
            chkM.Text = "Monday";
            CheckBox chkT = new CheckBox();
            chkT.Text = "Tuesday";
            CheckBox chkW = new CheckBox();
            chkW.Text = "Wednesday";
            CheckBox chkTD = new CheckBox();
            chkTD.Text = "Thursday";
            CheckBox chkF = new CheckBox();
            chkF.Text = "Friday";
            CheckBox chkS = new CheckBox();
            chkS.Text = "Saturday";
            CheckBox chkSD = new CheckBox();
            chkSD.Text = "Sunday";
            Button ok = new Button() { Text = "Yes" };
            ok.Click += (sender, e) => { prompt.Close(); };
            Button no = new Button() { Text = "No" };
            no.Click += (sender, e) => { prompt.Close(); };
            bool[] result = new bool[7];
            panel.Controls.Add(chkM);
            panel.SetFlowBreak(chkM, true);
            result[0] = chkM.Checked;
            panel.Controls.Add(chkT);
            panel.SetFlowBreak(chkT, true);
            result[1] = chkT.Checked;
            panel.Controls.Add(chkW);
            panel.SetFlowBreak(chkW, true);
            result[2] = chkW.Checked;
            panel.Controls.Add(chkTD);
            panel.SetFlowBreak(chkTD, true);
            result[3] = chkTD.Checked;
            panel.Controls.Add(chkF);
            panel.SetFlowBreak(chkF, true);
            result[4] = chkF.Checked;
            panel.Controls.Add(chkS);
            panel.SetFlowBreak(chkS, true);
            result[5] = chkS.Checked;
            panel.Controls.Add(chkSD);
            panel.SetFlowBreak(chkSD, true);
            result[6] = chkSD.Checked;
            panel.Controls.Add(ok);
            panel.Controls.Add(no);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();
            return result;
        }
    }
}
