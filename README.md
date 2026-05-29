## Cybersecurity Awareness Bot (Part 2)

 ## Project Overview

The Cybersecurity Awareness Bot is a console-based chatbot developed in C# to educate users about basic cybersecurity practices. This project focuses on building a foundational chatbot system with interactive features, multimedia elements, and version control using GitHub.

 ## Objectives

* Create an interactive chatbot experience
* Promote cybersecurity awareness
* Implement structured and readable code
* Use GitHub for version control and CI workflows

## Voice Greeting

A personalised voice greeting is played when the application starts.

 Implementation:

* A recorded .wav audio file is used
* The file welcomes the user to the chatbot
* Audio is played using C# (System.Media.SoundPlayer)


## ASCII Image Display

An ASCII art logo is displayed when the chatbot launches.

###  Features:

* Cybersecurity-themed ASCII art
* Displayed as a header/title screen
* Enhances visual presentation


##  Text-Based Greeting & Interaction

The chatbot creates a personalised user experience.

###  Features:

* Prompts the user to enter their name
* Displays a customised welcome message
* Combines text greeting with ASCII design
* Stores previously asked questions


##  Basic Response System

The bot responds to common and cybersecurity-related questions.

###  Supported Questions:

* "How are you?"
* "What is your purpose?"
* "What can I ask you about?"

###  Cybersecurity Topics:

*  Password safety
*  Phishing awareness
*  Safe browsing


##  Input Validation

The chatbot handles invalid or unexpected input gracefully.

###  Features:

* Detects empty input
* Handles unknown questions
* Provides fallback response:

  > "I didn't quite understand that. Could you rephrase?"


##  Enhanced Console UI

The chatbot interface is improved for better user experience.

###  Features:

* Coloured text using console formatting
* Decorative borders and spacing
* Section headers and dividers
* Typing effect (simulated delays for realism)


##  Code Structure & Readability

The code is organised for maintainability and clarity.

###  Implementation:

* Code split into multiple classes and methods
* Avoided placing all logic in Program.cs
* Clear naming conventions used


##  GitHub Version Control

The project uses GitHub for tracking progress and changes.

###  Commits:

No prior commits


##  Continuous Integration (CI)

GitHub Actions is used to automate checks on the project.

###  Implementation:

* CI workflow created in .github/workflows/
* Automatically runs on each push
* Checks include:

  * Successful project build
  * Syntax validation
  * Code quality checks



##  How to Run the Project

1. Clone the repository:

   bash
   git clone https://github.com/reggykoketso/Cybersercurity-Awareness.git
   
2. Open the project in Visual Studio
3. Build the solution
4. Run the application



##  Usage

* Launch the application
* Listen to the voice greeting
* Enter your name
* Ask cybersecurity-related questions
* Receive helpful responses and tips



## Limitations

* Limited to predefined responses
* No advanced AI or machine learning
* Console-based interface only



##  Future Improvements

* Add AI-powered responses
* Expand cybersecurity topics
* Develop a graphical user interface (GUI)
* Integrate real-time threat detection


##  Author

Malesela Regina Mothiba


##  Submission Note

This project was developed as part of an academic assignment. GitHub commits reflect the development stages, and CI was implemented using GitHub Actions.
