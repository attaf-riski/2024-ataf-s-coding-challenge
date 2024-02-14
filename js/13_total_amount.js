function points(games) {
    let total = 0;
    for (let i = 0; i < games.length; i++) {
        let game = games[i];
        let x = parseInt(game[0]);
        let y = parseInt(game[2]);
        if (x > y) {
            total += 3;
        } else if (x === y) {
            total += 1;
        }
    }
    return total;
  }