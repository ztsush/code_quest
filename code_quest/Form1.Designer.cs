namespace code_quest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_field = new System.Windows.Forms.PictureBox();
            this.panel_editor = new System.Windows.Forms.Panel();
            this.panel_open_quest = new System.Windows.Forms.Panel();
            this.btn_open_quest = new System.Windows.Forms.Button();
            this.btn_explanation = new System.Windows.Forms.Button();
            this.lb_open_quest_main = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).BeginInit();
            this.panel_open_quest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_field
            // 
            this.pb_field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_field.Location = new System.Drawing.Point(12, 12);
            this.pb_field.Name = "pb_field";
            this.pb_field.Size = new System.Drawing.Size(554, 363);
            this.pb_field.TabIndex = 0;
            this.pb_field.TabStop = false;
            // 
            // panel_editor
            // 
            this.panel_editor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_editor.Enabled = false;
            this.panel_editor.Location = new System.Drawing.Point(572, 12);
            this.panel_editor.Name = "panel_editor";
            this.panel_editor.Size = new System.Drawing.Size(200, 363);
            this.panel_editor.TabIndex = 1;
            // 
            // panel_open_quest
            // 
            this.panel_open_quest.Controls.Add(this.lb_open_quest_main);
            this.panel_open_quest.Controls.Add(this.btn_explanation);
            this.panel_open_quest.Controls.Add(this.btn_open_quest);
            this.panel_open_quest.Location = new System.Drawing.Point(168, 94);
            this.panel_open_quest.Name = "panel_open_quest";
            this.panel_open_quest.Size = new System.Drawing.Size(350, 200);
            this.panel_open_quest.TabIndex = 2;
            // 
            // btn_open_quest
            // 
            this.btn_open_quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open_quest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_open_quest.Location = new System.Drawing.Point(75, 106);
            this.btn_open_quest.Name = "btn_open_quest";
            this.btn_open_quest.Size = new System.Drawing.Size(200, 75);
            this.btn_open_quest.TabIndex = 0;
            this.btn_open_quest.Text = "open quest";
            this.btn_open_quest.UseVisualStyleBackColor = true;
            this.btn_open_quest.Click += new System.EventHandler(this.btn_open_quest_Click);
            // 
            // btn_explanation
            // 
            this.btn_explanation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_explanation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explanation.BackgroundImage")));
            this.btn_explanation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_explanation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_explanation.Location = new System.Drawing.Point(322, 172);
            this.btn_explanation.Name = "btn_explanation";
            this.btn_explanation.Size = new System.Drawing.Size(25, 25);
            this.btn_explanation.TabIndex = 1;
            this.btn_explanation.UseVisualStyleBackColor = false;
            // 
            // lb_open_quest_main
            // 
            this.lb_open_quest_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_open_quest_main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_open_quest_main.Location = new System.Drawing.Point(40, 12);
            this.lb_open_quest_main.Name = "lb_open_quest_main";
            this.lb_open_quest_main.Size = new System.Drawing.Size(270, 80);
            this.lb_open_quest_main.TabIndex = 2;
            this.lb_open_quest_main.Text = "are you ready ?";
            this.lb_open_quest_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.panel_open_quest);
            this.Controls.Add(this.panel_editor);
            this.Controls.Add(this.pb_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "code_quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).EndInit();
            this.panel_open_quest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_field;
        private System.Windows.Forms.Panel panel_editor;
        private System.Windows.Forms.Panel panel_open_quest;
        private System.Windows.Forms.Label lb_open_quest_main;
        private System.Windows.Forms.Button btn_explanation;
        private System.Windows.Forms.Button btn_open_quest;
    }
}

