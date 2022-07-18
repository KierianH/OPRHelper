using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCeption
{
    internal class Handler
    {
        public Handler(string font, string fontSize)
        {
            
        }
        
        //WIDTH of default Line in OPR Form
        const float DESIREDLINEWIDTH = 1970.4814F;
        public float GetTextSize(string text, string font, string fontSize)
        {
            Font fullFont = new Font(font, float.Parse(fontSize));
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage); 
            SizeF size = graphics.MeasureString(text, fullFont);
            //MessageBox.Show(size.Width.ToString());
            return size.Width;
        }

        public string FitToLine(string text, string font, string fontSize)
        {
            var handler = new Handler(font,fontSize);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(text);

            //TOO SMALL
            if (handler.GetTextSize(stringBuilder.ToString(),font,fontSize) < DESIREDLINEWIDTH)
            {
                for (int i = 0; i < stringBuilder.Length; i++)
                {
                    var character = stringBuilder[i];
                    if (character == ' ' && handler.GetTextSize(stringBuilder.ToString(), font, fontSize) < DESIREDLINEWIDTH)
                    {
                        stringBuilder.Replace(character, '\u2002', i, 1); //2004 smaller 2003 huge 2001 massive
                    }
                    else if (character == ' ' && handler.GetTextSize(stringBuilder.ToString(), font, fontSize) < DESIREDLINEWIDTH)
                    {
                        stringBuilder.Replace(character, '\u2002', i, 1); //2004 smaller 2003 huge 2001 massive
                    }
                    else if (character == ' ' && handler.GetTextSize(stringBuilder.ToString(), font, fontSize) < DESIREDLINEWIDTH)
                    {
                        stringBuilder.Replace(character, '\u2002', i, 1); //2004 smaller 2003 huge 2001 massive
                    }
                }
            }
            //TOO BIG
            else if (handler.GetTextSize(stringBuilder.ToString(),font,fontSize) > DESIREDLINEWIDTH)
            {
                for (int i = 0; i < stringBuilder.Length; i++)
                {
                    var character = stringBuilder[i];
                    if (character == ' ' && handler.GetTextSize(stringBuilder.ToString(), font, fontSize) > DESIREDLINEWIDTH)
                    {
                        stringBuilder.Replace(character, '\u200A', i, 1); //200A 8202
                    }
                    else if (character == ' ' && handler.GetTextSize(stringBuilder.ToString(), font, fontSize) > DESIREDLINEWIDTH)
                    {
                        stringBuilder.Replace(character, '\u200A', i, 1); //2004 smaller 2003 huge 2001 massive
                    }
                    else if (character == ' ' && handler.GetTextSize(stringBuilder.ToString(), font, fontSize) > DESIREDLINEWIDTH)
                    {
                        stringBuilder.Replace(character, '\u200A', i, 1); //2004 smaller 2003 huge 2001 massive
                    }

                }
            }
            string fittedText = stringBuilder.ToString();
            return fittedText;
        }
    }
}
