using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace postageCalculatorHelperMethodsChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }
        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }
        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }


        private void performChanged()
        {
            // do values exist in textboxes and checkboxes exists
            if (!valuesExist()) return;

            // volume of package 
            double volume = 0.0;
            if (!tryGetVolume(out volume)) return;

            // what is the multiplier
            double postageMultiplier = getPostageMultiplier();


            // determine cost
            double cost = volume * postageMultiplier;



            // show user
            resultLabel.Text = String.Format("The cost is {0} to ship to you", cost);

            //throw new NotImplementedException();
        }


        private bool valuesExist()
        {
             // basic code structrue built. fix this is a bit
                if (!airRadioButton.Checked
                    && !groundRadioButton.Checked
                    && !nextDayRadioButton.Checked)
                    return false;

                if (widthTextBox.Text.Trim().Length == 0 ||
                    heightTextBox.Text.Trim().Length == 0) 
                   // lengthTextBox.Text.Trim().Length == 0
                    return false;

            return true;
                // fixed
                // actually broken now
               
            
        }

        private bool tryGetVolume(out double volume)
        {
            //throw new NotImplementedException();
            volume = 0;
            double width = 0.0;
            double height = 0.0;
            double length = 0.0;

            if (!double.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!double.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!double.TryParse(lengthTextBox.Text.Trim(), out length)) return false;

            volume = width * height * length;
            return true;


        }

        private double getPostageMultiplier()
        {
            //throw new NotImplementedException();
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;

                
        }

        /*private void calculateCups()
            {
                if (quantityTextBox.Text.Trim().Length == 0)
                    return;

                double quantity = 0.0;
                if (!Double.TryParse(quantityTextBox.Text, out quantity))
                    return;

                double cups = 0.0;

                if (fromCupsRadio.Checked) cups = quantity;
                else if (fromPintsRadio.Checked) cups = quantity * 2;
                else if (fromQuartsRadio.Checked) cups = quantity * 4;
                else if (fromGallonsRadio.Checked) cups = quantity * 8;

                resultLabel.Text = "The number of cups:" + cups.ToString();
            }*/

        // the above is just there to help you get the syntax right
    }
}