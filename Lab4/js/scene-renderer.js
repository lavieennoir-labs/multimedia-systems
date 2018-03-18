
var sceneRef;
class SceneRenderer {
	constructor(canvasId, manualId, freezeId){
		this.moveFishVertical = 0;
		this.moveFishHorizontal = 0;
		this.fishSpeed = 5;
		this.fishDirectionX = 0;
		this.fishDirectionY = 0;
		this.textFrame = 0;

		this.enableRender = true;
		this.renderDelay = 100;
		this.renderTimer = setInterval(this.renderLoop, this.renderDelay,this);

		this.responsiveCanvas = new ResponsiveCanvas(canvasId);
		this.ctx = document.getElementById(canvasId).getContext("2d");
		this.manual = $('#' + manualId)[0];
		this.freeze = $('#' + freezeId)[0];

		this.initEvents();
		//this.initKeyHandler();
		this.initAssetsData();
		this.initScene();

		sceneRef = this;
		this.responsiveCanvas.onresize = this.resizeScene;	

		console.log('SceneRenderer initialized for canvas #' + canvasId + '.');	

	}

	initEvents() {
		var thisRef = this;
		if(this.manual.checked) {
     		thisRef.manualMode = true;
			this.initKeyHandler();
     	}
     	else {
     		thisRef.manualMode = false;
     		this.initPathMove();
     	}
     	if(this.freeze.checked) {
			this.enableRender = false;
     	}
     	else {
			this.enableRender = true;
     	}

		manual.onchange = function() {
     		if(this.checked) {
     			thisRef.manualMode = true;
				thisRef.initKeyHandler();
     		}
     		else {
     			thisRef.manualMode  = false;
     			thisRef.initPathMove();
     		}
		};
		freeze.onchange = function() {
     		if(this.checked) {
				thisRef.enableRender = false;
     		}
     		else {
				thisRef.enableRender = true;
     		}
		};
	}

	//handling keyboard input
	initKeyHandler() {
		var thisRef = this;
		document.onkeypress = function(index) {
			if(index.key === 'ArrowUp')
				thisRef.moveFishVertical += -thisRef.fishSpeed;
			else if(index.key === 'ArrowDown')
				thisRef.moveFishVertical += thisRef.fishSpeed;
			if(index.key === 'ArrowLeft')
				thisRef.moveFishHorizontal += -thisRef.fishSpeed;
			else if(index.key === 'ArrowRight')
				thisRef.moveFishHorizontal += thisRef.fishSpeed;
		}
	}
	initPathMove() {
		var thisRef = this;
		document.onkeypress = function(index) {};
	}

	countPath(thisRef) {
		if(thisRef.manualMode)
			return;
		var size = thisRef.getMapSize(thisRef);

		if(thisRef.fish.turnedRight) {	
			if(thisRef.fish.x <= -size.width / 2.0 + thisRef.fish.width)
				thisRef.fishDirectionX = thisRef.fishSpeed * 2;
			else if(thisRef.fish.x >= size.width / 2.0 - 2 * thisRef.fish.width)
				thisRef.fishDirectionX = -thisRef.fishSpeed * 2;
		}
		else {
			if(thisRef.fish.x <= -size.width / 2.0 + thisRef.fish.width)
				thisRef.fishDirectionX = -thisRef.fishSpeed * 2;
			else if(thisRef.fish.x >= size.width / 2.0 - 2 * thisRef.fish.width)
				thisRef.fishDirectionX = thisRef.fishSpeed * 2;
		}


		if(thisRef.fish.y <= -size.height / 2.0 + thisRef.fish.height)
			thisRef.fishDirectionY = thisRef.fishSpeed * 2;
		else if(thisRef.fish.y >= size.height / 2.0 - 2 * thisRef.fish.height)
			thisRef.fishDirectionY = -thisRef.fishSpeed * 2;

		if(thisRef.fishDirectionX === 0) {
			thisRef.fishDirectionX = (Math.random() * 2 - 1 ) * 2 * thisRef.fishSpeed;
		}
		if(thisRef.fishDirectionY === 0){
			thisRef.fishDirectionY = (Math.random() * 2 - 1 ) * 2 * thisRef.fishSpeed;
		}
		thisRef.moveFishHorizontal = thisRef.fishDirectionX;
		thisRef.moveFishVertical = thisRef.fishDirectionY;
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
		//generate scene objects
		this.staticObjects = [];
		this.animatedFrontObjects = [];
		this.animatedBackObjects = [];

		this.generateStaticObjects(this);
		this.generateAnimatedObjects(this);

		this.fish = new Fish(this.fishMoveData, this.fishTurnData);
		this.fish.width = 138;
		this.fish.height = 93;
	}

