namespace GUI___Three_Card_Monte
{
    partial class FormHome
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
            this.btneasy = new System.Windows.Forms.Button();
            this.lblcash = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnmedium = new System.Windows.Forms.Button();
            this.btnhard = new System.Windows.Forms.Button();
            this.btninstructions = new System.Windows.Forms.Button();
            this.btnmusic = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btneasy
            // 
            this.btneasy.BackColor = System.Drawing.Color.Firebrick;
            this.btneasy.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneasy.Location = new System.Drawing.Point(67, 232);
            this.btneasy.Name = "btneasy";
            this.btneasy.Size = new System.Drawing.Size(211, 47);
            this.btneasy.TabIndex = 0;
            this.btneasy.Text = "EASY";
            this.btneasy.UseVisualStyleBackColor = false;
            this.btneasy.Click += new System.EventHandler(this.btneasy_Click);
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.ForeColor = System.Drawing.Color.Orchid;
            this.lblcash.Location = new System.Drawing.Point(13, 13);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(97, 28);
            this.lblcash.TabIndex = 1;
            this.lblcash.Text = "Cash: 500";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Brown;
            this.lbltitle.Location = new System.Drawing.Point(190, 159);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(425, 57);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Three Card Monte";
            // 
            // btnmedium
            // 
            this.btnmedium.BackColor = System.Drawing.Color.Firebrick;
            this.btnmedium.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedium.Location = new System.Drawing.Point(301, 232);
            this.btnmedium.Name = "btnmedium";
            this.btnmedium.Size = new System.Drawing.Size(211, 47);
            this.btnmedium.TabIndex = 3;
            this.btnmedium.Text = "MEDIUM";
            this.btnmedium.UseVisualStyleBackColor = false;
            // 
            // btnhard
            // 
            this.btnhard.BackColor = System.Drawing.Color.Firebrick;
            this.btnhard.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhard.Location = new System.Drawing.Point(537, 232);
            this.btnhard.Name = "btnhard";
            this.btnhard.Size = new System.Drawing.Size(211, 47);
            this.btnhard.TabIndex = 4;
            this.btnhard.Text = "HARD";
            this.btnhard.UseVisualStyleBackColor = false;
            // 
            // btninstructions
            // 
            this.btninstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninstructions.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstructions.ForeColor = System.Drawing.Color.MediumPurple;
            this.btninstructions.Location = new System.Drawing.Point(537, 13);
            this.btninstructions.Name = "btninstructions";
            this.btninstructions.Size = new System.Drawing.Size(141, 37);
            this.btninstructions.TabIndex = 5;
            this.btninstructions.Text = "How to Play?";
            this.btninstructions.UseVisualStyleBackColor = false;
            this.btninstructions.Click += new System.EventHandler(this.btninstructions_Click);
            // 
            // btnmusic
            // 
            this.btnmusic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmusic.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusic.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnmusic.Location = new System.Drawing.Point(684, 13);
            this.btnmusic.Name = "btnmusic";
            this.btnmusic.Size = new System.Drawing.Size(104, 37);
            this.btnmusic.TabIndex = 6;
            this.btnmusic.Text = "Music";
            this.btnmusic.UseVisualStyleBackColor = false;
            this.btnmusic.Click += new System.EventHandler(this.btnmusic_Click);
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquit.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnquit.Location = new System.Drawing.Point(427, 13);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(104, 37);
            this.btnquit.TabIndex = 7;
            this.btnquit.Text = "QUIT";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnmusic);
            this.Controls.Add(this.btninstructions);
            this.Controls.Add(this.btnhard);
            this.Controls.Add(this.btnmedium);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.btneasy);
            this.Name = "FormHome";
            this.Text = "Three Card Monte";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneasy;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnmedium;
        private System.Windows.Forms.Button btnhard;
        private System.Windows.Forms.Button btninstructions;
        private System.Windows.Forms.Button btnmusic;
        private System.Windows.Forms.Button btnquit;
    }
}

