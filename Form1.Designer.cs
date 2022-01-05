
namespace Pendulum
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlb = new System.Windows.Forms.ComboBox();
            this.cbArt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richtxtbx = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.LinkLabel();
            this.addbnt = new System.Windows.Forms.Button();
            this.addurlbnt = new System.Windows.Forms.Button();
            this.editbnt = new System.Windows.Forms.Button();
            this.picbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(368, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // cbAlb
            // 
            this.cbAlb.FormattingEnabled = true;
            this.cbAlb.Location = new System.Drawing.Point(374, 64);
            this.cbAlb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbAlb.Name = "cbAlb";
            this.cbAlb.Size = new System.Drawing.Size(203, 33);
            this.cbAlb.TabIndex = 2;
            this.cbAlb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbArt
            // 
            this.cbArt.FormattingEnabled = true;
            this.cbArt.Location = new System.Drawing.Point(62, 64);
            this.cbArt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbArt.Name = "cbArt";
            this.cbArt.Size = new System.Drawing.Size(210, 33);
            this.cbArt.TabIndex = 3;
            this.cbArt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(59, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search in track\'s title";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.id});
            this.dgv.Location = new System.Drawing.Point(65, 255);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(512, 377);
            this.dgv.TabIndex = 6;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Length";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "URL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // richtxtbx
            // 
            this.richtxtbx.Location = new System.Drawing.Point(962, 64);
            this.richtxtbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richtxtbx.Name = "richtxtbx";
            this.richtxtbx.Size = new System.Drawing.Size(376, 234);
            this.richtxtbx.TabIndex = 9;
            this.richtxtbx.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "URL(if any):";
            // 
            // txtbx
            // 
            this.txtbx.Location = new System.Drawing.Point(65, 185);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(512, 30);
            this.txtbx.TabIndex = 11;
            this.txtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(784, 371);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 25);
            this.link.TabIndex = 14;
            // 
            // addbnt
            // 
            this.addbnt.Location = new System.Drawing.Point(631, 501);
            this.addbnt.Name = "addbnt";
            this.addbnt.Size = new System.Drawing.Size(170, 89);
            this.addbnt.TabIndex = 15;
            this.addbnt.Text = "Add Discography";
            this.addbnt.UseVisualStyleBackColor = true;
            // 
            // addurlbnt
            // 
            this.addurlbnt.Location = new System.Drawing.Point(897, 501);
            this.addurlbnt.Name = "addurlbnt";
            this.addurlbnt.Size = new System.Drawing.Size(173, 89);
            this.addurlbnt.TabIndex = 16;
            this.addurlbnt.Text = "Add URL";
            this.addurlbnt.UseVisualStyleBackColor = true;
            this.addurlbnt.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // editbnt
            // 
            this.editbnt.Location = new System.Drawing.Point(1170, 501);
            this.editbnt.Name = "editbnt";
            this.editbnt.Size = new System.Drawing.Size(168, 89);
            this.editbnt.TabIndex = 17;
            this.editbnt.Text = "Edit Selected";
            this.editbnt.UseVisualStyleBackColor = true;
            this.editbnt.Click += new System.EventHandler(this.editbnt_Click);
            // 
            // picbx
            // 
            this.picbx.Location = new System.Drawing.Point(631, 64);
            this.picbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picbx.Name = "picbx";
            this.picbx.Size = new System.Drawing.Size(262, 233);
            this.picbx.TabIndex = 8;
            this.picbx.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 652);
            this.Controls.Add(this.editbnt);
            this.Controls.Add(this.addurlbnt);
            this.Controls.Add(this.addbnt);
            this.Controls.Add(this.link);
            this.Controls.Add(this.txtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richtxtbx);
            this.Controls.Add(this.picbx);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbArt);
            this.Controls.Add(this.cbAlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Discography Tracker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlb;
        private System.Windows.Forms.ComboBox cbArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox picbx;
        private System.Windows.Forms.RichTextBox richtxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Button addbnt;
        private System.Windows.Forms.Button addurlbnt;
        private System.Windows.Forms.Button editbnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

