export default function Artist(artist){

    return `
        <h1>${artist.artistName}</h1>
        <ol>
            ${artist.albums.map(album =>{
                return `
                <li>
                    <h4>${album.title}</h4>
                </li>
                `
            }).join("")}
        <ol>
    `
}