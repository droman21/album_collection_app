export default function ArtistEdit(artist){
    return `
        <section class="content__todo">
            <h4>${artist.name}</h4>
        </section>

        <section class="update-todo">
            <input class="update-todo__name" type="text" value="${artist.artistname}">
            <input class="update-todo__id" type="hidden" value="${artist.id}">
            <button class="update-todo__submit">Save Changes</button>
        </section>

    `;
}