namespace NameValuePairApp
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
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortValue = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSortName = new System.Windows.Forms.Label();
            this.lbSortValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(12, 44);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(359, 20);
            this.txtVal.TabIndex = 0;
            this.txtVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name/Value Pair";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(389, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(359, 225);
            this.listBox1.TabIndex = 3;
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(389, 83);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(109, 23);
            this.btnSortName.TabIndex = 4;
            this.btnSortName.Text = "Sort by &Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortValue
            // 
            this.btnSortValue.Location = new System.Drawing.Point(389, 112);
            this.btnSortValue.Name = "btnSortValue";
            this.btnSortValue.Size = new System.Drawing.Size(109, 23);
            this.btnSortValue.TabIndex = 5;
            this.btnSortValue.Text = "Sort by &Value";
            this.btnSortValue.UseVisualStyleBackColor = true;
            this.btnSortValue.Click += new System.EventHandler(this.btnSortValue_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(389, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(389, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save as XML";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(389, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbSortName
            // 
            this.lbSortName.AutoSize = true;
            this.lbSortName.Location = new System.Drawing.Point(505, 92);
            this.lbSortName.Name = "lbSortName";
            this.lbSortName.Size = new System.Drawing.Size(0, 13);
            this.lbSortName.TabIndex = 9;
            // 
            // lbSortValue
            // 
            this.lbSortValue.AutoSize = true;
            this.lbSortValue.Location = new System.Drawing.Point(504, 122);
            this.lbSortValue.Name = "lbSortValue";
            this.lbSortValue.Size = new System.Drawing.Size(0, 13);
            this.lbSortValue.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 319);
            this.Controls.Add(this.lbSortValue);
            this.Controls.Add(this.lbSortName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSortValue);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key-Value Pair Entry Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbSortName;
        private System.Windows.Forms.Label lbSortValue;
    }
}

