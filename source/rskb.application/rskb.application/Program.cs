using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using rskb.board;
using rskb.boardportal;
using rskb.boardprovider;
using rskb.contracts;

namespace rskb.application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var ts = new TraceSource("rskb.application", SourceLevels.All);
            ts.TraceInformation("Build");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var portal = new BoardPortal();
            var prov = new PersistentBoardProvider("cards.xml");
            var board = new Board();
            var ctl = new boardcontroller.BoardController(board, prov, portal);

            ts.TraceInformation("Bind");
            portal.On_card_moved += (id, index) => {
                var all_cards = ctl.Move_card(id, index);
                portal.Display_cards(all_cards);
            };

            ts.TraceInformation("Run");
            Start(prov, portal);

            ts.TraceInformation("Show");
            Application.Run(portal);
        }


        private static void Start(IBoardProvider prov, IBoardPortal portal)
        {
            var cards = prov.Load_all_cards();
            portal.Display_cards(cards);
        }
    }
}
