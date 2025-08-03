const peliculas = {
  "Cinépolis Cayalá": [
    {
      nombre: "Amores Materialistas",
      duracion: "117 min",
      clasificacion: "B12",
      doblada: "15:15, 20:30, 20:40",
      subtitulada: "18:00, 19:00, 21:45",
      imagen: "https://via.placeholder.com/180x260?text=Amores+Materialistas"
    },
    {
      nombre: "Cómo entrenar a tu dragón",
      duracion: "126 min",
      clasificacion: "A",
      doblada: "13:25, 16:10",
      subtitulada: "",
      imagen: "https://via.placeholder.com/180x260?text=Cómo+entrenar+dragón"
    },
    {
      nombre: "Jurassic World: Renace",
      duracion: "134 min",
      clasificacion: "B",
      doblada: "13:45",
      subtitulada: "16:50",
      imagen: "https://image.tmdb.org/t/p/original/q0fGCmjLu42MPlSO9OYWpI5w86I.jpg"
    }
  ]
};

function renderCartelera(complejo) {
  const titulo = document.getElementById('tituloComplejo');
  const lista = document.getElementById('peliculasLista');
  titulo.textContent = `Cartelera - ${complejo}`;
  lista.innerHTML = '';

  const cartelera = peliculas[complejo] || [];

  cartelera.forEach(p => {
    const card = document.createElement('div');
    card.className = 'pelicula';
    card.innerHTML = `
      <img src="${p.imagen}" alt="${p.nombre}" />
      <div class="pelicula-info">
        <h3>${p.nombre} <span class="clasificacion">${p.clasificacion}</span></h3>
        <p><strong>Duración:</strong> ${p.duracion}</p>
        <div class="horarios">
          <strong>Doblada:</strong> ${p.doblada || '—'}<br>
          <strong>Subtitulada:</strong> ${p.subtitulada || '—'}
        </div>
        <button class="trailer-btn">▶️ Ver tráiler</button>
      </div>
    `;
    lista.appendChild(card);
  });
}

renderCartelera("Cinépolis Cayalá");
