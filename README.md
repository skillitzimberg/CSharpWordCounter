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
**Example:** The original input was a single letter 'a'. The output was the same letter 'a'.

This is a property that is passed in each time the program is run and I wanted to make sure it was accessible. I chose a letter because I knew that I was going to be looking for letters in later specs.

The input for StringToSearch was added later as the class/constructor now had two properties and passing in a single property caused compilation errors.

##### Spec 3: RepeatCounter can hold a string to be searched in later specs.
**Example:** The input is the word 'searched' and the phrase 'This string is to be searched for WordToFind' The output is the phrase 'This string is to be searched for WordToFind'.

I chose these inputs because I was trying to be semantic. This spec accomplishes a similar goal as the previous spec but incrementally adds to the program's capabilities.

##### Spec 4: RepeatCounter can compare its strings when they are both letters.
**Example:** The inputs for this spec are the single letters 'w'. The output is the boolean true.

I chose single letters (which single letter didn't seem important) as they are the simplest relevant things to compare. I wanted to be sure that RepeatCounter could 'see' and report the value of its properties.

##### Spec 5: RepeatCounter can find the first string as a letter in the second string when it is not part of a word.
**Example:** The first string is the letter 'a'; the second string is 'a cat' - the program will find the word 'a', but ignore the word 'cat'. The output is boolean true.

I chose these inputs because they were the smallest step up from comparing two letters and presented a potential stumbling block if the 'a' in 'cat' was found.

I am aware I'm not using the this nor the three methods above for the functionality of the program, but I thought they both handled the spec and might be useful in next week's work.

Also, as noted below, I messed up this spec by trying to do too much and things got confusing around this point and work started to straddle the fifth and sixth specs.

##### Spec 6: RepeatCounter can find the first string as a word in the second string when it is not part of a word.
**Example:** The first string is the word 'dog'; the second string is 'the dog dodged doggedly' - the program will find the word 'dog', but ignore the word 'doggedly'.

As for the previous spec, these inputs seemed the smallest relevant step to take and also double checked that the 'dog' in 'doggedly' would be ignored. I later changed the input to 'an' and output to 'a cat that saw a rat and a dog had an anuerysm.' because I wanted to make sure that the program was finding the word when it wasn't part of a word and was looking at every word in the string, not stopping part way through. This was in part due to some issues I was troubleshooting due to my making the fifth spec too broad.

##### Spec 7: RepeatCounter can find every instance of the first string as a word in the second string when it is not part of a word.
**Example:** The first string is the word 'happy'; the second string is 'I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.' - the program will find each instance of the word 'happy'.

Again, this is the smallest step forward from the previous spec, increasing the complexity very subtly.

It also ended up providing a good case to ignore punctuation.

##### Spec 8: RepeatCounter can find every instance of the first string as a word in the second string when it is not part of a word and count how many instances were found.
**Example:** The first string is the word 'happy'; the second string is 'I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.' - the program will find each instance of the word 'happy' and return the count 4.

This is also the next smallest logical step from the previous spec.

##### Problems Discovered With Specifications:
I think just due to nervousness I wasn't thinking clearly and did not include enough specifications. Below are missing specs and problems with the above specs discovered while building. I am continuing to build based only on the original eight specs, but I may have complications due to the things I missed.

**Below this list of missing and mishandled specs are additional specs I added after completing the first eight.**
* **Missing spec:** did not anticipate handling punctuation. Handled with seventh spec test.
* **Missing spec:** did not anticipate handling capitalization.
* **Missing spec:** did not anticipate creating Lists. Handled with fifth spec test.
* **Missing spec:** did not anticipate using those Lists. Handled with fifth spec test.
* **Missing/mishandled spec:** the fifth spec should have only checked that the stringToSearch contains wordToFind. My first commit on this spec passing was only for the 'contains' condition.

##### Spec 9: RepeatCounter can find instances of the first string as a word in the second string when it is capitalized.
**Example:** The first string is the word 'windy'; the second string is 'Is the Windy City always windy?' - the program will find each instance of the word 'windy' and return the count 2.

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
