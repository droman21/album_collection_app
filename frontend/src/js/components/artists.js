export default function Artists(artists){
    console.log(`in the artist component ${artists}`)
    return `
    <section class="header-container">
    <h1>Artists</h1>
    </section>
    <ul>
   
        ${artists.map(artist => {
            return `
            <article class="artist">
                <div class="artist__image">
                <img src="/images/DefaultArtistImage.jpg" alt="${artist.artistName}" style="width: 100px; height: 100px;">
                </div>
                <h4 class="artist__name" id="${artist.id}">${artist.artistName}</h4>
                <h4 class="artist__homeTown">${artist.homeTown}</h4>
                <h4 class="artist__recordLabel">${artist.recordLabel}</h4>
            </article>
            `
        }).join("")}
    </ul>
    `
}