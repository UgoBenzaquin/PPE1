namespace PPE1
{
    partial class FormClient
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
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxIntervention = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.Label();
            this.listBoxTypeMaterielle = new System.Windows.Forms.ListBox();
            this.listBoxSite = new System.Windows.Forms.ListBox();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.listBoxIDMaterielle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBoxIntervention);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Client);
            this.panel1.Controls.Add(this.listBoxTypeMaterielle);
            this.panel1.Controls.Add(this.listBoxSite);
            this.panel1.Controls.Add(this.listBoxClient);
            this.panel1.Controls.Add(this.listBoxIDMaterielle);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 341);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Intervention";
            // 
            // listBoxIntervention
            // 
            this.listBoxIntervention.FormattingEnabled = true;
            this.listBoxIntervention.Location = new System.Drawing.Point(611, 30);
            this.listBoxIntervention.Name = "listBoxIntervention";
            this.listBoxIntervention.Size = new System.Drawing.Size(142, 277);
            this.listBoxIntervention.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type de Materielle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Materielle";
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Location = new System.Drawing.Point(16, 14);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(33, 13);
            this.Client.TabIndex = 12;
            this.Client.Text = "Client";
            // 
            // listBoxTypeMaterielle
            // 
            this.listBoxTypeMaterielle.FormattingEnabled = true;
            this.listBoxTypeMaterielle.Location = new System.Drawing.Point(315, 30);
            this.listBoxTypeMaterielle.Name = "listBoxTypeMaterielle";
            this.listBoxTypeMaterielle.Size = new System.Drawing.Size(142, 277);
            this.listBoxTypeMaterielle.TabIndex = 11;
            // 
            // listBoxSite
            // 
            this.listBoxSite.FormattingEnabled = true;
            this.listBoxSite.Location = new System.Drawing.Point(167, 30);
            this.listBoxSite.Name = "listBoxSite";
            this.listBoxSite.Size = new System.Drawing.Size(142, 277);
            this.listBoxSite.TabIndex = 10;
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(19, 30);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(142, 277);
            this.listBoxClient.TabIndex = 9;
            // 
            // listBoxIDMaterielle
            // 
            this.listBoxIDMaterielle.FormattingEnabled = true;
            this.listBoxIDMaterielle.Location = new System.Drawing.Point(463, 30);
            this.listBoxIDMaterielle.Name = "listBoxIDMaterielle";
            this.listBoxIDMaterielle.Size = new System.Drawing.Size(142, 277);
            this.listBoxIDMaterielle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENT";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxIntervention;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.ListBox listBoxTypeMaterielle;
        private System.Windows.Forms.ListBox listBoxSite;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.ListBox listBoxIDMaterielle;
        private System.Windows.Forms.Label label1;
    }
}