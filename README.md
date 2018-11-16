# WordCounter

#### A C# word counting application

#### Scott Bergler

## Description
The goal of this project is to write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only.

### Specifications:
##### Spec 1: Instances of the RepeatCounter class can be successfully created.
##### Spec 2: RepeatCounter can hold a word to search for in later specs.
##### Spec 3: RepeatCounter can hold a string to be searched in later specs.
##### Spec 4: RepeatCounter can compare its strings when they are both letters.
##### Spec 5: RepeatCounter can find the first string as a letter in the second string when it is not part of a word.
**Example:** The first string is the letter 'a'; the second string is 'a cat' - the program will find the word 'a', but ignore the word 'cat'.
##### Spec 6: RepeatCounter can find the first string as a word in the second string when it is not part of a word.
**Example:** The first string is the word 'dog'; the second string is 'the dog dodged doggedly' - the program will find the word 'dog', but ignore the word 'doggedly'.
##### Spec 7: RepeatCounter can find every instance of the first string as a word in the second string when it is not part of a word.
**Example:** The first string is the word 'happy'; the second string is 'I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.' - the program will find each instance of the word 'happy'.
##### Spec 8: RepeatCounter can find every instance of the first string as a word in the second string when it is not part of a word and count how many instances were found.
**Example:** The first string is the word 'happy'; the second string is 'I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.' - the program will find each instance of the word 'happy' and return the count 4.

##### Problems Discovered With Specifications:
I think just due to nervousness I wasn't thinking clearly and did not include enough specifications. Below are missing specs and problems with the above specs discovered while building. I am continuing to build based only on the original eight specs, but I may have complications due to the things I missed.
* **Missing spec:** did not anticipate handling punctuation.
* **Missing spec:** did not anticipate handling capitalization.
* **Missing spec:** did not anticipate creating Lists.
* **Missing spec:** did not anticipate using those Lists.
* **Missing/mishandled spec:** the fifth spec should have only checked that the stringToSearch contains wordToFind. My first commit on this spec passing was only for the 'contains' condition.

## Setup/Installation Requirements
To view or clone the code, go to [GitHub](https://github.com/skillitzimberg/CSharpWordCounter).

## Known Bugs


## Support and contact details

There is no one here.

## Technologies Used

C#

### License

Licensed under the MIT license.

Copyright (c) 2018 ** _Scott Bergler_ **
