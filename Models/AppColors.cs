using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace EasyBizPos.Models
{
    public static class AppColors
    {
        public static readonly System.Drawing.Color black = ColorTranslator.FromHtml("#100F0F");
        public static readonly System.Drawing.Color base950 = ColorTranslator.FromHtml("#1C1B1A");
        public static readonly System.Drawing.Color base900 = ColorTranslator.FromHtml("#282726");
        public static readonly System.Drawing.Color base850 = ColorTranslator.FromHtml("#343331");
        public static readonly System.Drawing.Color base800 = ColorTranslator.FromHtml("#403E3C");
        public static readonly System.Drawing.Color base700 = ColorTranslator.FromHtml("#575653");
        public static readonly System.Drawing.Color base600 = ColorTranslator.FromHtml("#6F6E69");
        public static readonly System.Drawing.Color base500 = ColorTranslator.FromHtml("#878580");
        public static readonly System.Drawing.Color base300 = ColorTranslator.FromHtml("#B7B5AC");
        public static readonly System.Drawing.Color base200 = ColorTranslator.FromHtml("#CECDC3");
        public static readonly System.Drawing.Color base150 = ColorTranslator.FromHtml("#DAD8CE");
        public static readonly System.Drawing.Color base100 = ColorTranslator.FromHtml("#E6E4D9");
        public static readonly System.Drawing.Color base50 = ColorTranslator.FromHtml("#F2F0E5");
        public static readonly System.Drawing.Color paper = ColorTranslator.FromHtml("#FFFCF0");

        // Regular Tones
        public static readonly System.Drawing.Color red600 = ColorTranslator.FromHtml("#AF3029");
        public static readonly System.Drawing.Color orange600 = ColorTranslator.FromHtml("#BC5215");
        public static readonly System.Drawing.Color yellow600 = ColorTranslator.FromHtml("#AD8301");
        public static readonly System.Drawing.Color green600 = ColorTranslator.FromHtml("#66800B");
        public static readonly System.Drawing.Color cyan600 = ColorTranslator.FromHtml("#24837B");
        public static readonly System.Drawing.Color blue600 = ColorTranslator.FromHtml("#205EA6");
        public static readonly System.Drawing.Color purple600 = ColorTranslator.FromHtml("#5E409D");
        public static readonly System.Drawing.Color magenta600 = ColorTranslator.FromHtml("#A02F6F");

        // Light Tones
        public static readonly System.Drawing.Color red400 = ColorTranslator.FromHtml("#D14D41");
        public static readonly System.Drawing.Color orange400 = ColorTranslator.FromHtml("#DA702C");
        public static readonly System.Drawing.Color yellow400 = ColorTranslator.FromHtml("#D0A215");
        public static readonly System.Drawing.Color green400 = ColorTranslator.FromHtml("#879A39");
        public static readonly System.Drawing.Color cyan400 = ColorTranslator.FromHtml("#3AA99F");
        public static readonly System.Drawing.Color blue400 = ColorTranslator.FromHtml("#4385BE");
        public static readonly System.Drawing.Color purple400 = ColorTranslator.FromHtml("#8B7EC8");
        public static readonly System.Drawing.Color magenta400 = ColorTranslator.FromHtml("#CE5D97");

        //set color scheme
        public static readonly System.Drawing.Color bg = black;
        public static readonly System.Drawing.Color bg2 = base950;
        public static readonly System.Drawing.Color ui = base900;
        public static readonly System.Drawing.Color ui2 = base850;
        public static readonly System.Drawing.Color ui3 = base800;
        public static readonly System.Drawing.Color text = base200;
        public static readonly System.Drawing.Color text2 = base500;
    }
}
