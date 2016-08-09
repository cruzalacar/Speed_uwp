using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_UWP
{
    class Game
    {
        //The deck as a list of cards
        public List<Card> _cardDeck;
        public List<string> _Deck = new List<string>();

        //Define a constructor the Game class to create the deck
        public Game()
        {
            //create the card deck object
            _cardDeck = new List<Card>();

            //add the cards to the deck using a counted loop (for)
            CreateCards();
        }

        public int CardCount
        {
            get
            {
                return _cardDeck.Count;
            }
        }

        private void CreateCards()
        {
            //add the cards to the deck using a counted loop (for)
            //REPEAT for each suit
            //for(CardSuit suit = CardSuit.Diamond; suit <= CardSuit.Spade; suit++)
            for (int suitCounter = 0; suitCounter < 4; suitCounter++)
            {
                //get the suit value
                CardSuit suit = (CardSuit)suitCounter;

                //REPEAT going through every card value
                for (byte cardValue = 1; cardValue <= 13; cardValue++)
                {
                    //put together the value with the suit INTO a CARD object
                    Card card = new Card(cardValue, suit);


                    //add the card to the deck
                    _cardDeck.Add(card);

                    Play list = new Play();
                }
            }
            foreach (Card card in _cardDeck)
            {
                _Deck.Add(card.Suit.ToString() + card.Name.ToString());
            }
        }

        public void PrintDeck()
        {
            int i = 0;
            Play c = new Play();

            //Print the deck of cards. Each card is printed as "value of suit"
            //REPEAT through each card in the deck
            foreach (Card card in _cardDeck)
            {

                //print the name and value of the card (e.g. "Ace of Spades", 10 of Diamonds)
                Array _deck = Array.CreateInstance(typeof(String), 52);

                string carder = card.Suit + card.Name;
                _deck.SetValue(carder, i);
                i++;


                //Console.WriteLine("{0} of {1}", card.Name, card.Suit);
            }
        }

        public void ShuffleDeck()
        {
            //TODO: re-arrange the card list to randomize the deck (i.e.  for the amount
            //of cards in the deck, move the positions of the card randomly). How? 
            Random r = new Random();
            //create a random object to generate random nubmers to generate random positions
            //REPEAT processing each position in the deck
            for (int n = _Deck.Count - 1; n > 0; --n)
            {

                //generate a random number between the current position and the end position
                int k = r.Next(n + 1);
                var temp = _Deck[n];
                _Deck[n] = _Deck[k];
                _Deck[k] = temp;


                //exchange the card from the random position with the card in the current
                //position (the one being processed)
            }
        }

        public void HideLabel()
        {
            Play c = new Play();
            List<string> Deck;
            List<string> OpDeck;
            List<string> ReplaceDeck1;
            List<string> ReplaceDeck2;
            for (int i = 0; i <= 6; i++)
            {
                ReplaceDeck1.Insert();
            }
            
        }

        public void StartGame()
        {
            //repeat while there are more cards or the user decides to stop
            //for(byte cardPosition = 0; cardPosition < 52; cardPosition+=2)
            while (_cardDeck.Count > 0)
            {
                try
                {
                    //Prompt the user to select a card and read user input
                    Console.WriteLine("Please select a card from {0} to {1}. Press ENTER to stop.",
                                    1, _cardDeck.Count);
                    string cardNumInput = Console.ReadLine();

                    //Check if the user canceled the input and stopped the game
                    if (String.IsNullOrEmpty(cardNumInput)) //cardNumInput != ""
                    {
                        //the user has selected to cancel the game

                        //TODO: print the score

                        //finish the game
                        break;
                    }

                    //transform user input from text to number by parsing it
                    byte cardNum = byte.Parse(cardNumInput);

                    //extract card selected by the user from the deck
                    Card userCard;
                    if (ExtractCard(cardNum, out userCard))
                    {
                        //print the card selected by the user
                        Console.WriteLine("User Card: {0} of {1}", userCard.Name, userCard.Suit);

                        //select the card on top of the deck
                        Card topCard;
                        ExtractCard(1, out topCard);

                        //print the card selected by the house
                        Console.WriteLine("House Card: {0} of {1}", topCard.Name, topCard.Suit);

                        //compare the two cards to determine if the user won or the "house" won
                        if (userCard.Value > topCard.Value)
                        {
                            //TODO: user won the round, increase user's score
                            Console.WriteLine("User won the round.");
                        }
                        else if (userCard.Value < topCard.Value)
                        {
                            //TODO: house won the round, increase, the house's score
                            Console.WriteLine("House won the round.");
                        }
                        else
                        {
                            //The user and the house are tied
                            Console.WriteLine("The user and the house are tied, no points scored");

                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Incorrect input. Please chose a valid card number.\nError: {0}",
                                        ex.Message);
                }
                catch (InvalidCardNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //when the game is done because there are no more cards or the user stopped it
            //display the score and who won the game.
            Console.WriteLine("{0} scored {1} and {2} scored {3}\n{4} won the game\n====== GAME OVER ========",
                               "TODO", "TODO", "TODO", "TODO", "TODO");
        }


        private bool ExtractCard(byte cardNo, out Card card)
        {
            //extract the card from the index cardNo - 1 as the actual index in the deck starts at zero
            if (cardNo < 1 || cardNo > _cardDeck.Count) //|| means OR
            {
                //cannot extract card, generate an error, exception
                //throw new InvalidCardNumberException(); 
                //throw new InvalidCardNumberException("Please read the instructions, User!");
                throw new InvalidCardNumberException(cardNo, 1, (byte)_cardDeck.Count);
            }

            //obtain the card to extract 
            card = _cardDeck[cardNo - 1];

            //remove the card from the deck
            _cardDeck.RemoveAt(cardNo - 1);

            //card was successfully removed
            return true;
        }
    }
}
