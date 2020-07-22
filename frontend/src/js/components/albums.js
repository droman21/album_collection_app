export default function Albums(albums){
    console.log("In the albums component")
    return `
        <h1>Albums</h1>
        <section class="AlbumList">
        <ul>
            ${albums.map(album => {
                return `
                <li>
                    <h4 class='album__title'>${album.title}</h4>
                    <button class='album-item__edit'>Edit</button>
                    <button class='album-item__delete'>Delete</button>
                    <input class='album-item__id' type="hidden" value='${album.id}'>
                </li>
                `
            }).join("")}
        </ul>
        <section class="create-album">
        <button class="create-album__button">Add an Album</button>
        </section>
        </section>
    `;
}