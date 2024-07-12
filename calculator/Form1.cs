using System;
using System.Linq;
using System.Windows.Forms;


namespace calculator
{
    public partial class Form1 : Form
    {
        //done C = refresh data
        //done equal button na pag nag enter is mag equal
        //done sa "Cannot divide by zero"
        //-nag add po ako ng bool
        //--to disable the operator buttons
        //done nag add din po ako ng Alt + BackSpace
        //-para po sa ClearEntry
        //done add number button

        public double _FirstNumber, _SecondNumber;
        public string _OperatorSymbol, _TotalPercent;
        public bool _opComplete = false;


        public Form1()
        {
            InitializeComponent();

            cal_txt.TextChanged += cal_txt_TextChanged;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        #region --Keyboard press--       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Console.WriteLine("KeyData: " + keyData);

            if (keyData == Keys.Enter)
            {
                Equal_btn.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.Back))
            {
                ClearEnt_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad1 || keyData == Keys.D1)
            {
                btn_1.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad2 || keyData == Keys.D2)
            {
                btn_2.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad3 || keyData == Keys.D3)
            {
                btn_3.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad4 || keyData == Keys.D4)
            {
                btn_4.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad5 || keyData == Keys.D5)
            {
                btn_5.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad6 || keyData == Keys.D6)
            {
                btn_6.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad7 || keyData == Keys.D7)
            {
                btn_7.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad8 || keyData == Keys.D8)
            {
                btn_8.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad9 || keyData == Keys.D9)
            {
                btn_9.PerformClick();
                return true;
            }
            else if (keyData == Keys.NumPad0 || keyData == Keys.D0)
            {
                btn_0.PerformClick();
                return true;
            }
            else if (keyData == Keys.Add)
            {
                Add_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.Subtract)
            {
                Subtract_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.Multiply)
            {
                Multiply_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.Divide)
            {
                Divide_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.Decimal)
            {
                Dot_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.Back)
            {
                Delete_btn.PerformClick();
                return true;
            }
            else if (keyData == Keys.Delete)
            {
                Clear_btn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region--numbers--
        private void numbers(object sender, EventArgs e)
        {
            try
            {
                Button num = sender as Button;

                if (_opComplete == true)
                {
                    cal_txt.Text = "0";
                    _opComplete = false;
                }
                if (cal_txt.Text == "0")
                    cal_txt.Text = "0";
                {
                    if (num.Text == ".")
                    {
                        if (!cal_txt.Text.Contains("."))
                            cal_txt.Text = cal_txt.Text + num.Text;
                    }
                    else
                    {
                        cal_txt.Text = cal_txt.Text + num.Text;
                        ButtonEnabled(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        #endregion

        #region--operators--
        private void Operation(object sender, EventArgs e)
        {
            try
            {
                Button opbutton = sender as Button;

                //if (_opComplete == false)
                //{

                //    calculate();
                //    _opComplete = true;

                //}

                _FirstNumber = Convert.ToDouble(cal_txt.Text);
                _OperatorSymbol = opbutton.Text;
                show_txt.Text = $"{_FirstNumber} {_OperatorSymbol}";
                _opComplete = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }


        public void ButtonEnabled(bool DisableOrEnable)
        {
            Add_btn.Enabled = DisableOrEnable;
            Subtract_btn.Enabled = DisableOrEnable;
            Multiply_btn.Enabled = DisableOrEnable;
            Divide_btn.Enabled = DisableOrEnable;
        }
        #endregion

        #region --calculate--
        public void calculate()
        {
            try
            {
                _SecondNumber = Convert.ToDouble(cal_txt.Text);

                switch (_OperatorSymbol)
                    {
                        case "+":
                            cal_txt.Text = (_FirstNumber + _SecondNumber).ToString();
                            break;
                        case "-":
                            cal_txt.Text = (_FirstNumber - _SecondNumber).ToString();
                            break;
                        case "*":
                            cal_txt.Text = (_FirstNumber * _SecondNumber).ToString();
                            break;
                        case "/":
                            if (_SecondNumber == 0)
                            {
                                cal_txt.Text = "Cannot divide by zero";
                                ButtonEnabled(false);
                            }
                            else
                            {
                                cal_txt.Text = (_FirstNumber / _SecondNumber).ToString();
                            }
                            break;
                        default:
                            break;
                    }

                if (_OperatorSymbol == null)
                {
                    _FirstNumber = Convert.ToDouble(cal_txt.Text);                    
                    show_txt.Text = $"{_FirstNumber} =";
                    _opComplete = true;
                }

                else
                {
                    show_txt.Text = $"{_FirstNumber} {_OperatorSymbol} {_SecondNumber} =";                    
                    _opComplete = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }
        private void Percent_btn_Click(object sender, EventArgs e)
        {
            _SecondNumber = Convert.ToDouble(cal_txt.Text);

            _TotalPercent = ((_FirstNumber * _SecondNumber) / 100).ToString();

            cal_txt.Text = _TotalPercent;
            show_txt.Text = $"{_FirstNumber} {_OperatorSymbol} {_TotalPercent} =";
            _opComplete = true;
        }
        private void Equal_btn_Click(object sender, EventArgs e)
        {                
                calculate();
                _opComplete = true;            
        }

        #endregion

        #region--delete function--
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_opComplete == true)
                {
                    cal_txt.Text = cal_txt.Text;
                }
                else
                {
                    if (cal_txt.Text.Length > 1)
                    {
                        cal_txt.Text = cal_txt.Text.Substring(0, cal_txt.Text.Length - 1);
                    }
                    else
                    {
                        cal_txt.Text = "0";
                    }
                }

                if (cal_txt.Text == "Cannot divide by zero")
                {
                    cal_txt.Text = "0";
                    show_txt.Text = " ";
                    ButtonEnabled(true);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            cal_txt.Text = "0";
            show_txt.Text = " ";
            _FirstNumber = 0; _SecondNumber = 0;
            _OperatorSymbol = null;
            _opComplete = true;

            ButtonEnabled(true);
        }

        private void ClearEnt_btn_Click(object sender, EventArgs e)
        {
            cal_txt.Text = "0";
            ButtonEnabled(true);
        }       
        #endregion

        #region --Symbols--
        private void Negative_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cal_txt.Text.StartsWith("-"))
                {
                    cal_txt.Text = cal_txt.Text.Substring(1);
                }
                else if (!string.IsNullOrEmpty(cal_txt.Text) && decimal.Parse(cal_txt.Text) != 0)
                {
                    cal_txt.Text = "-" + cal_txt.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        /// <summary>
        /// Limiting the display of characters in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cal_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //format with comma
                if (sender is TextBox textBox)
                {
                    string value = textBox.Text.Replace(",", "");

                    if (long.TryParse(value, out long number))
                    {
                        textBox.Text = string.Format("{0:N0}", number);
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                }

                //set limit input
                int maxLength;
                int commaCount;

                TextBox textBox2 = sender as TextBox;

                if (cal_txt.Text.StartsWith("-"))
                {
                    maxLength = 22;
                }
                else if (cal_txt.Text.Contains(",") && cal_txt.Text.Contains("."))
                {
                    commaCount = cal_txt.Text.Count(characters => characters == ',');
                    maxLength = commaCount + 17;
                }
                else if (cal_txt.Text.Contains("."))
                {
                    maxLength = 17;
                }
                else
                {
                    maxLength = 21;
                }

                if (textBox2.Text.Length > maxLength)
                {
                    textBox2.Text = textBox2.Text.Substring(0, maxLength);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }                
        #endregion        
    }
}
