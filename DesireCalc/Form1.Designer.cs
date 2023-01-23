namespace DesireCalc
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
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxHead = new System.Windows.Forms.ComboBox();
            this.comboBoxChest = new System.Windows.Forms.ComboBox();
            this.comboBoxArms = new System.Windows.Forms.ComboBox();
            this.comboBoxWaist = new System.Windows.Forms.ComboBox();
            this.comboBoxLegs = new System.Windows.Forms.ComboBox();
            this.labelArmorSet = new System.Windows.Forms.Label();
            this.comboBoxASet = new System.Windows.Forms.ComboBox();
            this.btnLoadSet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Location = new System.Drawing.Point(105, 33);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(41, 15);
            this.labelArmor.TabIndex = 0;
            this.labelArmor.Text = "Armor";
            this.labelArmor.Click += new System.EventHandler(this.labelArmor_Click);
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Location = new System.Drawing.Point(25, 54);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(35, 15);
            this.labelHead.TabIndex = 1;
            this.labelHead.Text = "Head";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Waist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Legs";
            // 
            // comboBoxHead
            // 
            this.comboBoxHead.FormattingEnabled = true;
            this.comboBoxHead.Location = new System.Drawing.Point(66, 51);
            this.comboBoxHead.Name = "comboBoxHead";
            this.comboBoxHead.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHead.TabIndex = 6;
            // 
            // comboBoxChest
            // 
            this.comboBoxChest.FormattingEnabled = true;
            this.comboBoxChest.Location = new System.Drawing.Point(66, 80);
            this.comboBoxChest.Name = "comboBoxChest";
            this.comboBoxChest.Size = new System.Drawing.Size(121, 23);
            this.comboBoxChest.TabIndex = 7;
            // 
            // comboBoxArms
            // 
            this.comboBoxArms.FormattingEnabled = true;
            this.comboBoxArms.Location = new System.Drawing.Point(66, 109);
            this.comboBoxArms.Name = "comboBoxArms";
            this.comboBoxArms.Size = new System.Drawing.Size(121, 23);
            this.comboBoxArms.TabIndex = 8;
            // 
            // comboBoxWaist
            // 
            this.comboBoxWaist.FormattingEnabled = true;
            this.comboBoxWaist.Location = new System.Drawing.Point(66, 138);
            this.comboBoxWaist.Name = "comboBoxWaist";
            this.comboBoxWaist.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWaist.TabIndex = 9;
            // 
            // comboBoxLegs
            // 
            this.comboBoxLegs.FormattingEnabled = true;
            this.comboBoxLegs.Location = new System.Drawing.Point(66, 167);
            this.comboBoxLegs.Name = "comboBoxLegs";
            this.comboBoxLegs.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLegs.TabIndex = 10;
            // 
            // labelArmorSet
            // 
            this.labelArmorSet.AutoSize = true;
            this.labelArmorSet.Location = new System.Drawing.Point(202, 33);
            this.labelArmorSet.Name = "labelArmorSet";
            this.labelArmorSet.Size = new System.Drawing.Size(23, 15);
            this.labelArmorSet.TabIndex = 11;
            this.labelArmorSet.Text = "Set";
            // 
            // comboBoxASet
            // 
            this.comboBoxASet.FormattingEnabled = true;
            this.comboBoxASet.Items.AddRange(new object[] {
            "Kamura",
            "Leather",
            "Chainmail",
            "Hunter",
            "Izuchi",
            "Baggi",
            "Vaik",
            "Lagombi",
            "Alloy",
            "Bone",
            "Chaos",
            "Shell-Studded",
            "Slagtoth",
            "Rhenoplos",
            "Droth",
            "Bnahabra",
            "Jaggi",
            "Kulu",
            "Wroggi",
            "Aknosom",
            "Ludroth",
            "Barroth",
            "Khezu",
            "Tetranadon",
            "Ingot",
            "Melahoa",
            "Death Stench",
            "Mosgharl",
            "Gargwa",
            "Bullfango",
            "Uroktor",
            "Remobra",
            "Jaggi Mask",
            "Volvidon",
            "Bishaten",
            "Pukei",
            "Basarios",
            "Kadachi",
            "Makluva",
            "Rhopessa",
            "Medium",
            "Channeler",
            "Sinister",
            "Anja",
            "Nargacuga",
            "Mizutsune",
            "Rathalos",
            "Zinorge",
            "Skull",
            "Goss Harag",
            "Almudron",
            "Tigrex",
            "Diablos",
            "Jelly",
            "Aelucanth",
            "Utushi Visible",
            "Utushi Hidden",
            "Spio",
            "Skalda",
            "Rathian",
            "Somnacanth",
            "Barioth",
            "Azuros",
            "Edel",
            "Brigade"});
            this.comboBoxASet.Location = new System.Drawing.Point(231, 30);
            this.comboBoxASet.Name = "comboBoxASet";
            this.comboBoxASet.Size = new System.Drawing.Size(121, 23);
            this.comboBoxASet.TabIndex = 12;
            // 
            // btnLoadSet
            // 
            this.btnLoadSet.Location = new System.Drawing.Point(358, 29);
            this.btnLoadSet.Name = "btnLoadSet";
            this.btnLoadSet.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSet.TabIndex = 13;
            this.btnLoadSet.Text = "Load";
            this.btnLoadSet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(256, 23);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadSet);
            this.Controls.Add(this.comboBoxASet);
            this.Controls.Add(this.labelArmorSet);
            this.Controls.Add(this.comboBoxLegs);
            this.Controls.Add(this.comboBoxWaist);
            this.Controls.Add(this.comboBoxArms);
            this.Controls.Add(this.comboBoxChest);
            this.Controls.Add(this.comboBoxHead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHead);
            this.Controls.Add(this.labelArmor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelArmor;
        private Label labelHead;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxHead;
        private ComboBox comboBoxChest;
        private ComboBox comboBoxArms;
        private ComboBox comboBoxWaist;
        private ComboBox comboBoxLegs;
        private Label labelArmorSet;
        private ComboBox comboBoxASet;
        private Button btnLoadSet;
        private TextBox textBox1;
    }
}