class StaticSceneObject {
	constructor(spriteData){
		//x and y represents center of image
		this.x = 0;
		this.y = 0;
		this.width = spriteData.spriteWidth;
		this.height = spriteData.spriteHeight;
		this.spriteData = spriteData;
	}

	getRatio(thisRef)  {
		return thisRef.spriteData.spriteWidth / thisRef.spriteData.spriteHeight;
	}

	draw(ctx, thisRef) {
		ctx.drawImage(thisRef.spriteData.img, 
			0, 0,
			thisRef.spriteData.spriteWidth, thisRef.spriteData.spriteHeight, 
			thisRef.x - thisRef.width / 2, thisRef.y  - thisRef.height / 2,
			thisRef.width, thisRef.height);
	}
}