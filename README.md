## Cybersecurity Awareness Bot (Part 3)Final POE.

## Overview

CyberSecure Bot is a Windows Forms cybersecurity awareness chatbot developed in C# using .NET 8. The application helps users learn about online safety through interactive conversations, practical cybersecurity tips, task management, activity logging, and quizzes.

The chatbot provides information on topics such as phishing, password security, safe browsing, suspicious links, public Wi-Fi safety, privacy protection, and two-factor authentication (2FA).

---

## Features

### User Personalisation

* Users can enter their name when starting the application.
* The chatbot provides personalised responses based on the user's name.

### Cybersecurity Awareness Chatbot

The chatbot can answer questions about:

* Phishing attacks
* Smishing and vishing
* Password security
* Safe browsing practices
* Public Wi-Fi risks
* Two-factor authentication (2FA)
* Online privacy and scams

### Task Management

Users can:

* Add cybersecurity-related tasks
* View existing tasks
* Mark tasks as completed
* Manage security reminders

### Activity Logging

* Tracks user actions within the application.
* Displays recent activities for monitoring user interactions.

### Cybersecurity Quiz

* Interactive quiz system to test cybersecurity knowledge.
* Provides questions on common cybersecurity concepts.
* Tracks quiz progress and score.

### User-Friendly Interface

* Modern Windows Forms interface.
* Chat window for conversations.
* Dedicated buttons for tasks, quizzes, and activity logs.
* Real-time clock display.

### Audio Greeting

* Includes an audio greeting when interacting with the chatbot.



## Technologies Used

* C#
* .NET 8
* Windows Forms (WinForms)
* Object-Oriented Programming (OOP)
* Collections (Lists and Dictionaries)
* Event-Driven Programming


## Project Structure

PROG6221POE
│
├── Form1.cs                 # Main user interface
├── ChatbotEngine.cs         # Core chatbot logic
├── ActivityLogger.cs        # Activity logging functionality
├── QuizManager.cs           # Quiz management
├── QuizQuestion.cs          # Quiz question model
├── TaskItem.cs              # Task model
├── AudioPlayer.cs           # Audio functionality
├── AsciiArt.cs              # ASCII art support
└── greeting.wav             # Greeting audio file



## How to Run the Project
### Prerequisites

* Visual Studio 2022 or later
* .NET 8 SDK

### Steps

1. Download or clone the repository.
2. Open the solution in Visual Studio.
3. Build the project.
4. Run the application.
5. Enter your name and click **Connect**.
6. Start interacting with CyberSecure Bot.


## Sample Questions

Users can ask questions such as:

* What is phishing?
* How do I create a strong password?
* What is two-factor authentication?
* How can I browse safely online?
* What should I do if I clicked a suspicious link?
* Is public Wi-Fi safe?


## Learning Outcomes Demonstrated

This project demonstrates:

* Object-Oriented Programming principles
* Classes and objects
* Encapsulation
* Collections and data management
* Delegates
* Event handling
* GUI development using Windows Forms
* User interaction design
* Cybersecurity awareness education


## Future Improvements

* Database integration for persistent storage
* Advanced chatbot responses using AI/NLP
* User authentication system
* Enhanced quiz categories
* Exportable activity reports
* Additional cybersecurity learning modules


## Author
Malesela Regina Mothiba
ST10439241
Developed as part of the PROG6221 Programming Project focused on cybersecurity awareness and software development using C# and .NET.

