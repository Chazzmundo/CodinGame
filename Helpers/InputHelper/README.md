# CodinGame InputHelper

Supplying the input data for testing particular Test Cases for a CodinGame is tedious and repetitive and often makes the task much less fun.

This small script is designed to make life easier for removing the need for you to ever manually type the input for a Test Case again

It allows you to effortlessly use the test data from the UnitTests that CodinGame puzzles provide (or your own!) and will automatically supply you with the data line by line avoiding you needing to manually provide it yourself each time.

It also is built to seamlessly work when submitting your solution to CodinGame without needing to change even a single line of Program.cs file.

## How to use

1) Ensure you have the External Editor plugin setup and working as expected: https://www.codingame.com/forum/t/codingame-sync-beta/614

2) Find the file matching the language you want to use (currently only C# is supported but the repository is open for submissions) and copy it into your project.

3) Follow the instructions inside of the file in your own project (it can be slightly different for each programming language). The most important part is that each of these will require you to create a file called "InputData.txt" and reference it in the "InputHelper" code file

4) When attempting a puzzle and wanting to test a particular "Test Case" (be it your own or what the puzzle provides), simply copy the input data and paste it into the "InputData.txt" you created as part of the above step.

## How to find the Test Case data on CodinGame

CodinGame includes "Test Cases" that you can run to see if your code works. You've likely already seen them on the website itself when playing puzzles. 

However you may not have seen that you can actually see the input data they use for each Test Case by clicking icon/button to the right of "Test Cases"/"Custom" and then selecting the Test Case you are interested in.
Normally, you'd be required to type out each of these lines in the command line one by one each time Console.ReadLine() is called (or the equivalent method of whichever language you're operating in).

With this helper file, it will automatically read the next line from the file and supply it instantly without the need for you to actually type out the line manually. Drastically reducing the time and effort it takes to debug a particuliar Test Case.

## TroubleShooting

In case of an error (e.g. an exception being thrown), the likely causes are either:

### FileNotFound 

You have not yet correctly set the reference to the "InputData.txt" file correctly in your InputHelper file

### File is Empty

You have yet to copy the data into the file (it needs at least 1 line of data to correctly work as per CodinGame puzzles)

# Open to extension

CodinGame supports many languages. For now, I've only added this support to the following languages:
* C#

However, I'd love to eventually support every possible language CodinGame has to offer to allow easy development for people going forwards.

To achieve that, I'll need some help in porting them across!

Please feel free to contribute to adding support for more languages. Please follow the guidelines to ensure consistency across the languages and ReadMe file:

## Easy to integrate into a new project

It should be as easy as possible to integreate into someone's new project:
* Make sure there are clear step-by-step instructions inside the language file itself on how people can add it to their own project
* Ensure only 1 class/file needs to be copied into their project (avoid them needing to copy multiple files where possible)
* Avoid requiring user-specific setup where possible (outside of the location of the "InputData.txt")

## Seamless integration into CodinGame submissions

While it's okay to require them to copy some small data into the top of the Main file used for the puzzle (e.g. Program.cs), avoid writing your solution in such a way that ANY changes are required to make it work on CodinGame when they want to submit their answer.

It should be ZERO effort for them to write the code and test it locally using this solution and run it in the CodinGame webpage without any additional errors due to the InputHelper file.

This can be achieved by templates/macros/pragma defines that only exist within the local solution as created as part of the setup guide

## Setup is a 1-time operation

To make it as easy as possible to use, people should be able to set it up once as part of your setup instructions at the top of the InputHelper file for their given language and never have to care about touching it again (aside from replacing the data inside of "InputData.txt" file of course)

## Utilise "InputData.txt"

Ensure the code references a file going by the name of "InputData.txt". This ensures that the ReadMe file makes sense across ALL languages

## Print out useful error messages

Ensure that you print out informative error messages in the following situations:
* The file doesn't exist in the specified location
* The file is empty