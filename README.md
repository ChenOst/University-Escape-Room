# University-Escape-Room
Final project in development of computer games course [gamedev-5780](https://github.com/erelsgl-at-ariel/gamedev-5780)

**Created by:**

[Chen Ostrovski](https://github.com/ChenOst)

[Enna Grigor](https://github.com/ennagrigor)

## About the Game

A challenging game that aims to teach students various subjects in mathematics in fun way without the student feeling he is learning.
  
With the help of solving questions on various topics and levels of difficulty the player receives
information in a simple and enjoyable way.

The game is tailored to all levels of students,
the player can choose level of difficulty in any question and get a score accordingly.

**The higher the question level the higher the score!** :star: :star: :star:

The player must escape the room before the time runs out. :hourglass_flowing_sand:

**Good Luck! and have fun**

**[Play in Itch](https://chenostrovski.itch.io/university-escape-room) :video_game:**

![](Game_Version_1.gif)

## User Experience
We want our user experience to be based on the following five things:
1. **Usability**: Usability of the game's existing functions and operations is easy to use (performing operations, entering content, receiving appropriate feedback from the system).

2. **Aesthetics - UI:** The general appearance of the user interface, its appearance, the use of graphic elements such as colors, shapes, fonts, etc. that will be aesthetic for the user.

3. **Motion and Interpretation**: Feel & Motion: Animation is a trend that cannot be ignored and gives the user a natural flow and cognitive indications of what happened on the screen. Whether in seamless transitions between displays or as a key part of the product character.

4. **Reliability**: Passing reliable information to the user and avoiding mistakes or mistakes, which means that we have to make sure that the solution and the answers to the user's questions are indeed correct and not misleading.

5. **Accessibility**: Creating an information architecture that is appropriate to how the user thinks or searches for information in the game, we need to make sure we explain to the user how well he can play the game and provide information to him easily.

## Explanation

At the beginning of the game the player wakes up from his sleep.

The room is dark to make the player reach the switch of light that is at the exit door.

On the door the player can find his first clue, we
 created a easy clue that will lead the player to another area in the room
 so we allow the player to see the room before it begins with the heavier hints.
 
There are 6 clues in the room Of these, 3 contain a numerical answer that will later be used in the vault code.
After the player opened the vault he could escape the room and finally return home.

## Things that might help!

During the game the player can use the following:
### Handbook :closed_book:

The book includes formulas, explanations and ways of solving various mathematical questions.
 The book can be opened and moved to any area of the screen.
 You can move to the next page by clicking and holding on the bottom corner of the page.
 
### Calculator :1234:

A calculator with basic functions that the user can use throughout the game.
 The calculator can be opened and moved to any area of the screen.
 
### Information :information_source:
During the game the player can press the info button, A window will then open with explanations of the game, Like using
 the keyboard buttons to move, using the mouse and general explanations of the game.
 
## Scripts
### Player :sunglasses:
The player object contains 3 scripts: [Player Scripts](https://github.com/ChenOst/University-Escape-Room/tree/master/Assets/University%20Classroom/Scripts/Player)
- [Move Player](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Player/MovePlayer.cs) - moves the player around with arrows ot AWSD keys.
- [Move Camera](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Player/MoveCamera.cs) - moves the camera with the mouse.
- [Player](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Player/Player.cs) - contains all the information of the player (score etc.).

### Clues :mag:
The clue objects in the game contains 2 scripts:
- [ActiveClue](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/ActiveClue.cs) - Activate the clue if the player is close and enters E key.
- [Clue](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Clue.cs) - contains all the information of the clue (clueId, rightAnswer, Clue question etc.).
- [EndClue](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Clues/EndClue.cs) - some clues don't have mathematical answer, 
So if the player finishes the hint that comes after this hint, close this hint. Is intended to prevent player confusion.
- [SendAnswer](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Clues/SendAnswer.cs) - Responsible for sending and checking Hint's answer.
- [ActiveSafe](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Clues/ActiveSafe.cs) - Allows the player to open the safe when it is close to it. In addition,
 the camera changes to allow the player to enter the code.

### Lights :bulb:
- [TurnTheLights](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/TurnTheLights.cs) -
This script turn off and on the lights in the room, if the player is close to the switch object and presses E key.

### Message :envelope:
- [FirstMessage](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/FirstMessage.cs) -
The message pops up only once, after the wake up animation was ended. It gives the player more inforamtion about the game.
- [DestroyMessage](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Messages/DestroyMessage.cs) - In some clues,
 another message pops up that comes in 10 seconds. This script destroys this post after this time.
 
### Door :door:
- [ExitRoom](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/ExitRoom.cs) - Activated when the player finds the exit key and is at the door.
 The script moves to the next scene and calculates the player points.
 
### Animation :camera:
- [EndAnimation](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/EndAnimation.cs) - 
In this game we used two animations:
    - Camera Animation - moves the camera around.
    - Canvas Animation - fadeout black canvas.
    
This two animations gives the player a feeling that he does wake up and get him more into the game world.
Both animations run straight at the beginning of the game, at the end of all the animation we have defined
 a variable `AnimationEnded` that symbolizes the end of the animation.
 When `AnimationEnded` equals true it means that the animation was finished and we can close the animator.
