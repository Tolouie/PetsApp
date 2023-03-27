namespace PetsApp.View
{
    partial class InteractionMenuView
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
            this.petBtn = new System.Windows.Forms.Button();
            this.rubBellyBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.ignoreBtn = new System.Windows.Forms.Button();
            this.scoldBtn = new System.Windows.Forms.Button();
            this.playMusicBtn = new System.Windows.Forms.Button();
            this.talkToThemBtn = new System.Windows.Forms.Button();
            this.tapOnGlassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // petBtn
            // 
            this.petBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.petBtn.Location = new System.Drawing.Point(0, 0);
            this.petBtn.Name = "petBtn";
            this.petBtn.Size = new System.Drawing.Size(214, 47);
            this.petBtn.TabIndex = 0;
            this.petBtn.Text = "Pet";
            this.petBtn.UseVisualStyleBackColor = true;
            this.petBtn.Click += new System.EventHandler(this.petBtn_Click);
            // 
            // rubBellyBtn
            // 
            this.rubBellyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rubBellyBtn.Location = new System.Drawing.Point(0, 47);
            this.rubBellyBtn.Name = "rubBellyBtn";
            this.rubBellyBtn.Size = new System.Drawing.Size(214, 47);
            this.rubBellyBtn.TabIndex = 1;
            this.rubBellyBtn.Text = "Rub Belly";
            this.rubBellyBtn.UseVisualStyleBackColor = true;
            this.rubBellyBtn.Click += new System.EventHandler(this.rubBellyBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.playBtn.Location = new System.Drawing.Point(0, 94);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(214, 47);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // ignoreBtn
            // 
            this.ignoreBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ignoreBtn.Location = new System.Drawing.Point(0, 141);
            this.ignoreBtn.Name = "ignoreBtn";
            this.ignoreBtn.Size = new System.Drawing.Size(214, 47);
            this.ignoreBtn.TabIndex = 3;
            this.ignoreBtn.Text = "Ignore";
            this.ignoreBtn.UseVisualStyleBackColor = true;
            this.ignoreBtn.Click += new System.EventHandler(this.ignoreBtn_Click);
            // 
            // scoldBtn
            // 
            this.scoldBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoldBtn.Location = new System.Drawing.Point(0, 188);
            this.scoldBtn.Name = "scoldBtn";
            this.scoldBtn.Size = new System.Drawing.Size(214, 47);
            this.scoldBtn.TabIndex = 4;
            this.scoldBtn.Text = "Scold";
            this.scoldBtn.UseVisualStyleBackColor = true;
            this.scoldBtn.Click += new System.EventHandler(this.scoldBtn_Click);
            // 
            // playMusicBtn
            // 
            this.playMusicBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.playMusicBtn.Location = new System.Drawing.Point(0, 235);
            this.playMusicBtn.Name = "playMusicBtn";
            this.playMusicBtn.Size = new System.Drawing.Size(214, 47);
            this.playMusicBtn.TabIndex = 5;
            this.playMusicBtn.Text = "Play Music";
            this.playMusicBtn.UseVisualStyleBackColor = true;
            this.playMusicBtn.Click += new System.EventHandler(this.playMusicBtn_Click);
            // 
            // talkToThemBtn
            // 
            this.talkToThemBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.talkToThemBtn.Location = new System.Drawing.Point(0, 282);
            this.talkToThemBtn.Name = "talkToThemBtn";
            this.talkToThemBtn.Size = new System.Drawing.Size(214, 47);
            this.talkToThemBtn.TabIndex = 6;
            this.talkToThemBtn.Text = "Talk to Them";
            this.talkToThemBtn.UseVisualStyleBackColor = true;
            this.talkToThemBtn.Click += new System.EventHandler(this.talkToThemBtn_Click);
            // 
            // tapOnGlassBtn
            // 
            this.tapOnGlassBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tapOnGlassBtn.Location = new System.Drawing.Point(0, 329);
            this.tapOnGlassBtn.Name = "tapOnGlassBtn";
            this.tapOnGlassBtn.Size = new System.Drawing.Size(214, 47);
            this.tapOnGlassBtn.TabIndex = 7;
            this.tapOnGlassBtn.Text = "Tap on Glass";
            this.tapOnGlassBtn.UseVisualStyleBackColor = true;
            this.tapOnGlassBtn.Click += new System.EventHandler(this.tapOnGlassBtn_Click);
            // 
            // InteractionMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 376);
            this.Controls.Add(this.tapOnGlassBtn);
            this.Controls.Add(this.talkToThemBtn);
            this.Controls.Add(this.playMusicBtn);
            this.Controls.Add(this.scoldBtn);
            this.Controls.Add(this.ignoreBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.rubBellyBtn);
            this.Controls.Add(this.petBtn);
            this.Name = "InteractionMenuView";
            this.Text = "Action Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button petBtn;
        private System.Windows.Forms.Button rubBellyBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button ignoreBtn;
        private System.Windows.Forms.Button scoldBtn;
        private System.Windows.Forms.Button playMusicBtn;
        private System.Windows.Forms.Button talkToThemBtn;
        private System.Windows.Forms.Button tapOnGlassBtn;
    }
}