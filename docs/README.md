# Puzzler

This project was created as part of the Udacity VR Developer Nanodegree Program. The goal of this project was to teach the fundamentals of design and user centered thinking. This page shows the creative process from inception until completion.

## Statment of Purpose

Puzzler is a mobile VR puzzle game designed for new VR users. It challenges them to solve a familiar simon-says style of puzzle in a new way.

## Final Result (Video)

In this video you can see how the app finally looks like.

<iframe width="560" height="315" src="video link" frameborder="0" allowfullscreen="allowfullscreen"></iframe>

# The Process

Now I cover the complete process of designing this application. This will cover Persona, Sketch and User Testing:

## Persona

### Rhonda, 33 - Stay at home mom
![Image of Rhonda]("Github Raw")

#### About:
Rhonda is a stay at home mom, who has a sole interest in finding creative ways to educate her kids. One of her goals is to integrate technology with education to make learning more inspiring and fun for kids and parents. She loves to solve problems and to create challenging puzzles for her kids. 

She doesn't have any experience in Virtual Reality, but is interested in new technologies.

## Sketch

This sketch is the one and only drawing I made to describe the game mechanics and environment in general it should be almost self explaining:

![Image of Sketch]("Github raw sketch")

# User testing outcomes and iteration

Here are the testing outcomes from the different user tests. They all divide in Questions, Iterations #x and findings.

## Scale and Mood User Test

### Main Questions:

	1.) What do you think about the scale of yourself, is everything as big or small as it should?
	2.) Is the mood well established? What do you think, where you are?
	3.) Is the experience comfortable? Do you experience any strange or confusing stuff?

### Iteration #1:

	Ryan, 20:
	1.) I seem to be a little bit smaller than I normally am.
	2.) It seems a bit yellowish, like inside a cave with torches.
	3.) Some objects are flickering.

	Lester, 26:
	1.) The room seems to be bigger than normal. 
	2.) It looks like some kind of cell, it makes me feel a little bit claustrophobic.
	3.) Some objects are flickering.

Here you can see the current state for the user testing:
![Before Iteration](https://raw.githubusercontent.com/drbothen/VRNano/master/docs/Dungeon_Room_before_1.png)

### Findings:
	Good:
		- The ambient is great and is mystical as it should be.
	
	Bad:
		- I think that a problem is in the camera position I raised the camera to make the protagonist feel taller.
		- Some objects are growing inside each other, I fixed that so flickering should stop

After applying my findings the scenery changed marginally:
![After Findings](https://raw.githubusercontent.com/drbothen/VRNano/master/docs/Dungeon_Room_after_1.png)

### Iteration #2:

	Ryan, 20:
	1.) Now the size seems to be good.
	3.) The flickering is gone.

	Lester, 26:
	1.) The room shrank
	3.) Now I know that the room is standing on the ground.
	 
## User Test UI Panels:

### Main Questions:
	1.) Appearance of panel
	2.) Clear meaning

![Panel Tests ]("Github Raw Panel")

### Iteration #1:

	Ryan, 20:
	1.) Good contrast, good to read
	3.) Know what it should do.

	Lester, 26:
	1.) Nice color, nice highlight
	3.) Clear.
	 
### Findings:
	Good:
		- Everything seems to be clear
	
## User Test on Movement:

### Main Questions:
	1.) Speed of movement?
	2.) Feel uncomfortable?

### Iteration #1:

	Lester, 26:
	1.) Speed is a little bit too fast, I'm feeling dizzy.
	2.) Camera is positioned to near to the magic balls.
	
	
### Findings:
	Bad:
		- The speed was set to fast so I reduced the speed of travel.
		- The camera was positioned to near to the orbs so moved the way point further back.
		
### Iteration #2:

	Lester, 26:
	1.) Now it seems to be slower, but good.
	2.) Seems to be good now.
	
	
## Sound user test and other stuff (Final)
### Main Questions:
	1.) Does the sound feel comfortable?
	2.) Other stuff?
	
### Iteration #1:

	Lester, 26:
	1.) Failure sound is far too loud.

### Findings:

	Bad:
		- I set the sound volume of the failure sound to 0.5 instead of 1.0, because it was set far too high.
	
# Breakdown of final piece

This is a brief overview on the main elements of the game:

## Welcome UI (Start Game)
This is the screen the user will see at the beginning of the application, after pressing the user flies into the dungeon.
![Image of Welcome UI]("Raw First screen")

## Orbs (Play Game)
You can see the main game mechanic, the orbs. The orbs light up in random combinations:
![Image of Lightning orb]("Simon Orb")

 You have to repeat the order they did that by pointing and clicking on them:
![Image of Selected Orb]("Selected Orb")

## End UI (Restart Game)
This is the screen users see after successfully finishing the puzzle:
![Image of Finish UI]("Finished Puzzle")

# Conclusion

Building this project was a great experience and I would recommend anyone interested in developing for VR to take the VR developer Nanodegree program. This project proofed to be of moderate difficulty, but proved to be invaluable tool into the insight of user centered design and how user testing is performed  

# Next steps:

It would be great to add more features to this application some of them could be:

	1.) Improved lightning
	2.) Add particle effects to the torches for added realism
	3.) Multiple iterations and levels

# Link to additional work
Have a look at my other projects: 
"Link to additional Work"
