window.onload = function() {
  // try to create a WebGL canvas (will fail if WebGL isn't supported)
  try {
      var canvas = fx.canvas();
  } catch (e) {
      alert(e);
      return;
  }

  // convert the image to a texture
  let image = document.getElementById('image');
  let texture = canvas.texture(image);

  w = image.width;
  h = image.height;
  hw = w / 2;
  hh = h / 2;
  w75 = w * 0.75;
  // apply the ink filter
  canvas.draw(texture).bulgePinch(hw, hh, w75, 0.12).vignette(0.45, 0.74).update();

  // replace the image with the canvas
  image.parentNode.insertBefore(canvas, image);
  image.parentNode.removeChild(image);
};