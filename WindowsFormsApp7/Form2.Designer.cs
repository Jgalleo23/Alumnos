
namespace WindowsFormsApp7
{
    partial class Form
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbDirection = new System.Windows.Forms.Label();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(178, 109);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 22);
            this.txtID.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(96, 114);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 17);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(96, 156);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(178, 153);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(162, 22);
            this.txtUser.TabIndex = 2;
            // 
            // lbDirection
            // 
            this.lbDirection.AutoSize = true;
            this.lbDirection.Location = new System.Drawing.Point(96, 252);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(57, 17);
            this.lbDirection.TabIndex = 7;
            this.lbDirection.Text = "Quarter";
            // 
            // txtQuarter
            // 
            this.txtQuarter.Location = new System.Drawing.Point(178, 247);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.Size = new System.Drawing.Size(162, 22);
            this.txtQuarter.TabIndex = 6;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(96, 208);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(65, 17);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(178, 203);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(162, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(217, 338);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 8;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(217, 381);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(178, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quarter";
            this.label1.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbDirection);
            this.Controls.Add(this.txtQuarter);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtID);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Label lbDirection;
        public System.Windows.Forms.TextBox txtQuarter;
        public System.Windows.Forms.Label lbPhone;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.Button btOK;
        public System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
    }
}