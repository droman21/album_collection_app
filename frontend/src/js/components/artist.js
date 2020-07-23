export default function Artist(artist) {

    return `
        <section class="header-container">    
        <h1>Albums By: ${artist.artistName}</h1>
        </section>
        <section class="albumsByArtist">
        <ul>
            ${artist.albums.map(album => {
        return `
                <div class="album__title"> 
                <h4 id="${album.id}">${album.title}</h4>
                </div>
                <div class="album__image">
                <img src="/images/DefaultAlbumImage.jpg" alt="${album.id}" style="width: 200px; height: 200px;">
                </div>
                
                `
    }).join("")}
        </ul>
        </section>
    `
}