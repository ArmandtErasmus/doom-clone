# Doom Clone
Recreation of the 1993 classic, Doom, in Unity.

# Details
In this project, my aim is to recreate the game called Doom which was released in 1993 by id Software.
A recreation might not be an accurate description since I am making my own sprites (graphics), the core of the game mimics the classic fps style of games released in the same era.

# Features
1. The camera is restricted to horizontal rotation, similar to Doom, however this is just for effect and not due to any constraints.
2. Some gameobjects which are rendered as 2D sprites rotate according to the position of the player.
3. Enemy AI and pathfinding capabilities (Using a NavMesh Agent).

# Billboard Rotation
This is a very interesting feature of classic games. Some sprites in games such as Doom 1 and Doom 2 are 2D, however when the player walks around these gameobjects, they appear to be 3D. This is done by letting the sprites rotate toward the player. In my game, I've implemented this feature by creating an axis of rotation along the y-axis and so naturally the plane of rotation is the xz-plane. Note that in Unity, the left/right and forward/backward motion components are both restricted to the x and z axes, whereas the vertical motion components are in the y axis; this is the case for a 3D engine. Therefore, in order to recreate this rendering technique, I created this simple diagram:
