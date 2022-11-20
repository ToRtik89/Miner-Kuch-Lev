namespace Miner.Controllers
{
    partial class InputUsernameForm
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
            this.Labeltext = new System.Windows.Forms.Label();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.submitNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Labeltext
            // 
            this.Labeltext.AutoSize = true;
            this.Labeltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labeltext.Location = new System.Drawing.Point(38, 66);
            this.Labeltext.Name = "Labeltext";
            this.Labeltext.Size = new System.Drawing.Size(183, 31);
            this.Labeltext.TabIndex = 0;
            this.Labeltext.Tag = "";
            this.Labeltext.Text = "Введите имя:";
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameTextBox.Location = new System.Drawing.Point(44, 138);
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(177, 30);
            this.inputNameTextBox.TabIndex = 1;
            // 
            // submitNameButton
            // 
            this.submitNameButton.Location = new System.Drawing.Point(44, 218);
            this.submitNameButton.Name = "submitNameButton";
            this.submitNameButton.Size = new System.Drawing.Size(177, 54);
            this.submitNameButton.TabIndex = 2;
            this.submitNameButton.Text = "Принять";
            this.submitNameButton.UseVisualStyleBackColor = true;
            this.submitNameButton.Click += new System.EventHandler(this.submitNameButton_Click);
            // 
            // InputUsernameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 336);
            this.Controls.Add(this.submitNameButton);
            this.Controls.Add(this.inputNameTextBox);
            this.Controls.Add(this.Labeltext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputUsernameForm";
            this.Text = "Ввод имени";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputUsernameForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labeltext;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.Button submitNameButton;
    }
}