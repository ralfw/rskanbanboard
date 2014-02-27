using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using nblackbox;
using nblackbox.contract;
using rskb.board;
using rskb.boardcontroller;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var ts = new TraceSource("rskb.application", SourceLevels.All);
            var di = new SimpleInjector.Container();

            ts.TraceInformation("Build");
            var blackboxfolderpath = ConfigurationManager.AppSettings["blackboxfolderpath"];
            di.RegisterSingle<IBlackBox>(() => new FileBlackBox(blackboxfolderpath));
            di.RegisterSingle(typeof (IBoardPortal), typeof (BoardPortal));
            di.RegisterSingle(typeof(IBoardProvider2), typeof(EventstoreBoardprovider));
            di.RegisterSingle(typeof(IBoard2), typeof(Board2));
            di.RegisterSingle(typeof (IBoardController), typeof (BoardController2));

            var prov = di.GetInstance<IBoardProvider2>();
            var portal = di.GetInstance<IBoardPortal>();
            var ctl = di.GetInstance<IBoardController>();

            ts.TraceInformation("Bind");
            portal.On_card_moved += ctl.Move_card;
            portal.On_new_card += ctl.Create_card;
            portal.On_refresh += ctl.Refresh;

            ctl.On_cards_changed += portal.Display_cards;

            ts.TraceInformation("Run");
            Start(prov, portal);

            ts.TraceInformation("Show");
            Application.Run(portal as Form);
        }


        private static void Start(IBoardProvider2 prov, IBoardPortal portal)
        {
            var cards = prov.Load_all_cards();
            portal.Display_cards(cards);
        }
    }
}
