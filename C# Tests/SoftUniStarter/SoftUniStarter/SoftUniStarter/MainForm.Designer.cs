namespace SoftUniStarter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_settings = new Button();
            btn_softUniLink = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_settings
            // 
            btn_settings.Location = new Point(728, 12);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(60, 23);
            btn_settings.TabIndex = 0;
            btn_settings.Text = "settings";
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_softUniLink
            // 
            btn_softUniLink.Location = new Point(48, 45);
            btn_softUniLink.Name = "btn_softUniLink";
            btn_softUniLink.Size = new Size(90, 68);
            btn_softUniLink.TabIndex = 1;
            btn_softUniLink.Text = "SoftUni";
            btn_softUniLink.UseVisualStyleBackColor = true;
            btn_softUniLink.Click += btn_softUniLink_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(513, 343);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(136, 70);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "I`m done for now";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_softUniLink);
            Controls.Add(btn_settings);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_settings;
        private Button btn_softUniLink;
        private Button btn_exit;
    }
}