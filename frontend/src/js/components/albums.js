export default function Albums(albums){
    console.log("In the albums component")
    return `
        <h1>List of Albums</h1>
        <section class="AlbumList">
        <ul>
            ${albums.map(album => {
                return `
                <li>
                    <h4 class='album__title'>${album.title}</h4>
                    <h4 class='album__id' type="hidden">${album.id}</h4>
                </li>
                `
            }).join("")}
        </ul>
        <section class="create-album">
        <button class="create-album__button">Create an Album Here</button>
        </section>
        </section>
    `;
}