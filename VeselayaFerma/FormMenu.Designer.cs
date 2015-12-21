namespace VeselayaFerma
{
    partial class FormMenu
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_sound = new System.Windows.Forms.CheckBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_sound
            // 
            this.check_sound.AutoSize = true;
            this.check_sound.BackColor = System.Drawing.Color.Transparent;
            this.check_sound.Checked = true;
            this.check_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_sound.Location = new System.Drawing.Point(29, 27);
            this.check_sound.Name = "check_sound";
            this.check_sound.Size = new System.Drawing.Size(45, 17);
            this.check_sound.TabIndex = 5;
            this.check_sound.Text = "Вкл";
            this.check_sound.UseVisualStyleBackColor = false;
            this.check_sound.CheckedChanged += new System.EventHandler(this.check_sound_CheckedChanged);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Blackadder ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.Lime;
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_exit.Location = new System.Drawing.Point(229, 272);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(119, 46);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Blackadder ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.Lime;
            this.button_start.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_start.Location = new System.Drawing.Point(229, 190);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(119, 46);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Игра";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeselayaFerma.Properties.Resources.Веселая_ферма_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.check_sound);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeselayaFerma";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_sound;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_start;
    }
}

