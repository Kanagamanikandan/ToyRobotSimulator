<h3>Toy Robot Simulator</h3>
<h2>Description</h2>
<br>- The application is a simulation of a toy robot moving on a square tabletop, of
dimensions 5 units x 5 units.
<br>- There are no other obstructions on the table surface.
<br>- The robot is free to roam around the surface of the table, but must be prevented from
falling to destruction. Any movement that would result in the robot falling from the
table must be prevented, however further valid movement commands must still be
allowed.
<br>The application should be able to read in any one of the following commands:
<br>PLACE X,Y,F
<br>MOVE
<br>LEFT
<br>RIGHT
<br>REPORT
<br>- PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH,
EAST or WEST.
<br>- The origin (0,0) can be considered to be the SOUTH WEST most corner.
<br>- The first valid command to the robot is a PLACE command, after that, any sequence
of commands may be issued, in any order, including another PLACE command. The
application should discard all commands in the sequence until a valid PLACE
command has been executed.
<br>- MOVE will move the toy robot one unit forward in the direction it is currently facing.
<br>- LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without
changing the position of the robot.
<br>- REPORT will announce the X,Y and F of the robot. This can be in any form, but
standard output is sufficient.
<br>- A robot that is not on the table should ignore the MOVE, LEFT, RIGHT and REPORT
commands.
