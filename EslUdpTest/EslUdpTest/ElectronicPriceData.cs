using SmcEslLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;


namespace EslUdpTest
{
    class ElectronicPriceData
    {

        SmcDataToImage mSmcDataToImage = new SmcDataToImage();
        public Bitmap setPage1(string MacAddress)
        {
            Bitmap bmp = new Bitmap(212, 104);


           /* string[] temp = new string[] { "瑞", "新", "電", "子", "SMC", "Robert", "Lun", "Willy", "永", "晴", "恭", "賀", "Mini", "壓", "單", "提", "剛", "網", "賽", "鑫", "覦", "§"
            , "●", "€", "$", "わ", "ら", "や", "ま", "は", "な", "た", "さ", "か", "あ", "め", "つ", "ち", "の", "â", "ī", "u", "â", "û", "ô", "电", "子", "货", "价", "标", "签", "折"
            , "扣", "特", "殺", "杀", "下", "잘", "지", "냈", "어", "요", "수", "께", "끼", "는", "한", "국", "고", "유의", "언어", "문화적", "ESL", "Special"};
            */

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 212, 104);
            }

            Bitmap bar = new Bitmap(210, 30);
            BarcodeWriter barcode_w = new BarcodeWriter();
            barcode_w.Format = BarcodeFormat.CODE_93;
            barcode_w.Options.Width = 210;
            barcode_w.Options.Height = 30;
            barcode_w.Options.PureBarcode = true;
            bar = barcode_w.Write(MacAddress);
            bmp = mSmcDataToImage.ConvertImageToImage(bmp, bar, 4, 70); //QRcode




            /*   int max = temp.Length-1;
               int min = 0;
               int n = 6;
               Random rnd = new Random();
               int[] ValueString = new int[n];

               string str = "";

               for (int i = 0; i < n; i++)
               {
                   ValueString[i] = rnd.Next(min, max + 1);
                   while (Array.IndexOf(ValueString, ValueString[i], 0, i) > -1)
                   {
                       ValueString[i] = rnd.Next(min, max + 1);
                   }
               }*/
            /* for (int i = 0; i < n; i++)
             {
                 str = str + temp[ValueString[i]];
             }

             t1.Text = str;
             if(str.Length > 6)
             {
                 t1.Font = new Font("Cambria", 17, FontStyle.Bold);
             }else
             {
                 t1.Font = new Font("Cambria", 20, FontStyle.Bold);
             }*/



