using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tx_sample_line_numbering_gdi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textControl1.ButtonBar = buttonBar1;
            textControl1.RulerBar = rulerBar1;
            textControl1.VerticalRulerBar = rulerBar2;
            textControl1.StatusBar = statusBar1;
        }

        private Brush LINE_COLOR = new SolidBrush(Color.Gray);
        private int LINE_START_OFFSET = 500;

        private void setLineNumbering()
        {
            textControl1.Refresh();

            Graphics g = textControl1.CreateGraphics();

            //iterates all lines
            foreach (TXTextControl.Line line in textControl1.Lines)
            {
                //left position of current line minus offset so that the line number is displayed next to the current line
                int left = line.TextBounds.X - LINE_START_OFFSET;
                //top position of the current line
                int top = line.TextBounds.Top;
                //converts the positon of the current line to client coordinates
                Point p = textControl1.DocumentToClient(new Point(left, top));
                
                PointF pos = new PointF(p.X , p.Y);

                //draws line number to the specified position
                g.DrawString(line.Number.ToString() + ":",
                    new Font(textControl1.Font.Name, textControl1.Font.Size),
                    LINE_COLOR, pos);
            }
        }

        private void textControl1_Changed(object sender, EventArgs e)
        {
            setLineNumbering();
        }

        private void textControl1_InputPositionChanged(object sender, EventArgs e)
        {
            setLineNumbering();
        }

        private void textControl1_VScroll(object sender, EventArgs e)
        {
            setLineNumbering();
        }

        private void textControl1_HScroll(object sender, EventArgs e)
        {
            setLineNumbering();
        }       
    }
}