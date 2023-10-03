namespace Assignment1
{
    partial class Chat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.networkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.networkMenuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversationPane = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.conversationPaneLabel = new System.Windows.Forms.Label();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Network";
            // 
            // networkMenu
            // 
            this.networkMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkMenuConnect,
            this.disconnectToolStripMenuItem});
            this.networkMenu.Name = "networkMenu";
            this.networkMenu.Size = new System.Drawing.Size(64, 20);
            this.networkMenu.Text = "Network";
            // 
            // networkMenuConnect
            // 
            this.networkMenuConnect.Name = "networkMenuConnect";
            this.networkMenuConnect.Size = new System.Drawing.Size(180, 22);
            this.networkMenuConnect.Text = "Connect";
            this.networkMenuConnect.Click += new System.EventHandler(this.networkConnect_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // conversationPane
            // 
            this.conversationPane.FormattingEnabled = true;
            this.conversationPane.Location = new System.Drawing.Point(30, 67);
            this.conversationPane.Name = "conversationPane";
            this.conversationPane.Size = new System.Drawing.Size(734, 290);
            this.conversationPane.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(30, 375);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(581, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.Text = "Type something ...";
            // 
            // conversationPaneLabel
            // 
            this.conversationPaneLabel.AutoSize = true;
            this.conversationPaneLabel.Location = new System.Drawing.Point(27, 41);
            this.conversationPaneLabel.Name = "conversationPaneLabel";
            this.conversationPaneLabel.Size = new System.Drawing.Size(69, 13);
            this.conversationPaneLabel.TabIndex = 3;
            this.conversationPaneLabel.Text = "Conversation";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(641, 372);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(87, 23);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.conversationPaneLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.conversationPane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Chat";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem networkMenu;
        private System.Windows.Forms.ToolStripMenuItem networkMenuConnect;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ListBox conversationPane;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label conversationPaneLabel;
        private System.Windows.Forms.Button sendMessageButton;
    }
}

