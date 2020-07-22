export default function AlbumEdit(album){
    return `
        <h3>${album.title}</h3>
        <input class="edit-album__name" type="text" value="${album.title}">
        <input class="edit-album__id" type="hidden" value="${album.albumID}">
        <button class="edit-album__submit">Save Changes</button>
    `
}