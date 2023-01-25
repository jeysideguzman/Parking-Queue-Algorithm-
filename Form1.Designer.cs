namespace DSA_PROJ
{
    partial class parkingsystemform
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
            this.next1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkr = new System.Windows.Forms.Button();
            this.arrivalbtn = new System.Windows.Forms.Button();
            this.departurebtn = new System.Windows.Forms.Button();
            this.generatepn = new System.Windows.Forms.Button();
            this.lblplateno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next1
            // 
            this.next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next1.Location = new System.Drawing.Point(416, 452);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(75, 32);
            this.next1.TabIndex = 1;
            this.next1.Text = "Next";
            this.next1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(234, 230);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(214, 44);
            this.tb1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plate No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parking System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date:";
            // 
            // checkr
            // 
            this.checkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkr.Location = new System.Drawing.Point(55, 452);
            this.checkr.Name = "checkr";
            this.checkr.Size = new System.Drawing.Size(123, 32);
            this.checkr.TabIndex = 10;
            this.checkr.Text = "Check Record";
            this.checkr.UseVisualStyleBackColor = true;
            // 
            // arrivalbtn
            // 
            this.arrivalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalbtn.Location = new System.Drawing.Point(192, 327);
            this.arrivalbtn.Name = "arrivalbtn";
            this.arrivalbtn.Size = new System.Drawing.Size(75, 32);
            this.arrivalbtn.TabIndex = 11;
            this.arrivalbtn.Text = "Arrival";
            this.arrivalbtn.UseVisualStyleBackColor = true;
            // 
            // departurebtn
            // 
            this.departurebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departurebtn.Location = new System.Drawing.Point(291, 327);
            this.departurebtn.Name = "departurebtn";
            this.departurebtn.Size = new System.Drawing.Size(92, 32);
            this.departurebtn.TabIndex = 12;
            this.departurebtn.Text = "Departure";
            this.departurebtn.UseVisualStyleBackColor = true;
            // 
            // generatepn
            // 
            this.generatepn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatepn.Location = new System.Drawing.Point(2, 235);
            this.generatepn.Name = "generatepn";
            this.generatepn.Size = new System.Drawing.Size(205, 42);
            this.generatepn.TabIndex = 13;
            this.generatepn.Text = "Generate Plate Number";
            this.generatepn.UseVisualStyleBackColor = true;
            this.generatepn.Click += new System.EventHandler(this.generate_Click);
            // 
            // lblplateno
            // 
            this.lblplateno.AutoSize = true;
            this.lblplateno.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplateno.Location = new System.Drawing.Point(240, 191);
            this.lblplateno.Name = "lblplateno";
            this.lblplateno.Size = new System.Drawing.Size(138, 28);
            this.lblplateno.TabIndex = 14;
            this.lblplateno.Text = "                  ";
            // 
            // parkingsystemform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 522);
            this.Controls.Add(this.lblplateno);
            this.Controls.Add(this.generatepn);
            this.Controls.Add(this.departurebtn);
            this.Controls.Add(this.arrivalbtn);
            this.Controls.Add(this.checkr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.next1);
            this.Name = "parkingsystemform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Parking Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button next1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkr;
        private System.Windows.Forms.Button arrivalbtn;
        private System.Windows.Forms.Button departurebtn;
        private System.Windows.Forms.Button generatepn;
        private System.Windows.Forms.Label lblplateno;
    }
}

