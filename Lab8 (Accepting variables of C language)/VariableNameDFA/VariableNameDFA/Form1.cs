using System;
using System.Windows.Forms;

namespace VariableNameDFA
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = ""; // Clear the result label on start
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim(); // Remove leading/trailing whitespace

            // Check for null or empty input
            if (string.IsNullOrEmpty(input))
            {
                lblResult.Text = "Invalid Input: Variable name cannot be empty.";
                return;
            }

            bool isValid = IsValidVariableName(input);
            lblResult.Text = isValid ? "Valid Variable Name" : "Invalid Variable Name";

            txtInput.Text = "";
        }

        private bool IsValidVariableName(string input)
        {
            int state = 0; // Start state q0

            foreach (char ch in input)
            {
                switch (state)
                {
                    case 0: // q0
                        if (char.IsLetter(ch) || ch == '_')
                        {
                            state = 1; // Move to q1
                        }
                        else
                        {
                            return false; // Invalid character
                        }
                        break;

                    case 1: // q1
                        if (char.IsLetterOrDigit(ch) || ch == '_')
                        {
                            state = 1; // Stay in q1
                        }
                        else
                        {
                            return false; // Invalid character
                        }
                        break;

                    default:
                        return false; // Should not reach here
                }
            }

            return state == 1; // Accept if in state q1
        }
    }
}
