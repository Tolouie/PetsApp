namespace PetsApp.View
{
    partial class FoodMenuView
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
            this.baconSnackBtn = new System.Windows.Forms.Button();
            this.dryDogFoodBtn = new System.Windows.Forms.Button();
            this.tunaBtn = new System.Windows.Forms.Button();
            this.dryCatFoodBtn = new System.Windows.Forms.Button();
            this.waterBtn = new System.Windows.Forms.Button();
            this.plantFoodBtn = new System.Windows.Forms.Button();
            this.fishFoodBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baconSnackBtn
            // 
            this.baconSnackBtn.AutoSize = true;
            this.baconSnackBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.baconSnackBtn.Location = new System.Drawing.Point(0, 0);
            this.baconSnackBtn.Name = "baconSnackBtn";
            this.baconSnackBtn.Size = new System.Drawing.Size(214, 47);
            this.baconSnackBtn.TabIndex = 0;
            this.baconSnackBtn.Text = "Bacon Snack";
            this.baconSnackBtn.UseVisualStyleBackColor = true;
            this.baconSnackBtn.Click += new System.EventHandler(this.baconSnackBtn_Click);
            // 
            // dryDogFoodBtn
            // 
            this.dryDogFoodBtn.AutoSize = true;
            this.dryDogFoodBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dryDogFoodBtn.Location = new System.Drawing.Point(0, 47);
            this.dryDogFoodBtn.Name = "dryDogFoodBtn";
            this.dryDogFoodBtn.Size = new System.Drawing.Size(214, 47);
            this.dryDogFoodBtn.TabIndex = 1;
            this.dryDogFoodBtn.Text = "Dry Dog Food";
            this.dryDogFoodBtn.UseVisualStyleBackColor = true;
            this.dryDogFoodBtn.Click += new System.EventHandler(this.dryDogFoodBtn_Click);
            // 
            // tunaBtn
            // 
            this.tunaBtn.AutoSize = true;
            this.tunaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tunaBtn.Location = new System.Drawing.Point(0, 94);
            this.tunaBtn.Name = "tunaBtn";
            this.tunaBtn.Size = new System.Drawing.Size(214, 47);
            this.tunaBtn.TabIndex = 2;
            this.tunaBtn.Text = "Tuna";
            this.tunaBtn.UseVisualStyleBackColor = true;
            this.tunaBtn.Click += new System.EventHandler(this.tunaBtn_Click);
            // 
            // dryCatFoodBtn
            // 
            this.dryCatFoodBtn.AutoSize = true;
            this.dryCatFoodBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dryCatFoodBtn.Location = new System.Drawing.Point(0, 141);
            this.dryCatFoodBtn.Name = "dryCatFoodBtn";
            this.dryCatFoodBtn.Size = new System.Drawing.Size(214, 47);
            this.dryCatFoodBtn.TabIndex = 3;
            this.dryCatFoodBtn.Text = "Dry Cat Food";
            this.dryCatFoodBtn.UseVisualStyleBackColor = true;
            this.dryCatFoodBtn.Click += new System.EventHandler(this.dryCatFoodBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.AutoSize = true;
            this.waterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.waterBtn.Location = new System.Drawing.Point(0, 188);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(214, 47);
            this.waterBtn.TabIndex = 4;
            this.waterBtn.Text = "Water";
            this.waterBtn.UseVisualStyleBackColor = true;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // plantFoodBtn
            // 
            this.plantFoodBtn.AutoSize = true;
            this.plantFoodBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plantFoodBtn.Location = new System.Drawing.Point(0, 235);
            this.plantFoodBtn.Name = "plantFoodBtn";
            this.plantFoodBtn.Size = new System.Drawing.Size(214, 47);
            this.plantFoodBtn.TabIndex = 5;
            this.plantFoodBtn.Text = "Plant Food";
            this.plantFoodBtn.UseVisualStyleBackColor = true;
            this.plantFoodBtn.Click += new System.EventHandler(this.plantFoodBtn_Click);
            // 
            // fishFoodBtn
            // 
            this.fishFoodBtn.AutoSize = true;
            this.fishFoodBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.fishFoodBtn.Location = new System.Drawing.Point(0, 282);
            this.fishFoodBtn.Name = "fishFoodBtn";
            this.fishFoodBtn.Size = new System.Drawing.Size(214, 47);
            this.fishFoodBtn.TabIndex = 6;
            this.fishFoodBtn.Text = "Fish Food";
            this.fishFoodBtn.UseVisualStyleBackColor = true;
            this.fishFoodBtn.Click += new System.EventHandler(this.fishFoodBtn_Click);
            // 
            // FoodMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 329);
            this.Controls.Add(this.fishFoodBtn);
            this.Controls.Add(this.plantFoodBtn);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.dryCatFoodBtn);
            this.Controls.Add(this.tunaBtn);
            this.Controls.Add(this.dryDogFoodBtn);
            this.Controls.Add(this.baconSnackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FoodMenuView";
            this.Text = "Food Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baconSnackBtn;
        private System.Windows.Forms.Button dryDogFoodBtn;
        private System.Windows.Forms.Button tunaBtn;
        private System.Windows.Forms.Button dryCatFoodBtn;
        private System.Windows.Forms.Button waterBtn;
        private System.Windows.Forms.Button plantFoodBtn;
        private System.Windows.Forms.Button fishFoodBtn;
    }
}