# WordCounter

#### A C# word counting application

#### Scott Bergler

## Description
The goal of this project is to write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only.

Each spec should include a specific input and output, and a description sentence explaining why you selected that input value as the simplest way to test the behavior your spec covers.

### Model Specifications:
##### Spec 1: Counter returns a string input.
**Example:**
Input: 'a'.
Output: 'a'

A single letter is the simplest input that is a word.

##### Spec 2: Counter returns two string inputs.
**Example:**
InputOne: 'a'
InputTwo: 'b'
Output: 'a', 'b'

Checks to make sure both inputs are returned and cannot be confused with each other.

##### Spec 3: Counter can set and get its \_matchCount property.
**Example:**
InputOne: 3
Output: 3

Checks to make sure both Set and Get methods are working.

##### Spec 4: Counter compares both inputs and returns boolean: true if they match, boolean: false if they don't.
**Example:**
InputOne: 'a'
InputTwo: 'banana'
Output: 'false'

Confirms that inputs are being compared to each other rather than having InputOne found in InputTwo when InputTwo is a multi-letter word.

##### Spec 5: Counter can find InputOne in InputTwo when InputTwo contains two or more words.
**Example:**
InputOne: 'banana'
InputTwo: 'one banana'
Output: List<string> {"banana"}

Confirms that Counter doesn't stop comparing after the first word.

##### Spec 6: Counter counts every instance of InputOne in InputTwo and returns that number.
**Example:**
InputOne: 'banana'
InputTwo: 'banana cabana bananas banana annabanana another banana'
Output: '3'

Confirms that Counter can add instances found and return that number.

##### Spec 7: Counter ignores capitalization and returns correct number of matches.
**Example:**
InputOne: 'bAnana'
InputTwo: 'Banana cabana bananas baNana annabanana another bananA'
Output: '3'

Confirms that Counter can return the correct count regardless of capitalization.

##### Spec 8: Counter ignores punctuation and returns correct number of matches.
**Example:**
InputOne: 'happy'
InputTwo: 'I felt happy because I saw the others were .happy and because I knew I should feel happy,. but I wasn’t really happy.'
Output: '4'


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
