using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class javaCodeGenerator : Form
    {
        public javaCodeGenerator()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Get input from the form
            string condition = conditionTextBox.Text;
            string ifBlock = ifBlockTextBox.Text;
            string elseBlock = elseBlockTextBox.Text;

            // Generate Java code based on the grammar
            string javaCode = GenerateJavaIfElse(condition, ifBlock, elseBlock);

            // Display the generated Java code
            javaCodeTextBox.Text = javaCode;
        }

        private string GenerateJavaIfElse(string condition, string ifBlock, string elseBlock)
        {
            // Create the basic structure of an if-else statement in Java
            string javaCode = "if (" + condition + ") {\n";
            javaCode += "    " + ifBlock + "\n";
            javaCode += "} else {\n";
            javaCode += "    " + elseBlock + "\n";
            javaCode += "}\n";

            return javaCode;
        }

        private void JavaCodeGenerator_Load(object sender, EventArgs e)
        {
        }
    }
}
