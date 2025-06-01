/*
Modifications I made to the game:
- 1 - Enabled fog
It now being nighttime outside makes it easier to see the fog, obstructing the player's view if they're on opposite sides
of the castle. The fog itself is also VERY light blue.
- 2 - Completely revamped walls into a proper castle
I've added special textures for the walls, and the doors around each corner of the castle as well. 
Hopefully it brings out a better atmosphere than the crude looking sandbox from before!
- 3 - Retextured floor & skybox
The floor is now made of sand, as a neat callback to what the game used to look like. I also added a cartoonish looking
skybox to reflect the lightheartedness of the game!
- 4 - Turned balls into prefabs
Everything's a bit neater now, which I guess is cool.
- 5 - Goal collison is now bigger, making it less tedious to win
Goal dimensions used to be 3x2x3, but now they're 5x2x5. Almost twice as big, actually. 
- 6 - Donuts added for extra chaos
They bounce around the map too, but mostly because I thought it would be funnier NOT to anchor them.
- 7 - Pressing R now resets the game
I felt like adding this as a debug feature, just in case the game ends up breaking for whatever reason. Plus, it's also
a good way to immediately hop back into the action after beating the game!
- 8 - The game now records how long the player took to beat it
This is honestly a last minute addition, but I wanted to impliement it anyway because past me promised I would if I knew
how. I've grown quite a bit since then!

Known Bugs:
- 1 - The castle's lighting seems to be more dim than it's supposed to
I'm... honestly not sure what causes this? The lighting seems to be fine if the game's directly loaded in its own scene
instead of the start menu, so what gives? 
- 2 - Smaller balls sometimes glitch out of the castle and travel into the void
This might have something to do with the extremely high velocity they get from bouncing around the castle? I've filled in
seemingly every possible gap the balls could travel through, so they're probably just using wallclip hacks or something.
*/