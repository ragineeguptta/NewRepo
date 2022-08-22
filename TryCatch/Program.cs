using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            try 
	        {	        
	        	int userInputAsInt = int.Parse(userInput);
	        }
	        catch (FormatException)
	        {
            
                    Console.WriteLine("Formate exception, please enter the correct type next time.");
            
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNull exception, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
        }
    }
}
