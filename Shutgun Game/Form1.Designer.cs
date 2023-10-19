namespace Shutgun_Game
{
    partial class Form1
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
            laddaButton = new Button();
            blockaButton = new Button();
            skjuttaButton = new Button();
            cumputerChoice = new TextBox();
            startaButton = new Button();
            pAmmo = new Label();
            cAmmo = new Label();
            SuspendLayout();
            // 
            // laddaButton
            // 
            laddaButton.Font = new Font("Impact", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            laddaButton.Location = new Point(220, 78);
            laddaButton.Name = "laddaButton";
            laddaButton.Size = new Size(200, 200);
            laddaButton.TabIndex = 0;
            laddaButton.Text = "Ladda";
            laddaButton.UseVisualStyleBackColor = true;
            laddaButton.Click += laddaButton_Click;
            // 
            // blockaButton
            // 
            blockaButton.Font = new Font("Impact", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            blockaButton.Location = new Point(220, 528);
            blockaButton.Name = "blockaButton";
            blockaButton.Size = new Size(200, 200);
            blockaButton.TabIndex = 1;
            blockaButton.Text = "Blocka";
            blockaButton.UseVisualStyleBackColor = true;
            blockaButton.Click += blockaButton_Click;
            // 
            // skjuttaButton
            // 
            skjuttaButton.Font = new Font("Impact", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            skjuttaButton.Location = new Point(220, 307);
            skjuttaButton.Name = "skjuttaButton";
            skjuttaButton.Size = new Size(200, 200);
            skjuttaButton.TabIndex = 2;
            skjuttaButton.Text = "Skjut";
            skjuttaButton.UseVisualStyleBackColor = true;
            skjuttaButton.Click += skjuttaButton_Click;
            // 
            // cumputerChoice
            // 
            cumputerChoice.BackColor = SystemColors.AppWorkspace;
            cumputerChoice.Font = new Font("Gabriola", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cumputerChoice.ForeColor = Color.Red;
            cumputerChoice.Location = new Point(1154, 343);
            cumputerChoice.Name = "cumputerChoice";
            cumputerChoice.Size = new Size(206, 116);
            cumputerChoice.TabIndex = 3;
            // 
            // startaButton
            // 
            startaButton.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point);
            startaButton.Location = new Point(1352, 12);
            startaButton.Name = "startaButton";
            startaButton.Size = new Size(220, 124);
            startaButton.TabIndex = 6;
            startaButton.Text = "Starta";
            startaButton.UseVisualStyleBackColor = true;
            // 
            // pAmmo
            // 
            pAmmo.AutoSize = true;
            pAmmo.Font = new Font("Impact", 72F, FontStyle.Italic, GraphicsUnit.Point);
            pAmmo.Location = new Point(100, 354);
            pAmmo.Name = "pAmmo";
            pAmmo.Size = new Size(101, 117);
            pAmmo.TabIndex = 7;
            pAmmo.Text = "0";
            // 
            // cAmmo
            // 
            cAmmo.AutoSize = true;
            cAmmo.Font = new Font("Impact", 72F, FontStyle.Italic, GraphicsUnit.Point);
            cAmmo.Location = new Point(1380, 342);
            cAmmo.Name = "cAmmo";
            cAmmo.Size = new Size(101, 117);
            cAmmo.TabIndex = 8;
            cAmmo.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(cAmmo);
            Controls.Add(pAmmo);
            Controls.Add(startaButton);
            Controls.Add(cumputerChoice);
            Controls.Add(skjuttaButton);
            Controls.Add(blockaButton);
            Controls.Add(laddaButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button laddaButton;
        private Button blockaButton;
        private Button skjuttaButton;
        private TextBox cumputerChoice;
        private Button startaButton;
        private Label pAmmo;
        private Label cAmmo;
    }
}