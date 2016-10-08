namespace TextAdventureLib
{
    partial class AdventureForm
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
            this.ChoiceA = new System.Windows.Forms.Button();
            this.ChoiceB = new System.Windows.Forms.Button();
            this.ChoiceC = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoiceA
            // 
            this.ChoiceA.Location = new System.Drawing.Point(68, 355);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(140, 60);
            this.ChoiceA.TabIndex = 0;
            this.ChoiceA.UseVisualStyleBackColor = true;
            this.ChoiceA.Click += new System.EventHandler(this.ChoiceA_Click);
            // 
            // ChoiceB
            // 
            this.ChoiceB.Location = new System.Drawing.Point(293, 355);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(140, 60);
            this.ChoiceB.TabIndex = 1;
            this.ChoiceB.UseVisualStyleBackColor = true;
            this.ChoiceB.Click += new System.EventHandler(this.ChoiceB_Click);
            // 
            // ChoiceC
            // 
            this.ChoiceC.Location = new System.Drawing.Point(524, 355);
            this.ChoiceC.Name = "ChoiceC";
            this.ChoiceC.Size = new System.Drawing.Size(140, 60);
            this.ChoiceC.TabIndex = 2;
            this.ChoiceC.UseVisualStyleBackColor = true;
            this.ChoiceC.Click += new System.EventHandler(this.ChoiceC_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Font = new System.Drawing.Font("Moire", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.Location = new System.Drawing.Point(322, 276);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(61, 25);
            this.DisplayLabel.TabIndex = 3;
            this.DisplayLabel.Text = "Test";
            this.DisplayLabel.TextChanged += new System.EventHandler(this.DisplayLabel_TextChanged);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(68, 29);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(596, 231);
            this.ImageBox.TabIndex = 4;
            this.ImageBox.TabStop = false;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(683, 1);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(57, 30);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // AdventureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 472);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.ChoiceC);
            this.Controls.Add(this.ChoiceB);
            this.Controls.Add(this.ChoiceA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "AdventureForm";
            this.Load += new System.EventHandler(this.AdventureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ChoiceA;
        public System.Windows.Forms.Button ChoiceB;
        public System.Windows.Forms.Button ChoiceC;
        public System.Windows.Forms.Label DisplayLabel;
        public System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button helpButton;
    }
}

