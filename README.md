# class-project

3/28/19 Ruthie McCasland
I created tables for student information, courses and grades.My intention is for there to be able to be multiple entries for registered courses and exam grades in the Student table and I am not 100% sure that is acheivable with the code I have now.

I created 2 functions; 1 to calculate exam grade average and another to calculate GPA. I'm wondering if having a separate function to calculate exam grade average is redundant. 

Within the 2 functions I created, I attempted to join together the tables using the studID primary key found in the Student table and that can be found in Courses and Grades tables. These are the INNER JOIN commands you can see in my code.

I am wondering if this is all the tables that we are going to actually need. Looking at the assignment requirements, we just need to be able to have a login for Admin that allows them to update information, as well as add or remove items. We also need one more login for User that allows them to view a table of all of the student information in a read-only format.
