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
            this.panel_actions = new System.Windows.Forms.Panel();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_question = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).BeginInit();
            this.panel_actions.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_field
            // 
            resources.ApplyResources(this.pb_field, "pb_field");
            this.pb_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_field.Name = "pb_field";
            this.pb_field.TabStop = false;
            // 
            // panel_editor
            // 
            resources.ApplyResources(this.panel_editor, "panel_editor");
            this.panel_editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_editor.Name = "panel_editor";
            // 
            // panel_actions
            // 
            resources.ApplyResources(this.panel_actions, "panel_actions");
            this.panel_actions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_actions.Controls.Add(this.btn_restart);
            this.panel_actions.Controls.Add(this.btn_start);
            this.panel_actions.Controls.Add(this.btn_pause);
            this.panel_actions.Name = "panel_actions";
            // 
            // btn_restart
            // 
            resources.ApplyResources(this.btn_restart, "btn_restart");
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            resources.ApplyResources(this.btn_pause, "btn_pause");
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // panel_header
            // 
            resources.ApplyResources(this.panel_header, "panel_header");
            this.panel_header.Controls.Add(this.btn_question);
            this.panel_header.Controls.Add(this.btn_minimize);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Name = "panel_header";
            // 
            // btn_question
            // 
            resources.ApplyResources(this.btn_question, "btn_question");
            this.btn_question.Name = "btn_question";
            this.btn_question.UseVisualStyleBackColor = true;
            this.btn_question.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // btn_minimize
            // 
            resources.ApplyResources(this.btn_minimize, "btn_minimize");
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_actions);
            this.Controls.Add(this.panel_editor);
            this.Controls.Add(this.pb_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_field)).EndInit();
            this.panel_actions.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_field;
        private System.Windows.Forms.Panel panel_editor;
        private System.Windows.Forms.Panel panel_actions;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
    }
}

