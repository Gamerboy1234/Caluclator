
using System;
using System.Windows.Forms;

namespace Calulator
{
    public partial class CalculatorForm : Form
    {
        private string _operation = "";
        private string _operand1 = "";
        private string _operand2 = "";

        private string _value;

        public CalculatorForm()
        {
            InitializeComponent();

            _value = "0";
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            lblResult.Text = _value;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddToValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddToValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddToValue("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddToValue("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddToValue("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddToValue("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddToValue("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddToValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddToValue("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddToValue("0");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            _operation = "";
            _operand1 = "";
            _operand2 = "";

            _value = "0";

            lblResult.Text = _value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _operation = "add";
            _operand1 = _value;

            _value = "0";

            lblResult.Text = _value;
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            _operation = "subtract";
            _operand1 = _value;

            _value = "0";

            lblResult.Text = _value;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            _operation = "multiply";
            _operand1 = _value;

            _value = "0";

            lblResult.Text = _value;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            _operation = "divide";
            _operand1 = _value;

            _value = "0";

            lblResult.Text = _value;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // TODO: Needs to add . in between our 1st number and second number 

            AddToValue(".");
        }
        
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_operation) &&
                !string.IsNullOrEmpty(_operand1))
            {
                _operand2 = _value;

                switch (_operation)
                {
                    case "add":
                        {
                            if (_operand1.Contains(".") || _operand2.Contains("."))
                            {
                                var result = Convert.ToDecimal(_operand1) + Convert.ToDecimal(_operand2);

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            else
                            {
                                var result = Convert.ToInt64(_operand1) + Convert.ToInt64(_operand2);

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            _operation = "";
                            _operand1 = "";
                            _operand2 = "";
                        }
                        break;
                    case "subtract":
                        {
                            if (_operand1.Contains(".") || _operand2.Contains("."))
                            {
                                var result = Convert.ToDecimal(_operand1) - Convert.ToDecimal(_operand2);

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            else
                            {
                                var result = Convert.ToInt64(_operand1) - Convert.ToInt64(_operand2);

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            _operation = "";
                            _operand1 = "";
                            _operand2 = "";
                        }

                        break;
                    case "multiply":
                        {
                            if (_operand1.Contains(".") || _operand2.Contains("."))
                            {
                                var result = Convert.ToDecimal(_operand1) * Convert.ToDecimal(_operand2);

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            else
                            {
                                var result = Convert.ToInt64(_operand1) * Convert.ToInt64(_operand2);

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            _operation = "";
                            _operand1 = "";
                            _operand2 = "";
                        }

                        break;
                    case "divide":
                        {
                            if (_operand1.Contains(".") || _operand2.Contains("."))
                            {
                                decimal result = 0.0M;
                                try
                                {
                                    result = Convert.ToDecimal(_operand1) / Convert.ToDecimal(_operand2);
                                }
                                catch (System.DivideByZeroException)
                                {
                                    MessageBox.Show("Can't divde by 0 scrub git gud");
                                }
                               

                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            else
                            {
                                long result = 0;
                                try
                                {
                                    result = Convert.ToInt64(_operand1) / Convert.ToInt64(_operand2);
                                }
                                catch (System.DivideByZeroException)
                                {
                                    MessageBox.Show("Can't divde by 0 scrub git gud. Also bubba is a scrub too.");
                                }


                                _value = result.ToString();

                                lblResult.Text = result.ToString();
                            }

                            _operation = "";
                            _operand1 = "";
                            _operand2 = "";
                        }

                        break;
                }
            }
        }

        private void AddToValue(string addValue)
        {
            if (!string.IsNullOrEmpty(addValue))
            {
                if (addValue == "0")
                {
                    if (_value != "0")
                    {
                        _value = $"{_value}{addValue}";
                    }
                }

                else
                {
                    if (_value == "0")
                    {
                        _value = addValue;
                    }

                    else
                    {
                        _value = $"{_value}{addValue}";
                    }
                }

                lblResult.Text = _value;
            }
        }
    }
}
