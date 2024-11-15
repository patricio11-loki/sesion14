/* Reset básico */
body {
    margin: 0;
    font-family: Arial, sans-serif;
}

/* Estilo para la barra de navegación fija */
.navbar {
    background-color: #333;
    color: white;
    padding: 10px 20px;
    position: fixed; /* Fija la barra en la parte superior */
    top: 0;
    left: 0;
    width: 100%;
    z-index: 1000; /* Asegura que la barra de navegación esté por encima de otros elementos */
}

/* Estilo para los enlaces dentro de la barra de navegación */
.navbar ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    display: flex;
    justify-content: space-around;
}

.navbar li {
    margin: 0 10px;
}

.navbar a {
    color: white;
    text-decoration: none;
    padding: 8px 15px;
    border-radius: 4px;
    transition: background-color 0.3s ease;
}

.navbar a:hover {
    background-color: #555;
}

/* Estilo para las secciones */
section {
    padding: 20px;
    margin: 10px 0;
    border: 1px solid #ddd;
    border-radius: 4px;
    margin-top: 60px; /* Añade un margen superior para que el contenido no quede debajo de la barra fija */
}

/* Estilo para el pie de página */
footer {
    text-align: center;
    padding: 10px;
    background-color: #333;
    color: white;
    margin-top: 20px;
}