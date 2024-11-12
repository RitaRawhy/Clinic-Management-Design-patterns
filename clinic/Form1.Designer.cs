namespace clinic
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.koginbutton = new System.Windows.Forms.Button();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(316, 292);
            this.passtextBox.Multiline = true;
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(198, 40);
            this.passtextBox.TabIndex = 3;
            this.passtextBox.TextChanged += new System.EventHandler(this.passtextBox_TextChanged);
            // 
            // koginbutton
            // 
            this.koginbutton.BackColor = System.Drawing.Color.Turquoise;
            this.koginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.koginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koginbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.koginbutton.Location = new System.Drawing.Point(316, 378);
            this.koginbutton.Name = "koginbutton";
            this.koginbutton.Size = new System.Drawing.Size(198, 40);
            this.koginbutton.TabIndex = 2;
            this.koginbutton.Text = "Login";
            this.koginbutton.UseVisualStyleBackColor = false;
            this.koginbutton.Click += new System.EventHandler(this.koginbutton_Click);
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(316, 192);
            this.idtextbox.Multiline = true;
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(198, 40);
            this.idtextbox.TabIndex = 1;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::clinic.Properties.Resources._17f384a84a84dffbac4bcddcae743edb1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 584);
            this.Controls.Add(this.koginbutton);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button koginbutton;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passtextBox;
    }
}

