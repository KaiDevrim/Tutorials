function like(thing) {
  return 'I like ' + thing;
}

function love(thing) {
  return `I love ${thing}`;
}

const sentence = `<p>${like('apples')}, but ${love('oranges')}.</p>`;

document.querySelector('.interpolation').innerHTML = sentence;
