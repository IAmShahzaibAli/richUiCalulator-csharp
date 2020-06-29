namespace Calcuator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.MainTextBox2 = new System.Windows.Forms.TextBox();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.UnderRootButton = new System.Windows.Forms.Button();
            this.XSquareButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTextBox2
            // 
            this.MainTextBox2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.MainTextBox2.Location = new System.Drawing.Point(0, 0);
            this.MainTextBox2.Multiline = true;
            this.MainTextBox2.Name = "MainTextBox2";
            this.MainTextBox2.Size = new System.Drawing.Size(334, 122);
            this.MainTextBox2.TabIndex = 3;
            this.MainTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainTextBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CEButton
            // 
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CEButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.ForeColor = System.Drawing.Color.White;
            this.CEButton.Location = new System.Drawing.Point(0, 128);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(121, 50);
            this.CEButton.TabIndex = 5;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CButton.Location = new System.Drawing.Point(127, 128);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(115, 50);
            this.CButton.TabIndex = 6;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DivideButton.Location = new System.Drawing.Point(243, 179);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(80, 50);
            this.DivideButton.TabIndex = 11;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // UnderRootButton
            // 
            this.UnderRootButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderRootButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderRootButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnderRootButton.Location = new System.Drawing.Point(127, 179);
            this.UnderRootButton.Name = "UnderRootButton";
            this.UnderRootButton.Size = new System.Drawing.Size(115, 50);
            this.UnderRootButton.TabIndex = 10;
            this.UnderRootButton.Text = "√ ";
            this.UnderRootButton.UseVisualStyleBackColor = true;
            this.UnderRootButton.Click += new System.EventHandler(this.UnderRootButton_Click);
            // 
            // XSquareButton
            // 
            this.XSquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XSquareButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XSquareButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XSquareButton.Location = new System.Drawing.Point(0, 179);
            this.XSquareButton.Name = "XSquareButton";
            this.XSquareButton.Size = new System.Drawing.Size(121, 50);
            this.XSquareButton.TabIndex = 9;
            this.XSquareButton.Text = "x²";
            this.XSquareButton.UseVisualStyleBackColor = true;
            this.XSquareButton.Click += new System.EventHandler(this.XSquareButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MultiplyButton.Location = new System.Drawing.Point(243, 230);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(80, 50);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.SystemColors.Window;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NineButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(162, 230);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(80, 50);
            this.NineButton.TabIndex = 14;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.SystemColors.Window;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EightButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(81, 230);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(80, 50);
            this.EightButton.TabIndex = 13;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.SystemColors.Window;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(0, 230);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(80, 50);
            this.SevenButton.TabIndex = 12;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(243, 281);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 50);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.SystemColors.Window;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SixButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(162, 280);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(80, 50);
            this.SixButton.TabIndex = 18;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.SystemColors.Window;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(81, 280);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(80, 50);
            this.FiveButton.TabIndex = 17;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.SystemColors.Window;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FourButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(0, 280);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(80, 50);
            this.FourButton.TabIndex = 16;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SubtractButton.Location = new System.Drawing.Point(243, 330);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(80, 50);
            this.SubtractButton.TabIndex = 23;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.SystemColors.Window;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(162, 330);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(80, 50);
            this.ThreeButton.TabIndex = 22;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.SystemColors.Window;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(81, 330);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(80, 50);
            this.TwoButton.TabIndex = 21;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.SystemColors.Window;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OneButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(0, 330);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(80, 50);
            this.OneButton.TabIndex = 20;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.SystemColors.Window;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(0, 380);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(242, 50);
            this.ZeroButton.TabIndex = 25;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Window;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Image = global::Calcuator.Properties.Resources.four;
            this.DeleteButton.Location = new System.Drawing.Point(243, 121);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 57);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.DarkOrange;
            this.EqualButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EqualButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.ForeColor = System.Drawing.Color.Snow;
            this.EqualButton.Location = new System.Drawing.Point(243, 380);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(80, 50);
            this.EqualButton.TabIndex = 27;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(323, 432);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.UnderRootButton);
            this.Controls.Add(this.XSquareButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.MainTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MainTextBox2;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button UnderRootButton;
        private System.Windows.Forms.Button XSquareButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button EqualButton;
    }
}

