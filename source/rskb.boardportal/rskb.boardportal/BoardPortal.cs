using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rskb.contracts;

namespace rskb.boardportal
{
    public partial class BoardPortal : Form, IBoardPortal
    {
        public BoardPortal()
        {
            InitializeComponent();
        }

        public void Display_cards(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }

        public event Action<string, int> On_card_moved;
    }
}
