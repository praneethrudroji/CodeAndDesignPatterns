using System;

namespace AmazonInterviewPrep.CommandPattern;


/*
    Goal of this command pattern is that we have a button which is responsible to perform multiple operations 
    such as: Get current temperature in a city, update current temperature in a city etc.
*/

public interface ICommand
{
    string Execute();
}
