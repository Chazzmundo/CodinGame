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

# Open to extension

CodinGame supports many languages. For now, I've only added this support to the following languages:
* C#

However, I'd love to eventually support every possible language CodinGame has to offer to allow easy development for people going forwards.

To achieve that, I'll need some help in porting them across!