export default function album(album){
    return `
        <section class="header-container">
        <h1>${album.title}</h1>
        </section>
        <ol>
            ${album.songs.map(song =>{
                return `
                <li>
                    <h4>${song.name}</h4>
                <li>
                `
            }).join("")}
        <ol>
    `
}