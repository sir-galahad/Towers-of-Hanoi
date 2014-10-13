Towers-of-Hanoi
===============

My implementation of and solution to the "Towers of Hanoi"

Most of what I know of programming comes from chat rooms and IRC one common thing people seemed to cry for help with
is the "Towers of Hanoi" I guess it's often assigned as homework in early CS classes? Anyway once I learned what it was 
I thought I would take a shot at it. 

The rules for the Towers of Hanoi are these:

1. The "game board" has three spaces for stacks of "discs"
2. The game starts with one of those stacks filed with n discs from largest to smallest
3. The goal is to move all of the discs from the starting stack to another stack (usually the farthest stack, but this
   is arbitrary and the difficulty is the same to move all of the discs to either of the non starting positions)
4. The discs can only be moved one at a time from the top (just like a LIFO, or stack data structure)
5. Discs cannot be placed on top of a smaller disc.

In the end the problem really isn't that difficult for a simple recursive solution as my code here shows I believe I have
more code dedicated to displaying the current status of the game than I have written to solving it.

A know problem for a recursive solution here is that a stack overflow can result from a sufficiently large number of discs.
