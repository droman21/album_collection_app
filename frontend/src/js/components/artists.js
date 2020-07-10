export default function Artists(artists){
    console.log(`in the artist component ${artists}`)
    return `
    <ol> 
        ${artists.map(artist => {
            return `
            <li>
                <h4 class="artist__items">${artist.artistName}</h4>
                <h4 class="artist__items">${artist.homeTown}</h4>
                <h4 class="artist__items">${artist.recordLabel}</h4>
                <input class="artist__id" type="hidden" value="${artist.id}">
            </li>
            `
        }).join("")}
    </ol>
  
    `
    
        //  console.log(`in the Artists component ${artists}`)
        //  return `
        // <ol><li>test 123</li></ol>
        // `

}