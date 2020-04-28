namespace EmptyNegeriMonsterVersiWindowsForm
{
    partial class MainForm
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
            this.monstersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.eatButton = new System.Windows.Forms.Button();
            this.fireButton = new System.Windows.Forms.Button();
            this.flyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monstersListBox
            // 
            this.monstersListBox.FormattingEnabled = true;
            this.monstersListBox.Location = new System.Drawing.Point(12, 31);
            this.monstersListBox.Name = "monstersListBox";
            this.monstersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.monstersListBox.Size = new System.Drawing.Size(171, 134);
            this.monstersListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daftar Monster:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daftar Aksi:";
            // 
            // actionTextBox
            // 
            this.actionTextBox.Location = new System.Drawing.Point(12, 203);
            this.actionTextBox.Multiline = true;
            this.actionTextBox.Name = "actionTextBox";
            this.actionTextBox.ReadOnly = true;
            this.actionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.actionTextBox.Size = new System.Drawing.Size(354, 101);
            this.actionTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(190, 31);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Tambah Monster";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // eatButton
            // 
            this.eatButton.Location = new System.Drawing.Point(190, 60);
            this.eatButton.Name = "eatButton";
            this.eatButton.Size = new System.Drawing.Size(176, 23);
            this.eatButton.TabIndex = 5;
            this.eatButton.Text = "Makan Cacing 100 Tahun";
            this.eatButton.UseVisualStyleBackColor = true;
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(189, 89);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(176, 23);
            this.fireButton.TabIndex = 6;
            this.fireButton.Text = "Semburan Api Maha Dahsyat";
            this.fireButton.UseVisualStyleBackColor = true;
            // 
            // flyButton
            // 
            this.flyButton.Location = new System.Drawing.Point(189, 118);
            this.flyButton.Name = "flyButton";
            this.flyButton.Size = new System.Drawing.Size(176, 23);
            this.flyButton.TabIndex = 7;
            this.flyButton.Text = "Terbang Mengitari Bumi";
            this.flyButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 316);
            this.Controls.Add(this.flyButton);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.eatButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.actionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monstersListBox);
            this.Name = "MainForm";
            this.Text = "Aplikasi Negeri Monster Versi Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox monstersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox actionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button eatButton;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button flyButton;
    }
}

