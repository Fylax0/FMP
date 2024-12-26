using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApinProject
{
    public partial class RoundButton : UserControl
    {
        public RoundButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            Rectangle roundButtonRect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            using (Graphics g = e.Graphics)
            {
                g.FillEllipse(Brushes.Black, roundButtonRect);
                if (this.Size == new Size(50, 50))
                {
                    if (this.Font.Name == "Segoe UI")
                    {
                        g.DrawString("▷", new Font(familyName: "Cascadia Code SemiBold", 40), Brushes.Azure, new Point(this.Width / 2 + 4, this.Height / 2 + 4), format);
                    }
                }
                else if (this.Size == new Size(36, 36))
                {
                    if (this.Font.Name == "Times New Roman")
                    {
                        g.DrawString("⏭", new Font(familyName: "Cascadia Code SemiBold", 20), Brushes.Azure, new Point(this.Width / 2, this.Height / 2), format);
                    }
                    else if (this.Font.Name == "Segoe UI")
                    {
                        g.DrawString("⏮", new Font(familyName: "Cascadia Code SemiBold", 20), Brushes.Azure, new Point(this.Width / 2, this.Height / 2), format);
                    }
                }
            }
            base.OnPaint(e);
        }
    }
}
