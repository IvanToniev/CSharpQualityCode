using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        private string FaceToString() 
        {
            string faceStringified;
            switch (Face)
            {
                case CardFace.Two:
                    {
                        faceStringified = "Two";
                        break;
                    }
                case CardFace.Three:
                    {
                        faceStringified = "Three";
                        break;
                    }
                case CardFace.Four:
                    {
                        faceStringified = "Four";
                        break;
                    }
                case CardFace.Five:
                    {
                        faceStringified = "Five";
                        break;
                    }
                case CardFace.Six:
                    {
                        faceStringified = "Six";
                        break;
                    }
                case CardFace.Seven:
                    {
                        faceStringified = "Seven";
                        break;
                    }
                case CardFace.Eight:
                    {
                        faceStringified = "Eight";
                        break;
                    }
                case CardFace.Nine:
                    {
                        faceStringified = "Nine";
                        break;
                    }
                case CardFace.Ten:
                    {
                        faceStringified = "Ten";
                        break;
                    }
                case CardFace.Jack:
                    {
                        faceStringified = "Jack";
                        break;
                    }
                case CardFace.Queen:
                    {
                        faceStringified = "Queen";
                        break;
                    }
                case CardFace.King:
                    {
                        faceStringified = "King";
                        break;
                    }
                case CardFace.Ace:
                    {
                        faceStringified = "Ace";
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Bad card face!");
                    }
            }

            return faceStringified;
        }

        private string SuitToString() 
        {
            string suitStringified;
            switch (Suit)
            {
                case CardSuit.Clubs:
                    {
                        suitStringified = "Clubs";
                        break;
                    }
                case CardSuit.Diamonds:
                    {
                        suitStringified = "Diamonds";
                        break;
                    }
                case CardSuit.Hearts:
                    {
                        suitStringified = "Hearts";
                        break;
                    }
                case CardSuit.Spades:
                    {
                        suitStringified = "Spades";
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid card suit!");
                    }
            }

            return suitStringified;
        }

        public int CompareTo(object other)
        {
            int thisFace = (int)this.Face;
            int otherFace = (int)((other as Card).Face);
            if (thisFace > otherFace)
            {
                return 1;
            }
            if (thisFace == otherFace)
            {
                return 0;
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (this.Face)
            {
                case CardFace.Two:
                    {
                        sb.Append("2");
                        break;
                    }
                case CardFace.Three:
                    {
                        sb.Append("3");
                        break;
                    }
                case CardFace.Four:
                    {
                        sb.Append("4");
                        break;
                    }
                case CardFace.Five:
                    {
                        sb.Append("5");
                        break;
                    }
                case CardFace.Six:
                    {
                        sb.Append("6");
                        break;
                    }
                case CardFace.Seven:
                    {
                        sb.Append("7");
                        break;
                    }
                case CardFace.Eight:
                    {
                        sb.Append("8");
                        break;
                    }
                case CardFace.Nine:
                    {
                        sb.Append("9");
                        break;
                    }
                case CardFace.Ten:
                    {
                        sb.Append("10");
                        break;
                    }
                case CardFace.Jack:
                    {
                        sb.Append("J");
                        break;
                    }
                case CardFace.Queen:
                    {
                        sb.Append("Q");
                        break;
                    }
                case CardFace.King:
                    {
                        sb.Append("K");
                        break;
                    }
                case CardFace.Ace:
                    {
                        sb.Append("A");
                        break;
                    }
                default:
                    break;
            }

            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    {
                        sb.Append('♣');
                        break;
                    }
                case CardSuit.Diamonds:
                    {
                        sb.Append('♦');
                        break;
                    }
                case CardSuit.Hearts:
                    {
                        sb.Append('♥');
                        break;
                    }
                case CardSuit.Spades:
                    {
                        sb.Append('♠');
                        break;
                    }
                default:
                    break;
            }

            return sb.ToString();
        }
    }
}
