namespace PostRequestSender
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
            this.txtBxInputString = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtBxResponseContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxInputString
            // 
            this.txtBxInputString.Location = new System.Drawing.Point(12, 77);
            this.txtBxInputString.Name = "txtBxInputString";
            this.txtBxInputString.Size = new System.Drawing.Size(380, 20);
            this.txtBxInputString.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(398, 75);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String to post";
            // 
            // richTxtBxResponseContent
            // 
            this.richTxtBxResponseContent.Location = new System.Drawing.Point(12, 129);
            this.richTxtBxResponseContent.Name = "richTxtBxResponseContent";
            this.richTxtBxResponseContent.ReadOnly = true;
            this.richTxtBxResponseContent.Size = new System.Drawing.Size(461, 165);
            this.richTxtBxResponseContent.TabIndex = 4;
            this.richTxtBxResponseContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Response content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(12, 25);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(380, 20);
            this.txtBxAddress.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 304);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTxtBxResponseContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtBxInputString);
            this.Name = "Form1";
            this.Text = "Post Request Sender v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxInputString;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtBxResponseContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxAddress;
    }
}

