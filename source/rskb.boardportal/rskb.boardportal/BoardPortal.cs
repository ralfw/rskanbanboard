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
        List<TreeView> treeViews = null;

        public BoardPortal()
        {
            this.InitializeComponent();

            this.treeViews = new List<TreeView>()
            {
                this.treeViewNext,
                this.treeViewProgress,
                this.treeViewQs,
                this.treeViewDone
            };
        }

        public event Action<string, int> On_card_moved;

        public void Display_cards(IEnumerable<Card> cards)
        {
            if (cards == null)
            {
                return;
            }

            this.ClearTreeViews();

            foreach (var card in cards)
            {
                if (card.ColumnIndex == 0)
                {
                    this.AddCardToList(card, this.treeViewNext);
                }
                else if (card.ColumnIndex == 1)
                {
                    this.AddCardToList(card, this.treeViewProgress);
                }
                else if (card.ColumnIndex == 2)
                {
                    this.AddCardToList(card, this.treeViewQs);
                }
                else
                {
                    this.AddCardToList(card, this.treeViewDone);
                }
            }
        }

        private void ClearTreeViews()
        {
            foreach (TreeView tv in this.treeViews)
            {
                tv.Nodes.Clear();
            }
        }

        private void AddCardToList(Card card, TreeView treeView)
        {
            TreeNode addedNode = treeView.Nodes.Add(card.Text);
            addedNode.Tag = card.Id;
        }

        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            // handle only tree nodes
            if (!e.Data.GetDataPresent(typeof(TreeNode)))
            {
                return;
            }

            TreeNode draggedNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;
            if (draggedNode.TreeView != this.treeViewDone &&
                draggedNode.TreeView != this.treeViewNext &&
                draggedNode.TreeView != this.treeViewProgress &&
                draggedNode.TreeView != this.treeViewQs)
            {
                return;
            }

            e.Effect = DragDropEffects.Move;
        }

        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(TreeNode)))
            {
                return;
            }

            TreeNode draggedNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;
            TreeView targetTreeView = sender as TreeView;

            // remove from source view
            draggedNode.Remove();

            // add to target view
            targetTreeView.Nodes.Add(draggedNode);

            if (this.On_card_moved != null)
            {
                this.On_card_moved(draggedNode.Tag.ToString(), this.treeViews.IndexOf(targetTreeView));
            }
        }
    }
}
