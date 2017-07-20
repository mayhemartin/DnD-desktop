namespace DnD
{
    partial class Arena
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblConst = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblAttackBonus = new System.Windows.Forms.Label();
            this.lblDefenseBonus = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.ProgressBar();
            this.lblTotalHealth = new System.Windows.Forms.Label();
            this.lblCurrentHealth = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompCurrentHealth = new System.Windows.Forms.Label();
            this.lblCompTotalHealth = new System.Windows.Forms.Label();
            this.pbComp = new System.Windows.Forms.ProgressBar();
            this.lblCompDefenseBonus = new System.Windows.Forms.Label();
            this.lblCompAttackBonus = new System.Windows.Forms.Label();
            this.lblCompSpeed = new System.Windows.Forms.Label();
            this.lblCompConst = new System.Windows.Forms.Label();
            this.lblCompStrength = new System.Windows.Forms.Label();
            this.lblCompName = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Button();
            this.tail = new System.Windows.Forms.Button();
            this.pbFlip = new System.Windows.Forms.PictureBox();
            this.playerWeap = new System.Windows.Forms.PictureBox();
            this.playerArmor = new System.Windows.Forms.PictureBox();
            this.compWeap = new System.Windows.Forms.PictureBox();
            this.compArmor = new System.Windows.Forms.PictureBox();
            this.btnRePlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCompRC = new System.Windows.Forms.Label();
            this.lblRC = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWeap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compWeap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compArmor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 15);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "name";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(3, 42);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(54, 15);
            this.lblStrength.TabIndex = 44;
            this.lblStrength.Text = "strength";
            // 
            // lblConst
            // 
            this.lblConst.AutoSize = true;
            this.lblConst.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConst.Location = new System.Drawing.Point(3, 57);
            this.lblConst.Name = "lblConst";
            this.lblConst.Size = new System.Drawing.Size(39, 15);
            this.lblConst.TabIndex = 45;
            this.lblConst.Text = "Const";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(3, 72);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(37, 15);
            this.lblSpeed.TabIndex = 46;
            this.lblSpeed.Text = "speed";
            // 
            // lblAttackBonus
            // 
            this.lblAttackBonus.AutoSize = true;
            this.lblAttackBonus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackBonus.Location = new System.Drawing.Point(5, 87);
            this.lblAttackBonus.Name = "lblAttackBonus";
            this.lblAttackBonus.Size = new System.Drawing.Size(76, 15);
            this.lblAttackBonus.TabIndex = 47;
            this.lblAttackBonus.Text = "attack bonus";
            // 
            // lblDefenseBonus
            // 
            this.lblDefenseBonus.AutoSize = true;
            this.lblDefenseBonus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefenseBonus.Location = new System.Drawing.Point(5, 102);
            this.lblDefenseBonus.Name = "lblDefenseBonus";
            this.lblDefenseBonus.Size = new System.Drawing.Size(83, 15);
            this.lblDefenseBonus.TabIndex = 48;
            this.lblDefenseBonus.Text = "defense bonus";
            // 
            // pbPlayer
            // 
            this.pbPlayer.ForeColor = System.Drawing.Color.Red;
            this.pbPlayer.Location = new System.Drawing.Point(42, 293);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(252, 30);
            this.pbPlayer.TabIndex = 49;
            // 
            // lblTotalHealth
            // 
            this.lblTotalHealth.AutoSize = true;
            this.lblTotalHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHealth.Location = new System.Drawing.Point(149, 300);
            this.lblTotalHealth.Name = "lblTotalHealth";
            this.lblTotalHealth.Size = new System.Drawing.Size(64, 13);
            this.lblTotalHealth.TabIndex = 50;
            this.lblTotalHealth.Text = "/total health";
            // 
            // lblCurrentHealth
            // 
            this.lblCurrentHealth.AutoSize = true;
            this.lblCurrentHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentHealth.Location = new System.Drawing.Point(134, 300);
            this.lblCurrentHealth.Name = "lblCurrentHealth";
            this.lblCurrentHealth.Size = new System.Drawing.Size(36, 13);
            this.lblCurrentHealth.TabIndex = 51;
            this.lblCurrentHealth.Text = "health";
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(137, 364);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history.Size = new System.Drawing.Size(363, 111);
            this.history.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Battle History";
            // 
            // lblCompCurrentHealth
            // 
            this.lblCompCurrentHealth.AutoSize = true;
            this.lblCompCurrentHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblCompCurrentHealth.Location = new System.Drawing.Point(451, 300);
            this.lblCompCurrentHealth.Name = "lblCompCurrentHealth";
            this.lblCompCurrentHealth.Size = new System.Drawing.Size(36, 13);
            this.lblCompCurrentHealth.TabIndex = 60;
            this.lblCompCurrentHealth.Text = "health";
            // 
            // lblCompTotalHealth
            // 
            this.lblCompTotalHealth.AutoSize = true;
            this.lblCompTotalHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblCompTotalHealth.Location = new System.Drawing.Point(466, 300);
            this.lblCompTotalHealth.Name = "lblCompTotalHealth";
            this.lblCompTotalHealth.Size = new System.Drawing.Size(64, 13);
            this.lblCompTotalHealth.TabIndex = 59;
            this.lblCompTotalHealth.Text = "/total health";
            // 
            // pbComp
            // 
            this.pbComp.ForeColor = System.Drawing.Color.Red;
            this.pbComp.Location = new System.Drawing.Point(359, 293);
            this.pbComp.Name = "pbComp";
            this.pbComp.Size = new System.Drawing.Size(252, 30);
            this.pbComp.TabIndex = 58;
            // 
            // lblCompDefenseBonus
            // 
            this.lblCompDefenseBonus.AutoSize = true;
            this.lblCompDefenseBonus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompDefenseBonus.Location = new System.Drawing.Point(524, 102);
            this.lblCompDefenseBonus.Name = "lblCompDefenseBonus";
            this.lblCompDefenseBonus.Size = new System.Drawing.Size(83, 15);
            this.lblCompDefenseBonus.TabIndex = 70;
            this.lblCompDefenseBonus.Text = "defense bonus";
            // 
            // lblCompAttackBonus
            // 
            this.lblCompAttackBonus.AutoSize = true;
            this.lblCompAttackBonus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompAttackBonus.Location = new System.Drawing.Point(524, 87);
            this.lblCompAttackBonus.Name = "lblCompAttackBonus";
            this.lblCompAttackBonus.Size = new System.Drawing.Size(76, 15);
            this.lblCompAttackBonus.TabIndex = 69;
            this.lblCompAttackBonus.Text = "attack bonus";
            // 
            // lblCompSpeed
            // 
            this.lblCompSpeed.AutoSize = true;
            this.lblCompSpeed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompSpeed.Location = new System.Drawing.Point(522, 72);
            this.lblCompSpeed.Name = "lblCompSpeed";
            this.lblCompSpeed.Size = new System.Drawing.Size(37, 15);
            this.lblCompSpeed.TabIndex = 68;
            this.lblCompSpeed.Text = "speed";
            // 
            // lblCompConst
            // 
            this.lblCompConst.AutoSize = true;
            this.lblCompConst.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompConst.Location = new System.Drawing.Point(522, 57);
            this.lblCompConst.Name = "lblCompConst";
            this.lblCompConst.Size = new System.Drawing.Size(39, 15);
            this.lblCompConst.TabIndex = 67;
            this.lblCompConst.Text = "Const";
            // 
            // lblCompStrength
            // 
            this.lblCompStrength.AutoSize = true;
            this.lblCompStrength.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompStrength.Location = new System.Drawing.Point(522, 42);
            this.lblCompStrength.Name = "lblCompStrength";
            this.lblCompStrength.Size = new System.Drawing.Size(54, 15);
            this.lblCompStrength.TabIndex = 66;
            this.lblCompStrength.Text = "strength";
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.Location = new System.Drawing.Point(522, 9);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(36, 15);
            this.lblCompName.TabIndex = 65;
            this.lblCompName.Text = "name";
            // 
            // head
            // 
            this.head.Location = new System.Drawing.Point(241, 221);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(71, 26);
            this.head.TabIndex = 72;
            this.head.Text = "Heads";
            this.head.UseVisualStyleBackColor = true;
            this.head.Click += new System.EventHandler(this.head_Click);
            // 
            // tail
            // 
            this.tail.Location = new System.Drawing.Point(318, 221);
            this.tail.Name = "tail";
            this.tail.Size = new System.Drawing.Size(71, 26);
            this.tail.TabIndex = 73;
            this.tail.Text = "Tails";
            this.tail.UseVisualStyleBackColor = true;
            this.tail.Click += new System.EventHandler(this.tail_Click);
            // 
            // pbFlip
            // 
            this.pbFlip.Location = new System.Drawing.Point(229, 32);
            this.pbFlip.Name = "pbFlip";
            this.pbFlip.Size = new System.Drawing.Size(173, 149);
            this.pbFlip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFlip.TabIndex = 71;
            this.pbFlip.TabStop = false;
            // 
            // playerWeap
            // 
            this.playerWeap.Location = new System.Drawing.Point(173, 132);
            this.playerWeap.Name = "playerWeap";
            this.playerWeap.Size = new System.Drawing.Size(50, 49);
            this.playerWeap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerWeap.TabIndex = 64;
            this.playerWeap.TabStop = false;
            // 
            // playerArmor
            // 
            this.playerArmor.Location = new System.Drawing.Point(91, 132);
            this.playerArmor.Name = "playerArmor";
            this.playerArmor.Size = new System.Drawing.Size(64, 79);
            this.playerArmor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerArmor.TabIndex = 63;
            this.playerArmor.TabStop = false;
            // 
            // compWeap
            // 
            this.compWeap.Location = new System.Drawing.Point(422, 132);
            this.compWeap.Name = "compWeap";
            this.compWeap.Size = new System.Drawing.Size(50, 49);
            this.compWeap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.compWeap.TabIndex = 62;
            this.compWeap.TabStop = false;
            // 
            // compArmor
            // 
            this.compArmor.Location = new System.Drawing.Point(494, 132);
            this.compArmor.Name = "compArmor";
            this.compArmor.Size = new System.Drawing.Size(64, 79);
            this.compArmor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.compArmor.TabIndex = 61;
            this.compArmor.TabStop = false;
            // 
            // btnRePlay
            // 
            this.btnRePlay.Location = new System.Drawing.Point(272, 87);
            this.btnRePlay.Name = "btnRePlay";
            this.btnRePlay.Size = new System.Drawing.Size(94, 26);
            this.btnRePlay.TabIndex = 74;
            this.btnRePlay.Text = "Play Again?";
            this.btnRePlay.UseVisualStyleBackColor = true;
            this.btnRePlay.Visible = false;
            this.btnRePlay.Click += new System.EventHandler(this.btnRePlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 26);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCompRC
            // 
            this.lblCompRC.AutoSize = true;
            this.lblCompRC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompRC.Location = new System.Drawing.Point(524, 24);
            this.lblCompRC.Name = "lblCompRC";
            this.lblCompRC.Size = new System.Drawing.Size(69, 15);
            this.lblCompRC.TabIndex = 76;
            this.lblCompRC.Text = "race / class";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRC.Location = new System.Drawing.Point(3, 24);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(69, 15);
            this.lblRC.TabIndex = 77;
            this.lblRC.Text = "race / class";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Vladimir Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResult.Location = new System.Drawing.Point(278, 159);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 32);
            this.lblResult.TabIndex = 78;
            this.lblResult.Text = "label1";
            this.lblResult.Visible = false;
            // 
            // Arena
            // 
            this.AccessibleName = "battleArena";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 483);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRC);
            this.Controls.Add(this.lblCompRC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRePlay);
            this.Controls.Add(this.tail);
            this.Controls.Add(this.head);
            this.Controls.Add(this.pbFlip);
            this.Controls.Add(this.lblCompDefenseBonus);
            this.Controls.Add(this.lblCompAttackBonus);
            this.Controls.Add(this.lblCompSpeed);
            this.Controls.Add(this.lblCompConst);
            this.Controls.Add(this.lblCompStrength);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.playerWeap);
            this.Controls.Add(this.playerArmor);
            this.Controls.Add(this.compWeap);
            this.Controls.Add(this.compArmor);
            this.Controls.Add(this.lblCompCurrentHealth);
            this.Controls.Add(this.lblCompTotalHealth);
            this.Controls.Add(this.pbComp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.history);
            this.Controls.Add(this.lblCurrentHealth);
            this.Controls.Add(this.lblTotalHealth);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblDefenseBonus);
            this.Controls.Add(this.lblAttackBonus);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblConst);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.lblName);
            this.Name = "Arena";
            this.Text = "D&D - Combat Mechanic (Battle !!)";
            this.Load += new System.EventHandler(this.Arena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWeap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compWeap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compArmor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblConst;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblAttackBonus;
        private System.Windows.Forms.Label lblDefenseBonus;
        private System.Windows.Forms.ProgressBar pbPlayer;
        private System.Windows.Forms.Label lblTotalHealth;
        private System.Windows.Forms.Label lblCurrentHealth;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompCurrentHealth;
        private System.Windows.Forms.Label lblCompTotalHealth;
        private System.Windows.Forms.ProgressBar pbComp;
        private System.Windows.Forms.PictureBox compArmor;
        private System.Windows.Forms.PictureBox compWeap;
        private System.Windows.Forms.PictureBox playerWeap;
        private System.Windows.Forms.PictureBox playerArmor;
        private System.Windows.Forms.Label lblCompDefenseBonus;
        private System.Windows.Forms.Label lblCompAttackBonus;
        private System.Windows.Forms.Label lblCompSpeed;
        private System.Windows.Forms.Label lblCompConst;
        private System.Windows.Forms.Label lblCompStrength;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.PictureBox pbFlip;
        private System.Windows.Forms.Button head;
        private System.Windows.Forms.Button tail;
        private System.Windows.Forms.Button btnRePlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCompRC;
        private System.Windows.Forms.Label lblRC;
        private System.Windows.Forms.Label lblResult;
    }
}