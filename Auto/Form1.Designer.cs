namespace Auto
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
            this.autokLeabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTorol = new System.Windows.Forms.Button();
            this.txtTorol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // autokLeabel
            // 
            this.autokLeabel.AutoSize = true;
            this.autokLeabel.Location = new System.Drawing.Point(29, 37);
            this.autokLeabel.Name = "autokLeabel";
            this.autokLeabel.Size = new System.Drawing.Size(68, 13);
            this.autokLeabel.TabIndex = 0;
            this.autokLeabel.Text = "Autok Listája";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // btTorol
            // 
            this.btTorol.Location = new System.Drawing.Point(564, 34);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(75, 23);
            this.btTorol.TabIndex = 2;
            this.btTorol.Text = "Törlés";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // txtTorol
            // 
            this.txtTorol.Location = new System.Drawing.Point(397, 37);
            this.txtTorol.Name = "txtTorol";
            this.txtTorol.Size = new System.Drawing.Size(146, 20);
            this.txtTorol.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adja meg a sort";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(113, 30);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(53, 23);
            this.btReset.TabIndex = 5;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 412);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTorol);
            this.Controls.Add(this.btTorol);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.autokLeabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autokLeabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTorol;
        private System.Windows.Forms.TextBox txtTorol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReset;
    }
}

