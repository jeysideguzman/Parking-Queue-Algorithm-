namespace DSA_PROJ
{
    partial class ParkingQueueForm
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
            this.components = new System.ComponentModel.Container();
            this.Parkinglistt = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.next2 = new System.Windows.Forms.Button();
            this.btnref = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parkinglistt
            // 
            this.Parkinglistt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parkinglistt.HideSelection = false;
            this.Parkinglistt.Location = new System.Drawing.Point(97, 12);
            this.Parkinglistt.Name = "Parkinglistt";
            this.Parkinglistt.Size = new System.Drawing.Size(210, 469);
            this.Parkinglistt.TabIndex = 0;
            this.Parkinglistt.UseCompatibleStateImageBehavior = false;
            this.Parkinglistt.View = System.Windows.Forms.View.Tile;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBox1.Location = new System.Drawing.Point(28, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(44, 374);
            this.listBox1.TabIndex = 1;
            // 
            // next2
            // 
            this.next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2.Location = new System.Drawing.Point(433, 279);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(75, 32);
            this.next2.TabIndex = 3;
            this.next2.Text = "Leave";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // btnref
            // 
            this.btnref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnref.Location = new System.Drawing.Point(433, 142);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(75, 32);
            this.btnref.TabIndex = 4;
            this.btnref.Text = "Ref";
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "dequeue";
            // 
            // ParkingQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnref);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Parkinglistt);
            this.Name = "ParkingQueueForm";
            this.Text = "Algooo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Parkinglistt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}