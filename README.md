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

### First 30 seconds

You find yourself locked in a locked auditorium after falling asleep in a math class. 

The door is locked and there is no visible key. 

You can start walking around the room freely in search of a way to open the door.

There are many clues scattered throughout the room, once you found and resolved 
the clue you will get a hint of the next one that will bring you closer to the exit.

### Explanation

At the beginning of the game the player wakes up from his sleep.

The room is dark to make the player reach the switch of light that is at the exit door.

On the door the player can find his first clue, we
 created a easy clue that will lead the player to another area in the room
 so we allow the player to see the room before it begins with the heavier hints.
 
### Scripts
#### Player :sunglasses:
The player object contains 3 scripts: [Player Scripts](https://github.com/ChenOst/University-Escape-Room/tree/master/Assets/University%20Classroom/Scripts/Player)
- [Move Player](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Player/MovePlayer.cs) - moves the player around with arrows ot AWSD keys.
- [Move Camera](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Player/MoveCamera.cs) - moves the camera with the mouse.
- [Player](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Player/Player.cs) - contains all the information of the player (score etc.).

#### Clues :mag:
The clue objects in the game contains 2 scripts:
- [ActiveClue](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/ActiveClue.cs) - Activate the clue if the player is close and enters E key.
- [Clue](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/Clue.cs) - contains all the information of the clue (clueId, rightAnswer, Clue question etc.).

#### Lights :bulb:
- [ActiveClue](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/TurnTheLights.cs) -
This script turn off and on the lights in the room, if the player is close to the switch object and presses E key.

#### Message :envelope:
- [FirstMessage](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/FirstMessage.cs) -
The message pops up only once, after the wake up animation was ended. It gives the player more inforamtion about the game.

#### Animation :camera:
- [EndAnimation](https://github.com/ChenOst/University-Escape-Room/blob/master/Assets/University%20Classroom/Scripts/EndAnimation.cs) -
In this game we used two animations:
    - Camera Animation - moves the camera around.
    - Canvas Animation - fadeout black canvas.
    
This two animations gives the player a feeling that he does wake up and get him more into the game world.
Both animations run straight at the beginning of the game, at the end of all the animation we have defined
 a variable `AnimationEnded` that symbolizes the end of the animation.
 When `AnimationEnded` equals true it means that the animation was finished and we can close the animator.

#### Version 1
In this version we added the basics and created the first thirty seconds of the game, 
the following list shows all the objects we created:
- [x] First Scene - Main Menu
    - [x] Start Game button
    - [ ] Credits
    - [x] Exit button
    - [ ] Advanced design
    
- [x] Second  Scene - The Game
    - [x] Room structore
    - [x] Room accessories
    - [x] Wake up animation
    - [x] Player
        - [x] Players movement
        - [x] Camera
        - [ ] Advanced design - players animation
    - [x] Clues
        - [x] First clue
        - [ ] All clues
        - [ ] Easter egg
    - [x] Menu
        - [ ] Calculator
        - [x] Clock
        - [x] Score
        - [x] Book
            - [ ] Formula sheet
            
