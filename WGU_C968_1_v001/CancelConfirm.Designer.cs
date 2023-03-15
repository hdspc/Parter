namespace WGU_C968_1_v001
{
    partial class CancelConfirm
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
            this.lbl_CancelConfirm_BodyText = new System.Windows.Forms.Label();
            this.btn_CancelConfirm_Exit = new System.Windows.Forms.Button();
            this.btn_CancelConfirm_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lbl_CancelConfirm_BodyText
            // 
            this.lbl_CancelConfirm_BodyText.AutoSize = true;
            this.lbl_CancelConfirm_BodyText.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl_CancelConfirm_BodyText.Location = new System.Drawing.Point(117, 127);
            this.lbl_CancelConfirm_BodyText.Name = "lbl_CancelConfirm_BodyText";
            this.lbl_CancelConfirm_BodyText.Size = new System.Drawing.Size(567, 108);
            this.lbl_CancelConfirm_BodyText.TabIndex = 1;
            this.lbl_CancelConfirm_BodyText.Text = "Are you sure you\'d like to exit?\r\nYour changes won\'t be saved. ";
            this.lbl_CancelConfirm_BodyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CancelConfirm_Exit
            // 
            this.btn_CancelConfirm_Exit.Font = new System.Drawing.Font("Segoe UI", 12.875F);
            this.btn_CancelConfirm_Exit.Location = new System.Drawing.Point(160, 329);
            this.btn_CancelConfirm_Exit.Name = "btn_CancelConfirm_Exit";
            this.btn_CancelConfirm_Exit.Size = new System.Drawing.Size(144, 64);
            this.btn_CancelConfirm_Exit.TabIndex = 2;
            this.btn_CancelConfirm_Exit.Text = "Exit";
            this.btn_CancelConfirm_Exit.UseVisualStyleBackColor = true;
            this.btn_CancelConfirm_Exit.Click += new System.EventHandler(this.btn_CancelConfirm_Exit_Click);
            // 
            // btn_CancelConfirm_Cancel
            // 
            this.btn_CancelConfirm_Cancel.Font = new System.Drawing.Font("Segoe UI", 12.875F);
            this.btn_CancelConfirm_Cancel.Location = new System.Drawing.Point(487, 329);
            this.btn_CancelConfirm_Cancel.Name = "btn_CancelConfirm_Cancel";
            this.btn_CancelConfirm_Cancel.Size = new System.Drawing.Size(160, 64);
            this.btn_CancelConfirm_Cancel.TabIndex = 3;
            this.btn_CancelConfirm_Cancel.Text = "Cancel";
            this.btn_CancelConfirm_Cancel.UseVisualStyleBackColor = true;
            this.btn_CancelConfirm_Cancel.Click += new System.EventHandler(this.btn_CancelConfirm_Cancel_Click);
            // 
            // CancelConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CancelConfirm_Cancel);
            this.Controls.Add(this.btn_CancelConfirm_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_CancelConfirm_BodyText);
            this.Name = "CancelConfirm";
            this.Text = "CancelConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CancelConfirm_BodyText;
        private System.Windows.Forms.Button btn_CancelConfirm_Exit;
        private System.Windows.Forms.Button btn_CancelConfirm_Cancel;
    }
}