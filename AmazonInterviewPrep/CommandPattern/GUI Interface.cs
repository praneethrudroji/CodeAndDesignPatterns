using System;

namespace AmazonInterviewPrep.CommandPattern;

public class GUI_Interface
{
    //Get current temperature button
    public void InitializeGUI()
    {

            //Invoker => communicates through command => calls receiver

            Temperature temperature = new(); //receiver

            //Commands
            ICommand getTemperatureCommand = new GetCurrentTemperature(temperature); 
            ICommand updateTemperatureCommand = new UpdateCurrentTemperature(temperature, "55");


            //Get current temp button
            Button current_temperature = new(getTemperatureCommand); //Invoker

            Button update_temperature = new(updateTemperatureCommand); 

            Console.WriteLine(current_temperature.OnClick()); //On Click of get temp

            Console.WriteLine(update_temperature.OnClick()); //On Click of update temp

            Console.WriteLine(current_temperature.OnClick()); //On Click of get temp
    }
}
