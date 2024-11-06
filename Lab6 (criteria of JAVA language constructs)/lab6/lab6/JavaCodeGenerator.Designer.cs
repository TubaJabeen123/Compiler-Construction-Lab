namespace lab6
{
    partial class javaCodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.elseBlockTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.ifBlockTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.javaCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(238, 35);
            this.conditionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(175, 39);
            this.conditionTextBox.TabIndex = 0;
            // 
            // elseBlockTextBox
            // 
            this.elseBlockTextBox.Location = new System.Drawing.Point(238, 201);
            this.elseBlockTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.elseBlockTextBox.Name = "elseBlockTextBox";
            this.elseBlockTextBox.Size = new System.Drawing.Size(175, 39);
            this.elseBlockTextBox.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(100, 295);
            this.generateButton.Margin = new System.Windows.Forms.Padding(5);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(252, 37);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Check Code";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // ifBlockTextBox
            // 
            this.ifBlockTextBox.Location = new System.Drawing.Point(238, 112);
            this.ifBlockTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ifBlockTextBox.Name = "ifBlockTextBox";
            this.ifBlockTextBox.Size = new System.Drawing.Size(175, 39);
            this.ifBlockTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "If Block";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "else Block";
            // 
            // javaCodeTextBox
            // 
            this.javaCodeTextBox.Location = new System.Drawing.Point(60, 377);
            this.javaCodeTextBox.Name = "javaCodeTextBox";
            this.javaCodeTextBox.Size = new System.Drawing.Size(353, 39);
            this.javaCodeTextBox.TabIndex = 8;
            // 
            // javaCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 512);
            this.Controls.Add(this.javaCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ifBlockTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.elseBlockTextBox);
            this.Controls.Add(this.conditionTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "javaCodeGenerator";
            this.Text = "JavaCodeGenerator";
            this.Load += new System.EventHandler(this.JavaCodeGenerator_Load);
            this.Click += new System.EventHandler(this.JavaCodeGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox elseBlockTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox ifBlockTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox javaCodeTextBox;
    }
}