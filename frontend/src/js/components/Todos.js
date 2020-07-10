export default function Todos(artist){
    console.log(`in the todo component ${todos}`)
    return `
    <ol> 
        ${todos.map(todo => {
          return `
           <li>${artist.name}</li>
    `
        })}
        </ol>
        `
}