	generateStaticObjects(thisRef) {
		var maxGenHeight = 100;
		var objCount = 200;
		var size = thisRef.getMapSize(thisRef);
		var data = [
			thisRef.coralData,
			thisRef.seaweedsData[0],
			thisRef.seaweedsData[1],
			thisRef.seaweedsData[2],
			thisRef.rocksData[0],
			thisRef.rocksData[1],
			thisRef.rocksData[2]
			];

		for(var i = 0; i < objCount; i++) {
			var objIdx = Math.round(Math.random() * (data.length - 1));
			var obj = new StaticSceneObject(data[objIdx]);
			obj.x = Math.random() * size.width - size.width / 2.0;
			obj.y = Math.random() * maxGenHeight + size.height / 2.0 - 2 * maxGenHeight;
			obj.width = obj.width * (0.75 + Math.random() * 0.5);
			obj.height = obj.width / obj.getRatio(obj) * (Math.random() * 0.2 + 0.9);
			thisRef.staticObjects.push(obj);
		}
			

	}
	generateAnimatedObjects(thisRef) {
		var maxGenHeight = 100;
		var objCount = 50;
		var size = thisRef.getMapSize(thisRef);
		var swimData = [
			thisRef.jellyfishBlueData,
			thisRef.jellyfishOrangeData
			];
		var groundData = [
			thisRef.crabData,
			thisRef.seaweedFishData,
			];
			
		//swimming
		for(var i = 0; i < objCount; i++) 

			if(Math.random() < 0.7) {
				var objIdx = Math.round(Math.random() * (swimData.length - 1));
				var obj = new AnimatedSceneObject(swimData[objIdx]);
				obj.x = Math.random() * size.width - size.width / 2.0;
				obj.y = Math.random() * (size.height - maxGenHeight) - size.height / 2.0 - 2 * maxGenHeight;
				obj.width = obj.width * (0.75 + Math.random() * 0.5);
				obj.height = obj.width / obj.getRatio(obj);

				if(Math.random() < 0.5)
					thisRef.animatedFrontObjects.push(obj);
				else
					thisRef.animatedBackObjects.push(obj);
			}
			else {
			//on ground
				var objIdx = Math.round(Math.random() * (groundData.length - 1));
				var obj = new AnimatedSceneObject(groundData[objIdx]);
				obj.x = Math.random() * size.width - size.width / 2.0;
				obj.y = Math.random() * maxGenHeight + size.height / 2.0 - 2 * maxGenHeight;
				obj.width = obj.width * (0.75 + Math.random() * 0.5);
				obj.height = obj.width / obj.getRatio(obj);

				thisRef.animatedBackObjects.push(obj);
			}
	}

	drawText(thisRef) {
		var textFrames = [
			{x:thisRef.fish.x, y:thisRef.fish.y - thisRef.fish.height},
			{x:thisRef.fish.x - thisRef.fish.width, y:thisRef.fish.y - thisRef.fish.height},
			{x:thisRef.fish.x - thisRef.fish.width, y:thisRef.fish.y},
			{x:thisRef.fish.x - thisRef.fish.width, y:thisRef.fish.y + thisRef.fish.height},
			{x:thisRef.fish.x, y:thisRef.fish.y + thisRef.fish.height},
			{x:thisRef.fish.x + thisRef.fish.width, y:thisRef.fish.y + thisRef.fish.height},
			{x:thisRef.fish.x + thisRef.fish.width, y:thisRef.fish.y},
			{x:thisRef.fish.x + thisRef.fish.width, y:thisRef.fish.y - thisRef.fish.height},
			];
		var text = "Дмитро Хижняк"
		thisRef.ctx.font = "30px sans-serif";
		thisRef.ctx.fillStyle = "orange";
		thisRef.ctx.textAlign = "center";

		thisRef.ctx.fillText(text, textFrames[thisRef.textFrame].x, textFrames[thisRef.textFrame].y);
		thisRef.textFrame ++;
		if(thisRef.textFrame >= textFrames.length)
			thisRef.textFrame = 0;
	}

	drawStaticBack(thisRef) {
		for(var i = 0; i < thisRef.staticObjects.length; i++) {
		var obj = thisRef.staticObjects[i];
			obj.draw(thisRef.ctx, obj);
		}
	}

	drawFrontAnimations(thisRef) {
		for(var i = 0; i < thisRef.animatedFrontObjects.length; i++) {
		var anim = thisRef.animatedFrontObjects[i];
			anim.x += Math.random() * 10 - 5;
			anim.y += Math.random() * 10 - 5;
			anim.drawNextFrame(thisRef.ctx, anim);
		}
	}

