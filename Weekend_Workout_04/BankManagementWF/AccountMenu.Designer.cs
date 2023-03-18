namespace BankManagementWF
{
    partial class AccountMenu
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
            this.dgwDetail = new System.Windows.Forms.DataGridView();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.labelw = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.rdbTL = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbEuro2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbTL2 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clarendon Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Statement";
            // 
            // dgwDetail
            // 
            this.dgwDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDetail.Location = new System.Drawing.Point(17, 72);
            this.dgwDetail.Name = "dgwDetail";
            this.dgwDetail.Size = new System.Drawing.Size(771, 231);
            this.dgwDetail.TabIndex = 1;
            this.dgwDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDetail_CellClick);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(164, 347);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(150, 20);
            this.txtDeposit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-1, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deposit Amount : ";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.LightGreen;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeposit.Location = new System.Drawing.Point(201, 385);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Crimson;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWithdraw.Location = new System.Drawing.Point(641, 383);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // labelw
            // 
            this.labelw.AutoSize = true;
            this.labelw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelw.Location = new System.Drawing.Point(428, 342);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(169, 24);
            this.labelw.TabIndex = 6;
            this.labelw.Text = "Withdraw Amount :";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(603, 345);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(150, 20);
            this.txtWithdraw.TabIndex = 5;
            // 
            // rdbTL
            // 
            this.rdbTL.AutoSize = true;
            this.rdbTL.Location = new System.Drawing.Point(127, 372);
            this.rdbTL.Name = "rdbTL";
            this.rdbTL.Size = new System.Drawing.Size(31, 17);
            this.rdbTL.TabIndex = 8;
            this.rdbTL.TabStop = true;
            this.rdbTL.Text = "₺";
            this.rdbTL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type of Money";
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(127, 395);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(31, 17);
            this.rdbEuro.TabIndex = 10;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "€";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbEuro2
            // 
            this.rdbEuro2.AutoSize = true;
            this.rdbEuro2.Location = new System.Drawing.Point(563, 398);
            this.rdbEuro2.Name = "rdbEuro2";
            this.rdbEuro2.Size = new System.Drawing.Size(31, 17);
            this.rdbEuro2.TabIndex = 13;
            this.rdbEuro2.TabStop = true;
            this.rdbEuro2.Text = "€";
            this.rdbEuro2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type of Money";
            // 
            // rdbTL2
            // 
            this.rdbTL2.AutoSize = true;
            this.rdbTL2.Location = new System.Drawing.Point(563, 375);
            this.rdbTL2.Name = "rdbTL2";
            this.rdbTL2.Size = new System.Drawing.Size(31, 17);
            this.rdbTL2.TabIndex = 11;
            this.rdbTL2.TabStop = true;
            this.rdbTL2.Text = "₺";
            this.rdbTL2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Pink;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(719, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rdbEuro2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbTL2);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbTL);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.labelw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.dgwDetail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountMenu";
            this.Load += new System.EventHandler(this.AccountMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwDetail;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.RadioButton rdbTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbEuro2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbTL2;
        private System.Windows.Forms.Button btnExit;
    }
}