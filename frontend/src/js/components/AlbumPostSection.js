export default function AlbumPostSection(artists){
    console.log("Reached the Album Post Section")
    return `
        <input class="create-album__albumTitle" type="text" placeholder="Create an Album Here">
        <select class="create-album__albumArtists" type="dropdown">
            ${artists.map(artist => {
                return `
                    <option class="create-album__artistID" value="${artist.id}">${artist.artistName}</option>
                `
            }).join("")}
        </select>
        <button class="create-album__submit">Save Your Album</button>
    `
}