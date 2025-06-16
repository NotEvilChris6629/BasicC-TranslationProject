# Basic C# Translation Project

This repo marks the start of my upskilling journey to translate some of my Unity-based programming into more traditional app/console-based programming. After only a few days of playing about, I learnt a lot of fundamental techniques, method usage and extra information about methods I thought I knew everything about. With the limited time I've had to work on these, I feel there is so much more to learn, and I'm excited to do so!

## What is this?

This repo contains a project showcasing four mini console app activities:  
- A random dice-throwing mini-game with prizes  
- A subscription warning app  
- A fraudulent order searcher  
- A student exam grading app  

These four apps allowed me to explore various techniques for programming console applications. Below, I’ll share a bit about each one and what I learned along the way.

### Dice Mini-game

This mini-game began as a simple exercise that displayed text to the screen after generating random numbers between 1 and 6. Once the basic functionality was complete, I started experimenting with ways to make it more engaging by adding features like doubles and triple multipliers to the base score.

Originally, the user needed to score 14 or above to "win"; anything below meant losing. I then added a variety of silly prizes for when the player scored above or below certain thresholds. This helped me better understand the order of operations when working with nested IF statements.

After finishing the mini-game, I moved on to the other exercises, where I implemented ways to take user input using `Console.ReadLine()` and began offering the user options for what they wanted to do.

Once all the projects were complete, I revisited the mini-game and experimented with adding color to the console outputs. This deepened my understanding of how `Write()` and `WriteLine()` fundamentally differ, and how to color only certain words or parts of the output.

### Subscription Exercise
This project was one of the Microsoft Course projects in which you change the output of some text depending on the remaining time left on a subscription. Depending on how long the user has left on their subscription, the output will offer a better discount on their next payment. This project essentially reinforced how to properly use IF statements and the order of operations when using them in nested IF statements.

### Fraud Orders Exercise
This project was one of the Microsoft course exercises, where an array of order numbers—each starting with a letter—would be searched to output all orders that begin with the letter the user inputs into the console. While the original exercise included only about eight order numbers, I expanded it to roughly 200 to provide a more substantial output and reduce the likelihood that a user’s input would return no results.

In this project, I learned how to simulate a system "searching" for records by using the Thread.Sleep() method, along with string manipulation to add a dot to the end of the message each second. I also experimented with text coloring to highlight the number of records found.

### Student Grading Exercise.
This was a Microsoft course project I followed, which gave me a deeper understanding of using nested if and if-else statements, as well as searching through multiple arrays of data for scores. The project searches through different scores, calculates the average, and compares it to a predetermined "score sheet" to determine and output the user's grade based on their score.

It also introduced me to the concept of formatting console output using columns and rows, achieved by using the \t escape sequence, which represents a tab character.

### Conclusion/Summary
All in all, I enjoyed translating some of my Unity C# knowledge into a console application, as things are done slightly differently in this environment. I’ll be exploring this further, but unless there's a more streamlined approach, it was interesting having to break apart strings in order to color specific words. Doing it this way helped reinforce my understanding of the WriteLine and Write methods, and cemented the differences between them in my mind. It has been challenging to need to throw out some of what I know in regards to Unity Programming and instead look at it with a fresh perspective.

One of the challenges I overcame was that each project originally only ran once. To solve this, I implemented a way for users to repeat the projects if they wished. Completing these projects has been fairly challenging due to limited time from work commitments, but the process has been incredibly rewarding. I feel having dedicated time to work on upskilling or programming in general within a set work/study environment would be immensely more rewarding.

It was also intriguing to discover that there's so much more to learn about basic methods I thought I already understood. For example, I learned that strings can access variable values by placing a '$' before the string and {encapsulating} variables in curly brackets ({}). This might seem like a simple, obvious feature—but it was new to me! That’s one of the things I enjoyed most about these projects: realising that there is always something new to learn. Once these projects had been finished, I then moved on to diving into API's and started work on a TODO API, which is a minimal RESTful api that implements SwaggerUI (Swashbuckle) to input data into an in-memory database. You can find that repo here: https://github.com/NotEvilChris6629/API-Learning.
