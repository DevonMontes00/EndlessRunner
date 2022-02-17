-----------------------------------------------------------------------------------
Assignment 2: Survival-Like Game README
-----------------------------------------------------------------------------------
Student Name: Devon Montes
Student abc123: iog693


-----------------------------------------------------------------------------------
Links to Project (Such as Google Drive, OneDrive, or Dropbox for submission)
-----------------------------------------------------------------------------------
Please provide your Google Drive, OneDrive, or Dropbox link here. 
(Make sure the link does not expire and the link permissions allow us to download, 
otherwise you may receive a grade of 0 on your assignment submission if we cannot 
download it.)

Place this Link to Your Unity Project Here:



-----------------------------------------------------------------------------------
Version of Unity You Used for Your Game
-----------------------------------------------------------------------------------
Please write down the version of Unity you used when making your game here (e.g.
2019.4, 2020.1, 2020.2, etc...):

2020.3.16f1

-----------------------------------------------------------------------------------
Which Operating System You Made Your Game In
-----------------------------------------------------------------------------------
Please write down which operating system the computer you used while you worked in 
Unity has.  Are you using a MS Windows PC, or a Mac, or a Linux computer, etc.?  
(This matters because when you build the game, some of the files Unity produces 
will be different and your TA/grader needs to know this in order to properly open 
your project):

Windows 10
-----------------------------------------------------------------------------------
Game Controls 
-----------------------------------------------------------------------------------
Please explain what your buttons do. (You do not have to use all of these buttons.
If you use buttons other than these, please mention them to let us know.)

Mouse Movement:
Mouse Click: 
W: move forward 
A: move left 
D: move right
S: move backward
Spacebar: jump
Esc: pause game
left click: shoot gun
E: purchase weapons/open doors

-----------------------------------------------------------------------------------
Assets Downloaded for Game
-----------------------------------------------------------------------------------
Any assets that you downloaded and used from the Asset Store needs to be documented.
Please provide any links to these assets from the Asset Store you downloaded here:

https://assetstore.unity.com/packages/tools/gui/progressbar-pack-120981
https://assetstore.unity.com/packages/3d/environments/urban/abandoned-asylum-49137
https://assetstore.unity.com/packages/3d/chainlink-fences-73107
https://assetstore.unity.com/packages/3d/props/guns/guns-pack-low-poly-guns-collection-192553
https://assetstore.unity.com/packages/essentials/starter-assets-first-person-character-controller-196525

-----------------------------------------------------------------------------------
Instructions for Students
-----------------------------------------------------------------------------------
Please make sure you place all of your written scripts within a folder called 
"Scripts" to make it easier for the professor and/or TA/grader to find your 
written code for grading.  Make your game windowed at 720 by 576 resolution.
Follow the assignment submission instructions in the file titled "Step-By-Step
Guide for Assignment Submissions" on Blackboard for more detailed information.
Remember that your game is tested in the build executable, not the Unity Editor,
so please double-check that that works as intended before submitting your 
assignment.

The following sections are divided into each grading criteria for your assignment
submission. For each section where you must briefly describe something, a sentence
or two is all that is needed just to get your point across. If you did not
implement a particular feature (grading criteria), such as the extra credits, then 
simply mention "Did not do".  If you do not answer a question below it will be
assumed that you did not implement that feature and you will be docked the amount of
points that that particular grading criteria has so please double-check that you 
have answered all questions for the things you have implemented so your TA/grader 
can award you full-credit.


-----------------------------------------------------------------------------------
1. Movement - Mouse Look + Keyboard (10 pts)
-----------------------------------------------------------------------------------
Briefly describe how you implemented your mouse look and your character movement. 
e.g. Which script did you write that implements this? (Mention whether this script 
was attached to any game object and which ones.)

I was able to implement mouse look and character movement by using the first person character controller from the unity
asset store. This asset has a prefrab that is called "NestedParent_Unpack" which as everything need for character movement.
The prefab has a First Person Controller script which is attached to the player capsule of the prefab.

