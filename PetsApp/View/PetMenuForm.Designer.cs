namespace PetsApp
{
    partial class Pets
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.petIdentityLbl = new System.Windows.Forms.Label();
            this.petsToAdoptLstBox = new System.Windows.Forms.ListBox();
            this.petNameTxtBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.petStoreTitleLbl = new System.Windows.Forms.Label();
            this.adoptBtn = new System.Windows.Forms.Button();
            this.myPetsCollectionLstView = new System.Windows.Forms.ListView();
            this.resultLbl = new System.Windows.Forms.Label();
            this.resultLstBox = new System.Windows.Forms.ListBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.removePetBtn = new System.Windows.Forms.Button();
            this.interactBtn = new System.Windows.Forms.Button();
            this.feedBtn = new System.Windows.Forms.Button();
            this.petsCollectionTitleLbl = new System.Windows.Forms.Label();
            this.myPetsTitleLbl = new System.Windows.Forms.Label();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Identity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FeedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Turquoise;
            this.splitContainer1.Panel1.Controls.Add(this.petIdentityLbl);
            this.splitContainer1.Panel1.Controls.Add(this.petsToAdoptLstBox);
            this.splitContainer1.Panel1.Controls.Add(this.petNameTxtBox);
            this.splitContainer1.Panel1.Controls.Add(this.nameLbl);
            this.splitContainer1.Panel1.Controls.Add(this.petStoreTitleLbl);
            this.splitContainer1.Panel1.Controls.Add(this.adoptBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Turquoise;
            this.splitContainer1.Panel2.Controls.Add(this.myPetsCollectionLstView);
            this.splitContainer1.Panel2.Controls.Add(this.resultLbl);
            this.splitContainer1.Panel2.Controls.Add(this.resultLstBox);
            this.splitContainer1.Panel2.Controls.Add(this.viewBtn);
            this.splitContainer1.Panel2.Controls.Add(this.removePetBtn);
            this.splitContainer1.Panel2.Controls.Add(this.interactBtn);
            this.splitContainer1.Panel2.Controls.Add(this.feedBtn);
            this.splitContainer1.Panel2.Controls.Add(this.petsCollectionTitleLbl);
            this.splitContainer1.Panel2.Controls.Add(this.myPetsTitleLbl);
            this.splitContainer1.Size = new System.Drawing.Size(488, 599);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 0;
            // 
            // petIdentityLbl
            // 
            this.petIdentityLbl.AutoSize = true;
            this.petIdentityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petIdentityLbl.Location = new System.Drawing.Point(12, 64);
            this.petIdentityLbl.Name = "petIdentityLbl";
            this.petIdentityLbl.Size = new System.Drawing.Size(118, 24);
            this.petIdentityLbl.TabIndex = 4;
            this.petIdentityLbl.Text = "Pet Identity:";
            // 
            // petsToAdoptLstBox
            // 
            this.petsToAdoptLstBox.BackColor = System.Drawing.Color.White;
            this.petsToAdoptLstBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petsToAdoptLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsToAdoptLstBox.FormattingEnabled = true;
            this.petsToAdoptLstBox.ItemHeight = 20;
            this.petsToAdoptLstBox.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Plant",
            "Fish"});
            this.petsToAdoptLstBox.Location = new System.Drawing.Point(337, 38);
            this.petsToAdoptLstBox.Name = "petsToAdoptLstBox";
            this.petsToAdoptLstBox.Size = new System.Drawing.Size(139, 82);
            this.petsToAdoptLstBox.TabIndex = 6;
            this.petsToAdoptLstBox.SelectedIndexChanged += new System.EventHandler(this.petsToAdoptLstBox_SelectedIndexChanged);
            // 
            // petNameTxtBox
            // 
            this.petNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petNameTxtBox.Location = new System.Drawing.Point(89, 124);
            this.petNameTxtBox.Name = "petNameTxtBox";
            this.petNameTxtBox.Size = new System.Drawing.Size(151, 22);
            this.petNameTxtBox.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 124);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 24);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name:";
            // 
            // petStoreTitleLbl
            // 
            this.petStoreTitleLbl.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.petStoreTitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.petStoreTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petStoreTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.petStoreTitleLbl.Name = "petStoreTitleLbl";
            this.petStoreTitleLbl.Size = new System.Drawing.Size(488, 25);
            this.petStoreTitleLbl.TabIndex = 0;
            this.petStoreTitleLbl.Text = "Pet Store";
            this.petStoreTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adoptBtn
            // 
            this.adoptBtn.BackColor = System.Drawing.Color.Transparent;
            this.adoptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adoptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptBtn.Location = new System.Drawing.Point(336, 156);
            this.adoptBtn.Name = "adoptBtn";
            this.adoptBtn.Size = new System.Drawing.Size(139, 37);
            this.adoptBtn.TabIndex = 0;
            this.adoptBtn.Text = "Adopt";
            this.adoptBtn.UseVisualStyleBackColor = false;
            this.adoptBtn.Click += new System.EventHandler(this.adoptBtn_Click);
            // 
            // myPetsCollectionLstView
            // 
            this.myPetsCollectionLstView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.myPetsCollectionLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Identity,
            this.FeedTime});
            this.myPetsCollectionLstView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPetsCollectionLstView.FullRowSelect = true;
            this.myPetsCollectionLstView.GridLines = true;
            this.myPetsCollectionLstView.HideSelection = false;
            this.myPetsCollectionLstView.Location = new System.Drawing.Point(16, 118);
            this.myPetsCollectionLstView.MultiSelect = false;
            this.myPetsCollectionLstView.Name = "myPetsCollectionLstView";
            this.myPetsCollectionLstView.Size = new System.Drawing.Size(285, 245);
            this.myPetsCollectionLstView.TabIndex = 2;
            this.myPetsCollectionLstView.UseCompatibleStateImageBehavior = false;
            this.myPetsCollectionLstView.View = System.Windows.Forms.View.Details;
            // 
            // resultLbl
            // 
            this.resultLbl.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(327, 91);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(149, 25);
            this.resultLbl.TabIndex = 9;
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLstBox
            // 
            this.resultLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLstBox.FormattingEnabled = true;
            this.resultLstBox.ItemHeight = 15;
            this.resultLstBox.Location = new System.Drawing.Point(326, 119);
            this.resultLstBox.Name = "resultLstBox";
            this.resultLstBox.Size = new System.Drawing.Size(149, 244);
            this.resultLstBox.TabIndex = 8;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(30, 35);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(100, 40);
            this.viewBtn.TabIndex = 7;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // removePetBtn
            // 
            this.removePetBtn.Location = new System.Drawing.Point(345, 35);
            this.removePetBtn.Name = "removePetBtn";
            this.removePetBtn.Size = new System.Drawing.Size(100, 40);
            this.removePetBtn.TabIndex = 6;
            this.removePetBtn.Text = "Remove Pet";
            this.removePetBtn.UseVisualStyleBackColor = true;
            this.removePetBtn.Click += new System.EventHandler(this.removePetBtn_Click);
            // 
            // interactBtn
            // 
            this.interactBtn.Location = new System.Drawing.Point(239, 35);
            this.interactBtn.Name = "interactBtn";
            this.interactBtn.Size = new System.Drawing.Size(100, 40);
            this.interactBtn.TabIndex = 5;
            this.interactBtn.Text = "Interact";
            this.interactBtn.UseVisualStyleBackColor = true;
            this.interactBtn.Click += new System.EventHandler(this.interactBtn_Click);
            // 
            // feedBtn
            // 
            this.feedBtn.Location = new System.Drawing.Point(133, 35);
            this.feedBtn.Name = "feedBtn";
            this.feedBtn.Size = new System.Drawing.Size(100, 40);
            this.feedBtn.TabIndex = 4;
            this.feedBtn.Text = "Feed";
            this.feedBtn.UseVisualStyleBackColor = true;
            this.feedBtn.Click += new System.EventHandler(this.feedBtn_Click);
            // 
            // petsCollectionTitleLbl
            // 
            this.petsCollectionTitleLbl.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.petsCollectionTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsCollectionTitleLbl.Location = new System.Drawing.Point(16, 89);
            this.petsCollectionTitleLbl.Name = "petsCollectionTitleLbl";
            this.petsCollectionTitleLbl.Size = new System.Drawing.Size(285, 25);
            this.petsCollectionTitleLbl.TabIndex = 3;
            this.petsCollectionTitleLbl.Text = "Pets";
            this.petsCollectionTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myPetsTitleLbl
            // 
            this.myPetsTitleLbl.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.myPetsTitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPetsTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPetsTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.myPetsTitleLbl.Name = "myPetsTitleLbl";
            this.myPetsTitleLbl.Size = new System.Drawing.Size(488, 25);
            this.myPetsTitleLbl.TabIndex = 1;
            this.myPetsTitleLbl.Text = "My Pets";
            this.myPetsTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 100;
            // 
            // Identity
            // 
            this.Identity.Text = "Identity";
            // 
            // FeedTime
            // 
            this.FeedTime.Text = "Feed Time";
            this.FeedTime.Width = 80;
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 599);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Text = "Pets!";
            this.Load += new System.EventHandler(this.Pets_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox petNameTxtBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label petStoreTitleLbl;
        private System.Windows.Forms.Button adoptBtn;
        private System.Windows.Forms.ListBox petsToAdoptLstBox;
        private System.Windows.Forms.Label petIdentityLbl;
        private System.Windows.Forms.Label myPetsTitleLbl;
        private System.Windows.Forms.Label petsCollectionTitleLbl;
        private System.Windows.Forms.Button removePetBtn;
        private System.Windows.Forms.Button interactBtn;
        private System.Windows.Forms.Button feedBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.ListBox resultLstBox;
        private System.Windows.Forms.ListView myPetsCollectionLstView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Identity;
        private System.Windows.Forms.ColumnHeader FeedTime;
    }
}

