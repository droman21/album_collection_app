export default function Artist(artist){

    return `
        <h1>Albums By: ${artist.artistName}</h1>
        <section class="albumsByArtist">
        <h1>We're in the albums by artist page</h1>
        <ul>
            ${artist.albums.map(album =>{
                return `
                <li>
                    <h4 class="album__title">${album.title}</h4>
                </li>
                `
            }).join("")}
        </ul>
        </section>
    `
}