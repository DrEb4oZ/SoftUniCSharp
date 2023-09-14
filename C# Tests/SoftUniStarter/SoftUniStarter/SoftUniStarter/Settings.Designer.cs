namespace SoftUniStarter
{
    partial class Settings
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
            btn_saveAndExit = new Button();
            label1 = new Label();
            txb_softUni = new TextBox();
            SuspendLayout();
            // 
            // btn_saveAndExit
            // 
            btn_saveAndExit.Location = new Point(197, 361);
            btn_saveAndExit.Name = "btn_saveAndExit";
            btn_saveAndExit.Size = new Size(85, 39);
            btn_saveAndExit.TabIndex = 0;
            btn_saveAndExit.Text = "Save and exit";
            btn_saveAndExit.UseVisualStyleBackColor = true;
            btn_saveAndExit.Click += btn_saveAndExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 58);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "SoftUniLink";
            // 
            // txb_softUni
            // 
            txb_softUni.Location = new Point(197, 65);
            txb_softUni.Name = "txb_softUni";
            txb_softUni.Size = new Size(279, 23);
            txb_softUni.TabIndex = 2;
            txb_softUni.Text = "www.softuni.bg";
            txb_softUni.TextChanged += txb_softUni_TextChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_softUni);
            Controls.Add(label1);
            Controls.Add(btn_saveAndExit);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_saveAndExit;
        private Label label1;
        private TextBox txb_softUni;
    }
}