-----------------------------------------------------------------------------------
2. Raycasting - Shooting Enemies or Vice-Versa or 3D Object Selection, etc (20 pts)
-----------------------------------------------------------------------------------
Briefly describe how you implemented your raycasting for things in your game such
as shooting enemies or vice-versa. e.g. Which script did you write that implements
this? (Mention whether this script was attached to any game object and which ones.)

I implemented raycasting using the gunScript which I created. When Fire1 is pressed, a function called Shoot is called. This
function creates a Raycast and shoots the raycast out in front of the player which returns the object that it hits. The gunScript
is attached to the playercapsule.

-----------------------------------------------------------------------------------
3. 3 Types of Weapons/Items and a Way to Select Them (20 pts)
-----------------------------------------------------------------------------------
Briefly describe how you implemented your 3 types of weapons/items and how your
selection system works. e.g. Which script did you write that implements this and 
also what button or mechanism do you use to switch between these weapons/items? 
(Mention whether this script was attached to any game object and which ones.)

I have 9 different types of weapons. There are 3 pistols, 2 shotguns, 2 SMGs, and 2 assualt rifles. They are scattered around the map 
and can be purchased for the player to use with the points they get for defeating zombies. I wrote a "Pick Up Controller" script which 
allows the purchasing of these weapons. When a player has enough points to purchase a weapon, they can simply walk up to it and press "E"
to complete the purchase. The "Pick Up Controller" script is attached to every gun that is scattered on the map.

-----------------------------------------------------------------------------------
4. Randomly Spawning Never-Ending Enemies (20 pts)
-----------------------------------------------------------------------------------
Briefly describe how you implemented a stream of randomly spawning (and never-
ending enemies). e.g. Which script did you write that implements this? (Mention 
whether this script was attached to any game object and which ones.)

Outside of the map, there are "spawnpoints". This spawnpoints are gameobject spheres each tagged as a different spawnpoint. In my "GameController" script,
I have a CountDown function, which waits 5 seconds before every round. Once the CountDown function is finished, it calls a spawnZombies function. This
function goes to every spawnpoint on the map and checks if it is avaliable to spawn zombies (as some spawnpoints are not available till you unlock 
certain parts of the map). The GameController checks if its spawnable by checking the "spawnerScript". If a spawn point is available, it will spawn a zombie, 
reducing the numOfZombsToSpawn variable. The function will then continue onto the next spawnpoint and repeat the process until reaching the last spawnpoint. 
If the function reaches the last spawnpoint and still has zombies to spawn it will restart to the first spawnpoint and continue the process untill the 
numOfZombsToSpawn is equal to zero. Every round, the "GameController" script increases the number of zombies by adding 5 * (the round  - 1). The 
"GameController" script is attached to the GameManager GameObject. The "spawnerScript" is attached to every spawn point on the map.

Did you use spawn points for these enemies?  If so, give the x, y, and z 
coordinates of these spawn points.

Spawnpoint 1: X: -0.4365 Y: 2.25 Z: 0.25505
Spawnpoint 2: X: -0.1601935 Y: 2.25 Z: 0.25505
Spawnpoint 3: X: 0.1540398 Y: 2.25 Z: 0.25505
Spawnpoint 4: X: 0.4314732 Y: 2.25 Z: 0.25505
Spawnpoint 5: X: -0.3318 Y: 3.154999 Z: 0.25155
Spawnpoint 6: X: -0.01832684 Y: 2.854999 Z: 0.25155
Spawnpoint 7: X: 0.2969065 Y: 2.72 Z: 0.25155

Briefly describe how you implemented enemies being able to "kill" you. e.g. Which 
script did you write that implements this? (Mention whether this script was 
attached to any game object and which ones.)

The "zombieScript" creates a variable distance between every zombie and the player. If the zombie gets within a range of 4, it will begin the attack animation. 
After 1 second of the animation beginning, if the zombie is within a range of 2, the player will take 10 points of damage. The players health is a total of 
100 points. If this reaches 0, the game over screen will appear. The "zombieScript" is attached to all the zombiePrefabs.

(On a side-note, please do not make it so that the game application window quits 
when you die. You might want to make it so that your game returns to a menu where
you are given the option to quit the application as a button or something. Just 
think about when you play games on consoles. Does your game console just shut off 
whenever you die in a game forcing you to get up to push the Power button to turn 
on your system again? Obviously not. So please do not do that with your game here.)


