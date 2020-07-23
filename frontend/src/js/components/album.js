export default function album(album){
    return `
        <h1>${album.title}</h1>
        <ol>
            ${album.songs.map(song =>{
                return `
                <li class="album_song_font">
                    <h4>Song Name: ${song.name}</h4>
                    <h4>Song Duration: ${song.songDuration}</h4>
                </li>
                `
            }).join("")}
        <ol>
    `
}