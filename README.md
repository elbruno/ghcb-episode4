# ghcb-episode4

## Comenzando con .NET 9 y Aspire

Para comenzar con este proyecto, necesitas tener .NET 9 y Aspire instalados en tu máquina.

### Requisitos Previos

- [SDK de .NET 9](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Aspire](https://aspire.com/download)

### Instalación

1. Clona el repositorio:
    ```sh
    git clone https://github.com/yourusername/ghcb-episode4.git
    cd ghcb-episode4
    ```

2. Instala los paquetes requeridos:
    ```sh
    dotnet restore
    ```

## Probar el Proyecto Localmente

Para probar el proyecto localmente, sigue estos pasos:

1. Construye el proyecto:
    ```sh
    dotnet build
    ```

2. Ejecuta el proyecto:
    ```sh
    dotnet run
    ```

3. Abre tu navegador y navega a `http://localhost:5000` para ver la aplicación en funcionamiento.

## Probar con CodeSpaces

Para probar el proyecto usando GitHub CodeSpaces:

1. Abre el repositorio en GitHub.
2. Haz clic en el botón `Code` y selecciona `Open with CodeSpaces`.
3. Espera a que el CodeSpace se inicialice.
4. Una vez que el entorno esté listo, abre la terminal y ejecuta:
    ```sh
    dotnet run
    ```
5. Abre el puerto reenviado para ver la aplicación en funcionamiento.

## Colaborar en el Proyecto

Damos la bienvenida a las contribuciones a este proyecto. Para contribuir, sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una nueva rama:
    ```sh
    git checkout -b feature/tu-nombre-de-feature
    ```
3. Realiza tus cambios y haz commit:
    ```sh
    git commit -m "Agrega tu mensaje aquí"
    ```
4. Empuja a la rama:
    ```sh
    git push origin feature/tu-nombre-de-feature
    ```
5. Abre un pull request en GitHub.

Por favor, asegúrate de seguir el [código de conducta](CODE_OF_CONDUCT.md) y las [directrices de contribución](CONTRIBUTING.md).

## Componente Home.razor

El componente `Home.razor` es una página de Blazor que proporciona una interfaz de chat para que los usuarios interactúen con un modelo de IA. Inicializa un servicio de chat basado en la configuración y maneja la entrada del usuario para generar respuestas del modelo de IA.

### Funcionalidades Clave

- Mostrar mensajes de chat del usuario y del asistente de IA.
- Manejar la entrada del usuario y enviarla al modelo de IA para su procesamiento.
- Mostrar indicadores de carga y mensajes de error.
- Inicializar el servicio de chat basado en la configuración.

### Diagrama de Estados

```mermaid
stateDiagram
    [*] --> Inicializando
    Inicializando --> Listo : OnInitialized
    Listo --> Cargando : AskQuestion
    Cargando --> Listo : ResponseReceived
    Listo --> Error : ErrorOccurred
    Error --> Listo : Retry