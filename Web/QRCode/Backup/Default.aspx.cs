using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using QuickMark;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
using System.Drawing;
using System.Text;
using System.Net;

namespace QRCode
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text;
            string path = System.Web.HttpContext.Current.Server.MapPath("images");
            string file = path + "\\code.png";
            if (ToQRCode(str, file))
            {
                Image1.ImageUrl = "images/code.png";
                Label1.Text = "生成成功";
            }
            else
                Label1.Text = "生成失败";
        }
        private bool ToQRCode(string str, string filename)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qrCodeEncoder.QRCodeVersion = 7;
            qrCodeEncoder.QRCodeScale = 4;
            //生成图像
            Bitmap image = qrCodeEncoder.Encode(str, Encoding.Default);
            //将image保存到filename
            image.Save(filename);
            return true;
        }
    }
}
