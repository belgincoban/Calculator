using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        private enum TOperationType { OtNone, OtPlus, OtDiff, OtDiv, OtMult };
        private TOperationType OperationType = TOperationType.OtNone;
        private double Result = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            DialogResult dr;
            if (e.KeyChar == 27)
            {
                dr = MessageBox.Show("Çıkmak istediğinizden emin misiniz? ", "Çıkış Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        }
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{

            //}
        }
        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{

            //}
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DoSetOffButton();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
        }
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtPlus;
            DoGetResultFromTxtResult();
        }
        private void BtnDifference_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtDiff;
            DoGetResultFromTxtResult();
        }
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtDiv;
            DoGetResultFromTxtResult();
        }
        private void BtnMult_Click(object sender, EventArgs e)
        {
            OperationType = TOperationType.OtMult;
            DoGetResultFromTxtResult();
        }
        private void BtnTotal_Click(object sender, EventArgs e)
        {
            DoCalculate();
        }


        #region Self commands
        private void NumberButtonsClick(object sender, EventArgs e)
        {
            string ANumber = ((Button)sender).Text;
            DoAddTextIntoTxtResult(ANumber);
        }
        private void DoSetOffButton()
        {
            foreach (Control BtnControl in PnlNumbers.Controls)
            {
                Button button = BtnControl as Button;
                button.Click += NumberButtonsClick;
                string Number = button.Name.Replace("Btn", "").Replace("Dot", ",");
                button.Text = Number;
            }
        }
        private void DoAddTextIntoTxtResult(string AKey)
        {
            if (AKey.Trim() == "")
                return;

            if (AKey == ",")
            {
                if (TxtResult.Text.IndexOf(",") > -1)
                    return;
                if (TxtResult.Text.Length == 0)
                    AKey = "0,";
            }

            if (TxtResult.Text == "0")
                TxtResult.Text = "0,";

            TxtResult.Text += AKey;

        }
        private void DoGetResultFromTxtResult()
        {
            Result = Convert.ToDouble(TxtResult.Text);
            TxtResult.Clear();
        }
        private void DoCalculate()
        {
            switch (OperationType)
            {
                case TOperationType.OtNone:
                    break;
                case TOperationType.OtPlus:
                    DoCalculatePlus();
                    break;
                case TOperationType.OtDiff:
                    DoCalculateDiff();
                    break;
                case TOperationType.OtDiv:
                    DoCalculateDiv();
                    break;
                case TOperationType.OtMult:
                    DoCalculateMult();
                    break;
                default:
                    break;
            }
        }
        private void DoCalculatePlus()
        {
            double Avalue = Convert.ToDouble(TxtResult.Text);
            double Aresult = Result + Avalue;
            TxtResult.Text = Aresult.ToString();
        }
        private void DoCalculateDiff()
        {
            double Avalue = Convert.ToDouble(TxtResult.Text);
            double Aresult = Result - Avalue;
            TxtResult.Text = Aresult.ToString();
        }
        private void DoCalculateDiv()
        {
            double Avalue = Convert.ToDouble(TxtResult.Text);
            double Aresult = Result / Avalue;
            TxtResult.Text = Aresult.ToString();
        }
        private void DoCalculateMult()
        {
            double Avalue = Convert.ToDouble(TxtResult.Text);
            double Aresult = Result * Avalue;
            TxtResult.Text = Aresult.ToString();
        }

        #endregion

        private void Btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ben ilk çalışacağım");
        }
    }
}
