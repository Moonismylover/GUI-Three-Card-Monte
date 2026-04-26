namespace GUI___Three_Card_Monte
{
    partial class FormEasy
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
            this.btnquit = new System.Windows.Forms.Button();
            this.btnmusic = new System.Windows.Forms.Button();
            this.btninstructions = new System.Windows.Forms.Button();
            this.lblcash = new System.Windows.Forms.Label();
            this.lblcard = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.imgcardthree = new System.Windows.Forms.PictureBox();
            this.imgcardtwo = new System.Windows.Forms.PictureBox();
            this.imgcardone = new System.Windows.Forms.PictureBox();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgcardthree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcardtwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcardone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquit.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnquit.Location = new System.Drawing.Point(426, 12);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(104, 37);
            this.btnquit.TabIndex = 11;
            this.btnquit.Text = "QUIT";
            this.btnquit.UseVisualStyleBackColor = false;
            // 
            // btnmusic
            // 
            this.btnmusic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmusic.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusic.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnmusic.Location = new System.Drawing.Point(683, 12);
            this.btnmusic.Name = "btnmusic";
            this.btnmusic.Size = new System.Drawing.Size(104, 37);
            this.btnmusic.TabIndex = 10;
            this.btnmusic.Text = "Music";
            this.btnmusic.UseVisualStyleBackColor = false;
            // 
            // btninstructions
            // 
            this.btninstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninstructions.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstructions.ForeColor = System.Drawing.Color.MediumPurple;
            this.btninstructions.Location = new System.Drawing.Point(536, 12);
            this.btninstructions.Name = "btninstructions";
            this.btninstructions.Size = new System.Drawing.Size(141, 37);
            this.btninstructions.TabIndex = 9;
            this.btninstructions.Text = "How to Play?";
            this.btninstructions.UseVisualStyleBackColor = false;
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.ForeColor = System.Drawing.Color.Orchid;
            this.lblcash.Location = new System.Drawing.Point(12, 12);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(97, 28);
            this.lblcash.TabIndex = 8;
            this.lblcash.Text = "Cash: 500";
            // 
            // lblcard
            // 
            this.lblcard.AutoSize = true;
            this.lblcard.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcard.ForeColor = System.Drawing.Color.LightBlue;
            this.lblcard.Location = new System.Drawing.Point(35, 64);
            this.lblcard.Name = "lblcard";
            this.lblcard.Size = new System.Drawing.Size(52, 34);
            this.lblcard.TabIndex = 13;
            this.lblcard.Text = "ehh";
            this.lblcard.Click += new System.EventHandler(this.lblcard_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Indigo;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnplay.Location = new System.Drawing.Point(223, 381);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(211, 47);
            this.btnplay.TabIndex = 16;
            this.btnplay.Text = "PLAY";
            this.btnplay.UseVisualStyleBackColor = false;
            // 
            // imgcardthree
            // 
            this.imgcardthree.Image = global::GUI___Three_Card_Monte.Properties.Resources.Card;
            this.imgcardthree.Location = new System.Drawing.Point(576, 80);
            this.imgcardthree.Name = "imgcardthree";
            this.imgcardthree.Size = new System.Drawing.Size(211, 284);
            this.imgcardthree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcardthree.TabIndex = 15;
            this.imgcardthree.TabStop = false;
            // 
            // imgcardtwo
            // 
            this.imgcardtwo.Image = global::GUI___Three_Card_Monte.Properties.Resources.Card;
            this.imgcardtwo.Location = new System.Drawing.Point(347, 80);
            this.imgcardtwo.Name = "imgcardtwo";
            this.imgcardtwo.Size = new System.Drawing.Size(211, 284);
            this.imgcardtwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcardtwo.TabIndex = 14;
            this.imgcardtwo.TabStop = false;
            // 
            // imgcardone
            // 
            this.imgcardone.Image = global::GUI___Three_Card_Monte.Properties.Resources.Card;
            this.imgcardone.Location = new System.Drawing.Point(117, 80);
            this.imgcardone.Name = "imgcardone";
            this.imgcardone.Size = new System.Drawing.Size(211, 284);
            this.imgcardone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcardone.TabIndex = 12;
            this.imgcardone.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Indigo;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(466, 381);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(211, 47);
            this.btnreset.TabIndex = 17;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // FormEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.imgcardthree);
            this.Controls.Add(this.imgcardtwo);
            this.Controls.Add(this.lblcard);
            this.Controls.Add(this.imgcardone);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnmusic);
            this.Controls.Add(this.btninstructions);
            this.Controls.Add(this.lblcash);
            this.Name = "FormEasy";
            this.Text = "Three Card Monte";
            ((System.ComponentModel.ISupportInitialize)(this.imgcardthree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcardtwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcardone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnmusic;
        private System.Windows.Forms.Button btninstructions;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.PictureBox imgcardone;
        private System.Windows.Forms.Label lblcard;
        private System.Windows.Forms.PictureBox imgcardtwo;
        private System.Windows.Forms.PictureBox imgcardthree;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnreset;
    }
}