class AnimatedSceneObject {

	constructor(spriteSheetData){
		//x and y represents center of image 
		this.x = 0;
		this.y = 0;
		this.width = spriteSheetData.spriteWidth;
		this.height = spriteSheetData.spriteHeight;
		this.spriteSheetData = spriteSheetData;
		this.currentFrame = 0;
	}

	getRatio(thisRef)  {
		return thisRef.spriteSheetData.spriteWidth / thisRef.spriteSheetData.spriteHeight;
	}

	draw(ctx, frame, thisRef) {
		ctx.drawImage(thisRef.spriteSheetData.img, thisRef.spriteSheetData.spriteWidth * frame, 0,
			 thisRef.spriteSheetData.spriteWidth, thisRef.spriteSheetData.spriteHeight, 
			thisRef.x, thisRef.y, thisRef.width, thisRef.height);
	}

	drawNextFrame(ctx, thisRef) {
		if(thisRef.currentFrame  >= thisRef.spriteSheetData.spriteCount - 1)
			thisRef.currentFrame = 0;
		else
			thisRef.currentFrame++;
		
		ctx.drawImage(thisRef.spriteSheetData.img, thisRef.spriteSheetData.spriteWidth * thisRef.currentFrame, 0,
			thisRef.spriteSheetData.spriteWidth, thisRef.spriteSheetData.spriteHeight, 
			thisRef.x - thisRef.width / 2, thisRef.y  - thisRef.height / 2,
			thisRef.width, thisRef.height);
	}
}