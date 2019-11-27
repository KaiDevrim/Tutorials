const singleQuotes = '<p>Single quotes</p>';
const doubleQuotes = "<p>Double quotes</p>";
const templateLiterals = `<p>Template Literal</p>`;

const result = singleQuotes + doubleQuotes;
document.querySelector('.basic').innerHTML = result;
