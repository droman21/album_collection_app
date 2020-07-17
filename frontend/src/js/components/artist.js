export default function Artist(artist){

    return `
        <h1>Albums By: ${artist.artistName}</h1>
        <section class="albumsByArtist">
        <ul>
            ${artist.albums.map(album =>{
                return `
                <li>
                    <h4 class="album__title">${album.title}</h4>
                </li>
                `
            }).join("")}
        <ul>
        </section>
    `
}