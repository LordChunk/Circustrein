namespace Circustrein
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
            this.tbDierNaam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPlanteneter = new System.Windows.Forms.RadioButton();
            this.rbVleesEter = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbGroot = new System.Windows.Forms.RadioButton();
            this.rbMiddel = new System.Windows.Forms.RadioButton();
            this.rbKlein = new System.Windows.Forms.RadioButton();
            this.lbDierenLijst = new System.Windows.Forms.ListBox();
            this.btAddDier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.lbTrein = new System.Windows.Forms.ListBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDierNaam
            // 
            this.tbDierNaam.Location = new System.Drawing.Point(12, 12);
            this.tbDierNaam.Name = "tbDierNaam";
            this.tbDierNaam.Size = new System.Drawing.Size(100, 20);
            this.tbDierNaam.TabIndex = 0;
            this.tbDierNaam.Text = "Naam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPlanteneter);
            this.groupBox1.Controls.Add(this.rbVleesEter);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diersoort";
            // 
            // rbPlanteneter
            // 
            this.rbPlanteneter.AutoSize = true;
            this.rbPlanteneter.Location = new System.Drawing.Point(6, 42);
            this.rbPlanteneter.Name = "rbPlanteneter";
            this.rbPlanteneter.Size = new System.Drawing.Size(79, 17);
            this.rbPlanteneter.TabIndex = 1;
            this.rbPlanteneter.Text = "Planteneter";
            this.rbPlanteneter.UseVisualStyleBackColor = true;
            // 
            // rbVleesEter
            // 
            this.rbVleesEter.AutoSize = true;
            this.rbVleesEter.Checked = true;
            this.rbVleesEter.Location = new System.Drawing.Point(6, 19);
            this.rbVleesEter.Name = "rbVleesEter";
            this.rbVleesEter.Size = new System.Drawing.Size(69, 17);
            this.rbVleesEter.TabIndex = 0;
            this.rbVleesEter.TabStop = true;
            this.rbVleesEter.Text = "Vleeseter";
            this.rbVleesEter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbGroot);
            this.groupBox2.Controls.Add(this.rbMiddel);
            this.groupBox2.Controls.Add(this.rbKlein);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grootte";
            // 
            // rbGroot
            // 
            this.rbGroot.AutoSize = true;
            this.rbGroot.Location = new System.Drawing.Point(6, 65);
            this.rbGroot.Name = "rbGroot";
            this.rbGroot.Size = new System.Drawing.Size(51, 17);
            this.rbGroot.TabIndex = 2;
            this.rbGroot.Text = "Groot";
            this.rbGroot.UseVisualStyleBackColor = true;
            // 
            // rbMiddel
            // 
            this.rbMiddel.AutoSize = true;
            this.rbMiddel.Location = new System.Drawing.Point(6, 42);
            this.rbMiddel.Name = "rbMiddel";
            this.rbMiddel.Size = new System.Drawing.Size(80, 17);
            this.rbMiddel.TabIndex = 1;
            this.rbMiddel.Text = "Middelgroot";
            this.rbMiddel.UseVisualStyleBackColor = true;
            // 
            // rbKlein
            // 
            this.rbKlein.AutoSize = true;
            this.rbKlein.Checked = true;
            this.rbKlein.Location = new System.Drawing.Point(6, 19);
            this.rbKlein.Name = "rbKlein";
            this.rbKlein.Size = new System.Drawing.Size(48, 17);
            this.rbKlein.TabIndex = 0;
            this.rbKlein.TabStop = true;
            this.rbKlein.Text = "Klein";
            this.rbKlein.UseVisualStyleBackColor = true;
            // 
            // lbDierenLijst
            // 
            this.lbDierenLijst.FormattingEnabled = true;
            this.lbDierenLijst.Location = new System.Drawing.Point(138, 12);
            this.lbDierenLijst.Name = "lbDierenLijst";
            this.lbDierenLijst.Size = new System.Drawing.Size(147, 433);
            this.lbDierenLijst.TabIndex = 3;
            this.lbDierenLijst.SelectedIndexChanged += new System.EventHandler(this.LbDierenLijst_SelectedIndexChanged);
            // 
            // btAddDier
            // 
            this.btAddDier.Location = new System.Drawing.Point(12, 214);
            this.btAddDier.Name = "btAddDier";
            this.btAddDier.Size = new System.Drawing.Size(100, 23);
            this.btAddDier.TabIndex = 4;
            this.btAddDier.Text = "Voeg dier toe";
            this.btAddDier.UseVisualStyleBackColor = true;
            this.btAddDier.Click += new System.EventHandler(this.BtAddDier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geselecteerd dier:";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(15, 253);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(0, 13);
            this.labelSelected.TabIndex = 6;
            // 
            // lbWagon
            // 
            this.lbWagon.FormattingEnabled = true;
            this.lbWagon.Location = new System.Drawing.Point(291, 12);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(156, 433);
            this.lbWagon.TabIndex = 7;
            this.lbWagon.SelectedIndexChanged += new System.EventHandler(this.LbWagon_SelectedIndexChanged);
            // 
            // lbTrein
            // 
            this.lbTrein.FormattingEnabled = true;
            this.lbTrein.Location = new System.Drawing.Point(453, 12);
            this.lbTrein.Name = "lbTrein";
            this.lbTrein.Size = new System.Drawing.Size(156, 433);
            this.lbTrein.TabIndex = 8;
            this.lbTrein.SelectedIndexChanged += new System.EventHandler(this.LbTrein_SelectedIndexChanged);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(12, 415);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(100, 23);
            this.btConfirm.TabIndex = 9;
            this.btConfirm.Text = "Loco- locomotief";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.BtConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbTrein);
            this.Controls.Add(this.lbWagon);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddDier);
            this.Controls.Add(this.lbDierenLijst);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDierNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDierNaam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPlanteneter;
        private System.Windows.Forms.RadioButton rbVleesEter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbGroot;
        private System.Windows.Forms.RadioButton rbMiddel;
        private System.Windows.Forms.RadioButton rbKlein;
        private System.Windows.Forms.ListBox lbDierenLijst;
        private System.Windows.Forms.Button btAddDier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.ListBox lbWagon;
        private System.Windows.Forms.ListBox lbTrein;
        private System.Windows.Forms.Button btConfirm;
    }
}

