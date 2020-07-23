export default function ArtistPostSection(artists){
    console.log("Reached the Artist Post Section")
    return `
        <input class="create-artist__artistName" type="text" placeholder="Create an Artist Here">
        <input class="create-artist__recordLabel" type="text" placeholder="Enter Record Label">
        <input class="create-artist__homeTown" type="text" placeholder="Enter Artist Home Town">
            ${artists.map(artist => {
                return `
                    <option class="create-album__artistID" value="${artist.id}">${artist.artistName}</option>
                    <h4 class="artist__homeTown">${artist.homeTown}</h4>
                    <h4 class="artist__recordLabel">${artist.recordLabel}</h4>
                `
            }).join("")}
        </select>
        <button class="create-album__submit">Save Your Album</button>
    `
}