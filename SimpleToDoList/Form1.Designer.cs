namespace SimpleToDoList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRF = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.dtAdd = new System.Windows.Forms.DateTimePicker();
            this.cbImp = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleToDoList.Properties.Resources.png_mita;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(671, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(683, 19);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(31, 32);
            this.btnS.TabIndex = 3;
            this.btnS.Text = "🔍";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(21, 25);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(88, 80);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main List";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(21, 111);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(88, 76);
            this.btnImp.TabIndex = 5;
            this.btnImp.Text = "Important";
            this.btnImp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnS);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRF);
            this.groupBox2.Controls.Add(this.btnMain);
            this.groupBox2.Controls.Add(this.btnImp);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 414);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // txtRF
            // 
            this.txtRF.Location = new System.Drawing.Point(6, 385);
            this.txtRF.Name = "txtRF";
            this.txtRF.Size = new System.Drawing.Size(25, 23);
            this.txtRF.TabIndex = 6;
            this.txtRF.Text = "🔄";
            this.txtRF.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFix);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.cbImp);
            this.groupBox3.Controls.Add(this.dtAdd);
            this.groupBox3.Controls.Add(this.txtAdd);
            this.groupBox3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(134, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 91);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(6, 25);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(642, 26);
            this.txtAdd.TabIndex = 0;
            // 
            // dtAdd
            // 
            this.dtAdd.Location = new System.Drawing.Point(6, 57);
            this.dtAdd.Name = "dtAdd";
            this.dtAdd.Size = new System.Drawing.Size(244, 26);
            this.dtAdd.TabIndex = 1;
            // 
            // cbImp
            // 
            this.cbImp.AutoSize = true;
            this.cbImp.Location = new System.Drawing.Point(256, 57);
            this.cbImp.Name = "cbImp";
            this.cbImp.Size = new System.Drawing.Size(40, 20);
            this.cbImp.TabIndex = 2;
            this.cbImp.Text = " ★";
            this.cbImp.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(532, 57);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(55, 23);
            this.btnFix.TabIndex = 4;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(654, 317);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SimpleToDoList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txtRF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbImp;
        private System.Windows.Forms.DateTimePicker dtAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

