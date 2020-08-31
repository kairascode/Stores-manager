using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace AlpStores
{
    class Printer
    {

        PrintDocument pdoc = null;
        int ticketNo;
        DateTime TicketDate;
        String Source, Destination, DrawnBy;
        float Amount;

        public int TicketNo {
            set { this.ticketNo = value; }
            get { return this.ticketNo; }
        }

        public DateTime ticketDate
        {
            set { this.TicketDate = value; }
            get { return this.TicketDate; }
        }
        public String source
        {
            set { this.Source = value; }
            get { return this.Source; }
        }
        public string destination
        {
            set { this.Destination = value; }
            get { return this.Destination; }
        }

        public float amount
        {
            set { this.Amount = value; }
            get { return this.Amount; }
        }

        public string drawnBy
        {
            set { this.DrawnBy = value; }
            get { return this.drawnBy; }
        }


        public Printer()
        {

        }

        public Printer(int ticketNo, DateTime TicketDate, String Source, String Destination, float Amount, String DrawnBy)
        {
            this.ticketNo = ticketNo;
            this.TicketDate = TicketDate;
            this.Source = Source;
            this.Destination = Destination;
            this.Amount = Amount;
            this.DrawnBy = DrawnBy;

        }

        public void print() {
            try
            {
                PrintDialog pd = new PrintDialog();
                pdoc = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                Font font = new Font("Cambria", 15);

                PaperSize psize = new PaperSize("Custom", 100, 200);

                pd.Document = pdoc;
                pd.Document.DefaultPageSettings.PaperSize = psize;
                pdoc.DefaultPageSettings.PaperSize.Height = 820;
                pdoc.DefaultPageSettings.PaperSize.Width = 820;

                pdoc.PrintPage += new PrintPageEventHandler(pdo_PrintPage);

                DialogResult result = pd.ShowDialog();
                if (result == DialogResult.OK)
                {

                    PrintPreviewDialog pp = new PrintPreviewDialog();
                    pp.Document = pdoc;
                    result = pp.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        pdoc.Print();

                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

}

        void pdo_PrintPage(object sender, PrintPageEventArgs e) {

            Graphics graphics = e.Graphics;

            Font font = new Font("Cambria", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;

            graphics.DrawString("Welcome to MMST" ,new Font("Courier New",14),new SolidBrush(Color.Black),startX,startY+Offset);

            Offset = Offset + 20;


            graphics.DrawString("Ticket No:"+this.TicketNo,new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;

            graphics.DrawString("TicketDate"+this.ticketDate, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;

            String underline = "------------------------------------------------------------------------------------";

            graphics.DrawString(underline, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;

            graphics.DrawString("From"+Source+"Destination"+Destination, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;

            String GrossTotal = "Total Amount to Pay=" + amount;

            Offset = Offset + 20;

             underline = "------------------------------------------------------------------------------------";

            graphics.DrawString(underline, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(GrossTotal, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            String DrawnBy = this.drawnBy;
            graphics.DrawString("CONDUCTOR"+DrawnBy, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
        }
    }
}
