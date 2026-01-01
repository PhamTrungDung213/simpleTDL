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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbImp = new System.Windows.Forms.CheckBox();
            this.dtAdd = new System.Windows.Forms.DateTimePicker();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.dtSQL = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSQL)).BeginInit();
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
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(21, 25);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(88, 80);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main List";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(21, 111);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(88, 76);
            this.btnImp.TabIndex = 5;
            this.btnImp.Text = "Important";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnUp);
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
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(469, 57);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(69, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // dtAdd
            // 
            this.dtAdd.Location = new System.Drawing.Point(6, 57);
            this.dtAdd.Name = "dtAdd";
            this.dtAdd.Size = new System.Drawing.Size(244, 26);
            this.dtAdd.TabIndex = 1;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(6, 25);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(642, 26);
            this.txtAdd.TabIndex = 0;
            this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
            // 
            // dtSQL
            // 
            this.dtSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.note,
            this.dl,
            this.imp});
            this.dtSQL.Location = new System.Drawing.Point(134, 164);
            this.dtSQL.Name = "dtSQL";
            this.dtSQL.RowTemplate.Height = 28;
            this.dtSQL.Size = new System.Drawing.Size(654, 317);
            this.dtSQL.TabIndex = 9;
            this.dtSQL.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtSQL_CellMouseClick);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(544, 57);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(43, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "🗑";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "ToDo";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 430;
            // 
            // dl
            // 
            this.dl.DataPropertyName = "dl";
            this.dl.HeaderText = "Deadline";
            this.dl.Name = "dl";
            this.dl.ReadOnly = true;
            this.dl.Width = 150;
            // 
            // imp
            // 
            this.imp.DataPropertyName = "imp";
            this.imp.HeaderText = "★";
            this.imp.Name = "imp";
            this.imp.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.dtSQL);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSQL)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbImp;
        private System.Windows.Forms.DateTimePicker dtAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtSQL;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn dl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imp;
    }
}

