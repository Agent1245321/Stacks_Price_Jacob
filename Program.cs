// See https://aka.ms/new-console-template for more information
using Stacks_Price_Jacob;

//creates an empty cards arry with 52 slots
Console.WriteLine("Hello, World!");
Cards[] cardsArray = new Cards[52];
string nextcardvalue = "Ace";
string nextcardsuit = "Spades";

Stack<Cards> startingDeck = new Stack<Cards>();

//fills out the array with blank cards to be assigned in the foreach loop
for (int i = 0; i< cardsArray.Length; i++)
{
    cardsArray[i] = new Cards();
}

//gives all the blank cards in the array a value
foreach (Cards card in cardsArray)
{

    card.Number = nextcardvalue;
    card.Suit = nextcardsuit;

    startingDeck.Push(card);


    Console.WriteLine($"The {card.Number} of {card.Suit} was made!");
    switch (card.Number)
    {
        case "Ace":
            nextcardvalue = "Two";
            break;

        case "Two":
            nextcardvalue = "Three";
            break;

        case "Three":
            nextcardvalue = "Four";
            break;

        case "Four":
            nextcardvalue = "Five";
            break;

        case "Five":
            nextcardvalue = "Six";
            break;

        case "Six":
            nextcardvalue = "Seven";
            break;

        case "Seven":
            nextcardvalue = "Eight";
            break;

        case "Eight":
            nextcardvalue = "Nine";
            break;

        case "Nine":
            nextcardvalue = "Ten";
            break;

        case "Ten":
            nextcardvalue = "Jack";
            break;

        case "Jack":
            nextcardvalue = "Queen";
            break;

        case "Queen":
            nextcardvalue = "King";
            break;

        case "King":
            switch (card.Suit)
            {
                case "Hearts":
                    nextcardsuit = "Diamonds";
                    break;

                case "Diamonds":
                    nextcardsuit = "Clubs";
                    break;

                case "Clubs":
                    nextcardsuit = "Spades";
                    break;

                case "Spades":
                    nextcardsuit = "Hearts";
                    break;
            }
            nextcardvalue = "Ace";
            break;
    }

}

//prints all the cards in the stack to the console
    Console.WriteLine("Cards in Deck:");
    foreach(Cards card in startingDeck)
    {
    Console.WriteLine($"The {card.Number} of {card.Suit}");
    }

    //prints the deck size
Console.WriteLine($"Deck Size: {startingDeck.Count()}");

//creates an empty Cards() list
List<Cards> myHand = new List<Cards>();

//pops some cards into the list
myHand.Add(startingDeck.Pop());
myHand.Add(startingDeck.Pop());
myHand.Add(startingDeck.Pop());

Console.WriteLine("Got any eights?");

myHand.Add(startingDeck.Pop());


//prints the deck size
Console.WriteLine($"Deck Size: {startingDeck.Count()}");

startingDeck.Push(myHand[1]);
myHand.Remove(myHand[1]);


//prints the deck to the console
Console.WriteLine("Cards in Deck:");
foreach (Cards card in startingDeck)
{
    Console.WriteLine($"The {card.Number} of {card.Suit}");
}

//prints the hand to the console
Console.WriteLine("My hand:");
foreach(Cards card in myHand)
{
    Console.WriteLine($"The {card.Number} of {card.Suit}");
}