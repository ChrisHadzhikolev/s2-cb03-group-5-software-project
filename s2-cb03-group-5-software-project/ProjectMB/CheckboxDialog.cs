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
        private bool[] _result;
        
        public bool FormOpened { get; private set; }

        public CheckboxDialog() 
        {
            _result = new bool[7];            
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
            CheckBox chkTd = new CheckBox();
            chkTd.Text = "Thursday";
            CheckBox chkF = new CheckBox();
            chkF.Text = "Friday";
            CheckBox chkS = new CheckBox();
            chkS.Text = "Saturday";
            CheckBox chkSd = new CheckBox();
            chkSd.Text = "Sunday";
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
                _result[1] = chkT.Checked;               
                _result[2] = chkW.Checked;               
                _result[3] = chkTd.Checked;               
                _result[4] = chkF.Checked;                
                _result[5] = chkS.Checked;                
                _result[6] = chkSd.Checked;
                _result[0] = chkM.Checked;
                FormOpened = false;
                prompt.Close();
            };
            panel.Controls.Add(chkM);
            panel.SetFlowBreak(chkM, true);            
            panel.Controls.Add(chkT);
            panel.SetFlowBreak(chkT, true);
            _result[1] = chkT.Checked;
            panel.Controls.Add(chkW);
            panel.SetFlowBreak(chkW, true);
            _result[2] = chkW.Checked;
            panel.Controls.Add(chkTd);
            panel.SetFlowBreak(chkTd, true);
            _result[3] = chkTd.Checked;
            panel.Controls.Add(chkF);
            panel.SetFlowBreak(chkF, true);
            _result[4] = chkF.Checked;
            panel.Controls.Add(chkS);
            panel.SetFlowBreak(chkS, true);
            _result[5] = chkS.Checked;
            panel.Controls.Add(chkSd);
            panel.SetFlowBreak(chkSd, true);
            _result[6] = chkSd.Checked;
            panel.Controls.Add(ok);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();
        }
        public bool[] SelectedValues()
        {
            return _result;
        }
       
    }
}
