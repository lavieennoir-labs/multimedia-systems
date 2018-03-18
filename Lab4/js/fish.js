class Fish {
	constructor(moveSpriteSheetData, turnSpriteSheetData) {
		this.moveData = moveSpriteSheetData;
		this.turnData = turnSpriteSheetData;
		this.x = 0;
		this.y = 0;
		this.width = moveSpriteSheetData.spriteWidth;
		this.height = moveSpriteSheetData.spriteHeight;
		this.turnedRight = true;
		this.isTurning = false;
		this.moveFrameIdx = 0;
		this.turnFrameIdx = 0;
	}

	move(ctx, xOffset, yOffset, thisRef, mapWidthLim, mapHeightLim) {
		if(xOffset < 0 && thisRef.turnedRight && !thisRef.isTurning)
			thisRef.startTurn();
		else if(xOffset > 0 && !thisRef.turnedRight && !thisRef.isTurning)
			thisRef.startTurn();

		if(thisRef.turnedRight)
			thisRef.x += xOffset;
		else
			thisRef.x -= xOffset;	
		thisRef.y +=yOffset;

		//if mirror transform neded
		if(!thisRef.turnedRight)
		{
			ctx.translate(-thisRef.x, -thisRef.y);
			ctx.scale(-1, 1);
			ctx.translate(-thisRef.x, thisRef.y);
		}

		//turning case
		if(thisRef.isTurning) {

			ctx.drawImage(thisRef.turnData.img, 
				thisRef.turnData.spriteWidth * thisRef.turnFrameIdx, 0,
				thisRef.turnData.spriteWidth, thisRef.turnData.spriteHeight, 
				thisRef.x - thisRef.width / 2, thisRef.y  - thisRef.height / 2,
				thisRef.width, thisRef.height);


			thisRef.turnFrameIdx++;
		}
		//moving case
		else {
			ctx.drawImage(thisRef.moveData.img, 
				thisRef.moveData.spriteWidth * thisRef.moveFrameIdx, 0,
				thisRef.moveData.spriteWidth, thisRef.moveData.spriteHeight, 
				thisRef.x - thisRef.width / 2, thisRef.y  - thisRef.height / 2,
				thisRef.width, thisRef.height);
			

			thisRef.moveFrameIdx++;
			if(thisRef.moveFrameIdx > 1)
				thisRef.moveFrameIdx = 0;
		}

		//if mirror transform neded
		if(!thisRef.turnedRight)
		{
			ctx.translate(thisRef.x, -thisRef.y);
			ctx.scale(-1, 1);
			ctx.translate(thisRef.x, thisRef.y);


			//if(thisRef.x < 0 && thisRef.x > -mapWidthLim / 2.0)
			//	ctx.translate(-xOffset, 0);
		}
		//else {
			if(thisRef.x > -mapWidthLim / 2.0 && thisRef.x < mapWidthLim / 2.0)
				ctx.translate(-xOffset, 0);
		//}

		if(thisRef.y > -mapHeightLim / 2.0 && thisRef.y < mapHeightLim / 2.0)
			ctx.translate(0, -yOffset);	


		thisRef.checkEndTurn();
	}

	startTurn() {
		this.turnFrameIdx = 0;
		this.isTurning = true;
	}

	checkEndTurn() {
		if(this.turnFrameIdx < 3)
			return;

		this.turnFrameIdx = 0;
		this.turnedRight = !this.turnedRight;
		this.isTurning = false;
		this.x = -this.x;

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