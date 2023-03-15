namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.displayBtn_Click = new System.Windows.Forms.Button();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBtn_Click
            // 
            this.displayBtn_Click.Location = new System.Drawing.Point(123, 247);
            this.displayBtn_Click.Name = "displayBtn_Click";
            this.displayBtn_Click.Size = new System.Drawing.Size(108, 49);
            this.displayBtn_Click.TabIndex = 0;
            this.displayBtn_Click.Text = "Submit";
            this.displayBtn_Click.UseVisualStyleBackColor = true;
            this.displayBtn_Click.Click += new System.EventHandler(this.Submit_Click);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(95, 139);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(178, 20);
            this.firstNameInput.TabIndex = 1;
            this.firstNameInput.Text = "Enter First Name Here";
            this.firstNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(95, 172);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(95, 196);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(178, 20);
            this.lastNameInput.TabIndex = 3;
            this.lastNameInput.Text = "Enter Last Name Here";
            this.lastNameInput.TextChanged += new System.EventHandler(this.LastNameInput_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(95, 115);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Greetings Generator!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(123, 312);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 49);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 433);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.displayBtn_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayBtn_Click;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
    }
}

