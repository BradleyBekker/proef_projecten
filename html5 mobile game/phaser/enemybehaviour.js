let defeat = false;

function enemyturn(layer,enemy,player) {
  if(!defeat){
  if (player.x < enemy.x) {
    let tile = layer.getTileAtWorldXY(enemy.x-32,enemy.y,true)
        if (tile.index === 2)
        {
          //blocked
        }
          else {
          enemy.x -= 32;
        }
        return;
      }

  if (player.x > enemy.x) {
    let tile = layer.getTileAtWorldXY(enemy.x+32,enemy.y,true)
        if (tile.index === 2)
        {
        //blocked
        }
          else {
          enemy.x += 32;
        }
        return;
      }
  if (player.y < enemy.y) {
    let tile = layer.getTileAtWorldXY(enemy.x,enemy.y-32,true)
        if (tile.index === 2)
        {
        //blocked
        }
          else {
          enemy.y -= 32;
        }
        return;
      }
  if (player.y > enemy.y) {
    let tile = layer.getTileAtWorldXY(enemy.x,enemy.y+32,true)
        if (tile.index === 2)
        {
        //blocked
        }
          else {
          enemy.y += 32;
        }
        return;
      }

    }
    EcombatCheck();
}




function EcombatCheck(player,enemy){
  let tileUp = player.y-32;
  let tileDown = player.y+32;
  let tileLeft = player.x-32;
  let tileRight = player.x+32;

  if (tileUp == player.y && player.x == enemy.x) {
    defeat = true;
    console.log('úp');

  }
  if (tileDown == player.y  && player.x == enemy.x) {
    defeat =true;

    console.log('d');
  }
  if (tileLeft == player.x && player.y == enemy.y) {
    defeat = true;
    console.log('L');
  }
  if (tileRight == player.x && player.y == enemy.y) {
    defeat = true;
    console.log('R');

  }


}
