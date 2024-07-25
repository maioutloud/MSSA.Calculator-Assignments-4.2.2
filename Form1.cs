using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments_4._2._2
{
    // ASSIGNMENTS 4.2.2 : CALCULATOR
    // CCAD12 : MAI LOR
    public partial class FormCalculator : Form
    {
        Calculator calc = new Calculator();
        double num1;
        double num2;
        string operation;
        double result;

        public FormCalculator()
        {
            InitializeComponent();
        }
        private void FormCalculator_Load(object sender, EventArgs e)
        {
        }
          /*--------------------------------------*/
         /*            FORMULA LABEL             */
        /*--------------------------------------*/
        private void UpdateFormulaLabel(string character) 
        {
            if (string.IsNullOrEmpty(operation))
            {
                lblCurrentOperation.Text = character;
            }
            else
            {
                lblCurrentOperation.Text = $"{ character}";
            }
        }
          /*----------------------------------------------*/
         /*             CALCULATOR OPERATION             */
        /*----------------------------------------------*/
        private void btnequal_click(object sender, EventArgs e)
        {
            if (num1 != 0 && !string.IsNullOrEmpty(operation))
            {
                num2 = double.Parse(txtDisplay.Text);
                if (operation.Equals(btnPlus.Text))
                {
                    result = calc.Add(num1, num2);
                }
                else if (operation.Equals(btnMinus.Text))
                {
                    result = calc.Subtract(num1, num2);
                }
                else if (operation.Equals(btnMult.Text))
                {
                    result = calc.Multiply(num1, num2);
                }
                else if (operation.Equals(btnDiv.Text))
                {
                    if(num2==0)
                    {
                        MessageBox.Show("Cannot Divide by Zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = calc.Divide(num1, num2);
                }
                txtDisplay.Text = result.ToString();
                lblCurrentOperation.Text = num1 + operation + num2 + "=" + result.ToString();
            }
            else
            {
                MessageBox.Show("Please select an operator and a second number before calculating.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          /*--------------------------------------*/
         /*            CLEAR BUTTONS             */
        /*--------------------------------------*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
            result = 0;
            num1 = 0;
            num2 = 0;
            operation = ""; 
            lblCurrentOperation.Text = ""; 
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            // this condition checks if there are 1 or more character
            if (txtDisplay.Text.Length > 1) 
            {
                // if more than 1 character, remove the last
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1); 
                UpdateFormulaLabel(txtDisplay.Text);
            }
            else
            {
                // if the display is 0 and clear the label
                txtDisplay.Text = "0"; 
                lblCurrentOperation.Text = ""; 
            }
        }
          /*------------------------------------------*/
         /*            OPERATION BUTTONS             */
        /*------------------------------------------*/
        private void btnPlus_Click(object sender, EventArgs e)  
        // ADD
        {
            operation = btnPlus.Text;
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            UpdateFormulaLabel(num1 + operation);
        }

        private void btnMinus_Click(object sender, EventArgs e) 
        // SUBTRACT
        {
            operation = btnMinus.Text;
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            UpdateFormulaLabel(num1 + operation);
        }
        private void btnMult_Click(object sender, EventArgs e)  
        // MULTIPLY
        {
            operation = btnMult.Text;
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            UpdateFormulaLabel(num1 + operation);
        }

        private void btnDiv_Click(object sender, EventArgs e)   
        // DIVIDE
        {
            operation = btnDiv.Text;
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            UpdateFormulaLabel(num1 + operation);
        }
          /*---------------------------------------*/
         /*            NUMPAD BUTTONS             */
        /*---------------------------------------*/
        private void btnDot_Click(object sender, EventArgs e)
        // .
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text = txtDisplay.Text + btnDot.Text;
            }
            UpdateFormulaLabel(txtDisplay.Text);
        }
        private void btn0_Click(object sender, EventArgs e)
        // 0
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn0.Text;
                lblCurrentOperation.Text = btn0.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn0.Text;
                lblCurrentOperation.Text += btn0.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        // 1
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn1.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn1.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        // 2
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn2.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn2.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        // 3
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn3.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn3.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        // 4
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn4.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn4.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        // 5
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn5.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn5.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        // 6
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn6.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn6.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        // 7
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn7.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn7.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        // 8
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn8.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn8.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        // 9
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn9.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btn9.Text;
            }
            UpdateFormulaLabel(lblCurrentOperation.Text + btn9.Text);
        }
          /*-----------------------------------------------------*/
         /*                          FIN                        */
        /*-----------------------------------------------------*/
    }
}
