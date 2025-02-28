namespace BoardGame
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.infoPeshki = new System.Windows.Forms.Panel();
            this.buttonXod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yellowPeshka = new System.Windows.Forms.PictureBox();
            this.greenPeshka = new System.Windows.Forms.PictureBox();
            this.bluePeshka = new System.Windows.Forms.PictureBox();
            this.redPeshka = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cube1 = new System.Windows.Forms.PictureBox();
            this.cube2 = new System.Windows.Forms.PictureBox();
            this.infoPeshki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPeshka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPeshka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePeshka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPeshka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube2)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPeshki
            // 
            this.infoPeshki.Controls.Add(this.label2);
            this.infoPeshki.Controls.Add(this.buttonXod);
            this.infoPeshki.Controls.Add(this.label1);
            this.infoPeshki.Controls.Add(this.yellowPeshka);
            this.infoPeshki.Controls.Add(this.greenPeshka);
            this.infoPeshki.Controls.Add(this.bluePeshka);
            this.infoPeshki.Controls.Add(this.redPeshka);
            this.infoPeshki.Location = new System.Drawing.Point(500, 12);
            this.infoPeshki.Name = "infoPeshki";
            this.infoPeshki.Size = new System.Drawing.Size(536, 626);
            this.infoPeshki.TabIndex = 0;
            // 
            // buttonXod
            // 
            this.buttonXod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXod.Location = new System.Drawing.Point(185, 224);
            this.buttonXod.Name = "buttonXod";
            this.buttonXod.Size = new System.Drawing.Size(168, 65);
            this.buttonXod.TabIndex = 6;
            this.buttonXod.Text = "Бросить кубики";
            this.buttonXod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // yellowPeshka
            // 
            this.yellowPeshka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowPeshka.BackgroundImage")));
            this.yellowPeshka.Location = new System.Drawing.Point(382, 3);
            this.yellowPeshka.Name = "yellowPeshka";
            this.yellowPeshka.Size = new System.Drawing.Size(109, 128);
            this.yellowPeshka.TabIndex = 4;
            this.yellowPeshka.TabStop = false;
            // 
            // greenPeshka
            // 
            this.greenPeshka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenPeshka.BackgroundImage")));
            this.greenPeshka.Location = new System.Drawing.Point(267, 3);
            this.greenPeshka.Name = "greenPeshka";
            this.greenPeshka.Size = new System.Drawing.Size(109, 128);
            this.greenPeshka.TabIndex = 3;
            this.greenPeshka.TabStop = false;
            // 
            // bluePeshka
            // 
            this.bluePeshka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePeshka.BackgroundImage")));
            this.bluePeshka.Location = new System.Drawing.Point(152, 3);
            this.bluePeshka.Name = "bluePeshka";
            this.bluePeshka.Size = new System.Drawing.Size(109, 128);
            this.bluePeshka.TabIndex = 2;
            this.bluePeshka.TabStop = false;
            // 
            // redPeshka
            // 
            this.redPeshka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redPeshka.BackgroundImage")));
            this.redPeshka.Location = new System.Drawing.Point(37, 3);
            this.redPeshka.Name = "redPeshka";
            this.redPeshka.Size = new System.Drawing.Size(109, 128);
            this.redPeshka.TabIndex = 1;
            this.redPeshka.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 325);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // cube1
            // 
            this.cube1.Location = new System.Drawing.Point(83, 530);
            this.cube1.Name = "cube1";
            this.cube1.Size = new System.Drawing.Size(120, 120);
            this.cube1.TabIndex = 1;
            this.cube1.TabStop = false;
            // 
            // cube2
            // 
            this.cube2.Location = new System.Drawing.Point(258, 530);
            this.cube2.Name = "cube2";
            this.cube2.Size = new System.Drawing.Size(120, 120);
            this.cube2.TabIndex = 2;
            this.cube2.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 650);
            this.Controls.Add(this.cube2);
            this.Controls.Add(this.cube1);
            this.Controls.Add(this.infoPeshki);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра бродилка";
            this.infoPeshki.ResumeLayout(false);
            this.infoPeshki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPeshka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPeshka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePeshka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPeshka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPeshki;
        private System.Windows.Forms.PictureBox redPeshka;
        private System.Windows.Forms.PictureBox bluePeshka;
        private System.Windows.Forms.PictureBox greenPeshka;
        private System.Windows.Forms.PictureBox yellowPeshka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cube1;
        private System.Windows.Forms.PictureBox cube2;
    }
}

