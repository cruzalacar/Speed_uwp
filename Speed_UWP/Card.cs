using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_UWP
{
    enum CardSuit
    {
        d,
        c,
        h,
        s
    }

    class Card
    {
        //HAS-A relatioship shown in the UML diagram as an attribute of Card
        private byte _value;

        //HAS-A relationship shown in the UML diagram as an association relationship
        private CardSuit _suit;

        //Constructor that requires the a value and suit to create a card
        public Card(byte value, CardSuit suit)
        {
            _value = value;
            _suit = suit;
        }

        //define a property for Suit
        public CardSuit Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        //define a property for value
        public byte Value
        {
            get { return _value; }
            set { _value = value; }
        }

        //define a read-only property Name that will provide the name of the card Ace, 2.. 10, Jack,
        //Queen and King
        public string Name
        {
            get
            {
                string cardName;

                //Determine the name of the card based on value
                switch (_value)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                        cardName = _value.ToString();
                        break;


                    default:
                        //Defensive programming against unknown values
                        Debug.Assert(false, "Unknown card value");
                        cardName = "Unknown";
                        break;
                }

                return cardName;
            }

        }

        //accessor method for the _value field variable.  Provided only for comparison to the Value
        //property
        public byte GetValue()
        {
            return _value;
        }

        //mutator method for the _value field variable. Provided only for comparison to the Value
        //property
        public void SetValue(byte value)
        {
            _value = value;
        }

        //accessor method for card suit. Provided only for comparison to the Value
        //property
        public CardSuit GetSuit()
        {
            return _suit;
        }

        //mutator method for the card suit. Provided only for comparison to the Value
        //property
        public void SetSuit(CardSuit suit) //the property will generically call the parameter "value"
        {
            _suit = suit; //the property will generically call the parameter "value"
        }
    }
}
