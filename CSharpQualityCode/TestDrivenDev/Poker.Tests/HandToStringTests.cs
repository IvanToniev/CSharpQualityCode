using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class HandToStringTests
    {
        [TestMethod]
        public void ToStringWithNoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            string result = hand.ToString();

            Assert.AreEqual(string.Empty,result);
        }

        [TestMethod]
        public void ToStringOneCardTenOfSpades()
        {
            Hand hand = new Hand(new List<ICard>() {new Card(CardFace.Ten, CardSuit.Spades)});
            string result = hand.ToString();

            Assert.AreEqual("10♠", result);
        }

        [TestMethod]
        public void ToStringWithFiveCards()
        {
            Hand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });
            string result = hand.ToString();

            Assert.AreEqual("10♠ 5♣ J♠ A♥ 7♦", result);
        }

        [TestMethod]
        public void ToStringWithSameCards()
        {
            Hand hand = new Hand(new List<ICard>() { new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades) });
            string result = hand.ToString();

            Assert.AreEqual("10♠ 10♠", result);
        }
    }
}
