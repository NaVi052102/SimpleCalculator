namespace SimpleCalculator
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
            ButtonOne = new Button();
            TextBox = new TextBox();
            ButtonTwo = new Button();
            ButtonDivide = new Button();
            ButtonThree = new Button();
            ButtonClearEntry = new Button();
            ButtonClearAll = new Button();
            ButtonSix = new Button();
            ButtonMultiply = new Button();
            ButtonFive = new Button();
            ButtonFour = new Button();
            ButtonNine = new Button();
            ButtonMinus = new Button();
            ButtonEight = new Button();
            ButtonSeven = new Button();
            ButtonEquals = new Button();
            ButtonDecimal = new Button();
            ButtonAdd = new Button();
            ButtonZero = new Button();
            ButtonSign = new Button();
            SuspendLayout();
            // 
            // ButtonOne
            // 
            ButtonOne.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonOne.Location = new Point(10, 65);
            ButtonOne.Margin = new Padding(4, 3, 4, 3);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(62, 57);
            ButtonOne.TabIndex = 0;
            ButtonOne.Text = "1";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += Button_Click;
            // 
            // TextBox
            // 
            TextBox.BackColor = SystemColors.ActiveCaption;
            TextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox.Location = new Point(10, 14);
            TextBox.Margin = new Padding(4, 3, 4, 3);
            TextBox.Name = "TextBox";
            TextBox.ReadOnly = true;
            TextBox.Size = new Size(336, 33);
            TextBox.TabIndex = 1;
            TextBox.Text = "0";
            TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonTwo
            // 
            ButtonTwo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonTwo.Location = new Point(78, 65);
            ButtonTwo.Margin = new Padding(4, 3, 4, 3);
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.Size = new Size(62, 57);
            ButtonTwo.TabIndex = 2;
            ButtonTwo.Text = "2";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += Button_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.BackColor = Color.White;
            ButtonDivide.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonDivide.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDivide.Location = new Point(214, 65);
            ButtonDivide.Margin = new Padding(4, 3, 4, 3);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(62, 57);
            ButtonDivide.TabIndex = 3;
            ButtonDivide.Text = "/";
            ButtonDivide.UseVisualStyleBackColor = false;
            ButtonDivide.Click += Operator_Click;
            // 
            // ButtonThree
            // 
            ButtonThree.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonThree.Location = new Point(146, 65);
            ButtonThree.Margin = new Padding(4, 3, 4, 3);
            ButtonThree.Name = "ButtonThree";
            ButtonThree.Size = new Size(62, 57);
            ButtonThree.TabIndex = 4;
            ButtonThree.Text = "3";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += Button_Click;
            // 
            // ButtonClearEntry
            // 
            ButtonClearEntry.BackColor = SystemColors.ControlDarkDark;
            ButtonClearEntry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonClearEntry.Location = new Point(284, 65);
            ButtonClearEntry.Margin = new Padding(4, 3, 4, 3);
            ButtonClearEntry.Name = "ButtonClearEntry";
            ButtonClearEntry.Size = new Size(62, 57);
            ButtonClearEntry.TabIndex = 5;
            ButtonClearEntry.Text = "CE";
            ButtonClearEntry.UseVisualStyleBackColor = false;
            ButtonClearEntry.Click += ButtonClearEntry_Click;
            // 
            // ButtonClearAll
            // 
            ButtonClearAll.BackColor = SystemColors.ControlDarkDark;
            ButtonClearAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonClearAll.Location = new Point(284, 128);
            ButtonClearAll.Margin = new Padding(4, 3, 4, 3);
            ButtonClearAll.Name = "ButtonClearAll";
            ButtonClearAll.Size = new Size(62, 57);
            ButtonClearAll.TabIndex = 10;
            ButtonClearAll.Text = "C";
            ButtonClearAll.UseVisualStyleBackColor = false;
            ButtonClearAll.Click += ButtonClearAll_Click;
            // 
            // ButtonSix
            // 
            ButtonSix.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonSix.Location = new Point(146, 127);
            ButtonSix.Margin = new Padding(4, 3, 4, 3);
            ButtonSix.Name = "ButtonSix";
            ButtonSix.Size = new Size(62, 57);
            ButtonSix.TabIndex = 9;
            ButtonSix.Text = "6";
            ButtonSix.UseVisualStyleBackColor = true;
            ButtonSix.Click += Button_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.BackColor = Color.White;
            ButtonMultiply.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonMultiply.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonMultiply.Location = new Point(214, 128);
            ButtonMultiply.Margin = new Padding(4, 3, 4, 3);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(62, 57);
            ButtonMultiply.TabIndex = 8;
            ButtonMultiply.Text = "*";
            ButtonMultiply.UseVisualStyleBackColor = false;
            ButtonMultiply.Click += Operator_Click;
            // 
            // ButtonFive
            // 
            ButtonFive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonFive.Location = new Point(78, 127);
            ButtonFive.Margin = new Padding(4, 3, 4, 3);
            ButtonFive.Name = "ButtonFive";
            ButtonFive.Size = new Size(62, 57);
            ButtonFive.TabIndex = 7;
            ButtonFive.Text = "5";
            ButtonFive.UseVisualStyleBackColor = true;
            ButtonFive.Click += Button_Click;
            // 
            // ButtonFour
            // 
            ButtonFour.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonFour.Location = new Point(10, 128);
            ButtonFour.Margin = new Padding(4, 3, 4, 3);
            ButtonFour.Name = "ButtonFour";
            ButtonFour.Size = new Size(62, 57);
            ButtonFour.TabIndex = 6;
            ButtonFour.Text = "4";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += Button_Click;
            // 
            // ButtonNine
            // 
            ButtonNine.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonNine.Location = new Point(146, 190);
            ButtonNine.Margin = new Padding(4, 3, 4, 3);
            ButtonNine.Name = "ButtonNine";
            ButtonNine.Size = new Size(62, 57);
            ButtonNine.TabIndex = 14;
            ButtonNine.Text = "9";
            ButtonNine.UseVisualStyleBackColor = true;
            ButtonNine.Click += Button_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.BackColor = Color.White;
            ButtonMinus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonMinus.Location = new Point(214, 192);
            ButtonMinus.Margin = new Padding(4, 3, 4, 3);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(62, 57);
            ButtonMinus.TabIndex = 13;
            ButtonMinus.Text = "-";
            ButtonMinus.UseVisualStyleBackColor = false;
            ButtonMinus.Click += Operator_Click;
            // 
            // ButtonEight
            // 
            ButtonEight.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonEight.Location = new Point(78, 190);
            ButtonEight.Margin = new Padding(4, 3, 4, 3);
            ButtonEight.Name = "ButtonEight";
            ButtonEight.Size = new Size(62, 57);
            ButtonEight.TabIndex = 12;
            ButtonEight.Text = "8";
            ButtonEight.UseVisualStyleBackColor = true;
            ButtonEight.Click += Button_Click;
            // 
            // ButtonSeven
            // 
            ButtonSeven.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonSeven.Location = new Point(10, 192);
            ButtonSeven.Margin = new Padding(4, 3, 4, 3);
            ButtonSeven.Name = "ButtonSeven";
            ButtonSeven.Size = new Size(62, 57);
            ButtonSeven.TabIndex = 11;
            ButtonSeven.Text = "7";
            ButtonSeven.UseVisualStyleBackColor = true;
            ButtonSeven.Click += Button_Click;
            // 
            // ButtonEquals
            // 
            ButtonEquals.BackColor = Color.IndianRed;
            ButtonEquals.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonEquals.Location = new Point(284, 192);
            ButtonEquals.Margin = new Padding(4, 3, 4, 3);
            ButtonEquals.Name = "ButtonEquals";
            ButtonEquals.Size = new Size(62, 120);
            ButtonEquals.TabIndex = 20;
            ButtonEquals.Text = "=";
            ButtonEquals.UseVisualStyleBackColor = false;
            ButtonEquals.Click += ButtonEquals_Click;
            // 
            // ButtonDecimal
            // 
            ButtonDecimal.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDecimal.Location = new Point(80, 253);
            ButtonDecimal.Margin = new Padding(4, 3, 4, 3);
            ButtonDecimal.Name = "ButtonDecimal";
            ButtonDecimal.Size = new Size(62, 57);
            ButtonDecimal.TabIndex = 19;
            ButtonDecimal.Text = ".";
            ButtonDecimal.UseVisualStyleBackColor = true;
            ButtonDecimal.Click += Button_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.White;
            ButtonAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonAdd.Location = new Point(214, 255);
            ButtonAdd.Margin = new Padding(4, 3, 4, 3);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(62, 57);
            ButtonAdd.TabIndex = 18;
            ButtonAdd.Text = "+";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += Operator_Click;
            // 
            // ButtonZero
            // 
            ButtonZero.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ButtonZero.Location = new Point(10, 255);
            ButtonZero.Margin = new Padding(4, 3, 4, 3);
            ButtonZero.Name = "ButtonZero";
            ButtonZero.Size = new Size(62, 57);
            ButtonZero.TabIndex = 16;
            ButtonZero.Text = "0";
            ButtonZero.UseVisualStyleBackColor = true;
            ButtonZero.Click += Button_Click;
            // 
            // ButtonSign
            // 
            ButtonSign.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSign.Location = new Point(146, 253);
            ButtonSign.Name = "ButtonSign";
            ButtonSign.Size = new Size(61, 57);
            ButtonSign.TabIndex = 21;
            ButtonSign.Text = "+/-";
            ButtonSign.UseVisualStyleBackColor = true;
            ButtonSign.Click += ButtonSign_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(358, 322);
            Controls.Add(ButtonSign);
            Controls.Add(ButtonEquals);
            Controls.Add(ButtonDecimal);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonZero);
            Controls.Add(ButtonNine);
            Controls.Add(ButtonMinus);
            Controls.Add(ButtonEight);
            Controls.Add(ButtonSeven);
            Controls.Add(ButtonClearAll);
            Controls.Add(ButtonSix);
            Controls.Add(ButtonMultiply);
            Controls.Add(ButtonFive);
            Controls.Add(ButtonFour);
            Controls.Add(ButtonClearEntry);
            Controls.Add(ButtonThree);
            Controls.Add(ButtonDivide);
            Controls.Add(ButtonTwo);
            Controls.Add(TextBox);
            Controls.Add(ButtonOne);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonOne;
        private TextBox TextBox;
        private Button ButtonTwo;
        private Button ButtonDivide;
        private Button ButtonThree;
        private Button ButtonClearEntry;
        private Button ButtonClearAll;
        private Button ButtonSix;
        private Button ButtonMultiply;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonNine;
        private Button ButtonMinus;
        private Button ButtonEight;
        private Button ButtonSeven;
        private Button ButtonEquals;
        private Button ButtonDecimal;
        private Button ButtonAdd;
        private Button ButtonZero;
        private Button ButtonSign;
    }
}
