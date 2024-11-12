
namespace clinic
{
    partial class receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receptionist));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnametextBox = new System.Windows.Forms.TextBox();
            this.drnametextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.timetextBox = new System.Windows.Forms.TextBox();
            this.addpbutton = new System.Windows.Forms.Button();
            this.updatepbutton = new System.Windows.Forms.Button();
            this.deletepbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor";
            // 
            // pnametextBox
            // 
            this.pnametextBox.Location = new System.Drawing.Point(149, 15);
            this.pnametextBox.Name = "pnametextBox";
            this.pnametextBox.Size = new System.Drawing.Size(171, 22);
            this.pnametextBox.TabIndex = 4;
            this.pnametextBox.TextChanged += new System.EventHandler(this.pnametextBox_TextChanged);
            // 
            // drnametextBox
            // 
            this.drnametextBox.Location = new System.Drawing.Point(88, 112);
            this.drnametextBox.Name = "drnametextBox";
            this.drnametextBox.Size = new System.Drawing.Size(107, 22);
            this.drnametextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // timetextBox
            // 
            this.timetextBox.Location = new System.Drawing.Point(483, 73);
            this.timetextBox.Name = "timetextBox";
            this.timetextBox.Size = new System.Drawing.Size(107, 22);
            this.timetextBox.TabIndex = 8;
            // 
            // addpbutton
            // 
            this.addpbutton.Location = new System.Drawing.Point(12, 164);
            this.addpbutton.Name = "addpbutton";
            this.addpbutton.Size = new System.Drawing.Size(129, 32);
            this.addpbutton.TabIndex = 10;
            this.addpbutton.Text = "Add";
            this.addpbutton.UseVisualStyleBackColor = true;
            this.addpbutton.Click += new System.EventHandler(this.addpbutton_Click);
            // 
            // updatepbutton
            // 
            this.updatepbutton.Location = new System.Drawing.Point(191, 164);
            this.updatepbutton.Name = "updatepbutton";
            this.updatepbutton.Size = new System.Drawing.Size(129, 32);
            this.updatepbutton.TabIndex = 11;
            this.updatepbutton.Text = "Update";
            this.updatepbutton.UseVisualStyleBackColor = true;
            this.updatepbutton.Click += new System.EventHandler(this.updatepbutton_Click);
            // 
            // deletepbutton
            // 
            this.deletepbutton.Location = new System.Drawing.Point(399, 164);
            this.deletepbutton.Name = "deletepbutton";
            this.deletepbutton.Size = new System.Drawing.Size(129, 32);
            this.deletepbutton.TabIndex = 12;
            this.deletepbutton.Text = "Delete";
            this.deletepbutton.UseVisualStyleBackColor = true;
            this.deletepbutton.Click += new System.EventHandler(this.deletepbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type of reservation";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "consultation",
            "examination"});
            this.comboBox1.Location = new System.Drawing.Point(452, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::clinic.Properties.Resources.download__3_2;
            this.button1.Location = new System.Drawing.Point(867, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Logout";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "check :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 352);
            this.dataGridView1.TabIndex = 21;
            // 
            // receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinic.Properties.Resources.d2661e227ab9963b1cde9fa1c1599475;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletepbutton);
            this.Controls.Add(this.updatepbutton);
            this.Controls.Add(this.addpbutton);
            this.Controls.Add(this.timetextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.drnametextBox);
            this.Controls.Add(this.pnametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "receptionist";
            this.Text = "Appointments                                             ";
            this.Load += new System.EventHandler(this.receptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pnametextBox;
        private System.Windows.Forms.TextBox drnametextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timetextBox;
        private System.Windows.Forms.Button addpbutton;
        private System.Windows.Forms.Button updatepbutton;
        private System.Windows.Forms.Button deletepbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}