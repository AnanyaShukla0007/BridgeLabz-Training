using System;
using FutureLogistics.Models;
using FutureLogistics.Utilities;

namespace FutureLogistics.Menu
{
    public class UserInterface
    {
        public void Start()
        {
            Console.WriteLine("Enter the Goods Transport details");
            string input = Console.ReadLine();

            Utility util = new Utility();
            GoodsTransport gt = util.parseDetails(input);

            if (!util.validateTransportId(gt.TransportId))
                return;

            Console.WriteLine("Transporter id : " + gt.TransportId);
            Console.WriteLine("Date of transport : " + gt.TransportDate);
            Console.WriteLine("Rating of the transport : " + gt.TransportRating);

            string type = util.findObjectType(gt);

            if (type == "BrickTransport")
            {
                BrickTransport bt = (BrickTransport)gt;
                Console.WriteLine("Quantity of bricks : " + bt.BrickQuantity);
                Console.WriteLine("Brick price : " + bt.BrickPrice);
            }
            else
            {
                TimberTransport tt = (TimberTransport)gt;
                Console.WriteLine("Type of the timber : " + tt.GetType().GetProperty("timberType"));
                Console.WriteLine("Timber price per kilo : " + input.Split(':')[7]);
            }

            Console.WriteLine("Vehicle for transport : " + gt.vehicleSelection());
            Console.WriteLine("Total charge : " + gt.calculateTotalCharge());
        }
    }
}
