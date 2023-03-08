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
            this.tbxDeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxWithdraw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clarendon Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Özeti";
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
            // tbxDeposit
            // 
            this.tbxDeposit.Location = new System.Drawing.Point(110, 341);
            this.tbxDeposit.Name = "tbxDeposit";
            this.tbxDeposit.Size = new System.Drawing.Size(150, 20);
            this.tbxDeposit.TabIndex = 2;
            this.tbxDeposit.TextChanged += new System.EventHandler(this.tbxDeposit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deposit";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.LightGreen;
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeposit.Location = new System.Drawing.Point(185, 383);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Yatır";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Crimson;
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWithdraw.Location = new System.Drawing.Point(678, 383);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "Çek";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(509, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Withdraw";
            // 
            // tbxWithdraw
            // 
            this.tbxWithdraw.Location = new System.Drawing.Point(603, 341);
            this.tbxWithdraw.Name = "tbxWithdraw";
            this.tbxWithdraw.Size = new System.Drawing.Size(150, 20);
            this.tbxWithdraw.TabIndex = 5;
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeposit);
            this.Controls.Add(this.dgwDetail);
            this.Controls.Add(this.label1);
            this.Name = "AccountMenu";
            this.Text = "AccountMenu";
            this.Load += new System.EventHandler(this.AccountMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwDetail;
        private System.Windows.Forms.TextBox tbxDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxWithdraw;
    }
}