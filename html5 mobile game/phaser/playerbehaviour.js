let win = false
;

function left(player) {

  let tile = layer.getTileAtWorldXY(player.x-32,player.y,true)
  if (tile.index === 2) {
  //blocked
  }
  else {
    player.x -= 32;
    combatCheck(player,enemy);
    if(!win){
    enemyturn(layer,enemy,player);
    }
  }
}
function right(player) {

  let tile = layer.getTileAtWorldXY(player.x+32,player.y,true)
  if (tile.index === 2) {
  //blocked
  }
  else {
    player.x += 32;
    combatCheck(player,enemy)
    if(!win){
    enemyturn(layer,enemy,player);
    }
  }
}


function up(player) {

  let tile = layer.getTileAtWorldXY(player.x,player.y-32,true)
  if (tile.index === 2) {
  //blocked
  }
  else {
    player.y -= 32;
    combatCheck(player,enemy)
    if(!win){
    enemyturn(layer,enemy,player);
    }
  }
}
function down(player) {

  let tile = layer.getTileAtWorldXY(player.x,player.y+32,true)
  if (tile.index === 2) {
  //blocked
  }
  else {
    player.y += 32;
    combatCheck(player,enemy);
    if(!win){
    enemyturn(layer,enemy,player);
    }
  }
}


function combatCheck(player,enemy){
  let tileUp = player.y-32;
  let tileDown = player.y+32;
  let tileLeft = player.x-32;
  let tileRight = player.x+32;

  if (tileUp == enemy.y && player.x == enemy.x) {
    win = true;
    console.log('úp');

  }
  if (tileDown == enemy.y  && player.x == enemy.x) {
    win =true;

    console.log('d');
  }
  if (tileLeft == enemy.x && player.y == enemy.y) {
    win = true;
    console.log('L');
  }
  if (tileRight == enemy.x && player.y == enemy.y) {
    win = true;
    console.log('R');

  }


}
