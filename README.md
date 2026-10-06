# in-class-activities
## Devlogs
### W1
# What happens:
The camera stays still and no longer follows the cat when it moves.
# Why: 
Because in Unity, a child object automatically follows its parent's movement. Since the camera is no longer a child of the cat, it becomes independent and won't inherit the cat's position changes.
[In-class Activity](https://xwang2772.itch.io/gdim31a1)
### W2
# We use float because game engines calculate colors using decimals between 0.0 and 1.0 to handle smooth color transitions and brightness adjustments. Using int wouldn't allow decimal precision, bool only offers true/false, and string can't be used for math operations.
# We use int because bounces are discrete, countable whole numbers like 1, 2, or 3. The ball can't bounce half a time, so we don't need float, it's not just a simple true/false state (so bool isn't enough), and it doesn't need to be text, so string isn't appropriate.
# The error warned us that the red channel value went past its upper limit of 0.9. It pointed out that color variables have strict numerical boundaries, so we need to add logic in our code to reset the value back to 0.0 once it hits the maximum.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
