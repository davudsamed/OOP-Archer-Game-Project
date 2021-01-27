namespace Savas.Desktop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.asamaLabel = new System.Windows.Forms.Label();
            this.skorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.okcuPanel = new System.Windows.Forms.Panel();
            this.aksiyonPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Controls.Add(this.asamaLabel);
            this.bilgiPanel.Controls.Add(this.skorLabel);
            this.bilgiPanel.Controls.Add(this.label2);
            this.bilgiPanel.Controls.Add(this.label1);
            this.bilgiPanel.Controls.Add(this.lbl_over);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1601, 126);
            this.bilgiPanel.TabIndex = 0;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.BackColor = System.Drawing.Color.Transparent;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.Black;
            this.bilgiLabel.Location = new System.Drawing.Point(21, 22);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(382, 78);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Başlatma= ENTER\r\nHareket = YUKARI/ AŞAĞI yön tuşları\r\nAteş = SPACE\r\n";
            // 
            // asamaLabel
            // 
            this.asamaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.asamaLabel.AutoSize = true;
            this.asamaLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asamaLabel.ForeColor = System.Drawing.Color.Black;
            this.asamaLabel.Location = new System.Drawing.Point(708, 48);
            this.asamaLabel.Name = "asamaLabel";
            this.asamaLabel.Size = new System.Drawing.Size(232, 50);
            this.asamaLabel.TabIndex = 5;
            this.asamaLabel.Text = "AŞAMA 1";
            // 
            // skorLabel
            // 
            this.skorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skorLabel.AutoSize = true;
            this.skorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skorLabel.Location = new System.Drawing.Point(1365, 55);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(51, 55);
            this.skorLabel.TabIndex = 4;
            this.skorLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1486, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "SÜRE";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1359, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PUAN";
            // 
            // lbl_over
            // 
            this.lbl_over.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.White;
            this.lbl_over.Location = new System.Drawing.Point(1388, 48);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(201, 68);
            this.lbl_over.TabIndex = 1;
            this.lbl_over.Text = "0:00";
            this.lbl_over.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // okcuPanel
            // 
            this.okcuPanel.BackColor = System.Drawing.Color.White;
            this.okcuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.okcuPanel.Location = new System.Drawing.Point(0, 126);
            this.okcuPanel.Name = "okcuPanel";
            this.okcuPanel.Size = new System.Drawing.Size(312, 561);
            this.okcuPanel.TabIndex = 1;
            // 
            // aksiyonPanel
            // 
            this.aksiyonPanel.BackColor = System.Drawing.Color.White;
            this.aksiyonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aksiyonPanel.Location = new System.Drawing.Point(312, 126);
            this.aksiyonPanel.Name = "aksiyonPanel";
            this.aksiyonPanel.Size = new System.Drawing.Size(1289, 561);
            this.aksiyonPanel.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 687);
            this.Controls.Add(this.aksiyonPanel);
            this.Controls.Add(this.okcuPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Balon Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel okcuPanel;
        private System.Windows.Forms.Panel aksiyonPanel;
        private System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asamaLabel;
    }
}

