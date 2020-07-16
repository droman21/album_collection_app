import Header from './components/Header';
import Home from './components/Home';
import ArtistEdit from './components/ArtistEdit';
import apiActions from './api/apiActions';
import Artists from './components/Artists';
import Albums from './components/Albums';
import Album from './components/Album';
import Artist from './components/Artist';

const appDiv = document.querySelector('.app');

//pageBuild();

export default function pageBuild() {
  header();
  //footer();
  navHome();
  // albumsByArtistIDLink();
  buildNav();
  showArtists();
  showAlbums();
  albumLink();
  showArtistsPageLoad();
  showAlbumsByArtistID();
}

function header() {
  const header = document.querySelector("#header");
  header.innerHTML = Header();
}

function navHome() {
  const homeButton = document.querySelector(".nav__artist");
  homeButton.addEventListener("click", function () {
    document.querySelector("#app").innerHTML = Home();
  });
}

function showArtists() {
  const artistLink = document.querySelector(".nav__artist");
  artistLink.addEventListener('click', function () {
    fetch("https://localhost:44313/api/artist")
      .then(response => response.json())
      .then(artists => {
        appDiv.innerHTML = Artists(artists);
        console.log(artists);
      })
  })
}

function showArtistsPageLoad() {
  fetch("https://localhost:44313/api/artist")
    .then(response => response.json())
    .then(artists => {
      appDiv.innerHTML = Artists(artists);
      console.log(artists);
      showAlbumsByArtistID();
    })
}

function showAlbums() {
  const albumLink = document.querySelector('.nav__albums');
  albumLink.addEventListener('click', function () {
    fetch('https://localhost:44313/api/album')
      .then(response => response.json())
      .then(albums => {
        appDiv.innerHTML = Albums(albums)
        albumLink();
      })
      .catch(err => console.log(err))
  })
}

function albumLink() {
  const albumNameElements = document.querySelectorAll('.album__name');
  albumNameElements.forEach(element => {
    element.addEventListener('click', function () {
      const albumId = element.id;
      console.log("Album ID is" + albumId);
      fetch(`https://localhost:44313/api/album/${albumId}`)
        .then(response => response.json())
        .then(album => appDiv.innerHTML = Album(album))
        .catch(err => console.log(err))
    })
  })
}

function showAlbumsByArtistID() {
  console.log("we're in the fuction")
  const artistByIDLink = document.querySelectorAll(".artist__name");
  artistByIDLink.forEach(element => {
    element.addEventListener('click', function() {
      console.log("added eventlistener")
      const id = element.id;
      console.log(`Artist ID is ${id}`);
      fetch(`https://localhost:44313/api/album/${id}`)
      .then(response => response.json())
      .then(artist => appDiv.innerHTML = Artist(artist))
      // albumsByArtistIDLink();
      .catch(err => console.log(err))
    })
  })

}

// function albumsByArtistIDLink() {
//   const albumNameElements = document.querySelectorAll('.artist__name');
//   albumNameElements.forEach(element => {
//     element.addEventListener('click', function () {
//       const albumId = element.id;
//       console.log("Album ID is" + albumId);
//       fetch(`https://localhost:44313/api/album/${albumId}`)
//         .then(response => response.json())
//         .then(album => appDiv.innerHTML = Album(album))
//         .catch(err => console.log(err))
//     })
//   })
// }

function buildNav() {
  const artistButton = document.querySelector(".nav__artist");
  const app = document.querySelector('#app');

  artistButton.addEventListener("click", function () {
    fetch("https://localhost:44313/api/artist")
      .then(response => response.json())
      .then(data => console.log(data))
      .then(err => console.log(err))
      .catch(err => console.log(err))

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

