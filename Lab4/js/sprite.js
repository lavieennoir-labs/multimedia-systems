class SpriteData {
	constructor(path, spriteWidth, spriteHeight) {
		this.imgPath = path;
		this.img
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
				width : this.spriteWidth,
				class : "hidden",
				id : this.id
			}
		);
	}

	// update img object using id reference
	pullImg() {
		this.img = document.getElementById(this.id);
	}

	draw(ctx, x, y) {
		ctx.drawImage(this.img, x, y);
	}

	drawScaled(ctx, x, y, w, h) {
		ctx.drawImage(this.img, x, y, w, h);
	}
}