using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MathsOperators
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addition.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiplyValues();
                }
                else if ((bool)division.IsChecked)
                {
                    divideValues();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
            }
            catch (Exception caught)
            {
                expression.Text = "";
                result.Text = caught.Message;
            }
        }

        private void addValues()
        {
            int lhs = int.Parse(lhsOperand.Text);                                   //As an alternate method to what is in the book   
            int rhs = int.Parse(rhsOperand.Text);                                   //I assigned the value to the variable outcome in    
            int outcome = lhs + rhs;                                                //the same line that I declared it, thus removing 
            expression.Text = $"{lhsOperand.Text} + {rhsOperand.Text}";             //an extra line of code. Not sure why you wouldn't 
            result.Text = outcome.ToString();                                       //do this. 
        }

        private void subtractValues()
        {
            int lhs = int.Parse(lhsOperand.Text);                                   //Here I experimented with removing the 0 initally 
            int rhs = int.Parse(rhsOperand.Text);                                   //assigned to the variable outcome to see if it changed   
            int outcome;                                                            //anything, it didnt. The 0 was initially assigned so the  
            outcome = lhs - rhs;                                                    //code would still run before we edited it for this exercise. 
            expression.Text = $"{lhsOperand.Text} - {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }

        private void multiplyValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs * rhs;
            expression.Text = $"{lhsOperand.Text} * {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }

        private void divideValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs / rhs;
            expression.Text = $"{lhsOperand.Text} / {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }

        private void remainderValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs % rhs;
            expression.Text = $"{lhsOperand.Text} % {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }
    }
}
