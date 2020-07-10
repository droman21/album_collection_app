import Header from './components/Header';
import Home from './components/Home';
import ArtistEdit from './components/ArtistEdit';
import apiActions from './api/apiActions';
import Artists from './components/Artists';

const appDiv = document.querySelector('.app');

pageBuild();

function pageBuild() {
    header();
    // footer();
    navHome();
   buildNav();
   showArtists();
}

function header() {
    const header = document.querySelector("#header");
    header.innerHTML = Header(); 
}

function navHome() {
  const homeButton = document.querySelector(".nav__artist");
  homeButton.addEventListener("click", function() {
    document.querySelector("#app").innerHTML = Home();
  });
}

function showArtists(){

  console.log("Showing the artists!!");

  // const homeButton = document.querySelector(".nav__artist");
  fetch("https://localhost:44313/api/artist")
        .then(response => response.json())
        .then(artists => {
          appDiv.innerHTML = Artists(artists);
          console.log(artists);
        })
  //document.querySelector("#app").innerHTML = Artists();
console.log("Finished Showing the artists!!");

}

function buildNav() {
    
  
    const artistButton = document.querySelector(".nav__artist");
    const app = document.querySelector('#app');

    artistButton.addEventListener("click", function() {
        fetch("https://localhost:44313/api/artist")
        .then(response => response.json())
        .then(data => console.log(data))
        .then(err => console.log(err))
        .catch(err => console.log(err))
        console.log("called the REST service and returned.");
        

      });

      

    // app.addEventListener("click", function(){
    //   if(event.target.classList.contains('delete-todo__submit')){
    //     const todoId = event.target.parentElement.querySelector('.todo__id').value;
    //     console.log(todoId);

    //     apiActions.deleteRequest(
    //       `https://localhost:44393/api/todo/${todoId}`,
    //       toDos => {
    //         app.innerHTML = artists(toDos);
    //       }
    //     )
    //   }
    // })

    // app.addEventListener("click", function(){
    //   if(event.target.classList.contains('edit-todo__edit')){
    //     const todoId = event.target.parentElement.querySelector('.todo__id').value;
    //     console.log(todoId);

    //     apiActions.getRequest(
    //       `https://localhost:44393/api/artist/${artistId}`,
    //       ArtistEdit => {
    //         console.log(artistEdit);
    //         app.innerHTML = ArtistEdit(artistEdit);
    //       }
    //     )
    //   }
    // })

    // app.addEventListener("click", function(){
    //   if(event.target.classList.contains('update-todo__submit')){
    //     const todoId = event.target.parentElement.querySelector('.update-todo__id').value;
    //     const todoName = event.target.parentElement.querySelector('.update-todo__name').value;
    //     const todoOwner = event.target.parentElement.querySelector('.update-todo__owner').value;

    //     console.log(todoId);

    //     const todoData = {
    //       id: todoId,
    //       name: todoName,
    //       owner: todoOwner
    //     };

    //     console.log(todoData);
    //     console.log(JSON.stringify(todoData));


    //     apiActions.putRequest(
    //       `https://localhost:44393/api/todo/${todoId}`,
    //       todoData,
    //       todos => {
    //         console.log(todos);
    //         app.innerHTML = Artists(todos);
    //       }
    //     );
    //   }

    }
  
  