-----------------------------------------------------------------------------------
5. 3 Enemy Types (10 pts)
-----------------------------------------------------------------------------------
Mention your enemy types here.  (Minimum of 3)  Mention which folder in your 
project that you have placed these prefabs so that we can view them.

Name of Folder with Enemy Prefabs: Prefabs
Enemy 1: zombie male
Enemy 2: zombie female
Enemy 3: cop zombie


-----------------------------------------------------------------------------------
6. Pathfinding AI for Enemies (20 pts)
-----------------------------------------------------------------------------------
Please indicate that you indeed used a NavMesh and that there are places on your
map where you must jump to where enemies can follow using off-mesh links:
(Answer Yes or No)

Yes

How many locations on your map did you create where enemies can follow you using 
off-mesh links? 

1

Mention at least one general location with a x, y, and z coordinate that is 
close to where you placed an off-mesh link: (_, _, _)

Top = 0, 3.874, 9.267
Bottom = 0, 0.202, 6.749

-----------------------------------------------------------------------------------
7. Randomly Spawning Power-Ups (including a "healing" power-up) (20 pts)
-----------------------------------------------------------------------------------
List the power-ups that you implemented in your game (there should be a total of 4
power-ups which include 1 healing power-up and 3 others of your choice) and the 
object associated with that power-up. These objects must be items that are randomly
spawned somewhere on your game map. (Explain what your object looks like, such as a 
yellow coin, blue star, etc. so that the TA/grader can easily identify them when 
testing your game in the "Power-Up Object Description" section below. Do not just
put the name of your Asset. Things like "Coin1", "Coin2", etc. tell the grader 
nothing about what to look for.) Fill in the following-chart and mention how much 
health your character gains back from a healing power-up:

   Power-Up Object Description	|                Power-Up Effect
1) HealthPU                     | Healing Effect: Heals 10 amount of health back
2) InstakillPU                  | Makes all zombies die on the first shot
3) Invincability                | Cannot be damaged for 10 seconds
4) Double Tap                   | Doubles fire rate of current weapon

Briefly describe how you implemented this being displayed somewhere on the screen,
especially how you randomized the objects and placement of these objects. e.g. 
Which script did you write that implements this? (Mention whether this script was 
attached to any game object and which ones.)

These powerups have a chance of dropping when a zombie is killed. This is controlled in the zombieScript which is attached to
all zombie prefabs. Depending on the tag of the dropped powerUp, if the player gets within a certain range of the powerUp, the 
player will obtain the power up. This is controlled in the PUscript which is on all PowerUp prefabs.


-----------------------------------------------------------------------------------
8. Mecanim-Based Character Animation for Both Enemies and Main Character (20 pts)
-----------------------------------------------------------------------------------
Please list the folder(s) in your project where your animations are stored for your
character/enemies:

Animation/ScaryZombiePack2
 
Please list the folder(s) where your Animator Controllers for your character/enemies
are stored:

Animation/ScaryZombiePack2


-----------------------------------------------------------------------------------
9. Advancing Levels When All Enemies are "Dead" (20 pts)
-----------------------------------------------------------------------------------
Briefly describe how you implemented your character advancing to the next level
after all of the enemies are "dead". e.g. Which script did you write that 
implements this? (Mention whether this script was attached to any game object and
which ones.)

When a round begins, there is a variable that keeps track of the number of zombies in that round. When a zombie dies, that variable 
decreases by 1. Once the variable reaches 0, the NextRound() funciton will begin, starting the next round. This is controlled by the "GameController"
script which is attached to the Game Manager object.


Briefly describe what pops up when you advance to the next level. If there is a 
script associated with this, what is it and what game object is it attached to?

When a round ends, the round number in the rop right will change and a new number will be added to the number in the top left for zombies remaining.
This is controlled by the "GameController" which is attached to the Game Manager game object.


Briefly describe how each level has more or stronger enemies. e.g. Which script did
you write that implements this? (Mention whether this script was attached to any
game object and which ones.)

When a new round starts, 5 * (round) is added to the health of zombies. This is controlled by the ZombieScript, which is attached to all zombie prefabs.


