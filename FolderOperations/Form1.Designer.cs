
namespace FolderOperations
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
            this.btnFolderCount = new System.Windows.Forms.Button();
            this.btnFileCount = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lstCheck = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFolderCount
            // 
            this.btnFolderCount.Location = new System.Drawing.Point(22, 117);
            this.btnFolderCount.Name = "btnFolderCount";
            this.btnFolderCount.Size = new System.Drawing.Size(218, 54);
            this.btnFolderCount.TabIndex = 0;
            this.btnFolderCount.Text = "Folder Count";
            this.btnFolderCount.UseVisualStyleBackColor = true;
            this.btnFolderCount.Click += new System.EventHandler(this.btnFolderCount_Click);
            // 
            // btnFileCount
            // 
            this.btnFileCount.Location = new System.Drawing.Point(22, 189);
            this.btnFileCount.Name = "btnFileCount";
            this.btnFileCount.Size = new System.Drawing.Size(218, 54);
            this.btnFileCount.TabIndex = 1;
            this.btnFileCount.Text = "File Count";
            this.btnFileCount.UseVisualStyleBackColor = true;
            this.btnFileCount.Click += new System.EventHandler(this.btnFileCount_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(22, 258);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(218, 54);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Folders";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lstCheck
            // 
            this.lstCheck.FormattingEnabled = true;
            this.lstCheck.ItemHeight = 20;
            this.lstCheck.Location = new System.Drawing.Point(274, 117);
            this.lstCheck.Name = "lstCheck";
            this.lstCheck.Size = new System.Drawing.Size(330, 404);
            this.lstCheck.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(39, 38);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 37);
            this.lblStatus.TabIndex = 4;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(22, 327);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(218, 54);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move Files";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnFileCount);
            this.Controls.Add(this.btnFolderCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolderCount;
        private System.Windows.Forms.Button btnFileCount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lstCheck;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnMove;
    }
}

