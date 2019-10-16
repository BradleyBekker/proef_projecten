

var config = {
  type: Phaser.AUTO,
  width: window.innerWidth,
  height:500,
  parent: 'phaser-example',
  pixelArt: true,
  backgroundColor: '#a7c2c4',
  scene:{
    preload: preload,
    create: create,
    update: update
  }
};
var button;
var enemy;
var player;
var layer;
var text;
var game = new Phaser.Game(config);

function preload() {
  this.load.image('cUP','sprites/UP.png');


  this.load.image('sword','sprites/sword.png')
  this.load.image('Esword','sprites/Esword.png')
  this.load.image('player','sprites/player.png');
  this.load.image('enemy','sprites/WINDERLITCH.png');
  this.load.image('tiles','sprites/drawtiles-spaced.png');
  this.load.tilemapCSV('map','grid.csv');

}
let graphics;

let cUp;

let cDown;
let cLeft;

let cRight;

function create() {
  graphics = this.add.graphics();
      cUp = this.add.image(64,450,'cUP');
      cUp.angle = 180;
      cDown = this.add.image(128,450,'cUP');
      cLeft = this.add.image(192,450,'cUP');
      cLeft.angle = 90;
      cRight = this.add.image(256,450,'cUP');
      cRight.angle = 270;
  var map = this.make.tilemap({key:'map',tileWidth: 32, tileHeight: 32 });
  var tileset = map.addTilesetImage('tiles', null, 32, 32, 1, 2);
   layer = map.createStaticLayer(0, tileset, 0, 0);
   player = this.add.image(32+16,32+16,'player')
   enemy = this.add.image(256+16,256+16,'enemy');


     text = this.add.text(10, 10, 'Use up to 1 fingers at once', { font: '16px Courier', fill: '#00ff00' });

     this.input.keyboard.on('keydown_A', function (event) {
       if(!defeat || !win){
       left(player);
      }
     });

     this.input.keyboard.on('keydown_D', function (event) {
       if(!defeat || !win){
       right(player);
      }
     });
     this.input.keyboard.on('keydown_W', function (event) {
       if (!defeat || !win) {
         up(player);
       }

     });
     this.input.keyboard.on('keydown_S', function (event) {
       if (!defeat || !win) {
         down(player);
       }


     });


     graphics.fillStyle(0xfff000, 1);
     graphics.fillRect(cDown.x-cDown.width/2, cDown.y-cDown.height/2, cDown.width, cDown.height);




}
function update() {
  if (!defeat || !win) {
    if (this.input.pointer1.isDown) {
      if (this.input.pointer1.x > cDown.x-cDown.width/2 &&this.input.pointer1.x < cDown.x + cDown.width/2 && this.input.pointer1.y > cDown.y-cDown.height/2 && this.input.pointer1.y < cDown.y + cDown.width/2) {
        down(player);
      }
    }
  }
  if (!defeat || !win) {
    if (this.input.pointer1.isDown) {
      if (this.input.pointer1.x > cUp.x-cUp.width/2 &&this.input.pointer1.x < cUp.x + cUp.width/2 && this.input.pointer1.y > cUp.y-cUp.height/2 && this.input.pointer1.y < cUp.y + cUp.width/2) {
        up(player);
      }
    }
  }
  if (!defeat || !win) {
    if (this.input.pointer1.isDown) {
      if (this.input.pointer1.x > cLeft.x-cLeft.width/2 &&this.input.pointer1.x < cLeft.x + cLeft.width/2 && this.input.pointer1.y > cLeft.y-cLeft.height/2 && this.input.pointer1.y < cLeft.y + cLeft.width/2) {
        left(player);
      }
    }
  }
  if (!defeat || !win) {
    if (this.input.pointer1.isDown) {
      if (this.input.pointer1.x > cRight.x-cRight.width/2 &&this.input.pointer1.x < cRight.x + cRight.width/2 && this.input.pointer1.y > cRight.y-cRight.height/2 && this.input.pointer1.y < cRight.y + cRight.width/2) {
        right(player);
      }
    }
  }



  if (this.input.pointer1.isDown) {
    text.setText(["pressed"]);

  }



  if (win) {
    this.add.image(enemy.x,enemy.y,'sword')
  }
  if (defeat) {
    this.add.image(player.x,player.y,'Esword')
  }


}
