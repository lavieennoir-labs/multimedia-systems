$(document).ready(function () {
	var sceneRenderer = new SceneRenderer('main-canvas');
});


class SceneRenderer {
	constructor(canvasId){
		this.responsiveCanvas = new ResponsiveCanvas(canvasId);
		this.ctx = document.getElementById(canvasId).getContext("2d");

		this.initAssetsData();
		this.initScene();
		this.responsiveCanvas.onresize = this.resizeScene;	

		console.log('SceneRenderer initialized for canvas #' + canvasId + '.');	

		this.enableRender = true;
		this.renderDelay = 1000;
		this.renderTimer = setInterval(this.renderLoop, this.renderDelay,this);
	}

	initAssetsData() {
		this.backgroundData = new SpriteData('assets/ocean-bg.png', 3460, 1080);
		
		this.fishMoveData = new SpriteSheetData('assets/fish-move-spritesheet-92x62x2.png', 2, 92, 62);
		this.fishTurnData = new SpriteSheetData('assets/fish-turn-spritesheet-92x62x3.png', 3, 92, 62);
		this.jellyfishBlueData = new SpriteSheetData('assets/jellyfish-blue-spritesheet-147x147x8.png', 8, 147, 147);
		this.jellyfishOrangeData = new SpriteSheetData('assets/jellyfish-orange-spritesheet-147x153x8.png', 8, 147, 153);
		
		this.crabData = new SpriteSheetData('assets/crab-spritesheet-100x100x2.png', 2, 100, 100);
		this.coralData = new SpriteData('assets/coral-01.png', 195, 195);
		this.seaweedFishData = new SpriteSheetData('assets/seaweed-fish-spritesheet-269x247x4.png', 4, 269, 247);
		
		this.seaweedsData = [
			new SpriteData('assets/seaweed-01.png', 81, 81),
			new SpriteData('assets/seaweed-02.png', 75, 86),
			new SpriteData('assets/seaweed-03.png', 75, 151)
			];
		this.rocksData = [
			new SpriteData('assets/rock-01.png', 97, 60),
			new SpriteData('assets/rock-02.png', 151, 65),
			new SpriteData('assets/rock-03.png', 146, 81)
			];
		//inserting images to html	
		this.responsiveCanvas.canvas.after(
			this.backgroundData.img,
			this.fishMoveData.img,
			this.fishTurnData.img,
			this.jellyfishBlueData.img,
			this.jellyfishOrangeData.img,
			
			this.crabData.img,
			this.coralData.img,
			this.seaweedFishData.img,

			this.seaweedsData[0].img,
			this.seaweedsData[1].img,
			this.seaweedsData[2].img,

			this.rocksData[0].img,
			this.rocksData[1].img,
			this.rocksData[2].img
		);
		//update img
		this.backgroundData.pullImg();
		this.fishMoveData.pullImg();
		this.fishTurnData.pullImg();
		this.jellyfishBlueData.pullImg();
		this.jellyfishOrangeData.pullImg();
		
		this.crabData.pullImg();
		this.coralData.pullImg();
		this.seaweedFishData.pullImg();

		this.seaweedsData[0].pullImg();
		this.seaweedsData[1].pullImg();
		this.seaweedsData[2].pullImg();

		this.rocksData[0].pullImg();
		this.rocksData[1].pullImg();
		this.rocksData[2].pullImg();

	}

	initScene(){
	}

	resizeScene(width, height) {	
	}

	renderScene(thisRef) {
		console.log('rendering...');

		thisRef.ctx.fillStyle="#000000";
		thisRef.ctx.fillRect(0,0,
			thisRef.responsiveCanvas.canvas.attr('width'), 
			thisRef.responsiveCanvas.canvas.attr('height') );


		thisRef.ctx.save();
		//move (0,0) point to canvas center
		thisRef.ctx.translate(
			thisRef.responsiveCanvas.canvas.attr('width') / 2.0, 
			thisRef.responsiveCanvas.canvas.attr('height') / 2.0);


		thisRef.backgroundData.drawScaled(thisRef.ctx, 
			-thisRef.backgroundData.spriteWidth / thisRef.backgroundData.spriteHeight * thisRef.responsiveCanvas.canvas.attr('height') / 2, 
			-thisRef.responsiveCanvas.canvas.attr('height') / 2, 
			thisRef.backgroundData.spriteWidth / thisRef.backgroundData.spriteHeight * thisRef.responsiveCanvas.canvas.attr('height') , 
			thisRef.responsiveCanvas.canvas.attr('height') );




		thisRef.ctx.restore();

	}

	renderLoop(thisRef) {
		if(thisRef.enableRender)	
			thisRef.renderScene(thisRef);
	}
}