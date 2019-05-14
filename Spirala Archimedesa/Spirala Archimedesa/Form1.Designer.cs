namespace Spirala_Archimedesa
{
    partial class Okno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Draw_guzik = new System.Windows.Forms.Button();
            this.label_distance = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.SpaceBetweenArms = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reset_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.Resume_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw_guzik
            // 
            this.Draw_guzik.AutoSize = true;
            this.Draw_guzik.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Draw_guzik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Draw_guzik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Draw_guzik.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Draw_guzik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Draw_guzik.Location = new System.Drawing.Point(33, 197);
            this.Draw_guzik.Name = "Draw_guzik";
            this.Draw_guzik.Size = new System.Drawing.Size(137, 34);
            this.Draw_guzik.TabIndex = 0;
            this.Draw_guzik.Text = "Rysuj";
            this.Draw_guzik.UseVisualStyleBackColor = true;
            this.Draw_guzik.Click += new System.EventHandler(this.Draw_guzik_Click);
            // 
            // label_distance
            // 
            this.label_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_distance.Location = new System.Drawing.Point(33, 55);
            this.label_distance.Name = "label_distance";
            this.label_distance.Size = new System.Drawing.Size(137, 104);
            this.label_distance.TabIndex = 2;
            this.label_distance.Text = "Odległość między ramionami";
            this.label_distance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.Color.Wheat;
            this.PicBox.Location = new System.Drawing.Point(190, 0);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(610, 452);
            this.PicBox.TabIndex = 3;
            this.PicBox.TabStop = false;
            // 
            // SpaceBetweenArms
            // 
            this.SpaceBetweenArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpaceBetweenArms.Location = new System.Drawing.Point(33, 162);
            this.SpaceBetweenArms.Name = "SpaceBetweenArms";
            this.SpaceBetweenArms.Size = new System.Drawing.Size(137, 29);
            this.SpaceBetweenArms.TabIndex = 5;
            this.SpaceBetweenArms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reset_button
            // 
            this.Reset_button.AutoSize = true;
            this.Reset_button.Enabled = false;
            this.Reset_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset_button.Location = new System.Drawing.Point(33, 396);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(137, 36);
            this.Reset_button.TabIndex = 6;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.AutoSize = true;
            this.Pause_button.Enabled = false;
            this.Pause_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Pause_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pause_button.Location = new System.Drawing.Point(53, 278);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(95, 32);
            this.Pause_button.TabIndex = 7;
            this.Pause_button.Text = "Pauza";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // Resume_button
            // 
            this.Resume_button.AutoSize = true;
            this.Resume_button.Enabled = false;
            this.Resume_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Resume_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Resume_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Resume_button.Location = new System.Drawing.Point(53, 316);
            this.Resume_button.Name = "Resume_button";
            this.Resume_button.Size = new System.Drawing.Size(95, 32);
            this.Resume_button.TabIndex = 8;
            this.Resume_button.Text = "Wznów";
            this.Resume_button.UseVisualStyleBackColor = true;
            this.Resume_button.Click += new System.EventHandler(this.Resume_button_Click);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resume_button);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.SpaceBetweenArms);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.label_distance);
            this.Controls.Add(this.Draw_guzik);
            this.MaximizeBox = false;
            this.Name = "Okno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Okno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw_guzik;
        private System.Windows.Forms.Label label_distance;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.TextBox SpaceBetweenArms;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button Resume_button;
    }
}

