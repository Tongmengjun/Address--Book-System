using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace 通讯录信息管路系统
{
    public partial class DataGViewX : DataGridView
    {
         public DataGViewX()
         {
             InitializeComponent();
             this.SetStyle(ControlStyles.UserPaint, true);//用户自己绘制
             this.SetStyle(ControlStyles.ResizeRedraw, true);
             this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
             this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
             this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
         }
 
         private System.ComponentModel.IContainer components = null;
         protected override void Dispose(bool disposing)
         {
             if (disposing && (components != null))
            {
                 components.Dispose();
             }
             base.Dispose(disposing);
         }
         private void InitializeComponent()
         {
             components = new System.ComponentModel.Container();
         }
[DescriptionAttribute("自定义背景图：当BackTransparent=True时，忽略此设置，直接使用父容器背景")]
[EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
         public Image BackImage { get; set; }

[DescriptionAttribute("背景透明：当True时，直接使用父容器背景。否则使用BackImage填充背景")]
[EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
         public bool BackTransparent { get; set; } = true;

         protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
         {
             base.PaintBackground(graphics, clipBounds, gridBounds);
             if (BackTransparent)
                 BackImage = GetBackImage(this.Parent, this.Left, this.Top, this.Width, this.Height);
             if (BackImage != null)
                 graphics.DrawImage(BackImage, clipBounds);
         }

         public Bitmap GetBackImage(Control parent, int x, int y, int w, int h)
         {
             if (parent.BackgroundImage != null)
             {
                 Bitmap bt = new Bitmap(parent.Width, parent.Height);
                 PictureBox pb = new PictureBox();
                 pb.Size = parent.Size;
                 pb.BackgroundImage = parent.BackgroundImage;
                 pb.BackgroundImageLayout = parent.BackgroundImageLayout;
                 pb.DrawToBitmap(bt, pb.DisplayRectangle);
                 pb.Dispose();
                 Bitmap destBitmap = new Bitmap(w, h);
                 Graphics g = Graphics.FromImage(destBitmap);
                 g.DrawImage(bt, new Rectangle(0, 0, w, h), new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
                 bt.Dispose();
                 g.Dispose();
                 return destBitmap;
               }
               else
                   return null;
           }
     }

}
