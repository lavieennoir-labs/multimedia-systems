//constructor
var GameEngine = function () {
  this.grid = new HexagonGrid(0,0);
};

//instaintiate all with current settings
GameEngine.prototype.initialize = function(game) {  
  gameEngine.grid.createGrid(game);  
}

//set content of item with defined id to list of repositories
GameEngine.prototype.showRepositories = function(listContainerId) {
  console.log("Getting repository page");
  $.ajax({ 
      url: this.homePageLink, 
      type: "text/plain"
    }).
    done(
      function(data) { 
        getRepositoriesInfo(data, listContainerId); 
      }
    ).fail(
      function(xhr, textStatus, error) { 
        console.log("error reading repositories: " + textStatus + " " + error);
      }
    );
};
//get info about repositories from html document
GameEngine.prototype.getRepositoriesInfo = function(html, listContainerId) {
  console.log("Getting repositories info");
  //start of list
  var startIdx = html.indexOf("<ol class=\"pinned-repos-list",0);
  startIdx = html.indexOf(">", startIdx);
  //end of list
  var endIdx = html.indexOf("</ol>", startIdx);
  var data = html.substring(startIdx, endIdx);
  console.log(data);
  $( "#" + listContainerId).html = data;
};