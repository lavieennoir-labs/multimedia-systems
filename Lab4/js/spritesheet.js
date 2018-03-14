class SpriteSheetData {
	constructor(path, spriteCount, spriteWidth, spriteHeight) {
		this.imgPath = path;
		this.spriteCount = spriteCount;
		this.spriteWidth = spriteWidth;
		this.spriteHeight = spriteHeight;

		//get short filename
		this.id = path.split("/");
		this.id = this.id[this.id.length-1].split(".");
		this.id = this.id[0];

		this.img = $(
			'<img/>',
			{
				src : this.imgPath,
				height : this.spriteHeight,
				width : this.spriteCount * this.spriteWidth,
				class : "hidden",
				id : this.id
			}
		);		
	}

	// update img object using id reference
	pullImg() {
		this.img = document.getElementById(this.id);
	}

	draw(ctx, x, y, frameIdx) {
		ctx.drawImage(this.img, 
			0, this.spriteWidth * frameIdx, this.spriteWidth, this.spriteHeight, 
			x, y, this.spriteWidth, this.spriteHeight); 
	}

	drawScaled(ctx, x, y, h, w, frameIdx) {
		ctx.drawImage(this.img, 0, 
			this.spriteWidth * frameIdx, this.spriteWidth, this.spriteHeight, 
			x, y, w, h);
	}
}