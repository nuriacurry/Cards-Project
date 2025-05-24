using System;
using Cards2;

// loop while there's more input
// string input = Console.ReadLine(); // Commented out to run automatically

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck deck = new Deck();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
Card[] player1 = new Card[3]; // Will hold 3 cards total
Card[] player2 = new Card[3]; // Will hold 3 cards total  
Card[] player3 = new Card[3]; // Will hold 3 cards total
Card[] player4 = new Card[2]; // Will hold 2 cards total

// Deal first card to each player
player1[0] = deck.TakeTopCard();
player2[0] = deck.TakeTopCard();
player3[0] = deck.TakeTopCard();
player4[0] = deck.TakeTopCard();

// Deal second card to each player
player1[1] = deck.TakeTopCard();
player2[1] = deck.TakeTopCard();
player3[1] = deck.TakeTopCard();
player4[1] = deck.TakeTopCard();

// deal 1 more card to players 2 and 3
player2[2] = deck.TakeTopCard();
player3[2] = deck.TakeTopCard();
player1[2] = deck.TakeTopCard(); // Player 1 also gets a third card based on array size

// flip all the cards over
foreach (Card card in player1)
{
    if (card != null) card.FlipOver();
}
foreach (Card card in player2)
{
    if (card != null) card.FlipOver();
}
foreach (Card card in player3)
{
    if (card != null) card.FlipOver();
}
foreach (Card card in player4)
{
    if (card != null) card.FlipOver();
}

// print the cards for player 1
Console.WriteLine("Player 1:");
foreach (Card card in player1)
{
    if (card != null)
    {
        Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
}

// print the cards for player 2
Console.WriteLine("Player 2:");
foreach (Card card in player2)
{
    if (card != null)
    {
        Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
}

// print the cards for player 3
Console.WriteLine("Player 3:");
foreach (Card card in player3)
{
    if (card != null)
    {
        Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
}

// print the cards for player 4
Console.WriteLine("Player 4:");
foreach (Card card in player4)
{
    if (card != null)
    {
        Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
}