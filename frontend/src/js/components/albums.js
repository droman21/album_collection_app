export default function Albums(albums){
    console.log(`in the albums component ${albums}`)
    return `
        <h1>List of Albums</h1>
        <ul>
            ${albums.map(album => {
                return `
                <li>
                    <h4>${album.title}</h4>
                    <h4>${album.id}</h4>
                </li>
                `
            }).join("")}
    `
}