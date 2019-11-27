var html = '';

for ( var i = 1; i <= 10000; i += 1 ) {
  html += '<div>' + i + '</div>';
}
document.write(html);