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
        /// <summary>
        /// Tcollection holding references on the tree-views in the correct order
        /// </summary>
        List<TreeView> treeViews = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardPortal"/> class.
        /// </summary>
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

            // prepare the environment to handle "f5" for refreshing
            this.KeyPreview = true;
            this.KeyDown += BoardPortal_KeyDown;
        }

        /// <summary>
        /// Occurs when a card is moved.
        /// </summary>
        public event Action<string, int> On_card_moved;

        /// <summary>
        /// Occurs when a card is added.
        /// </summary>
        public event Action<string, int> On_new_card;

        /// <summary>
        /// Occurs when the UI has to be refreshed.
        /// </summary>
        public event Action On_refresh;

        /// <summary>
        /// Displays the specified cards.
        /// </summary>
        /// <param name="cards">The cards collection.</param>
        public void Display_cards(IEnumerable<Card> cards)
        {
            if (cards == null)
            {
                return;
            }

            // reset theUI
            this.ResetUI();

            // add the cards to the tree-view
            foreach (var card in cards)
            {
                try
                {
                    // the column index corresponds to the index of the corresponding tree-view in the local tree-views list
                    this.AddCardToList(card, this.treeViews[card.ColumnIndex]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    // ToDo: error handling is to be defined
                    Console.WriteLine("the column index is out-of range");
                }
            }
        }

        /// <summary>
        /// Resets the UI.
        /// </summary>
        private void ResetUI()
        {
            foreach (TreeView tv in this.treeViews)
            {
                tv.Nodes.Clear();
            }
        }

        /// <summary>
        /// Adds the card to the corresponding tree-view.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <param name="treeView">The tree view.</param>
        private void AddCardToList(Card card, TreeView treeView)
        {
            TreeNode addedNode = treeView.Nodes.Add(card.Text);

            // the ID is handled buy the mean of the node's Tag
            addedNode.Tag = card.Id;
        }

        /// <summary>
        /// Handles the ItemDrag event of the treeView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemDragEventArgs"/> instance containing the event data.</param>
        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        /// <summary>
        /// Handles the DragOver event of the treeView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            // handle only tree nodes
            if (!e.Data.GetDataPresent(typeof(TreeNode)))
            {
                return;
            }

            // drag & drop only items that are defined within the UI
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

        /// <summary>
        /// Handles the DragDrop event of the treeView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof (TreeNode))) return;

            var draggedNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;
            var targetTreeView = sender as TreeView;

            this.On_card_moved(draggedNode.Tag.ToString(), this.treeViews.IndexOf(targetTreeView));
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.AddNewCard(0);
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.AddNewCard(1);
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.AddNewCard(2);
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.AddNewCard(3);
        }

        /// <summary>
        /// Adds the new card to the concerned column
        /// </summary>
        /// <param name="columnIndex">Index of the column.</param>
        private void AddNewCard(int columnIndex)
        {
            NewCardDialog dlg = new NewCardDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            this.On_new_card(dlg.Description, columnIndex);
        }

        /// <summary>
        /// Handles the Click event of the button5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.On_refresh();
        }

        /// <summary>
        /// Handles the KeyDown event of the BoardPortal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        void BoardPortal_KeyDown(object sender, KeyEventArgs e)
        {
            // refresh on F5
            if (e.KeyCode == Keys.F5)
            {
                this.On_refresh();
            }
        }
    }
}
