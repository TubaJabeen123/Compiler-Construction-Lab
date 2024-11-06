using System;
using System.Windows.Forms;

namespace GrammarParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim(); // Remove leading/trailing whitespace
            bool isValid = Parse(input);
            lblResult.Text = isValid ? "Valid String" : "Invalid String";
            txtInput.Text = "";
        }

        private bool Parse(string input)
        {
            // Starting from the non-terminal S
            return ParseS(ref input) && input.Length == 0; // Check if all input is consumed
        }

        private bool ParseS(ref string input)
        {
            // S -> A B
            string originalInput = input;

            if (ParseA(ref input) && ParseB(ref input))
            {
                return true;
            }

            // Reset input if not valid
            input = originalInput;
            return false;
        }

        private bool ParseA(ref string input)
        {
            // A -> a C
            if (input.Length > 0 && input[0] == 'a')
            {
                input = input.Substring(1); // consume 'a'
                return ParseC(ref input);
            }
            return false;
        }

        private bool ParseB(ref string input)
        {
            // B -> b
            if (input.Length > 0 && input[0] == 'b')
            {
                input = input.Substring(1); // consume 'b'
                return true;
            }
            return false;
        }

        private bool ParseC(ref string input)
        {
            // C -> c | d
            if (input.Length > 0 && (input[0] == 'c' || input[0] == 'd'))
            {
                input = input.Substring(1); // consume 'c' or 'd'
                return true;
            }
            return false;
        }
    }
}
