# number-baseball
C#. Number baseball game. (UTA homework)

Rules:
1.	At the beginning of the game, a computer chooses randomly three numbers among 1 to 9. These numbers are not shown to the player. The numbers cannot be duplicated.
Example) 913, 319, 457, 175….   335 (incorrect), 340 (incorrect)
2.	The computer accepts three numbers from the player and shows the result for the input. If a number in player’s input matches a number in computer’s number and is placed in the same order, it is considered 1 strike. If a number in player’s input matches a number in computer’s number but is not placed in the same order, it is considered 1 ball.
Example) a computer’s number: 913, a user’s input: 935 ==> 1 strike and 1 ball
                 a computer’s number: 913, a user’s input: 915 ==> 2 strikes 
                  a computer’s number: 913, a user’s input: 395 ==> 2 balls
                  a computer’s number: 913, a user’s input: 865 ==> No strike and no ball.
3.	Players have 5 attempts to guess the correct numbers in the correct order.
