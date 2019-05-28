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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).BeginInit();
            this.panel_editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hero)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_field
            // 
            this.pb_field.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pb_field.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_field.BackgroundImage")));
            this.pb_field.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_field.Location = new System.Drawing.Point(12, 12);
            this.pb_field.Name = "pb_field";
            this.pb_field.Size = new System.Drawing.Size(1000, 750);
            this.pb_field.TabIndex = 0;
            this.pb_field.TabStop = false;
            // 
            // panel_editor
            // 
            this.panel_editor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_editor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_editor.Controls.Add(this.label2);
            this.panel_editor.Controls.Add(this.label1);
            this.panel_editor.Controls.Add(this.lb_result);
            this.panel_editor.Controls.Add(this.tb_result);
            this.panel_editor.Controls.Add(this.tb_code);
            this.panel_editor.Controls.Add(this.btn_stop);
            this.panel_editor.Controls.Add(this.btn_start);
            this.panel_editor.Location = new System.Drawing.Point(1024, 12);
            this.panel_editor.Name = "panel_editor";
            this.panel_editor.Size = new System.Drawing.Size(330, 750);
            this.panel_editor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "опис";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Попелюшка і Василь";
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_result.Location = new System.Drawing.Point(3, 639);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(192, 23);
            this.lb_result.TabIndex = 6;
            this.lb_result.Text = "result";
            this.lb_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_result
            // 
            this.tb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_result.Location = new System.Drawing.Point(3, 674);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(192, 71);
            this.tb_result.TabIndex = 5;
            // 
            // tb_code
            // 
            this.tb_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_code.Location = new System.Drawing.Point(3, 64);
            this.tb_code.Multiline = true;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(322, 518);
            this.tb_code.TabIndex = 4;
            this.tb_code.Text = "moveForward();";
            this.tb_code.TextChanged += new System.EventHandler(this.tb_code_TextChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_stop.Location = new System.Drawing.Point(160, 601);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(35, 35);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(3, 601);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(151, 35);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pb_hero
            // 
            this.pb_hero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_hero.BackgroundImage")));
            this.pb_hero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_hero.Location = new System.Drawing.Point(263, 287);
            this.pb_hero.Name = "pb_hero";
            this.pb_hero.Size = new System.Drawing.Size(47, 50);
            this.pb_hero.TabIndex = 2;
            this.pb_hero.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pb_hero);
            this.Controls.Add(this.panel_editor);
            this.Controls.Add(this.pb_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "code_quest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).EndInit();
            this.panel_editor.ResumeLayout(false);
            this.panel_editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_field;
        private System.Windows.Forms.Panel panel_editor;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.PictureBox pb_hero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

