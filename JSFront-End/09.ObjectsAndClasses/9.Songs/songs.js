function solve(input) {
    class Song{
        constructor(songType, name, time){
            this.songType = songType;
            this.name = name;
            this.time = time;
        }
    }

    let songCount = input.shift();
    let songType = input.pop();
    let playList = [];

    for(let i = 0; i < songCount; i++){
        let [type, name, time] = input[i].split('_');
        let song = new Song(type, name, time);
        playList.push(song);
    }

    if (songType === 'all'){
        playList.forEach(song => console.log(song.name));
    } else{
        let filteredPlayList = playList.filter(t => t.songType === songType);
        filteredPlayList.forEach(song => console.log(song.name));
    }
}


solve([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'favourite']
    );

solve([2,
    'like_Replay_3:15',
    'ban_Photoshop_3:48',
    'all']
    );