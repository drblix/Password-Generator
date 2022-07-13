namespace PasswordGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.settingsLabel = new System.Windows.Forms.Label();
            this.includeUppercase = new System.Windows.Forms.CheckBox();
            this.includeLowercase = new System.Windows.Forms.CheckBox();
            this.includeNumbers = new System.Windows.Forms.CheckBox();
            this.includeSymbols = new System.Windows.Forms.CheckBox();
            this.passLengthBox = new System.Windows.Forms.ComboBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.Name = "settingsLabel";
            // 
            // includeUppercase
            // 
            resources.ApplyResources(this.includeUppercase, "includeUppercase");
            this.includeUppercase.Checked = true;
            this.includeUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeUppercase.Name = "includeUppercase";
            this.toolTip1.SetToolTip(this.includeUppercase, resources.GetString("includeUppercase.ToolTip"));
            this.includeUppercase.UseVisualStyleBackColor = true;
            // 
            // includeLowercase
            // 
            resources.ApplyResources(this.includeLowercase, "includeLowercase");
            this.includeLowercase.Checked = true;
            this.includeLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeLowercase.Name = "includeLowercase";
            this.toolTip1.SetToolTip(this.includeLowercase, resources.GetString("includeLowercase.ToolTip"));
            this.includeLowercase.UseVisualStyleBackColor = true;
            // 
            // includeNumbers
            // 
            resources.ApplyResources(this.includeNumbers, "includeNumbers");
            this.includeNumbers.Checked = true;
            this.includeNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeNumbers.Name = "includeNumbers";
            this.toolTip1.SetToolTip(this.includeNumbers, resources.GetString("includeNumbers.ToolTip"));
            this.includeNumbers.UseVisualStyleBackColor = true;
            // 
            // includeSymbols
            // 
            resources.ApplyResources(this.includeSymbols, "includeSymbols");
            this.includeSymbols.Checked = true;
            this.includeSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSymbols.Name = "includeSymbols";
            this.toolTip1.SetToolTip(this.includeSymbols, resources.GetString("includeSymbols.ToolTip"));
            this.includeSymbols.UseVisualStyleBackColor = true;
            // 
            // passLengthBox
            // 
            this.passLengthBox.FormattingEnabled = true;
            this.passLengthBox.Items.AddRange(new object[] {
            resources.GetString("passLengthBox.Items"),
            resources.GetString("passLengthBox.Items1"),
            resources.GetString("passLengthBox.Items2"),
            resources.GetString("passLengthBox.Items3"),
            resources.GetString("passLengthBox.Items4"),
            resources.GetString("passLengthBox.Items5"),
            resources.GetString("passLengthBox.Items6"),
            resources.GetString("passLengthBox.Items7"),
            resources.GetString("passLengthBox.Items8"),
            resources.GetString("passLengthBox.Items9"),
            resources.GetString("passLengthBox.Items10"),
            resources.GetString("passLengthBox.Items11"),
            resources.GetString("passLengthBox.Items12"),
            resources.GetString("passLengthBox.Items13"),
            resources.GetString("passLengthBox.Items14"),
            resources.GetString("passLengthBox.Items15"),
            resources.GetString("passLengthBox.Items16"),
            resources.GetString("passLengthBox.Items17"),
            resources.GetString("passLengthBox.Items18"),
            resources.GetString("passLengthBox.Items19"),
            resources.GetString("passLengthBox.Items20"),
            resources.GetString("passLengthBox.Items21"),
            resources.GetString("passLengthBox.Items22"),
            resources.GetString("passLengthBox.Items23"),
            resources.GetString("passLengthBox.Items24"),
            resources.GetString("passLengthBox.Items25"),
            resources.GetString("passLengthBox.Items26"),
            resources.GetString("passLengthBox.Items27"),
            resources.GetString("passLengthBox.Items28"),
            resources.GetString("passLengthBox.Items29"),
            resources.GetString("passLengthBox.Items30"),
            resources.GetString("passLengthBox.Items31"),
            resources.GetString("passLengthBox.Items32"),
            resources.GetString("passLengthBox.Items33"),
            resources.GetString("passLengthBox.Items34"),
            resources.GetString("passLengthBox.Items35"),
            resources.GetString("passLengthBox.Items36"),
            resources.GetString("passLengthBox.Items37"),
            resources.GetString("passLengthBox.Items38"),
            resources.GetString("passLengthBox.Items39"),
            resources.GetString("passLengthBox.Items40"),
            resources.GetString("passLengthBox.Items41"),
            resources.GetString("passLengthBox.Items42"),
            resources.GetString("passLengthBox.Items43"),
            resources.GetString("passLengthBox.Items44"),
            resources.GetString("passLengthBox.Items45"),
            resources.GetString("passLengthBox.Items46"),
            resources.GetString("passLengthBox.Items47"),
            resources.GetString("passLengthBox.Items48"),
            resources.GetString("passLengthBox.Items49")});
            resources.ApplyResources(this.passLengthBox, "passLengthBox");
            this.passLengthBox.Name = "passLengthBox";
            this.toolTip1.SetToolTip(this.passLengthBox, resources.GetString("passLengthBox.ToolTip"));
            // 
            // lengthLabel
            // 
            resources.ApplyResources(this.lengthLabel, "lengthLabel");
            this.lengthLabel.Name = "lengthLabel";
            // 
            // passBox
            // 
            resources.ApplyResources(this.passBox, "passBox");
            this.passBox.Name = "passBox";
            this.passBox.ReadOnly = true;
            this.passBox.TabStop = false;
            // 
            // generateBtn
            // 
            resources.ApplyResources(this.generateBtn, "generateBtn");
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // copyBtn
            // 
            resources.ApplyResources(this.copyBtn, "copyBtn");
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.passLengthBox);
            this.Controls.Add(this.includeSymbols);
            this.Controls.Add(this.includeNumbers);
            this.Controls.Add(this.includeLowercase);
            this.Controls.Add(this.includeUppercase);
            this.Controls.Add(this.settingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label settingsLabel;
        private CheckBox includeUppercase;
        private CheckBox includeLowercase;
        private CheckBox includeNumbers;
        private CheckBox includeSymbols;
        private ComboBox passLengthBox;
        private Label lengthLabel;
        private TextBox passBox;
        private Button generateBtn;
        private Button copyBtn;
        private ToolTip toolTip1;
    }
}