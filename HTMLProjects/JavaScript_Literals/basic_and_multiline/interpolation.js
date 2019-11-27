function like(thing) {
  return 'I like ' + thing;
}

const sentence = `<p>` + like(`apples`) + `.</p>`;

//document.querySelector('.interpolation').innerHTML = sentence;
