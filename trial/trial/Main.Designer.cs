namespace trial
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.hero = new System.Windows.Forms.PictureBox();
            this.enemyA = new System.Windows.Forms.PictureBox();
            this.enemyB = new System.Windows.Forms.PictureBox();
            this.enemyAName = new System.Windows.Forms.Label();
            this.enemyBName = new System.Windows.Forms.Label();
            this.enemyAHp = new System.Windows.Forms.Label();
            this.enemyBHp = new System.Windows.Forms.Label();
            this.heroName = new System.Windows.Forms.Label();
            this.heroHp = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMagic = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyB)).BeginInit();
            this.SuspendLayout();
            // 
            // hero
            // 
            this.hero.Location = new System.Drawing.Point(83, 211);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(177, 178);
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // enemyA
            // 
            this.enemyA.Location = new System.Drawing.Point(189, 20);
            this.enemyA.Name = "enemyA";
            this.enemyA.Size = new System.Drawing.Size(134, 124);
            this.enemyA.TabIndex = 1;
            this.enemyA.TabStop = false;
            // 
            // enemyB
            // 
            this.enemyB.Location = new System.Drawing.Point(335, 18);
            this.enemyB.Name = "enemyB";
            this.enemyB.Size = new System.Drawing.Size(133, 125);
            this.enemyB.TabIndex = 2;
            this.enemyB.TabStop = false;
            // 
            // enemyAName
            // 
            this.enemyAName.AutoSize = true;
            this.enemyAName.Location = new System.Drawing.Point(189, 151);
            this.enemyAName.Name = "enemyAName";
            this.enemyAName.Size = new System.Drawing.Size(75, 12);
            this.enemyAName.TabIndex = 3;
            this.enemyAName.Text = "enemyAName";
            // 
            // enemyBName
            // 
            this.enemyBName.AutoSize = true;
            this.enemyBName.Location = new System.Drawing.Point(335, 150);
            this.enemyBName.Name = "enemyBName";
            this.enemyBName.Size = new System.Drawing.Size(75, 12);
            this.enemyBName.TabIndex = 4;
            this.enemyBName.Text = "enemyBName";
            // 
            // enemyAHp
            // 
            this.enemyAHp.AutoSize = true;
            this.enemyAHp.Location = new System.Drawing.Point(189, 173);
            this.enemyAHp.Name = "enemyAHp";
            this.enemyAHp.Size = new System.Drawing.Size(60, 12);
            this.enemyAHp.TabIndex = 5;
            this.enemyAHp.Text = "enemyAHp";
            // 
            // enemyBHp
            // 
            this.enemyBHp.AutoSize = true;
            this.enemyBHp.Location = new System.Drawing.Point(335, 168);
            this.enemyBHp.Name = "enemyBHp";
            this.enemyBHp.Size = new System.Drawing.Size(60, 12);
            this.enemyBHp.TabIndex = 6;
            this.enemyBHp.Text = "enemyBHp";
            // 
            // heroName
            // 
            this.heroName.AutoSize = true;
            this.heroName.Location = new System.Drawing.Point(82, 398);
            this.heroName.Name = "heroName";
            this.heroName.Size = new System.Drawing.Size(56, 12);
            this.heroName.TabIndex = 7;
            this.heroName.Text = "heroName";
            // 
            // heroHp
            // 
            this.heroHp.AutoSize = true;
            this.heroHp.Location = new System.Drawing.Point(82, 421);
            this.heroHp.Name = "heroHp";
            this.heroHp.Size = new System.Drawing.Size(41, 12);
            this.heroHp.TabIndex = 8;
            this.heroHp.Text = "heroHp";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(300, 344);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(94, 28);
            this.btnAttack.TabIndex = 9;
            this.btnAttack.Text = "攻撃";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(400, 344);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(94, 28);
            this.btnMagic.TabIndex = 10;
            this.btnMagic.Text = "魔法";
            this.btnMagic.UseVisualStyleBackColor = true;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(300, 378);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(94, 28);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "休む";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(400, 378);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(94, 28);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "逃げる";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 518);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.heroHp);
            this.Controls.Add(this.heroName);
            this.Controls.Add(this.enemyBHp);
            this.Controls.Add(this.enemyAHp);
            this.Controls.Add(this.enemyBName);
            this.Controls.Add(this.enemyAName);
            this.Controls.Add(this.enemyB);
            this.Controls.Add(this.enemyA);
            this.Controls.Add(this.hero);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.PictureBox enemyA;
        private System.Windows.Forms.PictureBox enemyB;
        private System.Windows.Forms.Label enemyAName;
        private System.Windows.Forms.Label enemyBName;
        private System.Windows.Forms.Label enemyAHp;
        private System.Windows.Forms.Label enemyBHp;
        private System.Windows.Forms.Label heroName;
        private System.Windows.Forms.Label heroHp;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnRun;
    }
}

