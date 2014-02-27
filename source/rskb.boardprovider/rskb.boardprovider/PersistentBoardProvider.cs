using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using rskb.contracts;

namespace rskb.boardprovider
{

    public class PersistentBoardProvider : IBoardProvider
    {
        private List<Card> initData = new List<Card>()
                                          {
                                              new Card() { ColumnIndex = 0, Id = "0", Text = "A" },
                                              new Card() { ColumnIndex = 0, Id = "1", Text = "B" },
                                              new Card() { ColumnIndex = 0, Id = "2", Text = "C" },
                                              new Card() { ColumnIndex = 1, Id = "3", Text = "D" },
                                              new Card() { ColumnIndex = 1, Id = "4", Text = "E" },
                                              new Card() { ColumnIndex = 2, Id = "5", Text = "F" },
                                              new Card() { ColumnIndex = 3, Id = "6", Text = "G" },
                                              new Card() { ColumnIndex = 3, Id = "7", Text = "H" },
                                              new Card() { ColumnIndex = 3, Id = "8", Text = "I" },
                                          };

        private String filename;
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));

        public PersistentBoardProvider()
        {
            this.filename = Path.Combine(Path.GetTempPath(), "KanbanCards.xml");
        }

        public PersistentBoardProvider(String filename)
        {
            this.filename = filename;
        }

        public IEnumerable<Card> Load_all_cards()
        {
            if (!File.Exists(this.filename))
            {
                return new List<Card>(this.initData);
            }

            List<Card> board = null;
            using (var stream = new StreamReader(this.filename))
            {
                board = (List<Card>)this.serializer.Deserialize(stream);
            }

            return board;
        }

        public Card LoadCard(string id)
        {
            var board = this.Load_all_cards();
            var existing_card = board.First(c => c.Id == id);
            return existing_card;
        }

        public void StoreCard(Card card)
        {
            var board = this.Load_all_cards().ToList();
            var existing_card = board.FirstOrDefault(c => c.Id == card.Id);
            if (existing_card == null)
            {
                board.Add(card);
            }
            else
            {
                existing_card.ColumnIndex = card.ColumnIndex;
                existing_card.Text = card.Text;
            }

            using (var stream = new StreamWriter(this.filename))
            {
                this.serializer.Serialize(stream, board);
            }
        }
    }
}
