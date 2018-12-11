namespace PPE1
{
    partial class FormProgramerBis
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
            this.radioButtonSuprrimer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonADD = new System.Windows.Forms.RadioButton();
            this.radioButtonModifier = new System.Windows.Forms.RadioButton();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonSuprrimer
            // 
            this.radioButtonSuprrimer.AutoSize = true;
            this.radioButtonSuprrimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSuprrimer.Location = new System.Drawing.Point(9, 52);
            this.radioButtonSuprrimer.Name = "radioButtonSuprrimer";
            this.radioButtonSuprrimer.Size = new System.Drawing.Size(99, 24);
            this.radioButtonSuprrimer.TabIndex = 2;
            this.radioButtonSuprrimer.TabStop = true;
            this.radioButtonSuprrimer.Text = "Suprimer";
            this.radioButtonSuprrimer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonADD);
            this.panel1.Controls.Add(this.radioButtonSuprrimer);
            this.panel1.Controls.Add(this.radioButtonModifier);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 101);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonADD
            // 
            this.radioButtonADD.AutoSize = true;
            this.radioButtonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonADD.Location = new System.Drawing.Point(9, 6);
            this.radioButtonADD.Name = "radioButtonADD";
            this.radioButtonADD.Size = new System.Drawing.Size(85, 24);
            this.radioButtonADD.TabIndex = 0;
            this.radioButtonADD.TabStop = true;
            this.radioButtonADD.Text = "Ajouter";
            this.radioButtonADD.UseVisualStyleBackColor = true;
            // 
            // radioButtonModifier
            // 
            this.radioButtonModifier.AutoSize = true;
            this.radioButtonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonModifier.Location = new System.Drawing.Point(9, 29);
            this.radioButtonModifier.Name = "radioButtonModifier";
            this.radioButtonModifier.Size = new System.Drawing.Size(91, 24);
            this.radioButtonModifier.TabIndex = 1;
            this.radioButtonModifier.TabStop = true;
            this.radioButtonModifier.Text = "Modifier";
            this.radioButtonModifier.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(31, 196);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Programé";
            // 
            // FormProgramerBis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.panel1);
            this.Name = "FormProgramerBis";
            this.Text = "FormProgramerBis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSuprrimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonADD;
        private System.Windows.Forms.RadioButton radioButtonModifier;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label label1;
    }
}