	drawBackAnimations(thisRef) {
		for(var i = 0; i < thisRef.animatedBackObjects.length; i++) {
		var anim = thisRef.animatedBackObjects[i];
			anim.x += Math.random() * 10 - 5;
			anim.y += Math.random() * 10 - 5;
			anim.drawNextFrame(thisRef.ctx, anim);
		}
	}

	resizeScene(width, height) {
		var size = sceneRef.getMapSize(sceneRef);
		var mapHeightLim = size.height / 2.0;
		var mapWidthLim = size.width / 2.0;
		var top = parseInt(-mapHeightLim) + parseInt(height) / 2.0;
		var bot = parseInt(mapHeightLim) - parseInt(height) / 2.0;
		var left = parseInt(-mapWidthLim) + parseInt(width) / 2.0;
		var right = parseInt(mapWidthLim) - parseInt(width) / 2.0;

			console.log(left + ' ' + right);
			console.log(sceneRef.fish.x + ' ' + sceneRef.fish.y);


		if(sceneRef.fish.x <= left)
				sceneRef.fish.x = left;
		else if(sceneRef.fish.x >= right)
				sceneRef.fish.x = right;
		
		if(sceneRef.fish.y <= top)
			sceneRef.fish.y = top;
		else if(sceneRef.fish.y >= bot)
			sceneRef.fish.y = bot;
		
		if(sceneRef.fish.turnedRight)
			sceneRef.ctx.translate(-sceneRef.fish.x, -sceneRef.fish.y);
		else
			sceneRef.ctx.translate(sceneRef.fish.x, -sceneRef.fish.y);
		//if(sceneRef.fish.turnedRight)
		//	sceneRef.ctx.translate(-sceneRef.fish.x, -sceneRef.fish.y);
		//else
		//	sceneRef.ctx.translate(sceneRef.fish.x, -sceneRef.fish.y);

	}

	renderScene(thisRef) {
		console.log('rendering...');

		thisRef.ctx.fillStyle="#000000";
		thisRef.ctx.fillRect(0,0,
			thisRef.responsiveCanvas.canvas.attr('width'), 
			thisRef.responsiveCanvas.canvas.attr('height') );


		//move (0,0) point to canvas center
		thisRef.ctx.translate(
			thisRef.responsiveCanvas.canvas.attr('width') / 2.0, 
			thisRef.responsiveCanvas.canvas.attr('height') / 2.0);

		thisRef.renderBackground(thisRef);
		thisRef.drawText(thisRef);


		//fish move
		var size = thisRef.getMapSize(thisRef);
		thisRef.fish.move(thisRef.ctx, thisRef.moveFishHorizontal, thisRef.moveFishVertical, thisRef.fish, 
			size.width - thisRef.responsiveCanvas.canvas.attr('width') - thisRef.fish.width,
			size.height - thisRef.responsiveCanvas.canvas.attr('height') - thisRef.fish.height);
		thisRef.moveFishHorizontal = 0;
		thisRef.moveFishVertical = 0;


		thisRef.drawStaticBack(thisRef);
		thisRef.drawBackAnimations(thisRef);

		thisRef.drawFrontAnimations(thisRef);

		//move (0,0) point back
		thisRef.ctx.translate(
			thisRef.responsiveCanvas.canvas.attr('width') / -2.0, 
			thisRef.responsiveCanvas.canvas.attr('height') / -2.0);
	}

	renderLoop(thisRef) {
		if(thisRef.enableRender)
		{	
			thisRef.countPath(thisRef);
			thisRef.renderScene(thisRef);
		}
	}

	getMapSize(thisRef) {
		var heightMult = 1.5;
		var size = 
			{
				width :	thisRef.backgroundData.ratio * 
					/*thisRef.responsiveCanvas.canvas.attr('height') */ 
					thisRef.backgroundData.spriteHeight * heightMult,
				height : thisRef.backgroundData.spriteHeight * heightMult
			}
		return size;
	}


	renderBackground(thisRef) {
		var size = thisRef.getMapSize(thisRef);
		var currentWidth = 0;	
		var targetWidth = thisRef.responsiveCanvas.canvas.attr('width');	
		var i = 0;

		//while(currentWidth < targetWidth) {
			thisRef.backgroundData.drawScaled(thisRef.ctx, 
				-size.width / 2.0/*currentWidth - i*/,
				-size.height / 2.0, 
				size.width, 
				size.height);	

		//	currentWidth += size.width;	
		//	i++;
		//}
	}
}