export default function Artists(artists){
    console.log(`in the artist component ${artists}`)
    return `
    <h1>Artist List</h1>
    <ul> 
        ${artists.map(artist => {
            return `
            <article class="artist">
                <h4 class="artist__name">${artist.artistName}</h4>
                <h4 class="artist__items">${artist.homeTown}</h4>
                <h4 class="artist__items">${artist.recordLabel}</h4>
                <input class="artist__id" type="hidden" value="${artist.id}">
            </article>
            `
        }).join("")}
    </ul>
    `
}