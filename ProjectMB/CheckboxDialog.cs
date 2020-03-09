using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public class CheckboxDialog
    {
        private bool[] result;
        
        public bool FormOpened { get; private set; }

        public CheckboxDialog() 
        {
            result = new bool[7];            
            FormOpened = false;
        }

        public void ShowDialog(string caption)
        {
            FormOpened = true;
            Form prompt = new Form
            {
                Width = 750,
                Height = 550,
                Text = caption
            };
            FlowLayoutPanel panel = new FlowLayoutPanel(); //let the hate flow through you
            panel.Size = new System.Drawing.Size(750, 550);
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
            prompt.FormClosing += (sender, e) => 
            {
                if (e.CloseReason == CloseReason.UserClosing && FormOpened)
                {
                    MessageBox.Show("Changes Not Saved!");
                    FormOpened = false;
                }
            };
            ok.Click += (sender, e) => 
            {
                result[1] = chkT.Checked;               
                result[2] = chkW.Checked;               
                result[3] = chkTD.Checked;               
                result[4] = chkF.Checked;                
                result[5] = chkS.Checked;                
                result[6] = chkSD.Checked;
                result[0] = chkM.Checked;
                FormOpened = false;
                prompt.Close();
            };
            panel.Controls.Add(chkM);
            panel.SetFlowBreak(chkM, true);            
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
            prompt.Controls.Add(panel);
            prompt.ShowDialog();
        }
        public bool[] SelectedValues()
        {
            return result;
        }
       
    }
}
