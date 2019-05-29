using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CommonLayer
{
    public class Ticket
    {

        PrintDocument pdoc = null;
        int ticketNo;
        DateTime TicketDate;
        string Source, Destination, DrawnBy;
        float Amount;


        public int TicketNo
        {
            set
            {
                this.ticketNo = value;
            }

            get
            {
                return this.ticketNo;
            }
        }

        public DateTime ticketDate
        {
            set
            {this.TicketDate = value;}

            get
            { return this.TicketDate;}
        }


        public string source
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
            get { return this.DrawnBy; }
        }


        public Ticket()
        {

        }


        public Ticket(int ticketNo, DateTime TicketDate, String Source,
              String Destination, float Amount, String DrawnBy)
        {
            this.ticketNo = ticketNo;
            this.TicketDate = TicketDate;
            this.Source = Source;
            this.Destination = Destination;
            this.Amount = Amount;
            this.DrawnBy = DrawnBy;
        }


        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

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

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("Welcome to MSST", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Ticket No:" + this.TicketNo,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Ticket Date :" + this.ticketDate,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String Source = this.source;
            graphics.DrawString("From " + Source + " To " + Destination, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String Grosstotal = "Total Amount to Pay = " + this.amount;

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(Grosstotal, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String DrawnBy = this.drawnBy;
            graphics.DrawString("Conductor - " + DrawnBy, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
        }
    

}

   
}
