using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace _107IPHW_HW1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            mirror_btn.Click += mirror_btn_Click;
        }

		Image<Bgr, Byte> inputImage;

		byte b, g, r;
        byte MAX = 255, MIN = 0;

		private void binarization_btn_Click(object sender, EventArgs e)
		{
            Image<Bgr, Byte> _Image = gray_process();
            byte value = 125;

            for (int x = 0; x < _Image.Rows; x++)
            {
                for (int y = 0; y < _Image.Cols; y++)
                {
                    if ((_Image.Data[x, y, 0] + _Image.Data[x, y, 1] + _Image.Data[x, y, 2]) / 3 >= value)
                    {
                        _Image.Data[x, y, 0] = _Image.Data[x, y, 1] = _Image.Data[x, y, 2] = MAX;
                    }
                    else
                    {
                        _Image.Data[x, y, 0] = _Image.Data[x, y, 1] = _Image.Data[x, y, 2] = MIN;
                    }
                }
            }
            _outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _outputPictureBox.Image = _Image.ToBitmap();
        }

		private void invert_btn_Click(object sender, EventArgs e)
		{
            Image<Bgr, Byte> _Image = inputImage.Clone();

            for (int x = 0; x < _Image.Rows; x++)
            {
                for (int y = 0; y < _Image.Cols; y++)
                {
                    _Image.Data[x, y, 0] = (byte)(MAX - _Image.Data[x, y, 0]);
                    _Image.Data[x, y, 1] = (byte)(MAX - _Image.Data[x, y, 1]);
                    _Image.Data[x, y, 2] = (byte)(MAX - _Image.Data[x, y, 2]);
                }
            }
            _outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _outputPictureBox.Image = _Image.ToBitmap();
        }

		private void relief_btn_Click(object sender, EventArgs e)
		{
            Image<Bgr, Byte> _Image = inputImage.Clone();

            for (int x = 0; x < _Image.Rows - 1; x++)
            {
                for (int y = 0; y < _Image.Cols - 1; y++)
                {
                    b = (byte)Math.Abs(_Image.Data[x, y, 0] - _Image.Data[x + 1, y + 1, 0] + 128);
                    g = (byte)Math.Abs(_Image.Data[x, y, 1] - _Image.Data[x + 1, y + 1, 1] + 128);
                    r = (byte)Math.Abs(_Image.Data[x, y, 2] - _Image.Data[x + 1, y + 1, 2] + 128);
                    _Image.Data[x, y, 0] = (byte)(Math.Min(Math.Max(b, MIN), MAX));
                    _Image.Data[x, y, 1] = (byte)(Math.Min(Math.Max(g, MIN), MAX));
                    _Image.Data[x, y, 2] = (byte)(Math.Min(Math.Max(r, MIN), MAX));
                }
            }
            _outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _outputPictureBox.Image = _Image.ToBitmap();
        }

		private void sharpen_btn_Click(object sender, EventArgs e)
		{
            Image<Bgr, Byte> _Image = inputImage.Clone();
            int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            int b, g, r;

            for (int x = 1; x < _Image.Rows - 1; x++)
            {
                for (int y = 1; y < _Image.Cols - 1; y++)
                {
                    b = g = r = 0;
                    int Index = 0;
                    for (int row = -1; row <= 1; row++)
                    {
                        for (int col = -1; col <= 1; col++)
                        {
                            b += _Image.Data[x + row, y + col, 0] * Laplacian[Index];
                            g += _Image.Data[x + row, y + col, 1] * Laplacian[Index];
                            r += _Image.Data[x + row, y + col, 2] * Laplacian[Index];
                            Index++;
                        }
                    }
                    _Image.Data[x - 1, y - 1, 0] = (byte)(Math.Min(Math.Max(b, MIN), MAX));
                    _Image.Data[x - 1, y - 1, 1] = (byte)(Math.Min(Math.Max(g, MIN), MAX));
                    _Image.Data[x - 1, y - 1, 2] = (byte)(Math.Min(Math.Max(r, MIN), MAX));
                }
            }
            _outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _outputPictureBox.Image = _Image.ToBitmap();
        }

        private void swap(ref byte a, ref byte b)
        {
            byte tmp = a;
            a = b;
            b = tmp;
        }

		private void mirror_btn_Click(object sender, EventArgs e)
		{
            Image<Bgr, Byte> _Image = inputImage.Clone();

            for (int x = 0; x < _Image.Rows; x++)
            {
                for (int y = 0; y < _Image.Cols / 2; y++)
                {
                    swap(ref _Image.Data[x, y, 0], ref _Image.Data[x, _Image.Cols - y - 1, 0]);
                    swap(ref _Image.Data[x, y, 1], ref _Image.Data[x, _Image.Cols - y - 1, 1]);
                    swap(ref _Image.Data[x, y, 2], ref _Image.Data[x, _Image.Cols - y - 1, 2]);

                }
            }
            _outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _outputPictureBox.Image = _Image.ToBitmap();
        }

		private void open_image_btn_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select file";
			dialog.InitialDirectory = ".\\";
			dialog.Filter = "所有合適文件(*.bmp, *.jpg *.png) | *.bmp; *.jpg; *.png";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				inputImage = new Image<Bgr, byte>(dialog.FileName);
				_sourcePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				_sourcePictureBox.Image = inputImage.ToBitmap();
			}
		}

		private void gray_btn_Click(object sender, EventArgs e)
		{
            Image<Bgr, Byte> _Image = gray_process();
			_outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			_outputPictureBox.Image = _Image.ToBitmap();
		}

        private Image<Bgr, Byte> gray_process()
        {
            Image<Bgr, Byte> _Image = inputImage.Clone();

            for (int x = 0; x < _Image.Rows; x++)
            {
                for (int y = 0; y < _Image.Cols; y++)
                {
                    b = _Image.Data[x, y, 0];
                    g = _Image.Data[x, y, 1];
                    r = _Image.Data[x, y, 2];

                    byte grayScale = (byte)((b * 0.3) + (g * 0.59) + (r * 0.11));

                    _Image.Data[x, y, 0] = grayScale;
                    _Image.Data[x, y, 1] = grayScale;
                    _Image.Data[x, y, 2] = grayScale;
                }
            }

            return _Image;
        }
	}
}
