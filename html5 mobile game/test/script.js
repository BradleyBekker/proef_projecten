const canvas = document.getElementById('canvas');
const ctx = canvas.getContext("2d");

canvas.width = window.innerWidth ;
canvas.height = window.innerHeight;

let grid = [];
let player = {};
let Tile = new Image;
Tile.src = "img/Untitled-1.png"

let i = 0;
function start() {

  for (var x = 0; x < 3; x++)
  {
    for (var y = 0; y < 6; y++)
    {

      let A = new gridNode(5 + x*100,5 + y*100,Tile);
      grid.push(A)
      ctx.fillStyle = "black"
      ctx.fillRect(grid[i].x,grid[i].y,100,100);
      i++;
    }




    }



  Update();
}

  function Update(){
    requestAnimationFrame(Update);
  }

start();


function randomNumber(max){
  return Math.random()*max;
}
