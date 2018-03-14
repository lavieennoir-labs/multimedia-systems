class ResponsiveCanvas {
	constructor(canvasId){
		this.widthRatio = 16/9;

		this.canvas = $('#' + canvasId);
		this.onresize = function (newWidth, newHeight){};
		this.updateSize();
		
		var thisRef = this;
		//setup resize handler
		window.onresize = function(event) {
	   		thisRef.updateSize();
	   		thisRef.onresize(thisRef.canvas.attr('width'), thisRef.canvas.attr('height'));
	   	};
	}

	updateSize() {
		this.canvas.attr('width',window.innerWidth + 1);
		this.canvas.attr('height',window.innerHeight + 1);
		this.widthRatio = this.canvas.attr('width')  / this.canvas.attr('height');
	}
}