namespace Backup {
    partial class frmbackup {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.lblmensagem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnfechar
			// 
			this.btnFecharComEsc.FlatAppearance.BorderSize = 0;
			this.btnFecharComEsc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(187)))));
			this.btnFecharComEsc.Location = new System.Drawing.Point(397, 647);
			this.btnFecharComEsc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			// 
			// lblmensagem
			// 
			this.lblmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmensagem.Location = new System.Drawing.Point(9, 7);
			this.lblmensagem.Name = "lblmensagem";
			this.lblmensagem.Size = new System.Drawing.Size(277, 73);
			this.lblmensagem.TabIndex = 0;
			this.lblmensagem.Text = "Gerando backup JSoftware. Aguarde...";
			this.lblmensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmbackup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 93);
			this.ControlBox = false;
			this.Controls.Add(this.lblmensagem);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmbackup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Backup";
			this.Load += new System.EventHandler(this.frmbackup_Load);
			this.Controls.SetChildIndex(this.btnFecharComEsc, 0);
			this.Controls.SetChildIndex(this.lblmensagem, 0);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmensagem;
    }
}

