# in-class-activities
## Devlogs
### W1
### What happens:
#### The camera stays still and no longer follows the cat when it moves.
### Why: 
#### Because in Unity, a child object automatically follows its parent's movement. Since the camera is no longer a child of the cat, it becomes independent and won't inherit the cat's position changes.
[In-class Activity](https://xwang2772.itch.io/gdim31a1)
### W2
#### 1.We use float because game engines calculate colors using decimals between 0.0 and 1.0 to handle smooth color transitions and brightness adjustments. Using int wouldn't allow decimal precision, bool only offers true/false, and string can't be used for math operations.
#### 2.We use int because bounces are discrete, countable whole numbers like 1, 2, or 3. The ball can't bounce half a time, so we don't need float, it's not just a simple true/false state (so bool isn't enough), and it doesn't need to be text, so string isn't appropriate.
#### 3.The error warned us that the red channel value went past its upper limit of 0.9. It pointed out that color variables have strict numerical boundaries, so we need to add logic in our code to reset the value back to 0.0 once it hits the maximum.
### W3
#### A1
##### q1:The method takes the player's friendship level (integer) and whether they know the secret (boolean) as inputs to evaluate which text response to output, returning the character's line as a string
##### q2:The method takes the player's sanity level (number) as an input parameter to adjust the room's light brightness directly. Since it modifies the scene directly and does not need to return a value, the return type is void
##### q3:The method takes the timestamp of when the key was pressed (float) as an input parameter to calculate accuracy. It returns a bool (true if the beat was hit accurately, false otherwise).
#### A2 
##### A Class is like the design blueprint for an Air Conditioner, defining its data and capabilities. A Component is the physical AC unit actually installed into a specific room (GameObject) to give it temperature-control functionality. Member Variables are its current settings (e.g., targetTemperature or isPowerOn), while Methods are the actions it can perform, such as TurnOn() or SetTemperature()
### W4
#### 1:I added Rigidbodies to the Cat and SoccerBall because I wanted them to have physical collisions. I checked Is Trigger on the Goal's Box Collider because I wanted the ball to pass through the goal and still detect when it entered the goal area.
#### 2:My game did not work perfectly at first. The cat could not kick the ball correctly. I checked the Collider and Rigidbody settings and adjusted them. After that, the cat could kick the ball and the game worked better.
### W5
#### 


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