-----------------------------------------------------------------------------------
10. Fully Featured HUD (10 pts)
-----------------------------------------------------------------------------------
Please fill in the following list for your HUD features and their locations within
the HUD (such as top-left, bottom-right, top-center, bottom-center, etc.):

       		 HUD Feature        		          |      Location within HUD
1) Current Level       				              |  Top Right of screen
2) Number of Enemies Left to Kill in Current Wave |  Top Left of screen
3) Icons for Current Weapons / Items Available    | 
4) Icon for "Life"                                |	 Top Middle for screen

Please mention the scripts that are associated with each of these HUD features.
GameController

What is your character's life based on (i.e. hit points, money left, etc.)?
hit points

-----------------------------------------------------------------------------------
11. Game Menus and Nice Title Screen (10 pts)
-----------------------------------------------------------------------------------
You are free to add whatever buttons or controls you want for your title screen, 
but you at least must implement some sort of "Play" or "Start" button. Your title 
screen should not just be plain text. It needs to have something on it, like an 
image or some animation or something to be considered "nice" as the instructions 
request. You must also implement some sort of "Quit" button that quits the game 
application entirely.

Which script(s) is associated with your Title Screen?

StartMenuScript

In addition to your title screen menu, what other game menus did you implement 
(such as a pause menu, a game over menu, etc)?

Pause Menu
Game Over Menu

Which script(s) are associated with each of these menus?

MenuScript

-----------------------------------------------------------------------------------
12. Nice Textured Assets (10 pts)
-----------------------------------------------------------------------------------
It is up to you which assets you would like to add to your game.  Please just
mention a few that you used here:

Assets_FenceChained
Low Poly Guns
First Person Controller

-----------------------------------------------------------------------------------
13. Music and 3D Audio FX (10 pts)
-----------------------------------------------------------------------------------
-Music-
You are free to add whatever music you wish to your game. However, there must be 
at least 2 music sources. One for your title screen and the other for in-game.
Please list the name of the songs used. If you downloaded them from a website, 
please document the source. If you used more than 2 songs, please list them and
their source as well.

1) Title Screen Music Name: The One - Treyarch
   Title Screen Music Source: https://www.youtube.com/watch?v=jG-6AXvk1vE

2) In-Game Music Name: Not Ready to Die - Aveneged Sevenfold
   In-Game Music Source: https://www.youtube.com/watch?v=WKP9RwoTWwE


-Audio-
You are free to use whatever 3D audio FX sounds you like. You can use as many sounds 
as you would like for things like your character dying, enemies shooting/attacking,
enemies dying, etc. You MUST use a sound for your weapon/gun firing.   
Please list the sounds you used in your game here:

         Audio FX Sound Effect       |      When Audio FX is Used
1) Glock Sound		         | Used when shooting glock
2) Desert Eagle Sound	     | Used when shooting Desert Eagle
3) M4 Sound				     | Used when shooting M4
4) AK-47 sound				 | Used when shooting AK-47


-----------------------------------------------------------------------------------
*Extra Credit* Terrain (5 pts)
-----------------------------------------------------------------------------------
If you implemented a terrain, then please just mention which folder you have placed 
your textures for it here:


-----------------------------------------------------------------------------------
*Extra Credit* Lightmapping (5 pts)
-----------------------------------------------------------------------------------
If you implemented any lightmaps, then please just mention which folder you have 
placed your lightmaps here:


-----------------------------------------------------------------------------------
*Extra Credit* Particles (5 pts)
-----------------------------------------------------------------------------------
If you implemented any particles, then please just mention which folder you have 
placed your particle prefabs here:

Muzzle flash on guns

-----------------------------------------------------------------------------------
*Extra Credit* Image Effects (5 pts)
-----------------------------------------------------------------------------------
If you implemented any image effects, then please mention what these are and what
game objects they are attached to:


-----------------------------------------------------------------------------------
Any Notes or Things the Professor or TA/Grader Should Be Aware Of
-----------------------------------------------------------------------------------
If there are any other concerns that you have about your submission or any known
bugs/glitches in your game that could potentially come up, please explain them here:
