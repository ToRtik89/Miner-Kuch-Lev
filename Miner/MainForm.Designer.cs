namespace Miner
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.new_game = new System.Windows.Forms.Button();
            this.leadersButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.new_game, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.leadersButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.settings, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.exit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // new_game
            // 
            this.new_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.new_game.Location = new System.Drawing.Point(269, 176);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(260, 63);
            this.new_game.TabIndex = 0;
            this.new_game.Text = "new game";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // leadersButton
            // 
            this.leadersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leadersButton.Location = new System.Drawing.Point(269, 245);
            this.leadersButton.Name = "leadersButton";
            this.leadersButton.Size = new System.Drawing.Size(260, 63);
            this.leadersButton.TabIndex = 1;
            this.leadersButton.Text = "records(не робит)";
            this.leadersButton.UseVisualStyleBackColor = true;
            this.leadersButton.Click += new System.EventHandler(this.leadersButton_Click);
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(269, 314);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(260, 63);
            this.settings.TabIndex = 2;
            this.settings.Text = "settings(не роибт)";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit.Location = new System.Drawing.Point(269, 383);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(260, 63);
            this.exit.TabIndex = 3;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 173);
            this.label1.TabIndex = 4;
            this.label1.Text = "грибы Тимо";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Button leadersButton;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
    }
}

