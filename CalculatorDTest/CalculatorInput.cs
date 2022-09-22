using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDTest
{
    public class CalculatorInput
    {
        Calculator cal = new Calculator();
        public void Start()
        {
            MainMenu();
        }

        //Menu that handles choice of mathematical method to use
        private void MainMenu()
        {
            bool choice = true;


            while (choice)
            {
                Console.Clear();
                int calculatorChoice = menu();

                switch (calculatorChoice)
                {
                    case 1:
                        {

                            break;
                        }

                    case 2:
                        {


                            break;
                        }
                    case 3:
                        {


                            break;
                        }
                    case 4:
                        {

                        
                            break;
                        }

                    case 9:
                        {
                            choice = false;
                            break;
                        }
                }

            }
        }
        //Menu options
        static int menu()
        {
            string count = "0";
            bool choice = true;
            Console.WriteLine("Choice what mathematical operation you want to preform:");
            Console.WriteLine("1. Addition.");
            Console.WriteLine("2. Subtraction.");
            Console.WriteLine("3. Multiplcation.");
            Console.WriteLine("4. Divide.");
            Console.WriteLine("9. Exit");
            do
            {
                
            } while ();
            return ;

        }
        //Method that gets input from InputNumbers and call method Multi in th class Calculator and returns the result.
        public double Multi()
        {
           
        }
        //Method that gets input from InputNumbers and call method Div in th class Calculator and returns the result.
        // It handles exeptions that can be thrown in the Calculator class.
        public double Div()
        {
           

            try
            {
               
            }
            catch (DivideByZeroException ex)
            {
                
            }
            return result;
        }
        //A text string is converted to a double and returned. ControllDouble is called and return a boolean that determines if the string contains a double.
        // It returns a double value
        public double InputNumber(string textSequence)
        {
        
        }

        //Control if string contains a integer and returns a boolean. Use try catch to catch execptions.
        public static bool ControlInteger(string number)
        {
            bool notInt = true;

            try
            {
                
            }
            catch (FormatException)
            {
                
            }
            catch (OverflowException)
            {
               
            }

            return notInt;
        }
        //Control if string contains a double and returns a boolean. Use try catch to catch execptions.
        public bool ControlDouble(string number)
        {
            bool notInt = true;

            try
            {
                
            }
            catch (FormatException)
            {
                
            }
            catch (OverflowException)
            {
                
            }

            return notInt;
        }
        // Method that reads in a text string and calls ToDouble with sends in the text string and the token it gets from the calling method.
        // It gets a array and calls the Calcorlator class method decide by the token. And it returns a double with the result of the operation.
        public double InputArray(char token)
        {
            double result = 0;
           
            {
                if ()
                {
                    
                }
                else if ()
                {
                    
                }
                else
                {
                    result = 0;
                }
            }
            else
            {
                if ()
                {
                    
                }
                else if ()
                {
                   
                }
                else
                {
                    
                }

            }
            return result;
        }

        // Method that decides how many number there is in the textstring and return a int
        public int LengthOfNumbersArray(string numbers, char token)
        {

            int index = 0;
            if ()
            {
                for ()
                {
                    if ()
                    {
                        
                    }
                }
            }
            return index;
        }

        public string ParenthasesRemove(StringBuilder stb)
        {

            for ()
            {
                if ()
                {
                    
                }
                else if 
                {
                    
                }
            }

            return stb.ToString();
        }

        // Method that creates arrays of doubles and returns a array of doubles. It extract the numbers from the text string and store them in a array.
        // Error handling is done by try catch.
        public double[] ToDoubleArray(string numbers, char token)
        {


            for ()
            {

                if ()
                {
                   

                }
                else if 
                {
                   

                }
                else if ()
                {
                 
                }
                // Special case where the input is a negativ number. ned to single out the negativ number in the input.  2-2- -2 = 2 in input.Input don't use () to single out negsativ numbers

                else if ()
                {
                   

                }
                else if ()
                {
                    try
                    {
                      
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                        //Console.WriteLine("Index out of range exception : " );
                    }
                    catch (FormatException)
                    {
                        break;
                        //Console.WriteLine("Your input was not a number : " );
                    }
                }
            }
            try
            {

                ;
            }
            catch (FormatException)
            {
                
            }
            catch (IndexOutOfRangeException)
            {
                
            }

            return;

        }
    }
}

}
