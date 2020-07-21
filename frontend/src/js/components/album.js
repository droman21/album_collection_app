export default function album(album){
    return `
        <h1>${album.name}</h1>
        <ol>
            ${album.artists.map(artist =>{
                return `
                <li>
                    <h4>${artist.name}</h4>
                    <h4>
                </li>
                `
            })}
        <ol>
    `
}