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

        public event Action<string, int> On_card_moved;

        public void Display_cards(IEnumerable<Card> cards)
        {
            if (cards == null)
            {
                return;
            }

            foreach (var card in cards)
            {
                if (card.ColumnIndex == 0)
                {
                    this.AddCardToList(card, this.treeView1);
                }
                else if (card.ColumnIndex == 1)
                {
                    this.AddCardToList(card, this.treeView2);
                }
                else if (card.ColumnIndex == 2)
                {
                    this.AddCardToList(card, this.treeView3);
                }
                else
                {
                    this.AddCardToList(card, this.treeView4);
                }
            }
        }

        private void AddCardToList(Card card, TreeView treeView)
        {
            treeView.Nodes.Add(card.Text);
        }
    }
}
