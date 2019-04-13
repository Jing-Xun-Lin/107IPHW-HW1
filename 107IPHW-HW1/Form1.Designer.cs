namespace _107IPHW_HW1
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
			this._sourcePictureBox = new System.Windows.Forms.PictureBox();
			this.open_image_btn = new System.Windows.Forms.Button();
			this.gray_btn = new System.Windows.Forms.Button();
			this._outputPictureBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.binarization_btn = new System.Windows.Forms.Button();
			this.invert_btn = new System.Windows.Forms.Button();
			this.relief_btn = new System.Windows.Forms.Button();
			this.sharpen_btn = new System.Windows.Forms.Button();
			this.mirror_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._sourcePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._outputPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _sourcePictureBox
			// 
			this._sourcePictureBox.Location = new System.Drawing.Point(35, 42);
			this._sourcePictureBox.Name = "_sourcePictureBox";
			this._sourcePictureBox.Size = new System.Drawing.Size(480, 360);
			this._sourcePictureBox.TabIndex = 0;
			this._sourcePictureBox.TabStop = false;
			// 
			// open_image_btn
			// 
			this.open_image_btn.Location = new System.Drawing.Point(35, 408);
			this.open_image_btn.Name = "open_image_btn";
			this.open_image_btn.Size = new System.Drawing.Size(120, 60);
			this.open_image_btn.TabIndex = 1;
			this.open_image_btn.Text = "開啟影像";
			this.open_image_btn.UseVisualStyleBackColor = true;
			this.open_image_btn.Click += new System.EventHandler(this.open_image_btn_Click);
			// 
			// gray_btn
			// 
			this.gray_btn.Location = new System.Drawing.Point(591, 408);
			this.gray_btn.Name = "gray_btn";
			this.gray_btn.Size = new System.Drawing.Size(100, 50);
			this.gray_btn.TabIndex = 2;
			this.gray_btn.Text = "灰階";
			this.gray_btn.UseVisualStyleBackColor = true;
			this.gray_btn.Click += new System.EventHandler(this.gray_btn_Click);
			// 
			// _outputPictureBox
			// 
			this._outputPictureBox.Location = new System.Drawing.Point(569, 42);
			this._outputPictureBox.Name = "_outputPictureBox";
			this._outputPictureBox.Size = new System.Drawing.Size(480, 360);
			this._outputPictureBox.TabIndex = 3;
			this._outputPictureBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(33, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Source Image";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(565, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Result";
			// 
			// binarization_btn
			// 
			this.binarization_btn.Location = new System.Drawing.Point(751, 408);
			this.binarization_btn.Name = "binarization_btn";
			this.binarization_btn.Size = new System.Drawing.Size(100, 50);
			this.binarization_btn.TabIndex = 6;
			this.binarization_btn.Text = "二值化";
			this.binarization_btn.UseVisualStyleBackColor = true;
			this.binarization_btn.Click += new System.EventHandler(this.binarization_btn_Click);
			// 
			// invert_btn
			// 
			this.invert_btn.Location = new System.Drawing.Point(901, 408);
			this.invert_btn.Name = "invert_btn";
			this.invert_btn.Size = new System.Drawing.Size(100, 50);
			this.invert_btn.TabIndex = 7;
			this.invert_btn.Text = "負片";
			this.invert_btn.UseVisualStyleBackColor = true;
			this.invert_btn.Click += new System.EventHandler(this.invert_btn_Click);
			// 
			// relief_btn
			// 
			this.relief_btn.Location = new System.Drawing.Point(591, 488);
			this.relief_btn.Name = "relief_btn";
			this.relief_btn.Size = new System.Drawing.Size(100, 50);
			this.relief_btn.TabIndex = 8;
			this.relief_btn.Text = "浮雕";
			this.relief_btn.UseVisualStyleBackColor = true;
			this.relief_btn.Click += new System.EventHandler(this.relief_btn_Click);
			// 
			// sharpen_btn
			// 
			this.sharpen_btn.Location = new System.Drawing.Point(751, 488);
			this.sharpen_btn.Name = "sharpen_btn";
			this.sharpen_btn.Size = new System.Drawing.Size(100, 50);
			this.sharpen_btn.TabIndex = 9;
			this.sharpen_btn.Text = "銳化";
			this.sharpen_btn.UseVisualStyleBackColor = true;
			this.sharpen_btn.Click += new System.EventHandler(this.sharpen_btn_Click);
			// 
			// mirror_btn
			// 
			this.mirror_btn.Location = new System.Drawing.Point(901, 488);
			this.mirror_btn.Name = "mirror_btn";
			this.mirror_btn.Size = new System.Drawing.Size(100, 50);
			this.mirror_btn.TabIndex = 10;
			this.mirror_btn.Text = "鏡射";
			this.mirror_btn.UseVisualStyleBackColor = true;
			this.mirror_btn.Click += new System.EventHandler(this.mirror_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 654);
			this.Controls.Add(this.mirror_btn);
			this.Controls.Add(this.sharpen_btn);
			this.Controls.Add(this.relief_btn);
			this.Controls.Add(this.invert_btn);
			this.Controls.Add(this.binarization_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._outputPictureBox);
			this.Controls.Add(this.gray_btn);
			this.Controls.Add(this.open_image_btn);
			this.Controls.Add(this._sourcePictureBox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this._sourcePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._outputPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox _sourcePictureBox;
		private System.Windows.Forms.Button open_image_btn;
		private System.Windows.Forms.Button gray_btn;
		private System.Windows.Forms.PictureBox _outputPictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button binarization_btn;
		private System.Windows.Forms.Button invert_btn;
		private System.Windows.Forms.Button relief_btn;
		private System.Windows.Forms.Button sharpen_btn;
		private System.Windows.Forms.Button mirror_btn;
	}
}

