initManual(sceneRenderer)
{
	//generate scene objects
		this.staticObjects = [
			new StaticSceneObject(this.coralData),
			new StaticSceneObject(this.seaweedsData[0]),
			new StaticSceneObject(this.seaweedsData[1]),
			new StaticSceneObject(this.seaweedsData[2]),
			new StaticSceneObject(this.rocksData[0]),
			new StaticSceneObject(this.rocksData[1]),
			new StaticSceneObject(this.rocksData[2])
		];

		this.animatedObjects = [
			new AnimatedSceneObject(this.jellyfishBlueData),
			new AnimatedSceneObject(this.jellyfishOrangeData),

			new AnimatedSceneObject(this.crabData),
			new AnimatedSceneObject(this.seaweedFishData)
		];
		this.animatedObjects[1].x = 100;
		this.animatedObjects[1].y = 100;
		this.animatedObjects[0].x = -100;
		this.animatedObjects[0].y = -100;

		this.fish = new Fish(this.fishMoveData, this.fishTurnData);
		this.fish.width = 138;
		this.fish.height = 93;
}

renderManual(sceneRenderer) {
		console.log('rendering...');

		sceneRenderer.ctx.fillStyle="#000000";
		sceneRenderer.ctx.fillRect(0,0,
			sceneRenderer.responsiveCanvas.canvas.attr('width'), 
			sceneRenderer.responsiveCanvas.canvas.attr('height') );

		sceneRenderer.renderBackground(sceneRenderer);

		//move (0,0) point to canvas center
		sceneRenderer.ctx.translate(
			sceneRenderer.responsiveCanvas.canvas.attr('width') / 2.0, 
			sceneRenderer.responsiveCanvas.canvas.attr('height') / 2.0);


		var jellyfish = sceneRenderer.animatedObjects[1];
		jellyfish.x += Math.random() * 10 - 5;
		jellyfish.y += Math.random() * 10 - 5;
		jellyfish.drawNextFrame(sceneRenderer.ctx, jellyfish);

		//fish move
		if(sceneRenderer.moveFishHorizontal != 0 || sceneRenderer.moveFishVertical != 0)
			console.log(sceneRenderer.moveFishHorizontal + ":" + sceneRenderer.moveFishVertical);
		sceneRenderer.fish.move(sceneRenderer.ctx, sceneRenderer.moveFishHorizontal, sceneRenderer.moveFishVertical, sceneRenderer.fish);
		sceneRenderer.moveFishHorizontal = 0;
		sceneRenderer.moveFishVertical = 0;

		jellyfish = sceneRenderer.animatedObjects[0];
		jellyfish.x += Math.random() * 10 - 5;
		jellyfish.y += Math.random() * 10 - 5;
		jellyfish.drawNextFrame(sceneRenderer.ctx, jellyfish);


		


		//move (0,0) point back
		sceneRenderer.ctx.translate(
			sceneRenderer.responsiveCanvas.canvas.attr('width') / -2.0, 
			sceneRenderer.responsiveCanvas.canvas.attr('height') / -2.0);
	}



var jellyBlue;
initAuto(sceneRenderer) {
	jellyBlue = new AnimatedSceneObject(this.jellyfishBlueData)
}


renderAuto(sceneRenderer) {
		console.log('rendering...');

		sceneRenderer.ctx.fillStyle="#000000";
		sceneRenderer.ctx.fillRect(0,0,
			sceneRenderer.responsiveCanvas.canvas.attr('width'), 
			sceneRenderer.responsiveCanvas.canvas.attr('height') );

		sceneRenderer.renderBackground(sceneRenderer);

		//move (0,0) point to canvas center
		sceneRenderer.ctx.translate(
			sceneRenderer.responsiveCanvas.canvas.attr('width') / 2.0, 
			sceneRenderer.responsiveCanvas.canvas.attr('height') / 2.0);


		jellyBlue = sceneRenderer.animatedObjects[1];
		jellyBlue.x += Math.random() * 10 - 5;
		jellyBlue.y += Math.random() * 10 - 5;
		jellyBlue.drawNextFrame(sceneRenderer.ctx, jellyBlue);


		//move (0,0) point back
		sceneRenderer.ctx.translate(
			sceneRenderer.responsiveCanvas.canvas.attr('width') / -2.0, 
			sceneRenderer.responsiveCanvas.canvas.attr('height') / -2.0);
	}