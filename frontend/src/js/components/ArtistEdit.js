export default function ArtistEdit(artist){
    return `
        <h3>${artist.artistName}</h3>
        <input class="edit-artist__name" type="text" value='${album.title}'>
        <input class="edit-album__id" type="hidden" value='${album.id}'>
        <input class="edit-album__image" type="hidden" value='${album.image}'>
        <input class="edit-album__label" type="hidden" value='${album.label}'>
        <input class="edit-album__artistID" type="hidden" value='${album.artistId}'>
        <button class="edit-album__submit">Save Changes</button>
    `
}