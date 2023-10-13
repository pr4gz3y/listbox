
namespace listbox
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
            this.ahalmaz = new System.Windows.Forms.ListBox();
            this.bhalmaz = new System.Windows.Forms.ListBox();
            this.aunio = new System.Windows.Forms.ListBox();
            this.ametszet = new System.Windows.Forms.ListBox();
            this.ab = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ba = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.feltolt = new System.Windows.Forms.Button();
            this.aszam = new System.Windows.Forms.NumericUpDown();
            this.bszam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.aszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bszam)).BeginInit();
            this.SuspendLayout();
            // 
            // ahalmaz
            // 
            this.ahalmaz.FormattingEnabled = true;
            this.ahalmaz.Location = new System.Drawing.Point(27, 52);
            this.ahalmaz.Name = "ahalmaz";
            this.ahalmaz.Size = new System.Drawing.Size(120, 238);
            this.ahalmaz.TabIndex = 0;
            this.ahalmaz.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bhalmaz
            // 
            this.bhalmaz.FormattingEnabled = true;
            this.bhalmaz.Location = new System.Drawing.Point(153, 52);
            this.bhalmaz.Name = "bhalmaz";
            this.bhalmaz.Size = new System.Drawing.Size(120, 238);
            this.bhalmaz.TabIndex = 1;
            // 
            // aunio
            // 
            this.aunio.FormattingEnabled = true;
            this.aunio.Location = new System.Drawing.Point(422, 52);
            this.aunio.Name = "aunio";
            this.aunio.Size = new System.Drawing.Size(120, 238);
            this.aunio.TabIndex = 3;
            // 
            // ametszet
            // 
            this.ametszet.FormattingEnabled = true;
            this.ametszet.Location = new System.Drawing.Point(550, 52);
            this.ametszet.Name = "ametszet";
            this.ametszet.Size = new System.Drawing.Size(120, 238);
            this.ametszet.TabIndex = 4;
            // 
            // ab
            // 
            this.ab.FormattingEnabled = true;
            this.ab.Location = new System.Drawing.Point(676, 52);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(120, 238);
            this.ab.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A halmaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "B halmaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "A unio B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "A metszet B";
            // 
            // ba
            // 
            this.ba.FormattingEnabled = true;
            this.ba.Location = new System.Drawing.Point(802, 52);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(120, 238);
            this.ba.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "A - B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "B - A";
            // 
            // feltolt
            // 
            this.feltolt.Location = new System.Drawing.Point(281, 335);
            this.feltolt.Name = "feltolt";
            this.feltolt.Size = new System.Drawing.Size(75, 23);
            this.feltolt.TabIndex = 15;
            this.feltolt.Text = "Feltölt";
            this.feltolt.UseVisualStyleBackColor = true;
            this.feltolt.Click += new System.EventHandler(this.feltolt_Click);
            // 
            // aszam
            // 
            this.aszam.Location = new System.Drawing.Point(27, 335);
            this.aszam.Name = "aszam";
            this.aszam.Size = new System.Drawing.Size(120, 20);
            this.aszam.TabIndex = 16;
            this.aszam.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // bszam
            // 
            this.bszam.Location = new System.Drawing.Point(154, 335);
            this.bszam.Name = "bszam";
            this.bszam.Size = new System.Drawing.Size(120, 20);
            this.bszam.TabIndex = 17;
            this.bszam.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.bszam);
            this.Controls.Add(this.aszam);
            this.Controls.Add(this.feltolt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ab);
            this.Controls.Add(this.ametszet);
            this.Controls.Add(this.aunio);
            this.Controls.Add(this.bhalmaz);
            this.Controls.Add(this.ahalmaz);
            this.Name = "Form1";
            this.Text = "Halmazok";
            ((System.ComponentModel.ISupportInitialize)(this.aszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ahalmaz;
        private System.Windows.Forms.ListBox bhalmaz;
        private System.Windows.Forms.ListBox aunio;
        private System.Windows.Forms.ListBox ametszet;
        private System.Windows.Forms.ListBox ab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button feltolt;
        private System.Windows.Forms.NumericUpDown aszam;
        private System.Windows.Forms.NumericUpDown bszam;
    }
}

