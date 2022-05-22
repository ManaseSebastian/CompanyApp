namespace CompanyApp
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.chatPanel = new System.Windows.Forms.Panel();
            this.chatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.chatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatPanel
            // 
            this.chatPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chatPanel.BackgroundImage")));
            this.chatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatPanel.Controls.Add(this.buttonClose);
            this.chatPanel.Controls.Add(this.sendRichTextBox);
            this.chatPanel.Controls.Add(this.chatRichTextBox);
            this.chatPanel.Location = new System.Drawing.Point(75, 80);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(339, 399);
            this.chatPanel.TabIndex = 0;
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.chatRichTextBox.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox.Location = new System.Drawing.Point(47, 43);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.Size = new System.Drawing.Size(248, 268);
            this.chatRichTextBox.TabIndex = 0;
            this.chatRichTextBox.Text = "";
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendRichTextBox.Location = new System.Drawing.Point(0, 333);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Size = new System.Drawing.Size(339, 66);
            this.sendRichTextBox.TabIndex = 1;
            this.sendRichTextBox.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.Location = new System.Drawing.Point(304, 9);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 545);
            this.Controls.Add(this.chatPanel);
            this.Name = "Form5";
            this.Text = "Form5";
            this.chatPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.RichTextBox chatRichTextBox;
        private System.Windows.Forms.RichTextBox sendRichTextBox;
        private System.Windows.Forms.Button buttonClose;
    }
}