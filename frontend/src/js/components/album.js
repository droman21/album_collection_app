export default function album(album){
    return `
        <h1>${album.title}</h1>
        <ol>
            ${album.songs.map(song =>{
                return `
                <li>
                    <h4>${song.name}</h4>
                </li>
                `
            }).join("")}
        <ol>
    `
}