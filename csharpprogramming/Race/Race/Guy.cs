using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Race
{
    class Guy  
    { 
       public string Name; // The guy’s name 
       public Bet MyBet; // An instance of Bet() that has his bet 
       public int Cash;
       public int dogn;
       public int amountn;// How much cash he has 
       // The last two fields are the guy’s GUI controls on the form  
       public RadioButton MyRadioButton; // My RadioButton 
       public Label MyLabel; // My Label 
        

        public Guy(string name, RadioButton rd,int cash,Label lb)
        {
            this.Name = name;
            this.MyRadioButton = rd;
            this.MyLabel = lb;
            this.Cash = cash;
            MyBet = new Bet();
            UpdateLabels();
            UpdateLabels4();
        }
       public string UpdateLabels()
       {
           // Set my label to my bet’s description, and the label on my  

           // radio button to show my cash (“Joe has 43 bucks”)  
           MyRadioButton.Text = Name + " has " + Cash + " bucks";
           return MyRadioButton.Text;
       }
       public string UpdateLabels2()
       {
           MyLabel.Text = Name + " has " + MyBet.Amount + " bucks on dog # "+ MyBet.Dog;
           return MyLabel.Text;
       }
       public string UpdateLabels3()
       {
           MyLabel.Text = Name + " can not plased any bet";
           return MyLabel.Text;
       }
       public string UpdateLabels4()
       {
           MyLabel.Text = Name + " has not plased any bet";
           return MyLabel.Text;
       }
       public string UpdateLabels5()
       {
           MyLabel.Text = Name + " has exited his limit";
           return MyLabel.Text;
       }
       public void ClearBet()
       {// Reset my bet so it’s zero 
           UpdateLabels4();
           dogn = 0;
           amountn = 0;
           MyBet.Amount =0;
           MyBet.Dog = 0;
       }
       public void PlaceBet(int Amount, int Dog)
       {
           // Place a new bet and store it in my bet field
           
           MyBet.Amount = Amount;
           MyBet.Dog = Dog;
           
           // Return true if the guy had enough money to bet 
           if (Amount < Cash)
           {
               if (Cash >= 5)
               {
                   if (Dog > 0)
                   {
                       dogn = MyBet.Dog;
                       amountn = MyBet.Amount;
                       UpdateLabels2();
                   }
                   else
                   {
                       UpdateLabels4();
                   }
               }
               else
               {
                   UpdateLabels3();
               }
           }
           else
           {
               UpdateLabels5();
           }
       }
    }
}
