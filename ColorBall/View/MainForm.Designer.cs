namespace ColorBall.View
{
	partial class MainForm
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
			this.GenerateButton = new System.Windows.Forms.Button();
			this.RedBallGroupBox = new System.Windows.Forms.GroupBox();
			this.Ball6label = new System.Windows.Forms.Label();
			this.Ball4label = new System.Windows.Forms.Label();
			this.Ball5label = new System.Windows.Forms.Label();
			this.Ball3label = new System.Windows.Forms.Label();
			this.Ball2label = new System.Windows.Forms.Label();
			this.Ball1label = new System.Windows.Forms.Label();
			this.BlueBallGroupBox = new System.Windows.Forms.GroupBox();
			this.Ball7label = new System.Windows.Forms.Label();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.ResetButton = new System.Windows.Forms.Button();
			this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
			this.RedBallGroupBox.SuspendLayout();
			this.BlueBallGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(1175, 484);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(129, 41);
			this.GenerateButton.TabIndex = 0;
			this.GenerateButton.Text = "生成";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// RedBallGroupBox
			// 
			this.RedBallGroupBox.Controls.Add(this.Ball6label);
			this.RedBallGroupBox.Controls.Add(this.Ball4label);
			this.RedBallGroupBox.Controls.Add(this.Ball5label);
			this.RedBallGroupBox.Controls.Add(this.Ball3label);
			this.RedBallGroupBox.Controls.Add(this.Ball2label);
			this.RedBallGroupBox.Controls.Add(this.Ball1label);
			this.RedBallGroupBox.Location = new System.Drawing.Point(12, 12);
			this.RedBallGroupBox.Name = "RedBallGroupBox";
			this.RedBallGroupBox.Size = new System.Drawing.Size(1169, 183);
			this.RedBallGroupBox.TabIndex = 1;
			this.RedBallGroupBox.TabStop = false;
			this.RedBallGroupBox.Text = "红球";
			// 
			// Ball6label
			// 
			this.Ball6label.AutoSize = true;
			this.Ball6label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball6label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Ball6label.Location = new System.Drawing.Point(961, 26);
			this.Ball6label.Name = "Ball6label";
			this.Ball6label.Size = new System.Drawing.Size(191, 134);
			this.Ball6label.TabIndex = 5;
			this.Ball6label.Text = "00";
			// 
			// Ball4label
			// 
			this.Ball4label.AutoSize = true;
			this.Ball4label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball4label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Ball4label.Location = new System.Drawing.Point(579, 26);
			this.Ball4label.Name = "Ball4label";
			this.Ball4label.Size = new System.Drawing.Size(191, 134);
			this.Ball4label.TabIndex = 4;
			this.Ball4label.Text = "00";
			// 
			// Ball5label
			// 
			this.Ball5label.AutoSize = true;
			this.Ball5label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball5label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Ball5label.Location = new System.Drawing.Point(770, 26);
			this.Ball5label.Name = "Ball5label";
			this.Ball5label.Size = new System.Drawing.Size(191, 134);
			this.Ball5label.TabIndex = 3;
			this.Ball5label.Text = "00";
			// 
			// Ball3label
			// 
			this.Ball3label.AutoSize = true;
			this.Ball3label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball3label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Ball3label.Location = new System.Drawing.Point(388, 26);
			this.Ball3label.Name = "Ball3label";
			this.Ball3label.Size = new System.Drawing.Size(191, 134);
			this.Ball3label.TabIndex = 2;
			this.Ball3label.Text = "00";
			// 
			// Ball2label
			// 
			this.Ball2label.AutoSize = true;
			this.Ball2label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball2label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Ball2label.Location = new System.Drawing.Point(197, 26);
			this.Ball2label.Name = "Ball2label";
			this.Ball2label.Size = new System.Drawing.Size(191, 134);
			this.Ball2label.TabIndex = 1;
			this.Ball2label.Text = "00";
			// 
			// Ball1label
			// 
			this.Ball1label.AutoSize = true;
			this.Ball1label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball1label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Ball1label.Location = new System.Drawing.Point(6, 26);
			this.Ball1label.Name = "Ball1label";
			this.Ball1label.Size = new System.Drawing.Size(191, 134);
			this.Ball1label.TabIndex = 0;
			this.Ball1label.Text = "00";
			// 
			// BlueBallGroupBox
			// 
			this.BlueBallGroupBox.Controls.Add(this.Ball7label);
			this.BlueBallGroupBox.Location = new System.Drawing.Point(1221, 12);
			this.BlueBallGroupBox.Name = "BlueBallGroupBox";
			this.BlueBallGroupBox.Size = new System.Drawing.Size(274, 183);
			this.BlueBallGroupBox.TabIndex = 2;
			this.BlueBallGroupBox.TabStop = false;
			this.BlueBallGroupBox.Text = "蓝球";
			// 
			// Ball7label
			// 
			this.Ball7label.AutoSize = true;
			this.Ball7label.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Ball7label.ForeColor = System.Drawing.Color.Blue;
			this.Ball7label.Location = new System.Drawing.Point(50, 26);
			this.Ball7label.Name = "Ball7label";
			this.Ball7label.Size = new System.Drawing.Size(191, 134);
			this.Ball7label.TabIndex = 6;
			this.Ball7label.Text = "00";
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Location = new System.Drawing.Point(31, 264);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(29, 12);
			this.ResultLabel.TabIndex = 3;
			this.ResultLabel.Text = "结果";
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(1333, 484);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(129, 41);
			this.ResetButton.TabIndex = 5;
			this.ResetButton.Text = "重置";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// ResultRichTextBox
			// 
			this.ResultRichTextBox.Font = new System.Drawing.Font("SimSun", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ResultRichTextBox.Location = new System.Drawing.Point(33, 291);
			this.ResultRichTextBox.Multiline = false;
			this.ResultRichTextBox.Name = "ResultRichTextBox";
			this.ResultRichTextBox.ReadOnly = true;
			this.ResultRichTextBox.Size = new System.Drawing.Size(707, 80);
			this.ResultRichTextBox.TabIndex = 6;
			this.ResultRichTextBox.Text = "00,00,00,00,00,00,00";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1507, 537);
			this.Controls.Add(this.ResultRichTextBox);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.BlueBallGroupBox);
			this.Controls.Add(this.RedBallGroupBox);
			this.Controls.Add(this.GenerateButton);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.RedBallGroupBox.ResumeLayout(false);
			this.RedBallGroupBox.PerformLayout();
			this.BlueBallGroupBox.ResumeLayout(false);
			this.BlueBallGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.GroupBox RedBallGroupBox;
		private System.Windows.Forms.Label Ball6label;
		private System.Windows.Forms.Label Ball4label;
		private System.Windows.Forms.Label Ball5label;
		private System.Windows.Forms.Label Ball3label;
		private System.Windows.Forms.Label Ball2label;
		private System.Windows.Forms.Label Ball1label;
		private System.Windows.Forms.GroupBox BlueBallGroupBox;
		private System.Windows.Forms.Label Ball7label;
		private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.RichTextBox ResultRichTextBox;
	}
}