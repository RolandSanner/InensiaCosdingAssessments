# InensiaCosdingAssessments


Task 1 – C#.

Develop a Console Application that reads the file “Input.txt”. Create a class called “MovieStar” and assign the properties from the file to instances of this class. Loop through each object of “MovieStar” and display the properties to the console. Calculate the age of each actor as shown in the example picture bellow. Use “Newtonsoft.Json” framework.


Task 2 C#

Create a console application that would calculate and output thegiven the gross value as input. The taxation rules in the country of Imaginaria as of date are as follows:
1.)	There is no taxation for any amount lower or equal to 1000 Imagiaria Dolars (IDR).
2.)	Income tax of 10% is incurred to the excess (amount above 1000).
3.)	Social contributions of 15% are expected to be made as well. As for the previous case, the taxable income is whatever is above 1000 IDR but social contributions never apply to amounts higher than 3000. 
Example 1 : George has a salary of 980 IDR. He would pay no taxes since this is below the taxation threshold and his net income is also 980.
Example 2 : Irina has a salary of 3400 IDR. She owns income tax : 10% out of 2400 => 240. Her Social contributions are 15% out of 2000 => 300. In total her tax is 540 and she gets to bring home 2860 IDR

*After completing the task, please leave some comments explaining how new taxes could be added to the system.



Task # 3 Javascipt (use vanilla Javascript)

Create a function that, given a DOM Element on the page, will return an array that contains the element itself and all its descendants (not just its immediate children).

For the ul#bottomMenu element the function should return elements [ul,li,li,a,a] (the order doesn’t matter).


<html>
    <head>
        <script>
            // your function goes here. Show examples of how to use the function.
        </script>
    </head>
    <body>
        <h1>Sample page</h1>
        <div id="row">
            <div id="col1">
                <h2>Section 1</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ipsum quam, condimentum ac pulvinar sed, luctus sed libero. Vestibulum vestibulum sodales tellus, sit amet placerat nulla venenatis non. Nunc facilisis est eget facilisis sollicitudin. Proin placerat mi eget consequat congue. </p>
                <p>Pellentesque finibus convallis magna, in convallis sapien fermentum id. Quisque rutrum sapien at sagittis sagittis. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum a interdum felis. Vestibulum ac nunc vel turpis posuere venenatis a eu arcu. Morbi vulputate massa sit amet dui consectetur efficitur. Phasellus a lobortis enim. Mauris hendrerit consectetur orci eget scelerisque.</p>
            </div>
            <div id="col2">
                <h2>Section 1</h2>
                <p><a href="#">Lipsum dolor</a> sit amet, consectetur adipiscing elit. Nunc ipsum quam, condimentum ac pulvinar sed, luctus sed libero. Vestibulum vestibulum sodales tellus, sit amet placerat nulla venenatis non. Nunc facilisis est eget facilisis sollicitudin. Proin placerat mi eget consequat congue. </p>
                <p>Pellentesque finibus convallis magna, in convallis sapien fermentum id. Quisque rutrum sapien at sagittis sagittis. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum a interdum felis. Vestibulum ac nunc vel turpis posuere venenatis a eu arcu. Morbi vulputate massa sit amet dui consectetur efficitur. Phasellus a lobortis enim. Mauris hendrerit consectetur orci eget scelerisque.</p>
            </div>
        </div>
        <footer>
            <ul id=”bottomMenu”>
                <li><a href="#">Home</a></li>
                <li><a href="#">About</a></li>
            </ul>
        </footer>
    </body>
</html>




