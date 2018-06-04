# Calc-App

To set up this program, clone the repository to your local machine. Once there, open with Visual Studio, and navigate into the Solution 'Calc App' folder. From there, execute the Program.cs file to start the application. Once the program begins, follow the printed instructions to use.

It took appx 3 hours to complete this assignment. The largest time sink was front-loaded in setting up the program. There were a number of different options, and after some research the best appeared to be a web application. I chose not to worry about starting with a front end after playing around with the VS UI and stick with a console application for this challenge.

The largest struggle was making the variables available for the entire application. I wanted to use a global variable as a running tally of the user's choices. I also wanted to stick with what the tutorials covered in the sense that when looking at a method you should say "method x does..." and avoid "method x does this AND..." For that purpose I needed to be able to use a global variable, but got stuck on establishing the correct space and class to put it in. At first I got exceptions, which did reinforce how much compiled code in general, and Intellisense in particular, help vis-a-vis Javascript. C# syntax still isn't familiar, so to solve the problem was largely trial and error in using different public and private settings until all the methods agreed they could access the variable I needed.

Once past that, the logic for the proram itself is very simple. It just uses helper functions to keep looping through the program until the user decides to exit. 

During the assignment I learned about scoping, and the syntax for referencing objects throughout a code base. Also I learned about the different number types available, and I liked the way double and int are very specific to how the memory is allocated, rather than one general integer type. I also learned about exception handling and the try catch statements, and how to parse a string to obtain a double or int. Also, I learned how to use the Git extension in VS. I initialized the repo and handled the ACP and branching through VS, which was really convenient.

Overall, it was a great exercise to practice what I learned in the pre-work tutorials so far.

Resources used for the app were Visual Studio, MSNDN and Stack Overflow. 