            /*int b = 0;
            int c = 8;
            Random rNumber = new Random();


            if (rNumber.Next(b, c) == 0) {
                t1.Text = "SMC Lun缺女友";
                t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            }
            else if (rNumber.Next(b, c) == 1)
            {
                t1.Text = "SMC 永晴";
                t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            }
            else if (rNumber.Next(b, c) == 2)
            {
                t1.Text = "SMC Robert神";
                t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            }
            else if (rNumber.Next(b, c) == 3)
            {
                t1.Text = "SMC 冬瓜哥";
                t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            }
            else if (rNumber.Next(b, c) == 4)
            {
                t1.Text = "SMC 晴勇";
                t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            }
            else if (rNumber.Next(b, c) == 5)
            {
                t1.Text = "Willy感謝讚美主";
                t1.Font = new Font("Cambria", 17, FontStyle.Bold);
            }
            else if (rNumber.Next(b, c) == 6) 
            {
                t1.Text = "Willy主賜福於你";
                t1.Font = new Font("Cambria", 17, FontStyle.Bold);
            }
            else 
            {
                t1.Text = "SMC ESL";
                t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            }*/
            TextBox t1 = new TextBox();
            t1.Text = "SMC ESL";
            t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 206;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 1, 0);

            String StrName = String.Format("{0}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            t1.Text = StrName;
            t1.Font = new Font("Cambria", 15, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 206;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 2, 23);


            t1.Text = MacAddress;
            t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 206;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Black, 2, 40);




            return bmp;
        }

        public Bitmap setESLimage(string MacAddress, string battery)
        {
            Bitmap bmp = new Bitmap(212, 104);

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 212, 104);
            }

            Bitmap bar = new Bitmap(210, 30);
            BarcodeWriter barcode_w = new BarcodeWriter();
            barcode_w.Format = BarcodeFormat.CODE_93;
            barcode_w.Options.Width = 210;
            barcode_w.Options.Height = 30;
            barcode_w.Options.PureBarcode = true;
            bar = barcode_w.Write(MacAddress);
            bmp = mSmcDataToImage.ConvertImageToImage(bmp, bar, 4, 70); //QRcode

            TextBox t1 = new TextBox();
            t1.Text = "SMC ESL  " + battery + " V";
            t1.Font = new Font("Cambria", 18, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 206;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 1, 0);

            String StrName = String.Format("{0}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            t1.Text = StrName;
            t1.Font = new Font("Cambria", 15, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 206;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 2, 23);


            t1.Text = MacAddress;
            t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 206;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Black, 2, 40);

            return bmp;
        }


        public Bitmap setESLimage_29(string MacAddress, string battery)
        {
            Bitmap bmp = new Bitmap(296, 128);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 296, 128);
            }

            Bitmap bar = new Bitmap(290, 50);
            BarcodeWriter barcode_w = new BarcodeWriter();
            barcode_w.Format = BarcodeFormat.CODE_93;
            barcode_w.Options.Width = 296;
            barcode_w.Options.Height = 40;
            barcode_w.Options.PureBarcode = true;
            bar = barcode_w.Write(MacAddress);
            bmp = mSmcDataToImage.ConvertImageToImage(bmp, bar, 4, 85); //QRcode

            TextBox t1 = new TextBox();
            t1.Text = "SMC ESL  " + battery + " V";
            t1.Font = new Font("Cambria", 26, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 280;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 1, 0);

            String StrName = String.Format("{0}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            t1.Text = StrName;
            t1.Font = new Font("Cambria", 15, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 280;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 2, 35);


            t1.Text = MacAddress;
            t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 280;
            t1.Height = 25;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Black, 2, 53);




            return bmp;
        }
        public Bitmap setESLimage_42(string MacAddress, string battery)
        {
            Bitmap bmp = new Bitmap(400, 300);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 400, 300);
            }

           

            TextBox t1 = new TextBox();
            t1.Text = "SMC ESL  " + battery + " V";
            t1.Font = new Font("Cambria", 38, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 380;
            t1.Height = 40;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 1, 0);

            String StrName = String.Format("{0}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            t1.Text = StrName;
            t1.Font = new Font("Cambria", 20, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 380;
            t1.Height = 40;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Red, 2, 60);


            t1.Text = MacAddress;
            t1.Font = new Font("Cambria", 26, FontStyle.Bold);
            t1.TextAlign = HorizontalAlignment.Center; //置中
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Width = 380;
            t1.Height = 40;
            bmp = mSmcDataToImage.ConvertTextToImage(bmp, t1, Color.Black, 2, 85);

            Bitmap bar = new Bitmap(400, 80);
            BarcodeWriter barcode_w = new BarcodeWriter();
            barcode_w.Format = BarcodeFormat.CODE_93;
            barcode_w.Options.Width = 400;
            barcode_w.Options.Height = 80;
            barcode_w.Options.PureBarcode = true;
            bar = barcode_w.Write(MacAddress);
            bmp = mSmcDataToImage.ConvertImageToImage(bmp, bar, 4, 210); //QRcode


            Bitmap qr = new Bitmap(400, 70);
          
            barcode_w.Format = BarcodeFormat.QR_CODE;
            barcode_w.Options.Width = 400;
            barcode_w.Options.Height = 70;
            barcode_w.Options.PureBarcode = true;
            bar = barcode_w.Write("http://www.smartchip.com.tw/");
            bmp = mSmcDataToImage.ConvertImageToImage(bmp, bar, 4, 130); //QRcode



            return bmp;
        }
    }
}
