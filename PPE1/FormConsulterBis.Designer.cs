namespace PPE1
{
    partial class FormConsulterBis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonIntervetion = new System.Windows.Forms.RadioButton();
            this.radioButtonMateriel = new System.Windows.Forms.RadioButton();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonIntervetion);
            this.panel1.Controls.Add(this.radioButtonMateriel);
            this.panel1.Controls.Add(this.radioButtonClient);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 101);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonIntervetion
            // 
            this.radioButtonIntervetion.AutoSize = true;
            this.radioButtonIntervetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIntervetion.Location = new System.Drawing.Point(9, 6);
            this.radioButtonIntervetion.Name = "radioButtonIntervetion";
            this.radioButtonIntervetion.Size = new System.Drawing.Size(123, 24);
            this.radioButtonIntervetion.TabIndex = 0;
            this.radioButtonIntervetion.TabStop = true;
            this.radioButtonIntervetion.Text = "Intervention";
            this.radioButtonIntervetion.UseVisualStyleBackColor = true;
            this.radioButtonIntervetion.CheckedChanged += new System.EventHandler(this.radioButtonIntervetion_CheckedChanged);
            // 
            // radioButtonMateriel
            // 
            this.radioButtonMateriel.AutoSize = true;
            this.radioButtonMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMateriel.Location = new System.Drawing.Point(9, 52);
            this.radioButtonMateriel.Name = "radioButtonMateriel";
            this.radioButtonMateriel.Size = new System.Drawing.Size(91, 24);
            this.radioButtonMateriel.TabIndex = 2;
            this.radioButtonMateriel.TabStop = true;
            this.radioButtonMateriel.Text = "Materiel";
            this.radioButtonMateriel.UseVisualStyleBackColor = true;
            this.radioButtonMateriel.CheckedChanged += new System.EventHandler(this.radioButtonMateriel_CheckedChanged);
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonClient.Location = new System.Drawing.Point(9, 29);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(73, 24);
            this.radioButtonClient.TabIndex = 1;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulter";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(30, 199);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // FormConsulterBis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 244);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsulterBis";
            this.Text = "FormConsulterBis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonIntervetion;
        private System.Windows.Forms.RadioButton radioButtonMateriel;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonOK;
    }
}