# WordCounter

#### A C# word counting application

#### Scott Bergler

## Description
The goal of this project is to write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only.

Each spec should include a specific input and output, and a description sentence explaining why you selected that input value as the simplest way to test the behavior your spec covers.

### Specifications:
##### Spec 1: Instances of the RepeatCounter class can be successfully created.
Other than a call to the constructor, I'm not sure what the input is for this spec. The output is an instance of the class.

This is the most basic step in starting the project. An instance of the class holds the properties need for the program to run. I understand that C# allows implicit construction of instances, but I wanted to keep practicing as many elements of object oriented programming as I could. Also it might be needed for next week. I'm not totally sure.

##### Spec 2: RepeatCounter can hold a word to search for in later specs.
**Example:** Input: "hello". Output: "hello, world".

##### Spec 3: RepeatCounter can hold a string to be searched in later specs.
**Example:** Input: wordToFind is "searched"; expectedStringToSearch is "This string is to be searched for WordToFind" Output is "This string is to be searched for WordToFind".

##### Spec 4: RepeatCounter can compare its strings when they are both letters.
**Example:** Input: Both wordToFind and StringToSearch are the letter 'w'. Output is the boolean true.

##### Spec 5: RepeatCounter can compare its strings when they are both letters but one of them is capitalized.
**Example:** Input: wordToFind is "W"; StringToSearch is "w". Output is the boolean true.

##### Spec 6: RepeatCounter can compare its strings when they are both words but one of them is capitalized.
**Example:** Input: wordToFind is "windy"; StringToSearch is "Windy". Output is the boolean true.

##### Spec 7: RepeatCounter can compare its strings and ignore punctuation.
**Example:** Input: wordToFind is "windy"; StringToSearch is "Windy.". Output is the boolean true.

##### Spec 8: RepeatCounter can find every instance of the first string as a word in the second string when it is not part of a word.
**Example:** Input: wordToFind is "happy"; stringToSearch is 'I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.' Output: 4.

## Setup/Installation Requirements
To view or clone the code, go to [GitHub](https://github.com/skillitzimberg/WordCounter.Solution).

To set up your Mac:
Download .NET Core SDK (Software Development Kit);

Open the file to launch the installer. The default settings are alright.

Confirm the installation by running the command $ dotnet --version in the terminal. The response will be along the lines of 1.1.4.

Download Mono [here](https://www.mono-project.com/download/stable/).

Open the downloaded .pkg file to run the installation wizard.

Confirm the installation is successful by running the command $ mono --version. You should see a response including a version number similar to, but not necessarily exactly,  5.10.1.57.

Instruction for PC/Windows are [here](https://www.microsoft.com/net/learn/dotnet/hello-world-tutorial).

## Known Bugs
Does not handle capitalization.

## Support and contact details

There is no one here.

## Technologies Used

C#, .Net, and Mono.

### License

Licensed under the MIT license.

Copyright (c) 2018 ** _Scott Bergler_ **
