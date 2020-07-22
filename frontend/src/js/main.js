import Header from './components/Header';
import Home from './components/Home';
import apiActions from './api/apiActions';
import Artists from './components/Artists';
import Albums from './components/Albums';
import Album from './components/Album';
import Artist from './components/Artist';
import AlbumsPostSection from './components/AlbumPostSection';
import AlbumEdit from './components/AlbumEdit';

const appDiv = document.querySelector('.app');

//pageBuild();

export default function pageBuild() {
  header();
  //footer();
  navHome();
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
        showAlbumsByArtistID();
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
  const albumShowLink = document.querySelector('.nav__albums');
  albumShowLink.addEventListener('click', function () {
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
    element.addEventListener('click', function () {
      console.log("added eventlistener")
      const id = element.id;
      console.log(`Artist ID is ${id}`);
      fetch(`https://localhost:44313/api/artist/${id}`)
        .then(response => response.json())
        .then(artist => appDiv.innerHTML = Artist(artist))
        .catch(err => console.log(err))
    })
  })

}


function buildNav() {
  const artistButton = document.querySelector(".nav__artist");
  const app = document.querySelector('#app');
  artistButton.addEventListener("click", function () {
    fetch("https://localhost:44313/api/artist")
      .then(response => response.json())
      .then(data => console.log(data))
      .then(err => console.log(err))
      .catch(err => console.log(err))

  })
}

appDiv.addEventListener("click", function () {
  if(event.target.classList.contains('album__title')){
    //const albumTitle = document.querySelector(".album__title");
    console.log("added album eventlistener");
      const id = event.target.id;
      console.log(`Album ID is ${id}`);
      fetch(`https://localhost:44313/api/album/${id}`)
        .then(response => response.json())
        .then(album => appDiv.innerHTML = Album(album))
        .catch(err => console.log(err))
  }
})

appDiv.addEventListener("click", function(){
  const createAlbumSection = document.querySelector('.create-album');
  if(event.target.classList.contains('create-album__button')){
    apiActions.getRequest('https://localhost:44313/api/artist',
    artists => {
      console.log(artists)
    createAlbumSection.innerHTML= AlbumsPostSection(artists);
    })
  }
})

appDiv.addEventListener("click", function () {
  if (event.target.classList.contains('create-album__submit')) {
    const albumName = event.target.parentElement.querySelector('.create-album__albumTitle').value;
    const albumArtist = event.target.parentElement.querySelector('.create-album__albumArtists').value;
    const recordLabel = event.target.parentElement.querySelector('.artist__recordLabel').value;

    console.log("Album name is" + albumName +" The artist is" + albumArtist);

    var requestBody = {
      title: albumName,
      artistId: albumArtist,
      label: recordLabel
    }

    apiActions.postRequest(
      "https://localhost:44313/api/album",
      requestBody,
      albums => {
          console.log("Albums returned from back end");
          console.log("TEST TEST");
          appDiv.innerHTML = Albums(albums);
      }
  )
}
})

appDiv.addEventListener('click', function(){
  if(event.target.classList.contains('album-item__delete')){
      console.log("We're in the delete function");
      const albumId = event.target.parentElement.querySelector('.album-item__id').value;
      console.log("About to delete the album " + albumId);

      apiActions.deleteRequest(
          `https://localhost:44313/api/album/${albumId}`,
          albums => {
              appDiv.innerHTML = Albums(albums);
          }
      )
  }
})

appDiv.addEventListener("click", function(){
  if(event.target.classList.contains('album-item__edit')){
      const albumId = event.target.parentElement.querySelector('.album-item__id').value;
      apiActions.getRequest(
          `https://localhost:44313/api/album/${albumId}`,
          albumEdit => {
              console.log("Retrive the album " + albumEdit);
              appDiv.innerHTML = AlbumEdit(albumEdit);
           }
      )
  }
})

appDiv.addEventListener("click", function(){
  if(event.target.classList.contains('edit-album__submit')){
      const albumId = event.target.parentElement.querySelector('.edit-album__id').value;
      const albumTitle = event.target.parentElement.querySelector('.edit-album__name').value;
      console.log("About to get artist ID");
      const albumArtist = event.target.parentElement.querySelector('.edit-album__artistID').value;
      console.log("Got the artist ID");
      const recordLabel = event.target.parentElement.querySelector('.edit-album__label').value;
      
      console.log("Put request is logging " + albumId);
      const albumData = {
        id: albumId,
        title: albumTitle,
        artistId: 2,
        label: recordLabel

      };

      apiActions.putRequest(
          `https://localhost:44313/api/album/${albumId}`,
          albumData,
          albums => {
          console.log("Return all albums after edit " + albumId);
             
              appDiv.innerHTML = Albums(albums);
          }
      )
  }
})