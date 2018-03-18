//-----------------------------------------------------------------------------
//HexagonCellTypes enum
//-----------------------------------------------------------------------------
var HexagonCellTypes = function () {
  this.disabled = 'disabled';
  this.empty = 'empty';
  this.highlighted = 'highlighted';
  this.active = 'active';

  this.current = this.disabled;
}

//-----------------------------------------------------------------------------
//HexagonCell class
//-----------------------------------------------------------------------------
//constructor
var HexagonCell = function (x, y) {
  this.x = x;
  this.y = y;
  this.graphics;
  //define polygon types
  this.type = new HexagonCellTypes();
};

//get points for polygon with defined center coordinates and radius
HexagonCell.prototype.getVertexes = function (cellRadius, cellWidth) {
  //count cell cabsolute position
  var offset = cellWidth;
  var xAbs = offset * this.x * 2;
  var yAbs = offset * this.y * Math.sqrt(3);
  if (this.y % 2 !== 0) 
    xAbs += offset;
  //count vertex positions
  var points = [];
  for (var theta = 0; theta < Math.PI * 2; theta += Math.PI / 3) {
    var pointX, pointY;
    pointX = xAbs + cellRadius * Math.sin(theta);
    pointY = yAbs + cellRadius * Math.cos(theta);
    points.push(new Phaser.Point(pointX, pointY));
  }
  return points;
}

//create polygon dom and returns it
HexagonCell.prototype.createPolygon = function (defaultPolygon) {
  //this.setType(this.type.disabled);
  this.graphics = defaultPolygon;
  return this.polygon;
}

//set fill color for polygon
HexagonCell.prototype.setColor = function (color) {
  
}

//set polygon type
HexagonCell.prototype.setType = function (type) {
  
}

//get absolute position of cell on x axis
HexagonCell.prototype.xAbs = function (cellWidth) {
  var xAbs = cellWidth * this.x * 2;
  if (this.y % 2 !== 0) 
    xAbs += cellWidth;
  return xAbs;
}
//get absolute position of cell on y axis
HexagonCell.prototype.yAbs = function (cellWidth) {
  return cellWidth * this.y * Math.sqrt(3);
}


//-----------------------------------------------------------------------------
//HexagonGrid class
//-----------------------------------------------------------------------------
//constructor
var HexagonGrid = function (width, height) {
  this.width = width;
  this.height = height;
  this.cells = [];
  this.setRadius(30);
};

//update width according to radius
HexagonGrid.prototype.setRadius = function (radius) { 
  this.cellRadius = 30;
  this.cellWidth = this.cellRadius * Math.sqrt(3) / 2;
  this.defaultPolygon = new Phaser.Polygon(this.calcPolygonRelativePoints());
}

//get points for polygon with center (0,0) and defined radius
HexagonGrid.prototype.calcPolygonRelativePoints = function () { 
  //count vertex positions
  var points = [];
  var pointX, pointY;
  for (var theta = 0; theta < Math.PI * 2; theta += Math.PI / 3) {    
    pointX = this.cellRadius * Math.sin(theta);
    pointY = this.cellRadius * Math.cos(theta);
    points.push(new Phaser.Point(pointX, pointY));
  }
  return points;
}

//generate grid content with defined count rows and columns
HexagonGrid.prototype.createGrid = function (game) {
  var row, col;
  //clear existing cells
  this.cells = [];
  //create each cell
  for (col = 1; col <= this.width; col += 1) {
    for (row = 1; row <= this.height; row += 1) {
      //setup cell
      var cell = new HexagonCell(col,row);  
      var graphics = game.add.graphics(cell.xAbs(this.cellWidth), cell.yAbs(this.cellWidth));
      graphics.lineStyle(1.5, 0x3f3353, 1);
      graphics.drawPolygon(this.defaultPolygon.points);

      cell.graphics = graphics;
      this.cells.push(cell);
      //this.svg.appendChild(cell.polygon);
      //cell.createPolygon(this.cellRadius, this.cellWidth); 
    }
  }
};


//returns cell by it`s position
HexagonGrid.prototype.getCell = function (x,y) {
  return this.cells[x * this.height + y];
}

//get absolute position of cell on x axis
HexagonGrid.prototype.widthAbs = function () {
  return this.cellWidth * (this.width + 1) * 2 + this.cellWidth;
}

//get absolute position of cell on y axis
HexagonGrid.prototype.heightAbs = function () {
  return this.cellWidth * (this.height + 1) * Math.sqrt(3);
}