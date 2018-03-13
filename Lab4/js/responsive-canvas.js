var canvas;

function updateSize() {
	canvas.attr('width',window.innerWidth);
	canvas.attr('height',window.innerHeight);
}

$(document).ready(function () {
	canvas = $('#main-canvas');
	updateSize();
	//setup resize handler
	window.onresize = function(event) {
    	updateSize();
	};
});