namespace Calaculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            ClearButton = new Button();
            divine = new Button();
            multiply = new Button();
            Subtract = new Button();
            Plus = new Button();
            Equals = new Button();
            Nine = new Button();
            Eight = new Button();
            Seven = new Button();
            Six = new Button();
            Five = new Button();
            Four = new Button();
            Three = new Button();
            Two = new Button();
            One = new Button();
            Decimal = new Button();
            Zero = new Button();
            result = new TextBox();
            equation = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(247, 230, 244);
            ClearButton.BackgroundImageLayout = ImageLayout.None;
            ClearButton.FlatAppearance.BorderColor = Color.Black;
            ClearButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            ClearButton.FlatStyle = FlatStyle.Popup;
            ClearButton.ForeColor = Color.FromArgb(140, 117, 136);
            ClearButton.ImageAlign = ContentAlignment.BottomRight;
            ClearButton.Location = new Point(12, 127);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(288, 51);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += Clear;
            // 
            // divine
            // 
            divine.BackColor = Color.FromArgb(247, 230, 244);
            divine.FlatStyle = FlatStyle.Popup;
            divine.ForeColor = Color.FromArgb(140, 117, 136);
            divine.Location = new Point(306, 128);
            divine.Name = "divine";
            divine.Size = new Size(92, 51);
            divine.TabIndex = 4;
            divine.Text = "/";
            divine.UseVisualStyleBackColor = false;
            divine.Click += Button_Click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.FromArgb(247, 230, 244);
            multiply.FlatStyle = FlatStyle.Popup;
            multiply.ForeColor = Color.FromArgb(140, 117, 136);
            multiply.Location = new Point(306, 185);
            multiply.Name = "multiply";
            multiply.Size = new Size(92, 51);
            multiply.TabIndex = 5;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += Button_Click;
            // 
            // Subtract
            // 
            Subtract.BackColor = Color.FromArgb(247, 230, 244);
            Subtract.FlatStyle = FlatStyle.Popup;
            Subtract.ForeColor = Color.FromArgb(140, 117, 136);
            Subtract.Location = new Point(306, 242);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(92, 51);
            Subtract.TabIndex = 6;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += Button_Click;
            // 
            // Plus
            // 
            Plus.BackColor = Color.FromArgb(247, 230, 244);
            Plus.FlatStyle = FlatStyle.Popup;
            Plus.ForeColor = Color.FromArgb(140, 117, 136);
            Plus.Location = new Point(306, 299);
            Plus.Name = "Plus";
            Plus.Size = new Size(92, 51);
            Plus.TabIndex = 7;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = false;
            Plus.Click += Button_Click;
            // 
            // Equals
            // 
            Equals.BackColor = Color.FromArgb(247, 230, 244);
            Equals.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            Equals.FlatAppearance.BorderSize = 3;
            Equals.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            Equals.FlatAppearance.MouseOverBackColor = Color.Olive;
            Equals.FlatStyle = FlatStyle.Popup;
            Equals.ForeColor = Color.FromArgb(140, 117, 136);
            Equals.Location = new Point(306, 356);
            Equals.Name = "Equals";
            Equals.Size = new Size(92, 51);
            Equals.TabIndex = 8;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = false;
            Equals.Click += Equals_Click;
            // 
            // Nine
            // 
            Nine.BackColor = Color.FromArgb(247, 230, 244);
            Nine.FlatStyle = FlatStyle.Popup;
            Nine.ForeColor = Color.FromArgb(140, 117, 136);
            Nine.Location = new Point(208, 185);
            Nine.Name = "Nine";
            Nine.Size = new Size(92, 51);
            Nine.TabIndex = 9;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = false;
            Nine.Click += Button_Click;
            // 
            // Eight
            // 
            Eight.BackColor = Color.FromArgb(247, 230, 244);
            Eight.FlatStyle = FlatStyle.Popup;
            Eight.ForeColor = Color.FromArgb(140, 117, 136);
            Eight.Location = new Point(110, 185);
            Eight.Name = "Eight";
            Eight.Size = new Size(92, 51);
            Eight.TabIndex = 10;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += Button_Click;
            // 
            // Seven
            // 
            Seven.BackColor = Color.FromArgb(247, 230, 244);
            Seven.FlatStyle = FlatStyle.Popup;
            Seven.ForeColor = Color.FromArgb(140, 117, 136);
            Seven.Location = new Point(12, 185);
            Seven.Name = "Seven";
            Seven.Size = new Size(92, 51);
            Seven.TabIndex = 11;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += Button_Click;
            // 
            // Six
            // 
            Six.BackColor = Color.FromArgb(247, 230, 244);
            Six.FlatStyle = FlatStyle.Popup;
            Six.ForeColor = Color.FromArgb(140, 117, 136);
            Six.Location = new Point(208, 242);
            Six.Name = "Six";
            Six.Size = new Size(92, 51);
            Six.TabIndex = 12;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = false;
            Six.Click += Button_Click;
            // 
            // Five
            // 
            Five.BackColor = Color.FromArgb(247, 230, 244);
            Five.FlatStyle = FlatStyle.Popup;
            Five.ForeColor = Color.FromArgb(140, 117, 136);
            Five.Location = new Point(110, 242);
            Five.Name = "Five";
            Five.Size = new Size(92, 51);
            Five.TabIndex = 13;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = false;
            Five.Click += Button_Click;
            // 
            // Four
            // 
            Four.BackColor = Color.FromArgb(247, 230, 244);
            Four.FlatStyle = FlatStyle.Popup;
            Four.ForeColor = Color.FromArgb(140, 117, 136);
            Four.Location = new Point(12, 242);
            Four.Name = "Four";
            Four.Size = new Size(92, 51);
            Four.TabIndex = 14;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = false;
            Four.Click += Button_Click;
            // 
            // Three
            // 
            Three.BackColor = Color.FromArgb(247, 230, 244);
            Three.FlatStyle = FlatStyle.Popup;
            Three.ForeColor = Color.FromArgb(140, 117, 136);
            Three.Location = new Point(208, 299);
            Three.Name = "Three";
            Three.Size = new Size(92, 51);
            Three.TabIndex = 15;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = false;
            Three.Click += Button_Click;
            // 
            // Two
            // 
            Two.BackColor = Color.FromArgb(247, 230, 244);
            Two.FlatStyle = FlatStyle.Popup;
            Two.ForeColor = Color.FromArgb(140, 117, 136);
            Two.Location = new Point(110, 299);
            Two.Name = "Two";
            Two.Size = new Size(92, 51);
            Two.TabIndex = 16;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = false;
            Two.Click += Button_Click;
            // 
            // One
            // 
            One.BackColor = Color.FromArgb(247, 230, 244);
            One.FlatStyle = FlatStyle.Popup;
            One.ForeColor = Color.FromArgb(140, 117, 136);
            One.Location = new Point(12, 299);
            One.Name = "One";
            One.Size = new Size(92, 51);
            One.TabIndex = 17;
            One.Text = "1";
            One.UseVisualStyleBackColor = false;
            One.Click += Button_Click;
            // 
            // Decimal
            // 
            Decimal.BackColor = Color.FromArgb(247, 230, 244);
            Decimal.FlatStyle = FlatStyle.Popup;
            Decimal.ForeColor = Color.FromArgb(140, 117, 136);
            Decimal.Location = new Point(208, 356);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(92, 51);
            Decimal.TabIndex = 18;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = false;
            Decimal.Click += Button_Click;
            // 
            // Zero
            // 
            Zero.BackColor = Color.FromArgb(247, 230, 244);
            Zero.FlatStyle = FlatStyle.Popup;
            Zero.ForeColor = Color.FromArgb(140, 117, 136);
            Zero.Location = new Point(12, 356);
            Zero.Name = "Zero";
            Zero.Size = new Size(190, 51);
            Zero.TabIndex = 19;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = false;
            Zero.Click += Button_Click;
            // 
            // result
            // 
            result.BackColor = Color.White;
            result.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            result.ForeColor = Color.FromArgb(140, 117, 136);
            result.Location = new Point(12, 65);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(386, 57);
            result.TabIndex = 20;
            result.Text = "0";
            result.TextAlign = HorizontalAlignment.Right;
            // 
            // equation
            // 
            equation.FlatStyle = FlatStyle.Popup;
            equation.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            equation.ForeColor = Color.FromArgb(201, 183, 198);
            equation.Location = new Point(12, 9);
            equation.Name = "equation";
            equation.Size = new Size(386, 37);
            equation.TabIndex = 21;
            equation.TextAlign = ContentAlignment.TopRight;
            // 
            // Calaculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(252, 242, 250);
            ClientSize = new Size(412, 418);
            Controls.Add(equation);
            Controls.Add(result);
            Controls.Add(Zero);
            Controls.Add(Decimal);
            Controls.Add(One);
            Controls.Add(Two);
            Controls.Add(Three);
            Controls.Add(Four);
            Controls.Add(Five);
            Controls.Add(Six);
            Controls.Add(Seven);
            Controls.Add(Eight);
            Controls.Add(Nine);
            Controls.Add(Equals);
            Controls.Add(Plus);
            Controls.Add(Subtract);
            Controls.Add(multiply);
            Controls.Add(divine);
            Controls.Add(ClearButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Calaculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calaculator";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button divine;
        private Button multiply;
        private Button Subtract;
        private Button Plus;
        private Button Equals;
        private Button Nine;
        private Button Eight;
        private Button Seven;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button Three;
        private Button Two;
        private Button One;
        private Button Decimal;
        private Button Zero;
        private TextBox result;
        private Label equation;
    }
}