# GameEnginesProject

## Bump

### What I set out to do at the beginning:

I planned for Bump to be a procedurally generated platforming music visualiser.
How the game would work is the player would spawn on top of a lane of moving,
colour changing cubes that constantly spawn and move towards the player before 
falling as the player passes them. This was inspired by the game ClusterTruck. The 
blocks will also bounce up and down as they move in time with the music playing 
through the game akin to many generic visualisers. The cubes would also come in
various randomly generated patterns and with randomly generated obstacles to keep
gameplay fast paced and exciting while also hopefully creating some gorgeous
visuals to keep things interesting.

[ClusterTruck Trailer](https://www.youtube.com/watch?v=ZLMIpok-aZ0)

[Bar-graph type Music visualiser](https://www.youtube.com/watch?v=82Q6DRqf9H4)

For an art style I was thiking something along the lines of Beatsaber with darker colours
contrasted with bright primary coloured neon for that flashy club/EDM feeling.

[Beat Saber](https://www.youtube.com/watch?v=rh0ZRCOIgmw)

## And now what I have done:

Bump is a 3D Platformer that uses music to procedurally generates maps. It does this but taking the height of the individual bars of the music visualiser I have listening to the internal sound of the game and spawning platforms at regular increments at the height the bar was at in that moment. The bars of the visualiser are wrapped in frequency bands that only detect 1/8th of the frequency range and increase their y scale based off of the amount of that frequency present in the music. Childed to each of these bars I have a game object thats y transform is equal to its corrisponding bars y scale. This lead to the song selection becoming the difficulty selection in a way as the heavier, louder songs spiked the visualiser higher and thus created more spaced out an high up platforms. The player jumps around the scene while bouncing off of almost every surface to allow them to climb by flowing through the approaching platforms and bouncing off of the lower platforms from increasing heights. Wanting to allow the player to have an only enjoyable experience; dying by falling off of the platforms doesn't stop the fun, instead it rockets the player upwards giving them a much needed boost and turning 'messing up' into a sound strategy to gain some height! As a sort of safety net, I have a spawner generating rows of thick blocks to act as a broken up floor of bouncepads to allow the player to regain their footing if they lose their momentum. To prevent the game from starting to lag after a while, I have two game objects that serve as 'killers' that destroy any object that moves towards them. One serves as the floor and the other serves as the wall of white the blocks all move towards. I made only the wall white, specifically a blinding white, to tell the player that it is a white void - something consuming all colour that enters it. However, the only object they don't destroy is the player, instead they move the player to their respawn point and give them a rigidbody boost to keep them going. Every other object in the scene has a 'bouncy' physics material to allow the player to jump around. To give the game its look I used post processing and shaders to give a neon glow to everything while I replaced the skybox with a Night Sky to give a little space aestethic.

### What I'm proud of

I'm really proud of the games overall feel. The controls are light and give the player the feeling that they're gliding around the world or flying; the feeling of freedom always brings a smile to my face. The movement code was inspired by the original Doom and Quake games. Not the code itself but the way I wanted it to work. Though I didn't get everything perfect, I feel like I got quite close either the level of control you have in the air.

### Building Instructions:

Shouldn't be a problem, UI is set to scale to screen and the controls are universal, my only concern is the volume! To be safe I'd reccommend starting at 50% in case the tracks are too loud. The volume was made to personal preference.

Footage of Bump's Gameplay!

[![Youtube](http://img.youtube.com/vi/mJ6Dka03i7I/0.jpg)](https://www.youtube.com/watch?v=mJ6Dka03i7I)
