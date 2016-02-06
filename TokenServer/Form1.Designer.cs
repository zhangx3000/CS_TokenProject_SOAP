namespace TokenServer {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rbtnByBankNumber = new System.Windows.Forms.RadioButton();
            this.rbtnByToken = new System.Windows.Forms.RadioButton();
            this.lblServer = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            
            this.btnExport.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(12, 51);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            
            this.groupBox.Controls.Add(this.rbtnByToken);
            this.groupBox.Controls.Add(this.rbtnByBankNumber);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(185, 102);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Sorted By";
            
            this.rbtnByBankNumber.AutoSize = true;
            this.rbtnByBankNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByBankNumber.Location = new System.Drawing.Point(6, 19);
            this.rbtnByBankNumber.Name = "rbtnByBankNumber";
            this.rbtnByBankNumber.Size = new System.Drawing.Size(117, 22);
            this.rbtnByBankNumber.TabIndex = 0;
            this.rbtnByBankNumber.TabStop = true;
            this.rbtnByBankNumber.Text = "Bank Number";
            this.rbtnByBankNumber.UseVisualStyleBackColor = true;
            
            this.rbtnByToken.AutoSize = true;
            this.rbtnByToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByToken.Location = new System.Drawing.Point(6, 42);
            this.rbtnByToken.Name = "rbtnByToken";
            this.rbtnByToken.Size = new System.Drawing.Size(68, 22);
            this.rbtnByToken.TabIndex = 1;
            this.rbtnByToken.TabStop = true;
            this.rbtnByToken.Text = "Token";
            this.rbtnByToken.UseVisualStyleBackColor = true;
            
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(12, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(192, 20);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server is up and running...";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 191);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rbtnByToken;
        private System.Windows.Forms.RadioButton rbtnByBankNumber;
        private System.Windows.Forms.Label lblServer;
    }
}

