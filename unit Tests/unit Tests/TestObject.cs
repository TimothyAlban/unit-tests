﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace unit_Tests
{
    public delegate string myDelegate();
    public class TestObject
    {
        //internal variables
        private bool pass;
        private string testMessage;
        

        // properties
        public bool Pass
        {

            get { return pass; }
            set { pass = value; }

        }

        public string TestMessage
        {

            get { return testMessage; }
            set { testMessage = value; }

        }


        //test Functions

        public void IsHeads(){

            if (Program.FlipCoin() == "heads")
            {
                testMessage = "It was heads!";
                pass = true;
            }
            else
            {
                testMessage = "it was tails!";
                pass = false;
            }
            

        }
    

    }
}
