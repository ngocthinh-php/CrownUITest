using NUnit.Framework;
using SalesForce.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class ChatterPostSteps
    {
        [Given(@"I am on Chatter Page")]
        public void GivenIAmOnChatterPage()
        {
            TestBase.home.VerifyPage();
            Thread.Sleep(2000);
            TestBase.landing.ClickOnChatterTab();
            Thread.Sleep(3000);
            TestBase.chatter.VerifyPage();
            Console.WriteLine("Chatter Page Loaded");
            TestBase.chatter.ClickOnQuestionLink();
            Thread.Sleep(2000);
            Console.WriteLine("Question Page Loaded");
        }

        [When(@"I enter a chatter question with (.*)")]
        public void WhenIEnterAChatterQuestionWith(string questionTitle)
        {
            TestBase.chatter.UserEntersQuestionTitle(questionTitle);
            Thread.Sleep(2000);
        }

        //[When(@"I enter a chatter question with (.*) and (.*)")]
        //public void WhenIEnterAChatterQuestionWithAnd(string questionTitle, string questionDetails)
        //{
        //    //TestBase.chatter.UserEntersQuestionTitle(questionTitle);
        //    //Thread.Sleep(2000);
        //    //TestBase.chatter.UserEntersQuestionDetails(questionDetails);
        //    //Thread.Sleep(2000);
        //    TestBase.chatter.EnterAQuestion(questionTitle, questionDetails);
        //}

        [When(@"click on Ask button")]
        public void WhenClickOnAskButton()
        {
            TestBase.chatter.ClickOnAskButton();
            Thread.Sleep(2000);
        }

        [Then(@"I can verify the question under (.*)")]
        public void ThenICanVerifyTheQuestionUnder(string showUpdates)
        {
            TestBase.chatter.SelectFromShowUpdatesList(showUpdates);
            Thread.Sleep(3000);
            Console.WriteLine(showUpdates);
            Assert.AreEqual("Chatter Automation Test001", TestBase.chatter.UpsertQuestionText.Text);
        }


    }
}
