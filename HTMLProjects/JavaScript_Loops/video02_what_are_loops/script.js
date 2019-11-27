var upper = 100000;

var d = new Date();
d.setMilliseconds(0);
//var milli = d.getMilliseconds();

var d2 = new Date();
d2.setSeconds(0);
//var seconds = d2.getSeconds();

var randomNumber = getRandomNumber(upper);
var guess;
var attempts = 0;

function getRandomNumber(upper) {
  return Math.floor( Math.random () * upper ) +1;
}

while ( guess !== randomNumber ) {
  guess = getRandomNumber( upper );
  attempts += 1;

  d += 1;
  d2 += 1;

  //milli += 1;
  //seconds += 1;
}

document.write("<p>The random number was:" + randomNumber + "</p>");
document.write("<p>It took the computer: " + attempts + " attempts to get it right.</p>");

//document.write("<p>It took the computer: " + milli+ " milliseconds to calculate this number</p>")
//document.write("<p>It took the computer: " + seconds + " seconds to to calculate this number</p>")

document.write("<p>It took the computer: " + d + " milliseconds to calculate this number</p>")
document.write("<p>It took the computer: " + d2 + " seconds to to calculate this number</p>")
/* var counter = 0;

while ( counter < 10) {
  var randNum = randomNumber(6);
  document.write(randNum + " ");
  counter += 1;
}
*/