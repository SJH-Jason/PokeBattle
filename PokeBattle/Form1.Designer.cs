namespace PokeBattle
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAtk = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnpoke = new System.Windows.Forms.Button();
            this.btngiveup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.labHP1 = new System.Windows.Forms.Label();
            this.labName1 = new System.Windows.Forms.Label();
            this.labLV1 = new System.Windows.Forms.Label();
            this.labName2 = new System.Windows.Forms.Label();
            this.labLv2 = new System.Windows.Forms.Label();
            this.labHpVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelatk = new System.Windows.Forms.Panel();
            this.btnatk4 = new System.Windows.Forms.Button();
            this.btnatk3 = new System.Windows.Forms.Button();
            this.btnatk2 = new System.Windows.Forms.Button();
            this.btnatk1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelskill = new System.Windows.Forms.Panel();
            this.labskillno2 = new System.Windows.Forms.Label();
            this.labskilla = new System.Windows.Forms.Label();
            this.labskillb = new System.Windows.Forms.Label();
            this.labskillclass2 = new System.Windows.Forms.Label();
            this.labskillclass1 = new System.Windows.Forms.Label();
            this.labskillno1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panelatk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelskill.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtk
            // 
            this.btnAtk.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAtk.Location = new System.Drawing.Point(348, 431);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(100, 56);
            this.btnAtk.TabIndex = 0;
            this.btnAtk.Text = "戰鬥";
            this.btnAtk.UseVisualStyleBackColor = true;
            this.btnAtk.Click += new System.EventHandler(this.btnAtk_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnback.Location = new System.Drawing.Point(454, 431);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 56);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "背包";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnpoke
            // 
            this.btnpoke.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpoke.Location = new System.Drawing.Point(348, 493);
            this.btnpoke.Name = "btnpoke";
            this.btnpoke.Size = new System.Drawing.Size(100, 56);
            this.btnpoke.TabIndex = 2;
            this.btnpoke.Text = "寶可夢";
            this.btnpoke.UseVisualStyleBackColor = true;
            // 
            // btngiveup
            // 
            this.btngiveup.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngiveup.Location = new System.Drawing.Point(454, 493);
            this.btngiveup.Name = "btngiveup";
            this.btngiveup.Size = new System.Drawing.Size(100, 56);
            this.btngiveup.TabIndex = 3;
            this.btngiveup.Text = "逃走";
            this.btngiveup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 130);
            this.label1.TabIndex = 4;
            this.label1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(329, 358);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 10);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.ForeColor = System.Drawing.Color.Lime;
            this.progressBar2.Location = new System.Drawing.Point(85, 56);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(206, 10);
            this.progressBar2.TabIndex = 8;
            this.progressBar2.Value = 100;
            // 
            // labHP1
            // 
            this.labHP1.AutoSize = true;
            this.labHP1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labHP1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labHP1.Location = new System.Drawing.Point(295, 351);
            this.labHP1.Name = "labHP1";
            this.labHP1.Size = new System.Drawing.Size(39, 17);
            this.labHP1.TabIndex = 9;
            this.labHP1.Text = "HP：";
            // 
            // labName1
            // 
            this.labName1.AutoSize = true;
            this.labName1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName1.Location = new System.Drawing.Point(298, 301);
            this.labName1.Name = "labName1";
            this.labName1.Size = new System.Drawing.Size(131, 47);
            this.labName1.TabIndex = 11;
            this.labName1.Text = "皮卡丘";
            // 
            // labLV1
            // 
            this.labLV1.AutoSize = true;
            this.labLV1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLV1.Location = new System.Drawing.Point(474, 311);
            this.labLV1.Name = "labLV1";
            this.labLV1.Size = new System.Drawing.Size(61, 35);
            this.labLV1.TabIndex = 12;
            this.labLV1.Text = "L33";
            // 
            // labName2
            // 
            this.labName2.AutoSize = true;
            this.labName2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName2.Location = new System.Drawing.Point(55, 2);
            this.labName2.Name = "labName2";
            this.labName2.Size = new System.Drawing.Size(131, 47);
            this.labName2.TabIndex = 13;
            this.labName2.Text = "超音蝠";
            // 
            // labLv2
            // 
            this.labLv2.AutoSize = true;
            this.labLv2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLv2.Location = new System.Drawing.Point(230, 14);
            this.labLv2.Name = "labLv2";
            this.labLv2.Size = new System.Drawing.Size(61, 35);
            this.labLv2.TabIndex = 14;
            this.labLv2.Text = "L30";
            // 
            // labHpVal
            // 
            this.labHpVal.AutoSize = true;
            this.labHpVal.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHpVal.Location = new System.Drawing.Point(330, 371);
            this.labHpVal.Name = "labHpVal";
            this.labHpVal.Size = new System.Drawing.Size(168, 47);
            this.labHpVal.TabIndex = 15;
            this.labHpVal.Text = "100/100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "HP：";
            // 
            // panelatk
            // 
            this.panelatk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelatk.Controls.Add(this.btnatk4);
            this.panelatk.Controls.Add(this.btnatk3);
            this.panelatk.Controls.Add(this.btnatk2);
            this.panelatk.Controls.Add(this.btnatk1);
            this.panelatk.Location = new System.Drawing.Point(12, 301);
            this.panelatk.Name = "panelatk";
            this.panelatk.Size = new System.Drawing.Size(280, 248);
            this.panelatk.TabIndex = 17;
            this.panelatk.Visible = false;
            // 
            // btnatk4
            // 
            this.btnatk4.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnatk4.Location = new System.Drawing.Point(23, 185);
            this.btnatk4.Name = "btnatk4";
            this.btnatk4.Size = new System.Drawing.Size(187, 56);
            this.btnatk4.TabIndex = 21;
            this.btnatk4.Text = "影子分身";
            this.btnatk4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnatk4.UseVisualStyleBackColor = true;
            // 
            // btnatk3
            // 
            this.btnatk3.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnatk3.Location = new System.Drawing.Point(23, 123);
            this.btnatk3.Name = "btnatk3";
            this.btnatk3.Size = new System.Drawing.Size(151, 56);
            this.btnatk3.TabIndex = 20;
            this.btnatk3.Text = "搖尾巴";
            this.btnatk3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnatk3.UseVisualStyleBackColor = true;
            this.btnatk3.Click += new System.EventHandler(this.btnatk3_Click);
            // 
            // btnatk2
            // 
            this.btnatk2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnatk2.Location = new System.Drawing.Point(23, 61);
            this.btnatk2.Name = "btnatk2";
            this.btnatk2.Size = new System.Drawing.Size(100, 56);
            this.btnatk2.TabIndex = 19;
            this.btnatk2.Text = "電擊";
            this.btnatk2.UseVisualStyleBackColor = true;
            this.btnatk2.Click += new System.EventHandler(this.btnatk2_Click);
            // 
            // btnatk1
            // 
            this.btnatk1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnatk1.Location = new System.Drawing.Point(23, 3);
            this.btnatk1.Name = "btnatk1";
            this.btnatk1.Size = new System.Drawing.Size(100, 56);
            this.btnatk1.TabIndex = 18;
            this.btnatk1.Text = "撞擊";
            this.btnatk1.UseVisualStyleBackColor = true;
            this.btnatk1.Click += new System.EventHandler(this.btnatk1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::PokeBattle.Properties.Resources._41;
            this.pictureBox2.Location = new System.Drawing.Point(354, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PokeBattle.Properties.Resources._25;
            this.pictureBox1.Location = new System.Drawing.Point(53, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelskill
            // 
            this.panelskill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelskill.Controls.Add(this.labskillno2);
            this.panelskill.Controls.Add(this.labskilla);
            this.panelskill.Controls.Add(this.labskillb);
            this.panelskill.Controls.Add(this.labskillclass2);
            this.panelskill.Controls.Add(this.labskillclass1);
            this.panelskill.Controls.Add(this.labskillno1);
            this.panelskill.Location = new System.Drawing.Point(400, 243);
            this.panelskill.Name = "panelskill";
            this.panelskill.Size = new System.Drawing.Size(277, 125);
            this.panelskill.TabIndex = 18;
            this.panelskill.Visible = false;
            // 
            // labskillno2
            // 
            this.labskillno2.AutoSize = true;
            this.labskillno2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labskillno2.Location = new System.Drawing.Point(145, 7);
            this.labskillno2.Name = "labskillno2";
            this.labskillno2.Size = new System.Drawing.Size(64, 47);
            this.labskillno2.TabIndex = 7;
            this.labskillno2.Text = "20";
            // 
            // labskilla
            // 
            this.labskilla.AutoSize = true;
            this.labskilla.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labskilla.Location = new System.Drawing.Point(103, 7);
            this.labskilla.Name = "labskilla";
            this.labskilla.Size = new System.Drawing.Size(36, 47);
            this.labskilla.TabIndex = 6;
            this.labskilla.Text = "/";
            // 
            // labskillb
            // 
            this.labskillb.AutoSize = true;
            this.labskillb.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labskillb.Location = new System.Drawing.Point(103, 66);
            this.labskillb.Name = "labskillb";
            this.labskillb.Size = new System.Drawing.Size(36, 47);
            this.labskillb.TabIndex = 5;
            this.labskillb.Text = "/";
            // 
            // labskillclass2
            // 
            this.labskillclass2.AutoSize = true;
            this.labskillclass2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labskillclass2.Location = new System.Drawing.Point(143, 69);
            this.labskillclass2.Name = "labskillclass2";
            this.labskillclass2.Size = new System.Drawing.Size(131, 47);
            this.labskillclass2.TabIndex = 3;
            this.labskillclass2.Text = "電　系";
            // 
            // labskillclass1
            // 
            this.labskillclass1.AutoSize = true;
            this.labskillclass1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labskillclass1.Location = new System.Drawing.Point(3, 69);
            this.labskillclass1.Name = "labskillclass1";
            this.labskillclass1.Size = new System.Drawing.Size(94, 47);
            this.labskillclass1.TabIndex = 2;
            this.labskillclass1.Text = "屬性";
            // 
            // labskillno1
            // 
            this.labskillno1.AutoSize = true;
            this.labskillno1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labskillno1.Location = new System.Drawing.Point(33, 7);
            this.labskillno1.Name = "labskillno1";
            this.labskillno1.Size = new System.Drawing.Size(64, 47);
            this.labskillno1.TabIndex = 0;
            this.labskillno1.Text = "20";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panelatk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelskill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labHpVal);
            this.Controls.Add(this.labLv2);
            this.Controls.Add(this.labName2);
            this.Controls.Add(this.labLV1);
            this.Controls.Add(this.labName1);
            this.Controls.Add(this.labHP1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngiveup);
            this.Controls.Add(this.btnpoke);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnAtk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelatk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelskill.ResumeLayout(false);
            this.panelskill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtk;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnpoke;
        private System.Windows.Forms.Button btngiveup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label labHP1;
        private System.Windows.Forms.Label labName1;
        private System.Windows.Forms.Label labLV1;
        private System.Windows.Forms.Label labName2;
        private System.Windows.Forms.Label labLv2;
        private System.Windows.Forms.Label labHpVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelatk;
        private System.Windows.Forms.Button btnatk4;
        private System.Windows.Forms.Button btnatk3;
        private System.Windows.Forms.Button btnatk2;
        private System.Windows.Forms.Button btnatk1;
        private System.Windows.Forms.Panel panelskill;
        private System.Windows.Forms.Label labskillno2;
        private System.Windows.Forms.Label labskilla;
        private System.Windows.Forms.Label labskillb;
        private System.Windows.Forms.Label labskillclass2;
        private System.Windows.Forms.Label labskillclass1;
        private System.Windows.Forms.Label labskillno1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

