using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmcEslLib
{
    public class SmcDataToImage
    {

        //**************
        public Bitmap ConvertTextToImage(Bitmap mbmp, TextBox textbox, Color textcolor, int x, int y)
        {
            using (Graphics graphics = Graphics.FromImage(mbmp))
            {
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                StringFormat drawFormat = new StringFormat();
                if (textbox.TextAlign == HorizontalAlignment.Center) //置中
                {
                    //置中x座標+box寬度/2  ， StringAlignment.Center= 讓文字以做標點為中心
                    drawFormat.Alignment = StringAlignment.Center;
                    graphics.DrawString(textbox.Text, textbox.Font, new SolidBrush(textcolor), x + textbox.Width / 2, y, drawFormat);
                }
                else if (textbox.TextAlign == HorizontalAlignment.Right) //置右
                {
                    drawFormat.Alignment = StringAlignment.Far;
                    graphics.DrawString(textbox.Text, textbox.Font, new SolidBrush(textcolor), x + textbox.Width, y, drawFormat);
                }
                else //置左
                {
                    graphics.DrawString(textbox.Text, textbox.Font, new SolidBrush(textcolor), x, y);
                }

                graphics.Flush();
                graphics.Dispose();
            }
            return mbmp;
        }
        public Bitmap ConvertTextToImage(Bitmap mbmp, Label label, Color textcolor, int x, int y)
        {
            using (Graphics graphics = Graphics.FromImage(mbmp))
            {
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                graphics.DrawString(label.Text, label.Font, new SolidBrush(textcolor), x, y);
                graphics.Flush();
                graphics.Dispose();
            }
            return mbmp;
        }
        //直接輸入中文
        public Bitmap ConvertTextToImage(Bitmap mbmp, string txt, Font font1, Color textcolor, int x, int y)
        {
            using (Graphics graphics = Graphics.FromImage(mbmp))
            {
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                graphics.DrawString(txt, font1, new SolidBrush(textcolor), x, y);
                graphics.Flush();
                graphics.Dispose();
            }
            return mbmp;
        }


        public Bitmap ConvertBoxToImage(Bitmap mbmp, Label label, Color textcolor, int x, int y)
        {
            using (Graphics graphics = Graphics.FromImage(mbmp))
            {

                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

                SolidBrush blackPen = new SolidBrush(label.BackColor);
                Rectangle rect = new Rectangle(x, y, 65, 19);
                graphics.FillRectangle(blackPen, rect);


                graphics.DrawString(label.Text, label.Font, new SolidBrush(textcolor), x, y);
                graphics.Flush();
                graphics.Dispose();
            }
            return mbmp;
        }



        //**************
        public Bitmap ConvertImageToImage(Bitmap mbmp, Bitmap img, int x, int y)
        {

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    int ttt = (color.R + color.B + color.G) / 3;
                    if (ttt < 180)
                    {
                        mbmp.SetPixel(i + x, j + y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            return mbmp;
        }


    }
}
